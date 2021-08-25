using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KKSMCommon;

namespace ichiran
{
    public partial class ichiran : Form
    {
        private KKSMCommon.DbAccess dbAccess = new KKSMCommon.DbAccess();
        public string year = string.Empty;
        public ichiran()
        {
            InitializeComponent();
        }

        #region ロード
        private void ichiran_Load(object sender, EventArgs e)
        {
            lbl_nendo.Text = year;
            //検索
            set_grid("1");
        }
        #endregion

        #region 検索処理
        private void set_grid(string kousyu_code)
        {
            string s_ymd = year + "0426";
            string e_ymd = (int.Parse(year) + 1).ToString() + "0425";
            dataGridView1.Rows.Clear();

            string sql = "select no, kouji_no, kouji_nm, kouosyu_code, substr(m.han_name, 1, 1) as kouosyu_name, kouji_kingaku, bikou from kouji_kanri k ";
            sql += "left join m_hanyou m on k.kouosyu_code = m.han_cd and m.mst_kbn = 'kousyu' ";
            sql += "where del_flg = 0 and " + kousyu_code + " and substr(no, 1, 8) >= '" + s_ymd + "' and substr(no, 1, 8) <= '" + e_ymd + "' order by no";
            ArrayList koujiList = dbAccess.selectDB(sql);
            int row_count = 0;
            foreach (Hashtable koujiHash in koujiList)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, row_count].Value = int.Parse(koujiHash["no"].ToString().Substring(4, 2)).ToString() + "/" + int.Parse(koujiHash["no"].ToString().Substring(6, 2)).ToString();
                dataGridView1[1, row_count].Value = koujiHash["kouji_no"].ToString();
                dataGridView1[2, row_count].Value = koujiHash["kouosyu_code"].ToString();
                dataGridView1[3, row_count].Value = koujiHash["kouosyu_name"].ToString();
                dataGridView1[4, row_count].Value = koujiHash["kouji_nm"].ToString();
                dataGridView1[5, row_count].Value = int.Parse(koujiHash["kouji_kingaku"].ToString());
                //税抜き + 1000円単位 + 四捨五入
                double zeinuki_kingaku = double.Parse(koujiHash["kouji_kingaku"].ToString()) / 1.1;
                zeinuki_kingaku /= 1000;
                zeinuki_kingaku = Math.Round(zeinuki_kingaku);
                dataGridView1[6, row_count].Value = zeinuki_kingaku;
                dataGridView1[7, row_count].Value = koujiHash["bikou"].ToString();
                dataGridView1[8, row_count].Value = koujiHash["no"].ToString();
                row_count++;
            }
        }
        #endregion

        #region ラジオボタンイベント
        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            set_grid("1");
        }

        private void rb_ken_CheckedChanged(object sender, EventArgs e)
        {
            set_grid("kouosyu_code = '0'");
        }

        private void rb_do_CheckedChanged(object sender, EventArgs e)
        {
            set_grid("kouosyu_code = '2'");
        }

        private void rb_to_CheckedChanged(object sender, EventArgs e)
        {
            set_grid("kouosyu_code = '1'");
        }

        private void rb_zou_CheckedChanged(object sender, EventArgs e)
        {
            set_grid("kouosyu_code = '3'");
        }
        #endregion

        #region グリッドの行削除ボタン
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 8)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }
        #endregion

        #region 閉じる
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

    }
}
