namespace tuika
{
    partial class tuika
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_koujino = new System.Windows.Forms.TextBox();
            this.txt_koujiname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rt_bikou = new System.Windows.Forms.RichTextBox();
            this.lbl_kingaku = new System.Windows.Forms.Label();
            this.txt_kingaku = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_kousyu = new System.Windows.Forms.ComboBox();
            this.lbl_no = new System.Windows.Forms.Label();
            this.lbl_ym = new System.Windows.Forms.Label();
            this.cmb_shitauke = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(283, 428);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 32);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "追加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "工事No";
            // 
            // txt_koujino
            // 
            this.txt_koujino.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_koujino.Location = new System.Drawing.Point(103, 96);
            this.txt_koujino.Name = "txt_koujino";
            this.txt_koujino.Size = new System.Drawing.Size(100, 26);
            this.txt_koujino.TabIndex = 2;
            // 
            // txt_koujiname
            // 
            this.txt_koujiname.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_koujiname.Location = new System.Drawing.Point(103, 142);
            this.txt_koujiname.Name = "txt_koujiname";
            this.txt_koujiname.Size = new System.Drawing.Size(264, 26);
            this.txt_koujiname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "工事名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "日にち";
            // 
            // txt_date
            // 
            this.txt_date.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_date.Location = new System.Drawing.Point(103, 51);
            this.txt_date.MaxLength = 2;
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(50, 26);
            this.txt_date.TabIndex = 1;
            this.txt_date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_date_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(158, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(21, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "備考";
            // 
            // rt_bikou
            // 
            this.rt_bikou.Location = new System.Drawing.Point(103, 240);
            this.rt_bikou.Name = "rt_bikou";
            this.rt_bikou.Size = new System.Drawing.Size(264, 172);
            this.rt_bikou.TabIndex = 5;
            this.rt_bikou.Text = "";
            // 
            // lbl_kingaku
            // 
            this.lbl_kingaku.AutoSize = true;
            this.lbl_kingaku.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_kingaku.Location = new System.Drawing.Point(287, 194);
            this.lbl_kingaku.Name = "lbl_kingaku";
            this.lbl_kingaku.Size = new System.Drawing.Size(0, 16);
            this.lbl_kingaku.TabIndex = 14;
            // 
            // txt_kingaku
            // 
            this.txt_kingaku.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_kingaku.Location = new System.Drawing.Point(103, 189);
            this.txt_kingaku.Name = "txt_kingaku";
            this.txt_kingaku.Size = new System.Drawing.Size(156, 26);
            this.txt_kingaku.TabIndex = 3;
            this.txt_kingaku.TextChanged += new System.EventHandler(this.txt_kingaku_TextChanged);
            this.txt_kingaku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kingaku_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(21, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "金額";
            // 
            // cmb_kousyu
            // 
            this.cmb_kousyu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_kousyu.FormattingEnabled = true;
            this.cmb_kousyu.Location = new System.Drawing.Point(246, 53);
            this.cmb_kousyu.Name = "cmb_kousyu";
            this.cmb_kousyu.Size = new System.Drawing.Size(121, 20);
            this.cmb_kousyu.TabIndex = 7;
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_no.Location = new System.Drawing.Point(216, 18);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(0, 19);
            this.lbl_no.TabIndex = 17;
            // 
            // lbl_ym
            // 
            this.lbl_ym.AutoSize = true;
            this.lbl_ym.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ym.Location = new System.Drawing.Point(41, 17);
            this.lbl_ym.Name = "lbl_ym";
            this.lbl_ym.Size = new System.Drawing.Size(46, 16);
            this.lbl_ym.TabIndex = 18;
            this.lbl_ym.Text = "label7";
            // 
            // cmb_shitauke
            // 
            this.cmb_shitauke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_shitauke.FormattingEnabled = true;
            this.cmb_shitauke.Location = new System.Drawing.Point(280, 98);
            this.cmb_shitauke.Name = "cmb_shitauke";
            this.cmb_shitauke.Size = new System.Drawing.Size(87, 20);
            this.cmb_shitauke.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "↑赤穂市の場合は「赤穂市」";
            // 
            // tuika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_shitauke);
            this.Controls.Add(this.lbl_ym);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.cmb_kousyu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_kingaku);
            this.Controls.Add(this.lbl_kingaku);
            this.Controls.Add(this.rt_bikou);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_koujiname);
            this.Controls.Add(this.txt_koujino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "tuika";
            this.Text = "追加";
            this.Load += new System.EventHandler(this.tuika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_koujino;
        private System.Windows.Forms.TextBox txt_koujiname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rt_bikou;
        private System.Windows.Forms.Label lbl_kingaku;
        private System.Windows.Forms.TextBox txt_kingaku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_kousyu;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.Label lbl_ym;
        private System.Windows.Forms.ComboBox cmb_shitauke;
        private System.Windows.Forms.Label label7;
    }
}

