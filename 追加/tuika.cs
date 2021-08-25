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

namespace tuika
{
    public partial class tuika : Form
    {
        public ArrayList list = new ArrayList();
        public bool tuika_flg = false;
        public ArrayList edit_list = new ArrayList();
        public string ym_string = string.Empty;
        public tuika()
        {
            InitializeComponent();
        }

        #region ロード
        private void tuika_Load(object sender, EventArgs e)
        {
            lbl_ym.Text = ym_string;
            //コンボボックスにセット
            cmb_kousyu.Items.Add("建築");
            cmb_kousyu.Items.Add("とび・土木");
            cmb_kousyu.Items.Add("土木");
            cmb_kousyu.Items.Add("造園");
            cmb_kousyu.SelectedIndex = 0;
            //コンボボックスにセット
            cmb_shitauke.Items.Add("下請");
            cmb_shitauke.Items.Add("元請");
            cmb_shitauke.SelectedIndex = 0;
            
            //編集の場合値セット
            if(edit_list.Count > 0)
            {
                txt_date.Text = int.Parse(edit_list[0].ToString()).ToString();
                txt_koujino.Text = edit_list[1].ToString();
                txt_koujiname.Text = edit_list[2].ToString();
                cmb_kousyu.SelectedIndex = int.Parse(edit_list[3].ToString());
                txt_kingaku.Text = edit_list[4].ToString();
                rt_bikou.Text = edit_list[5].ToString();
                lbl_no.Text = edit_list[6].ToString();
                cmb_shitauke.SelectedIndex = int.Parse(edit_list[7].ToString());
                btn_add.Text = "修正";
            }
        }
        #endregion

        #region 半角数字のみ入力
        private void txt_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txt_kingaku_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        #endregion

        #region カンマ
        private void txt_kingaku_TextChanged(object sender, EventArgs e)
        {
            if(txt_kingaku.Text.Length == 0)
            {
                lbl_kingaku.Text = string.Empty;
                return;
            }
            int number = int.Parse(txt_kingaku.Text); // 変換前の数値
            lbl_kingaku.Text = "\\" + String.Format("{0:#,0}", number) + ".-";
        }
        #endregion


        #region 追加ボタン
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_date.Text.Equals(string.Empty) || txt_koujiname.Text.Equals(string.Empty) || txt_kingaku.Text.Equals(string.Empty))
            {
                MessageBox.Show("必須項目書け！");
                return;
            }
            tuika_flg = true;
            list.Add(txt_date.Text);
            list.Add(txt_koujino.Text);
            list.Add((cmb_kousyu.SelectedIndex).ToString());
            switch(cmb_kousyu.SelectedIndex)
            {
                case 0:
                    list.Add("建");
                    break;
                case 1:
                    list.Add("と");
                    break;
                case 2:
                    list.Add("土");
                    break;
                case 3:
                    list.Add("造");
                    break;
            }
            list.Add(txt_koujiname.Text);
            list.Add(txt_kingaku.Text);
            list.Add(rt_bikou.Text);
            list.Add(lbl_no.Text);
            list.Add((cmb_shitauke.SelectedIndex).ToString());
            this.Dispose();
        }
        #endregion
    }
}
