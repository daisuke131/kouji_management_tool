using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Npgsql;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KKSMCommon
{
    public class DbAccess
    {
        //条件付きコンパイルシンボル　空白でポスグレ
#if Mysql
        private MySqlConnection Conn = null;
#else
        private NpgsqlConnection Conn = null;
#endif
        private string settingDir = System.Environment.CurrentDirectory + "\\Config.ini";

        [DllImport("KERNEL32.DLL")]
        public static extern uint
          GetPrivateProfileString(string lpAppName,
          string lpKeyName, string lpDefault,
          StringBuilder lpReturnedString, uint nSize,
          string lpFileName);
        [DllImport("KERNEL32.DLL",
    EntryPoint = "GetPrivateProfileString")]
        public static extern uint
          GetPrivateProfileStringByByteArray(string lpAppName,
          string lpKeyName,
          string lpDefault,
          byte[] lpReturnedString,
          uint nSize,
          string lpFileName);

        #region SQL接続
        public void connect()
        {
            try
            {
#if Mysql //KKSMCommonのプロパティの条件付きシンボルを「Mysql」にするとMysqlで。posgresqlは空欄
                string connectionString = "Server=" + inistr("connect_mysql", "sever") + ";"
                    + "Port=" + inistr("connect_mysql", "port") + ";"
                    + "Database=" + inistr("connect_mysql", "database") + ";"
                    + "Uid=" + inistr("connect_mysql", "user") + ";"
                    + "Pwd=" + inistr("connect_mysql", "password") + ";";
                Conn = new MySqlConnection(connectionString);
#else
                //ポスグレ用useがpostgresでは繋がらないので新たにユーザー作る
                string connectionString = "Server=" + inistr("connect_posgresql", "sever") + ";"
                    + "Port=" + inistr("connect_posgresql", "port") + ";"
                    + "Database=" + inistr("connect_posgresql", "database") + ";"
                    + "Uid=" + inistr("connect_posgresql", "user") + ";"
                    + "Pwd=" + inistr("connect_posgresql", "password") + ";";
                Conn = new NpgsqlConnection(connectionString);
#endif
                Conn.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        #endregion

        #region ini セクション、キーの値
        private string inistr(string SECTION, string KEY)
        {
            StringBuilder sb = new StringBuilder(1024);
            GetPrivateProfileString(
                SECTION,      // セクション名
                KEY,          // キー名    
                "",   // 値が取得できなかった場合に返される初期値
                sb,             // 格納先
                Convert.ToUInt32(sb.Capacity), // 格納先のキャパ
                settingDir);   // iniファイル名
            return sb.ToString();
        }
        #endregion

        #region SQL切断
        public void disconnect()
        {
            try
            {
                Conn.Close();
                Conn = null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        #endregion

        #region select文 Arraylistの中にhashlistで返す
        public ArrayList selectDB(string sql)
        {
            try
            {
                connect();//DB接続
                ArrayList selectList = new ArrayList();
#if Mysql
                MySqlCommand dbCmd = new MySqlCommand();
#else
                NpgsqlCommand dbCmd = new NpgsqlCommand();
#endif
                dbCmd.Connection = Conn;
                dbCmd.CommandText = sql;
                dbCmd.CommandType = CommandType.Text;
#if Mysql
                MySqlDataReader dtr = dbCmd.ExecuteReader();
#else
                NpgsqlDataReader dtr = dbCmd.ExecuteReader();
#endif
                //件数分回す
                while ((dtr.Read()))
                {
                    Hashtable selectHash = new Hashtable();
                    //列分回す
                    for (int i = 0; i <= dtr.FieldCount - 1; i++)
                    {
                        selectHash.Add(dtr.GetName(i), dtr.GetValue(i));
                    }
                    selectList.Add(selectHash);
                }
                dtr.Close();
                dtr = null;
                dbCmd.Dispose();
                dbCmd = null;
                disconnect();//DB切断
                return selectList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        #endregion

        #region SQL検索結果をDataTableで返す
        public System.Data.DataTable datatable(string sql)
        {
            try
            {
                connect();//DB接続
#if Mysql
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Conn);
#else
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, Conn);
#endif
                System.Data.DataTable dt = new System.Data.DataTable();
                da.Fill(dt);
                disconnect();//DB切断
                return dt;
                //dataGridView.DataSource = dt;でグリッドにセット
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
        }
        #endregion

        #region SQLトランザクション
        public void tranDB(string sql)
        {
            connect();//DB接続
#if Mysql
            MySqlCommand command = new MySqlCommand(sql, Conn);
#else
            NpgsqlCommand command = new NpgsqlCommand(sql, Conn);
#endif
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            disconnect();//DB切断
        }
        #endregion

        #region CSV出力
        public void output_csv(string csv_pass,string sql)
        {
            connect();//DB接続
#if Mysql
            MySqlCommand dbCmd = new MySqlCommand(sql, Conn);
            MySqlDataReader dtr = dbCmd.ExecuteReader();
#else
            NpgsqlCommand dbCmd = new NpgsqlCommand(sql, Conn);
            NpgsqlDataReader dtr = dbCmd.ExecuteReader();
#endif
            string excelName = System.IO.Path.GetFullPath(csv_pass);
            StreamWriter file = new StreamWriter(@excelName, false, Encoding.GetEncoding("Shift_JIS"));
            var dataList = new List<string>();
            //ヘッダー書き込み
            for (int i = 0; i < dtr.FieldCount; i++)
            {
                dataList.Add(dtr.GetName(i).ToString());
            }
            file.WriteLine(String.Join(",", dataList));
            //データ書き込み
            while (dtr.Read())
            {
                dataList = new List<string>();
                for (int i = 0; i <= dtr.FieldCount - 1; i++)
                {
                    //セル内改行なら""で囲む
                    if(dtr.GetValue(i).ToString().Contains("\r\n"))
                    {
                        dataList.Add("\"" + dtr.GetValue(i).ToString() + "\"");
                    }
                    else
                    {
                        dataList.Add(dtr.GetValue(i).ToString());
                    }
                    
                }
                file.WriteLine(String.Join(",", dataList));
            }
            file.Close();
            Conn.Close();
        }
        #endregion
    }
}