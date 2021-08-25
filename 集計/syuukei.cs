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

namespace syuukei
{
    public partial class syuukei : Form
    {
        private KKSMCommon.DbAccess dbAccess = new KKSMCommon.DbAccess();
        public string year = string.Empty;
        public syuukei()
        {
            InitializeComponent();
        }

        #region ロード
        private void tuika_Load(object sender, EventArgs e)
        {
            //５月～４月
            lbl_nendo.Text = year;
            int month = 5;
            int flg = 0;//while脱出フラグ
            string sql = string.Empty;
            ArrayList a_list = new ArrayList();
            string year1 = year;
            while (flg != 1)
            {
                if (month == 1)
                {
                    year1 = (int.Parse(year) + 1).ToString();
                }
                sql = "select COALESCE(sum(kouji_kingaku), 0) as kingaku from kouji_kanri ";
                sql += "where del_flg = 0 ";
                sql += "and substr(no,1,8) >= '" + year1 + (month - 1).ToString("00") + "26" + "' ";
                sql += "and substr(no,1,8) <= '" + year1 + month.ToString("00") + "25" + "';";
                a_list = a_list = dbAccess.selectDB(sql);
                foreach (Hashtable Hash in a_list)
                {
                    ((Label)Controls["lbl_" + month.ToString()]).Text = String.Format("{0:#,0}", int.Parse(Hash["kingaku"].ToString()));
                }
                if (month == 12)
                {
                    month = 1;
                }
                else
                {
                    month++;
                }
                if(month == 5)
                {
                    flg = 1;
                }
            }
            //各合計
            for (int kousyu = 0; kousyu < 4; kousyu++)
            {
                sql = "select COALESCE(sum(kouji_kingaku), 0) as kingaku from kouji_kanri ";
                sql += "where del_flg = 0 and kouosyu_code = '" + kousyu.ToString() + "' and substr(no, 1, 8) between '" + year + "0426' and '" + (int.Parse(year) + 1).ToString() + "0425';";
                a_list = dbAccess.selectDB(sql);
                foreach (Hashtable Hash in a_list)
                {
                    ((Label)Controls["lbl_syubetsu_zen" + kousyu.ToString()]).Text = String.Format("{0:#,0}", Math.Round((decimal)int.Parse(Hash["kingaku"].ToString()) / 1));
                    //税抜
                    double syubetsu_zeinuki_zen = double.Parse(Hash["kingaku"].ToString()) / 1.1;
                    syubetsu_zeinuki_zen = Math.Round(syubetsu_zeinuki_zen);

                    ((Label)Controls["lbl_syubetsu_zeinuki_zen" + kousyu.ToString()]).Text = String.Format("{0:#,0}", syubetsu_zeinuki_zen);

                    ((Label)Controls["lbl_syubetsu" + kousyu.ToString()]).Text = String.Format("{0:#,0}", Math.Round((decimal)int.Parse(Hash["kingaku"].ToString()) / 1000));
                    //税抜
                    ((Label)Controls["lbl_zeinuki_syubetsu" + kousyu.ToString()]).Text = String.Format("{0:#,0}", syubetsu_zeinuki_zen / 1000);
                }
                sql = "select COALESCE(sum(kouji_kingaku), 0) as kingaku from kouji_kanri ";
                sql += "where del_flg = 0 and shitauke_flg = '1' and kouosyu_code = '" + kousyu.ToString() + "' and substr(no, 1, 8) between '" + year + "0426' and '" + (int.Parse(year) + 1).ToString() + "0425';";
                a_list = dbAccess.selectDB(sql);
                foreach (Hashtable Hash in a_list)
                {
                    ((Label)Controls["lbl_syubetsu_moto" + kousyu.ToString()]).Text = String.Format("{0:#,0}", Math.Round((decimal)int.Parse(Hash["kingaku"].ToString()) / 1));
                    //税抜
                    double syubetsu_moto_zeinuki_zen = double.Parse(Hash["kingaku"].ToString()) / 1.1;
                    syubetsu_moto_zeinuki_zen = Math.Round(syubetsu_moto_zeinuki_zen);
                    ((Label)Controls["lbl_zeinuki_syubetsu_moto" + kousyu.ToString()]).Text = String.Format("{0:#,0}", syubetsu_moto_zeinuki_zen);
                }
                sql = "select COALESCE(sum(kouji_kingaku), 0) as kingaku from kouji_kanri ";
                sql += "where del_flg = 0 and shitauke_flg = '0' and kouosyu_code = '" + kousyu.ToString() + "' and substr(no, 1, 8) between '" + year + "0426' and '" + (int.Parse(year) + 1).ToString() + "0425';";
                a_list = dbAccess.selectDB(sql);
                foreach (Hashtable Hash in a_list)
                {
                    ((Label)Controls["lbl_syubetsu_shita" + kousyu.ToString()]).Text = String.Format("{0:#,0}", Math.Round((decimal)int.Parse(Hash["kingaku"].ToString()) / 1));
                    //税抜
                    double syubetsu_moto_zeinuki_zen = double.Parse(Hash["kingaku"].ToString()) / 1.1;
                    syubetsu_moto_zeinuki_zen = Math.Round(syubetsu_moto_zeinuki_zen);
                    ((Label)Controls["lbl_zeinuki_syubetsu_shita" + kousyu.ToString()]).Text = String.Format("{0:#,0}", syubetsu_moto_zeinuki_zen);
                }
            }
            //総合計
            sql = "select COALESCE(sum(kouji_kingaku), 0) as kingaku from kouji_kanri ";
            sql += "where del_flg = 0 and substr(no, 1, 8) between '" + year + "0426' and '" + (int.Parse(year) + 1).ToString() + "0425';";
            a_list = dbAccess.selectDB(sql);
            foreach (Hashtable Hash in a_list)
            {
                lbl_total.Text = "\\" + String.Format("{0:#,0}", int.Parse(Hash["kingaku"].ToString())) + " -.";
                //税抜
                double zeinuki_total = double.Parse(Hash["kingaku"].ToString()) / 1.1;
                zeinuki_total = Math.Round(zeinuki_total);
                lbl_zeinuki_total.Text = "\\" + String.Format("{0:#,0}", zeinuki_total) + " -.";
            }
        }
        #endregion

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
