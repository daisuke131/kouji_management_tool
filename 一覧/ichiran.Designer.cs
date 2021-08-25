namespace ichiran
{
    partial class ichiran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_nendo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kouji_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kousyucode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kousyu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kouji_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zeinuki_kingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.rb_ken = new System.Windows.Forms.RadioButton();
            this.rb_do = new System.Windows.Forms.RadioButton();
            this.rb_zou = new System.Windows.Forms.RadioButton();
            this.rb_to = new System.Windows.Forms.RadioButton();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nendo
            // 
            this.lbl_nendo.AutoSize = true;
            this.lbl_nendo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_nendo.Location = new System.Drawing.Point(27, 26);
            this.lbl_nendo.Name = "lbl_nendo";
            this.lbl_nendo.Size = new System.Drawing.Size(49, 19);
            this.lbl_nendo.TabIndex = 8;
            this.lbl_nendo.Text = "2016";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(77, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "年度";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.kouji_no,
            this.kousyucode,
            this.kousyu,
            this.kouji_name,
            this.kingaku,
            this.zeinuki_kingaku,
            this.bikou,
            this.no,
            this.check});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.Location = new System.Drawing.Point(26, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(932, 481);
            this.dataGridView1.TabIndex = 11;
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
            this.kouji_no.Width = 120;
            // 
            // kousyucode
            // 
            this.kousyucode.HeaderText = "工種コード";
            this.kousyucode.Name = "kousyucode";
            this.kousyucode.Visible = false;
            // 
            // kousyu
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kousyu.DefaultCellStyle = dataGridViewCellStyle17;
            this.kousyu.HeaderText = "工種";
            this.kousyu.Name = "kousyu";
            this.kousyu.Width = 60;
            // 
            // kouji_name
            // 
            this.kouji_name.HeaderText = "工事名";
            this.kouji_name.Name = "kouji_name";
            this.kouji_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kouji_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kouji_name.Width = 350;
            // 
            // kingaku
            // 
            this.kingaku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "C0";
            dataGridViewCellStyle18.NullValue = null;
            this.kingaku.DefaultCellStyle = dataGridViewCellStyle18;
            this.kingaku.HeaderText = "金額";
            this.kingaku.Name = "kingaku";
            this.kingaku.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kingaku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kingaku.Width = 120;
            // 
            // zeinuki_kingaku
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = null;
            this.zeinuki_kingaku.DefaultCellStyle = dataGridViewCellStyle19;
            this.zeinuki_kingaku.HeaderText = "税抜(千単位)";
            this.zeinuki_kingaku.Name = "zeinuki_kingaku";
            this.zeinuki_kingaku.Width = 120;
            // 
            // bikou
            // 
            this.bikou.HeaderText = "備考";
            this.bikou.Name = "bikou";
            this.bikou.Visible = false;
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.Name = "no";
            this.no.Visible = false;
            // 
            // check
            // 
            this.check.HeaderText = "チェック";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.check.Width = 50;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_close.Location = new System.Drawing.Point(839, 567);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 61);
            this.btn_close.TabIndex = 12;
            this.btn_close.Text = "閉じる";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rb_ken
            // 
            this.rb_ken.AutoSize = true;
            this.rb_ken.Location = new System.Drawing.Point(82, 21);
            this.rb_ken.Name = "rb_ken";
            this.rb_ken.Size = new System.Drawing.Size(35, 16);
            this.rb_ken.TabIndex = 13;
            this.rb_ken.Text = "建";
            this.rb_ken.UseVisualStyleBackColor = true;
            this.rb_ken.CheckedChanged += new System.EventHandler(this.rb_ken_CheckedChanged);
            // 
            // rb_do
            // 
            this.rb_do.AutoSize = true;
            this.rb_do.Location = new System.Drawing.Point(130, 21);
            this.rb_do.Name = "rb_do";
            this.rb_do.Size = new System.Drawing.Size(35, 16);
            this.rb_do.TabIndex = 14;
            this.rb_do.Text = "土";
            this.rb_do.UseVisualStyleBackColor = true;
            this.rb_do.CheckedChanged += new System.EventHandler(this.rb_do_CheckedChanged);
            // 
            // rb_zou
            // 
            this.rb_zou.AutoSize = true;
            this.rb_zou.Location = new System.Drawing.Point(174, 22);
            this.rb_zou.Name = "rb_zou";
            this.rb_zou.Size = new System.Drawing.Size(35, 16);
            this.rb_zou.TabIndex = 15;
            this.rb_zou.Text = "造";
            this.rb_zou.UseVisualStyleBackColor = true;
            this.rb_zou.CheckedChanged += new System.EventHandler(this.rb_zou_CheckedChanged);
            // 
            // rb_to
            // 
            this.rb_to.AutoSize = true;
            this.rb_to.Location = new System.Drawing.Point(228, 22);
            this.rb_to.Name = "rb_to";
            this.rb_to.Size = new System.Drawing.Size(31, 16);
            this.rb_to.TabIndex = 16;
            this.rb_to.Text = "と";
            this.rb_to.UseVisualStyleBackColor = true;
            this.rb_to.CheckedChanged += new System.EventHandler(this.rb_to_CheckedChanged);
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(17, 21);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(52, 16);
            this.rb_all.TabIndex = 17;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "すべて";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_all);
            this.groupBox1.Controls.Add(this.rb_to);
            this.groupBox1.Controls.Add(this.rb_ken);
            this.groupBox1.Controls.Add(this.rb_zou);
            this.groupBox1.Controls.Add(this.rb_do);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 49);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "種別表示";
            // 
            // ichiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_nendo);
            this.Controls.Add(this.label5);
            this.Name = "ichiran";
            this.Text = "集計";
            this.Load += new System.EventHandler(this.ichiran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nendo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn kouji_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn kousyucode;
        private System.Windows.Forms.DataGridViewTextBoxColumn kousyu;
        private System.Windows.Forms.DataGridViewTextBoxColumn kouji_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn zeinuki_kingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn bikou;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewButtonColumn check;
        private System.Windows.Forms.RadioButton rb_ken;
        private System.Windows.Forms.RadioButton rb_do;
        private System.Windows.Forms.RadioButton rb_zou;
        private System.Windows.Forms.RadioButton rb_to;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

