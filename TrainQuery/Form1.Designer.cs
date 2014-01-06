namespace _TrainQuery_
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDesFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbTrainNo = new System.Windows.Forms.GroupBox();
            this.cbO = new System.Windows.Forms.CheckBox();
            this.cbT = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.cbK = new System.Windows.Forms.CheckBox();
            this.cbZ = new System.Windows.Forms.CheckBox();
            this.cbG = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbStatusDic = new System.Windows.Forms.Label();
            this.lbStatusCon = new System.Windows.Forms.Label();
            this.lbListCount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbPrice = new System.Windows.Forms.Label();
            this.票价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.gbTrainNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDesFrom
            // 
            this.txtDesFrom.Location = new System.Drawing.Point(68, 18);
            this.txtDesFrom.Name = "txtDesFrom";
            this.txtDesFrom.Size = new System.Drawing.Size(100, 21);
            this.txtDesFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "出发地";
            // 
            // txtDesTo
            // 
            this.txtDesTo.Location = new System.Drawing.Point(270, 18);
            this.txtDesTo.Name = "txtDesTo";
            this.txtDesTo.Size = new System.Drawing.Size(100, 21);
            this.txtDesTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "目的地";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "出发日";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(453, 17);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(103, 21);
            this.dtp.TabIndex = 2;
            this.dtp.Value = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.txtDesFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDesTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // gbTrainNo
            // 
            this.gbTrainNo.Controls.Add(this.cbO);
            this.gbTrainNo.Controls.Add(this.cbT);
            this.gbTrainNo.Controls.Add(this.cbD);
            this.gbTrainNo.Controls.Add(this.cbK);
            this.gbTrainNo.Controls.Add(this.cbZ);
            this.gbTrainNo.Controls.Add(this.cbG);
            this.gbTrainNo.Location = new System.Drawing.Point(12, 75);
            this.gbTrainNo.Name = "gbTrainNo";
            this.gbTrainNo.Size = new System.Drawing.Size(507, 54);
            this.gbTrainNo.TabIndex = 5;
            this.gbTrainNo.TabStop = false;
            this.gbTrainNo.Text = "车次类型";
            // 
            // cbO
            // 
            this.cbO.AutoSize = true;
            this.cbO.Location = new System.Drawing.Point(452, 20);
            this.cbO.Name = "cbO";
            this.cbO.Size = new System.Drawing.Size(48, 16);
            this.cbO.TabIndex = 5;
            this.cbO.Tag = "O";
            this.cbO.Text = "其他";
            this.cbO.UseVisualStyleBackColor = true;
            this.cbO.CheckedChanged += new System.EventHandler(this.CbChange);
            // 
            // cbT
            // 
            this.cbT.AutoSize = true;
            this.cbT.Location = new System.Drawing.Point(284, 20);
            this.cbT.Name = "cbT";
            this.cbT.Size = new System.Drawing.Size(60, 16);
            this.cbT.TabIndex = 3;
            this.cbT.Tag = "T";
            this.cbT.Text = "T-特快";
            this.cbT.UseVisualStyleBackColor = true;
            this.cbT.CheckedChanged += new System.EventHandler(this.CbChange);
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(116, 20);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(60, 16);
            this.cbD.TabIndex = 1;
            this.cbD.Tag = "D";
            this.cbD.Text = "D-动车";
            this.cbD.UseVisualStyleBackColor = true;
            this.cbD.CheckedChanged += new System.EventHandler(this.CbChange);
            // 
            // cbK
            // 
            this.cbK.AutoSize = true;
            this.cbK.Location = new System.Drawing.Point(368, 20);
            this.cbK.Name = "cbK";
            this.cbK.Size = new System.Drawing.Size(60, 16);
            this.cbK.TabIndex = 4;
            this.cbK.Tag = "K";
            this.cbK.Text = "K-快速";
            this.cbK.UseVisualStyleBackColor = true;
            this.cbK.CheckedChanged += new System.EventHandler(this.CbChange);
            // 
            // cbZ
            // 
            this.cbZ.AutoSize = true;
            this.cbZ.Location = new System.Drawing.Point(200, 20);
            this.cbZ.Name = "cbZ";
            this.cbZ.Size = new System.Drawing.Size(60, 16);
            this.cbZ.TabIndex = 2;
            this.cbZ.Tag = "Z";
            this.cbZ.Text = "Z-直达";
            this.cbZ.UseVisualStyleBackColor = true;
            this.cbZ.CheckedChanged += new System.EventHandler(this.CbChange);
            // 
            // cbG
            // 
            this.cbG.AutoSize = true;
            this.cbG.Location = new System.Drawing.Point(8, 20);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(102, 16);
            this.cbG.TabIndex = 0;
            this.cbG.Tag = "G";
            this.cbG.Text = "G/C-高铁/城际";
            this.cbG.UseVisualStyleBackColor = true;
            this.cbG.CheckedChanged += new System.EventHandler(this.CbChange);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(681, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column15,
            this.Column14,
            this.Column13,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column16,
            this.Column17,
            this.Column8,
            this.Column18});
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(744, 374);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "station_train_code";
            this.Column1.HeaderText = "车次";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "from_station_name";
            this.Column2.HeaderText = "出发站";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "to_station_name";
            this.Column3.HeaderText = "目的站";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "start_time";
            this.Column4.HeaderText = "出发时间";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "arrive_time";
            this.Column5.HeaderText = "到达时间";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "lishi";
            this.Column6.HeaderText = "历时";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "tz_num";
            this.Column7.HeaderText = "特等座";
            this.Column7.Name = "Column7";
            this.Column7.Width = 40;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "swz_num";
            this.Column15.HeaderText = "商务座";
            this.Column15.Name = "Column15";
            this.Column15.Width = 40;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "zy_num";
            this.Column14.HeaderText = "一等座";
            this.Column14.Name = "Column14";
            this.Column14.Width = 40;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "ze_num";
            this.Column13.HeaderText = "二等座";
            this.Column13.Name = "Column13";
            this.Column13.Width = 40;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "rw_num";
            this.Column9.HeaderText = "软卧";
            this.Column9.Name = "Column9";
            this.Column9.Width = 40;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "rz_num";
            this.Column10.HeaderText = "软座";
            this.Column10.Name = "Column10";
            this.Column10.Width = 40;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "yw_num";
            this.Column11.HeaderText = "硬卧";
            this.Column11.Name = "Column11";
            this.Column11.Width = 40;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "yz_num";
            this.Column12.HeaderText = "硬座";
            this.Column12.Name = "Column12";
            this.Column12.Width = 40;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "wz_num";
            this.Column16.HeaderText = "无座";
            this.Column16.Name = "Column16";
            this.Column16.Width = 40;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "qt_num";
            this.Column17.HeaderText = "其他";
            this.Column17.Name = "Column17";
            this.Column17.Visible = false;
            this.Column17.Width = 40;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "gr_num";
            this.Column8.HeaderText = "不知道";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 40;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "yb_num";
            this.Column18.HeaderText = "不知道";
            this.Column18.Name = "Column18";
            this.Column18.Visible = false;
            this.Column18.Width = 40;
            // 
            // lbStatusDic
            // 
            this.lbStatusDic.AutoSize = true;
            this.lbStatusDic.Location = new System.Drawing.Point(612, 82);
            this.lbStatusDic.Name = "lbStatusDic";
            this.lbStatusDic.Size = new System.Drawing.Size(29, 12);
            this.lbStatusDic.TabIndex = 8;
            this.lbStatusDic.Text = "字典";
            // 
            // lbStatusCon
            // 
            this.lbStatusCon.AutoSize = true;
            this.lbStatusCon.Location = new System.Drawing.Point(613, 108);
            this.lbStatusCon.Name = "lbStatusCon";
            this.lbStatusCon.Size = new System.Drawing.Size(29, 12);
            this.lbStatusCon.TabIndex = 9;
            this.lbStatusCon.Text = "网络";
            // 
            // lbListCount
            // 
            this.lbListCount.AutoSize = true;
            this.lbListCount.Location = new System.Drawing.Point(526, 95);
            this.lbListCount.Name = "lbListCount";
            this.lbListCount.Size = new System.Drawing.Size(29, 12);
            this.lbListCount.TabIndex = 10;
            this.lbListCount.Text = "数量";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.票价ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(20, 516);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(41, 12);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "label4";
            // 
            // 票价ToolStripMenuItem
            // 
            this.票价ToolStripMenuItem.Name = "票价ToolStripMenuItem";
            this.票价ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.票价ToolStripMenuItem.Text = "票价";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 537);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbListCount);
            this.Controls.Add(this.lbStatusCon);
            this.Controls.Add(this.lbStatusDic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbTrainNo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainQuery(20131230)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTrainNo.ResumeLayout(false);
            this.gbTrainNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbTrainNo;
        private System.Windows.Forms.CheckBox cbO;
        private System.Windows.Forms.CheckBox cbT;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.CheckBox cbK;
        private System.Windows.Forms.CheckBox cbZ;
        private System.Windows.Forms.CheckBox cbG;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.Label lbStatusDic;
        private System.Windows.Forms.Label lbStatusCon;
        private System.Windows.Forms.Label lbListCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ToolStripMenuItem 票价ToolStripMenuItem;
    }
}

