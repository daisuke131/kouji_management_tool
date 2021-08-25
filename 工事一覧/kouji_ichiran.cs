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
using Microsoft.Office.Interop.Excel;
using tuika;
using KKSMCommon;
using syuukei;

namespace kouji_ichiran
{
    public partial class kouji_ichiran : Form
    {

        private KKSMCommon.DbAccess dbAccess = new KKSMCommon.DbAccess();
        //条件付き　Excelならエクセル、空白はSQL
        public kouji_ichiran()
        {
            InitializeComponent();
        }
        #region ロード
        private void kouji_ichiran_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            // 日付を取得
            string date = today.ToString().Substring(0, 10);
            string year = date.Substring(0, 4);
            string month = date.Substring(5, 2);
            string day = date.Substring(8, 2);
            //月ドロップボックス
            for (int x = 1; x <= 12; x++)
            {
                cmb_month.Items.Add(x.ToString() + "月");
            }
            cmb_month.SelectedIndex = int.Parse(month) - 1;
            txt_year.Text = year.ToString();
#if Excel
            txt_year.Visible = false;
            lbl_year.Visible = false;
            txt_nendo.Visible = false;
            lbl_nendo.Visible = false;
            //検索
            excel_search();
#else

            //年度セット
            if(int.Parse(month + day) <= 425)
            {
                year = (int.Parse(year) - 1).ToString();
            }
            txt_nendo.Text = year;
            //検索
            sql_search();
#endif
            //バックアップCSV書き込み
            dbAccess.output_csv(".\\backup\\koji_kanri.csv", "select * from kouji_kanri");
            dbAccess.output_csv(".\\backup\\m_hanyou.csv", "select * from m_hanyou");
        }
        #endregion

        #region 半角数字のみ入力
        private void txt_nen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txt_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 検索ボタン押下
        private void btn_search_Click(object sender, EventArgs e)
        {
#if Excel
            excel_search();
#else
            sql_search();
#endif
        }
        #endregion

        #region 追加ボタン押下
        private void btn_add_Click(object sender, EventArgs e)
        {
            tuika.tuika tuikaform = new tuika.tuika();
            tuikaform.ym_string = txt_year.Text + "年" + (cmb_month.SelectedIndex + 1).ToString() + " 月";
            tuikaform.ShowDialog();
            if(tuikaform.tuika_flg == true)
            {
#if Excel
                //グリッドに追加
                dataGridView1.Rows.Add(tuikaform.list[0], tuikaform.list[1], tuikaform.list[2], tuikaform.list[3], tuikaform.list[4], tuikaform.list[5], tuikaform.list[6]);
                //sortedlist作成
                SortedList<int, ArrayList> s_list = cre_s_list();
                //エクセルアップデート
                excel_update(s_list);
                //再検索
                excel_search();
#else
                //アップデート
                sql_update(tuikaform.list);
                //再検索
                sql_search();
#endif

                MessageBox.Show("追加完了");
            }
        }
        #endregion

        #region sortedlist作成
        private SortedList<int, ArrayList> cre_s_list()
        {
            SortedList<int, ArrayList> s_list = new SortedList<int, ArrayList>();
            int date = 0;
            int date_count = 0;
            int key = 0;
            ArrayList a_list = new ArrayList();

            //sortedlistに収納
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                a_list = new ArrayList();
                for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                {
                    if (j == 0)
                    {
                        date = int.Parse((dataGridView1[j, i].Value).ToString());
                    }
                    if (dataGridView1[j, i].Value == null)
                    {
                        a_list.Add("");
                    }
                    else
                    {
                        a_list.Add((dataGridView1[j, i].Value).ToString());
                    }
                }
                int wh = 0;
                while (wh == 0)
                {
                    key = int.Parse(date.ToString() + date_count.ToString());
                    if (s_list.ContainsKey(key))
                    {
                        date_count++;
                    }
                    else
                    {
                        s_list.Add(key, a_list);
                        wh = 1;
                    }
                }
                
            }
            return s_list;
        }
        #endregion
        
        #region グリッドクリック（編集or削除）
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.ColumnIndex == 8)
            {
                if (MessageBox.Show("削除しますか？", "削除", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
#if Excel
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                    //sortedlist作成
                    SortedList<int, ArrayList> s_list = cre_s_list();
                    //エクセルアップデート
                    excel_update(s_list);
                    //再検索
                    excel_search();
#else
                    //削除処理
                    sql_del();
                    //再検索
                    sql_search();
#endif

                    MessageBox.Show("削除完了");
                }
            }
            else
            {
#if Excel
                //Excelバージョンはなにもしない
#else
                string sql = "select no, substr(no, 7, 2) as date, kouji_no, kouji_nm, kouosyu_code, kouji_kingaku, shitauke_flg, bikou from kouji_kanri where no = '" + dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value + "';";
                ArrayList a_list = dbAccess.selectDB(sql);
                tuika.tuika tuikaform = new tuika.tuika();
                tuikaform.ym_string = txt_year.Text + "年" + (cmb_month.SelectedIndex + 1).ToString() + " 月";
                foreach(Hashtable hash in a_list)
                {
                    tuikaform.edit_list.Add(hash["date"].ToString());
                    tuikaform.edit_list.Add(hash["kouji_no"].ToString());
                    tuikaform.edit_list.Add(hash["kouji_nm"].ToString());
                    tuikaform.edit_list.Add(hash["kouosyu_code"].ToString());
                    tuikaform.edit_list.Add(hash["kouji_kingaku"].ToString());
                    tuikaform.edit_list.Add(hash["bikou"].ToString());
                    tuikaform.edit_list.Add(hash["no"].ToString());
                    tuikaform.edit_list.Add(hash["shitauke_flg"].ToString());
                }
                tuikaform.ShowDialog();
                if (tuikaform.tuika_flg == true)
                {
                    //アップデート
                    sql_update(tuikaform.list);
                    //再検索
                    sql_search();
                    MessageBox.Show("編集完了");
                }
            }
        }
#endif
        #endregion

        #region 集計ボタン押下
        private void btn_goukei_Click(object sender, EventArgs e)
        {
#if Excel
            if (MessageBox.Show("締める？", "〆", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //エクセルアップデート
                excel_shime();
                MessageBox.Show("〆処理完了");
            }
#else
            syuukei.syuukei syuukei = new syuukei.syuukei();
            syuukei.year = txt_nendo.Text;
            syuukei.ShowDialog();
#endif
        }
        #endregion

        #region 一覧ボタン押下
        private void btn_ichiran_Click(object sender, EventArgs e)
        {
            ichiran.ichiran ichiran = new ichiran.ichiran();
            ichiran.year = txt_nendo.Text;
            ichiran.ShowDialog();
        }
        #endregion

        #region 月チェンジ
        private void cmb_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            //検索
#if Excel
            excel_search();
#else
            sql_search();
#endif
        }
        #endregion

        #region SQL処理

        #region 検索処理
        private void sql_search()
        {
            dataGridView1.Rows.Clear();
            string year = txt_year.Text;
            string month = (cmb_month.SelectedIndex + 1).ToString("00");
            string sql = "select no, kouji_no, kouji_nm, kouosyu_code, substr(m.han_name, 1, 1) as kouosyu_name, kouji_kingaku, bikou ";
            sql += "from kouji_kanri k left join m_hanyou m on k.kouosyu_code = m.han_cd and m.mst_kbn = 'kousyu' ";
            sql += "where del_flg = '0' and substr(no, 1, 6) = '" + year + month + "' order by no";
            ArrayList koujiList = dbAccess.selectDB(sql);
            int row_count = 0;
            foreach (Hashtable koujiHash in koujiList)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, row_count].Value = int.Parse(koujiHash["no"].ToString().Substring(6, 2)).ToString();
                dataGridView1[1, row_count].Value = koujiHash["kouji_no"].ToString();
                dataGridView1[2, row_count].Value = koujiHash["kouosyu_code"].ToString();
                dataGridView1[3, row_count].Value = koujiHash["kouosyu_name"].ToString();
                dataGridView1[4, row_count].Value = koujiHash["kouji_nm"].ToString();
                dataGridView1[5, row_count].Value = int.Parse(koujiHash["kouji_kingaku"].ToString());
                dataGridView1[6, row_count].Value = koujiHash["bikou"].ToString();
                dataGridView1[7, row_count].Value = koujiHash["no"].ToString();
                row_count++;
            }
        }
        #endregion

        #region アップデート
        private void sql_update(ArrayList a_list)
        {
            string year = txt_year.Text;
            string month = (cmb_month.SelectedIndex + 1).ToString("00");
            string sql = "select no from kouji_kanri where del_flg = '0' and substr(no, 1, 8) = '" + year + month + int.Parse(a_list[0].ToString()).ToString("00") + "'";
            ArrayList koujiList = dbAccess.selectDB(sql);
            string no = year + month + int.Parse(a_list[0].ToString()).ToString("00") + koujiList.Count.ToString("0000");
            if (string.IsNullOrEmpty(a_list[7].ToString()))
            {
                sql = "INSERT INTO kouji_kanri (no, kouji_no, kouji_nm, kouosyu_code, kouji_kingaku, shitauke_flg, bikou, del_flg, cre_time) ";
                sql += "VALUES ('" + no + "', '" + a_list[1].ToString() + "', '" + a_list[4].ToString() + "', '" + a_list[2].ToString() + "', '" + a_list[5].ToString() + "', '" + a_list[8].ToString() + "', '" + a_list[6].ToString() + "',  0, now());";
                dbAccess.tranDB(sql);
            }
            else
            {
                sql = "UPDATE kouji_kanri SET no = '" + no + "', kouji_no = '" + a_list[1].ToString() + "', kouosyu_code = '" + a_list[2].ToString() + "', ";
                sql += "kouji_nm = '" + a_list[4].ToString() + "', kouji_kingaku = " + a_list[5].ToString() + ", shitauke_flg = '" + a_list[8].ToString() + "', bikou = '" + a_list[6].ToString() + "', upd_time = now() ";
                sql += "WHERE no = '" + a_list[7].ToString() + "';";
                dbAccess.tranDB(sql);
                haita();
            }
            
        }
        #endregion

        #region 削除処理
        private void sql_del()
        {
            string sql = "UPDATE kouji_kanri SET del_flg = '1', upd_time = now() ";
            sql += "WHERE no = '" + dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value + "';";
            dbAccess.tranDB(sql);
            haita();
        }
        #endregion
        
        #region 排他処理
        private void haita()
        {
            string year = txt_year.Text;
            string month = (cmb_month.SelectedIndex + 1).ToString("00");
            string sql = "select no from kouji_kanri where substr(no, 1, 6) = '" + year + month + "' order by no";
            ArrayList koujiList = dbAccess.selectDB(sql);
            int count = 0;
            string ym = string.Empty;
            string no = string.Empty;
            foreach (Hashtable koujiHash in koujiList)
            {
                if (!ym.Equals(koujiHash["no"].ToString().Substring(0, 8)))
                {
                    count = 0;
                }
                sql = "UPDATE kouji_kanri SET no = '" + koujiHash["no"].ToString().Substring(0, 8) + count.ToString("0000") + "' ";
                sql += "WHERE no = '" + koujiHash["no"].ToString() + "';";
                dbAccess.tranDB(sql);
                ym = koujiHash["no"].ToString().Substring(0, 8);
                count++;
            }
        }
        #endregion

        #endregion

        #region エクセル処理
        #region 検索処理
        private void excel_search()
        {
            string excelName = System.IO.Path.GetFullPath("..\\エクセルファイル\\月別売上.xlsx");
            Microsoft.Office.Interop.Excel.Application oXls = new Microsoft.Office.Interop.Excel.Application(); //エクセルオブジェクト
            Workbook oWBook = (Workbook)(oXls.Workbooks.Open(excelName)); //ワークブックオブジェクト
            dataGridView1.Rows.Clear();
            string month = (cmb_month.SelectedIndex + 1).ToString();
            Worksheet sheet = new Worksheet();
            foreach (Worksheet sh in oWBook.Sheets)
            {
                if (month + "月" == sh.Name)
                {
                    sheet = (Worksheet)oWBook.Sheets[sh.Index];

                    int rowCount = sheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
                    int colCount = sheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Column;
                    for (int r = 2; r <= rowCount; r++)
                    {
                        dataGridView1.Rows.Add();
                        for (int c = 1; c <= colCount; c++)
                        {

                            Range xlRange = sheet.Cells[r, c];
                            dataGridView1[c - 1, r - 2].Value = xlRange.Value;
                        }
                    }
                }
            }
            oWBook.Close();
        }
        #endregion

        #region 〆処理
        private void excel_shime()
        {
            string excelName = System.IO.Path.GetFullPath("..\\エクセルファイル\\月別売上.xlsx");
            Microsoft.Office.Interop.Excel.Application oXls = new Microsoft.Office.Interop.Excel.Application(); //エクセルオブジェクト
            Workbook oWBook = (Workbook)(oXls.Workbooks.Open(excelName)); //ワークブックオブジェクト
            Worksheet sheet = new Worksheet();

            int goukei1 = 0;
            int goukei2 = 0;
            int goukei3 = 0;
            int goukei4 = 0;
            foreach (Worksheet sh in oWBook.Sheets)
            {
                sheet = (Worksheet)oWBook.Sheets[sh.Index];

                int rowCount = sheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell).Row;
                for (int r = 2; r <= rowCount; r++)
                {
                    Range kousyu = sheet.Cells[r, 3];
                    Range kingaku = sheet.Cells[r, 6];
                    //kousyu 1：建築　2：とび、土工　3：土工　4：造園
                    if (kousyu.Value == 1)
                    {
                        goukei1 += kingaku.Value;
                    }
                    else if (kousyu.Value == 2)
                    {
                        goukei2 += kingaku.Value;
                    }
                    else if (kousyu.Value == 3)
                    {
                        goukei3 += kingaku.Value;
                    }
                    else if (kousyu.Value == 4)
                    {
                        goukei4 += kingaku.Value;
                    }
                }
            }
            oWBook.Close();

            //合計エクセルに書き込み
            excelName = System.IO.Path.GetFullPath("..\\エクセルファイル\\締め合計.xlsx");
            oXls = new Microsoft.Office.Interop.Excel.Application(); //エクセルオブジェクト
            oWBook = (Workbook)(oXls.Workbooks.Open(excelName)); //ワークブックオブジェクト
            sheet = oWBook.ActiveSheet;
            sheet.Cells.Delete();
            sheet.Cells[1, 2] = "建築";
            sheet.Cells[1, 3] = "とび・土工";
            sheet.Cells[1, 4] = "土工";
            sheet.Cells[1, 5] = "造園";
            sheet.Cells[1, 6] = "合計";
            sheet.Cells[2, 1] = "計";
            sheet.Cells[2, 2] = String.Format("{0:#,0}", goukei1);
            sheet.Cells[2, 3] = String.Format("{0:#,0}", goukei2);
            sheet.Cells[2, 4] = String.Format("{0:#,0}", goukei3);
            sheet.Cells[2, 5] = String.Format("{0:#,0}", goukei4);
            sheet.Cells[2, 6] = String.Format("{0:#,0}", goukei1 + goukei2 + goukei3 + goukei4);
            sheet.Cells[3, 1] = "(千円)";
            sheet.Cells[3, 2] = String.Format("{0:#,0}", Math.Round((decimal)goukei1 / 1000));
            sheet.Cells[3, 3] = String.Format("{0:#,0}", Math.Round((decimal)goukei2 / 1000));
            sheet.Cells[3, 4] = String.Format("{0:#,0}", Math.Round((decimal)goukei3 / 1000));
            sheet.Cells[3, 5] = String.Format("{0:#,0}", Math.Round((decimal)goukei4 / 1000));
            sheet.Cells[3, 6] = String.Format("{0:#,0}", Math.Round((decimal)goukei1 / 1000) + Math.Round((decimal)goukei2 / 1000) + Math.Round((decimal)goukei3 / 1000) + Math.Round((decimal)goukei4 / 1000));
            oWBook.Save();
            oWBook.Close();
        }
        #endregion

        #region エクセルアップデート
        private void excel_update(SortedList<int, ArrayList> s_list)
        {
            string excelName = System.IO.Path.GetFullPath("..\\エクセルファイル\\月別売上.xlsx");
            Microsoft.Office.Interop.Excel.Application oXls = new Microsoft.Office.Interop.Excel.Application(); //エクセルオブジェクト
            Workbook oWBook = (Workbook)(oXls.Workbooks.Open(excelName)); //ワークブックオブジェクト

            string month = (cmb_month.SelectedIndex + 1).ToString();
            Worksheet sheet = new Worksheet();
            foreach (Worksheet sh in oWBook.Sheets)
            {
                if (month + "月" == sh.Name)
                {
                    sheet = (Worksheet)oWBook.Sheets[sh.Index];
                    sheet.Cells.Delete();
                    sheet.Cells[1, 1] = "日にち";
                    sheet.Cells[1, 2] = "工事番号";
                    sheet.Cells[1, 3] = "工種コード";
                    sheet.Cells[1, 4] = "工種";
                    sheet.Cells[1, 5] = "工事名";
                    sheet.Cells[1, 6] = "金額";
                    sheet.Cells[1, 7] = "備考";

                    int row_count = 2;
                    ArrayList a_list = new ArrayList();
                    foreach (KeyValuePair<int, ArrayList> pair in s_list)
                    {
                        a_list = (ArrayList)pair.Value;
                        for (int i = 1; i <= 7; i++)
                        {
                            sheet.Cells[row_count, i] = a_list[i - 1];
                        }
                        row_count++;
                    }
                }
            }
            oWBook.Save();
            oWBook.Close();
        }
        #endregion
        #endregion

        #region SQL表示ボタン
        private void btn_sql_Click(object sender, EventArgs e)
        {
            string start_ymd = txt_nendo.Text.ToString() + "0426";
            string end_ymd = (int.Parse(txt_nendo.Text.ToString()) + 1).ToString() + "0425";
            string sql = "select substring(no, 1, 8) ymd, kouji_no, ";
            sql += "CASE WHEN kouosyu_code = '0' THEN '建' ";
            sql += "WHEN kouosyu_code = '1' THEN 'とび・土工' ";
            sql += "WHEN kouosyu_code = '2' THEN '土工' ";
            sql += "WHEN kouosyu_code = '3' THEN '造園' ";
            sql += "ELSE kouosyu_code END ";
            sql += ", kouji_nm, kouji_kingaku, bikou ";
            sql += "from kouji_kanri ";
            sql += "where del_flg = 0 and substring(no, 1, 8) >= '" + start_ymd + "' and substring(no, 1, 8) <= '" + end_ymd + "'";
            sql += "order by no";
            Clipboard.SetText(sql);
            MessageBox.Show(this, "クリップボードにコピーされました。");
        }
        #endregion
    }
}
