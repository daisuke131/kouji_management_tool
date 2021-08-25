namespace kouji_ichiran
{
    partial class kouji_ichiran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kouji_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kousyucode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kousyu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kouji_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.btn_goukei = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.lbl_year = new System.Windows.Forms.Label();
            this.txt_nendo = new System.Windows.Forms.TextBox();
            this.lbl_nendo = new System.Windows.Forms.Label();
            this.btn_ichiran = new System.Windows.Forms.Button();
            this.btn_sql = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(507, 31);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 32);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "追加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "4/26～翌4/25まで";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.kouji_no,
            this.kousyucode,
            this.kousyu,
            this.kouji_name,
            this.kingaku,
            this.bikou,
            this.no,
            this.del_btn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(26, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(914, 401);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // date
            // 
            this.date.HeaderText = "日にち";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.date.Width = 80;
            // 
            // kouji_no
            // 
            this.kouji_no.HeaderText = "工事No";
            this.kouji_no.Name = "kouji_no";
            this.kouji_no.ReadOnly = true;
            this.kouji_no.Width = 120;
            // 
            // kousyucode
            // 
            this.kousyucode.HeaderText = "工種コード";
            this.kousyucode.Name = "kousyucode";
            this.kousyucode.ReadOnly = true;
            this.kousyucode.Visible = false;
            // 
            // kousyu
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kousyu.DefaultCellStyle = dataGridViewCellStyle2;
            this.kousyu.HeaderText = "工種";
            this.kousyu.Name = "kousyu";
            this.kousyu.ReadOnly = true;
            this.kousyu.Width = 60;
            // 
            // kouji_name
            // 
            this.kouji_name.HeaderText = "工事名";
            this.kouji_name.Name = "kouji_name";
            this.kouji_name.ReadOnly = true;
            this.kouji_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kouji_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kouji_name.Width = 400;
            // 
            // kingaku
            // 
            this.kingaku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.kingaku.DefaultCellStyle = dataGridViewCellStyle3;
            this.kingaku.HeaderText = "金額";
            this.kingaku.Name = "kingaku";
            this.kingaku.ReadOnly = true;
            this.kingaku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kingaku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kingaku.Width = 150;
            // 
            // bikou
            // 
            this.bikou.HeaderText = "備考";
            this.bikou.Name = "bikou";
            this.bikou.ReadOnly = true;
            this.bikou.Visible = false;
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Visible = false;
            // 
            // del_btn
            // 
            this.del_btn.HeaderText = "削除";
            this.del_btn.Name = "del_btn";
            this.del_btn.ReadOnly = true;
            this.del_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.del_btn.Text = "削除";
            this.del_btn.UseColumnTextForButtonValue = true;
            // 
            // cmb_month
            // 
            this.cmb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_month.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(168, 34);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(90, 27);
            this.cmb_month.TabIndex = 4;
            this.cmb_month.SelectedIndexChanged += new System.EventHandler(this.cmb_month_SelectedIndexChanged);
            // 
            // btn_goukei
            // 
            this.btn_goukei.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_goukei.Location = new System.Drawing.Point(834, 516);
            this.btn_goukei.Name = "btn_goukei";
            this.btn_goukei.Size = new System.Drawing.Size(106, 98);
            this.btn_goukei.TabIndex = 8;
            this.btn_goukei.Text = "集計";
            this.btn_goukei.UseVisualStyleBackColor = true;
            this.btn_goukei.Click += new System.EventHandler(this.btn_goukei_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(306, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "※サンライフ光都は建築";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(622, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "日付は工事終了日";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_year.Location = new System.Drawing.Point(39, 36);
            this.txt_year.MaxLength = 4;
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(60, 23);
            this.txt_year.TabIndex = 11;
            this.txt_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_year_KeyPress);
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_year.Location = new System.Drawing.Point(115, 37);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(28, 19);
            this.lbl_year.TabIndex = 12;
            this.lbl_year.Text = "年";
            // 
            // txt_nendo
            // 
            this.txt_nendo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_nendo.Location = new System.Drawing.Point(583, 554);
            this.txt_nendo.MaxLength = 4;
            this.txt_nendo.Name = "txt_nendo";
            this.txt_nendo.Size = new System.Drawing.Size(60, 23);
            this.txt_nendo.TabIndex = 13;
            // 
            // lbl_nendo
            // 
            this.lbl_nendo.AutoSize = true;
            this.lbl_nendo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_nendo.Location = new System.Drawing.Point(649, 555);
            this.lbl_nendo.Name = "lbl_nendo";
            this.lbl_nendo.Size = new System.Drawing.Size(47, 19);
            this.lbl_nendo.TabIndex = 14;
            this.lbl_nendo.Text = "年度";
            // 
            // btn_ichiran
            // 
            this.btn_ichiran.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ichiran.Location = new System.Drawing.Point(713, 516);
            this.btn_ichiran.Name = "btn_ichiran";
            this.btn_ichiran.Size = new System.Drawing.Size(106, 46);
            this.btn_ichiran.TabIndex = 15;
            this.btn_ichiran.Text = "一覧";
            this.btn_ichiran.UseVisualStyleBackColor = true;
            this.btn_ichiran.Click += new System.EventHandler(this.btn_ichiran_Click);
            // 
            // btn_sql
            // 
            this.btn_sql.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_sql.Location = new System.Drawing.Point(713, 568);
            this.btn_sql.Name = "btn_sql";
            this.btn_sql.Size = new System.Drawing.Size(106, 46);
            this.btn_sql.TabIndex = 16;
            this.btn_sql.Text = "一覧SQL";
            this.btn_sql.UseVisualStyleBackColor = true;
            this.btn_sql.Click += new System.EventHandler(this.btn_sql_Click);
            // 
            // kouji_ichiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 670);
            this.Controls.Add(this.btn_sql);
            this.Controls.Add(this.btn_ichiran);
            this.Controls.Add(this.lbl_nendo);
            this.Controls.Add(this.txt_nendo);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_goukei);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Name = "kouji_ichiran";
            this.Text = "工事一覧";
            this.Load += new System.EventHandler(this.kouji_ichiran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Button btn_goukei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kouji_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn kousyucode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kousyu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kouji_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikou;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewButtonColumn del_btn;
        private System.Windows.Forms.TextBox txt_nendo;
        private System.Windows.Forms.Label lbl_nendo;
        private System.Windows.Forms.Button btn_ichiran;
        private System.Windows.Forms.Button btn_sql;
    }
}