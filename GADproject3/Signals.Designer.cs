
namespace GADproject3
{
    partial class Signals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Sdescription = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_STarget = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Pair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_SBS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Sdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_SPair = new System.Windows.Forms.ComboBox();
            this.txt_SEntry = new System.Windows.Forms.TextBox();
            this.txt_SStopLoss = new System.Windows.Forms.TextBox();
            this.signalDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TradeSubmit = new System.Windows.Forms.Button();
            this.btn_Editdelete = new System.Windows.Forms.Button();
            this.btn_SRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "⬅";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.btn_home.BackgroundImage = global::GADproject3.Properties.Resources.kisspng_home_assistant_computer_icons_home_automation_kits_5b2beb86ae54e0_8600300515296049987141;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_home.Location = new System.Drawing.Point(75, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(48, 40);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(112)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 40);
            this.panel2.TabIndex = 5;
            // 
            // txt_Sdescription
            // 
            this.txt_Sdescription.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Sdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Sdescription.Location = new System.Drawing.Point(157, 503);
            this.txt_Sdescription.Name = "txt_Sdescription";
            this.txt_Sdescription.Size = new System.Drawing.Size(242, 93);
            this.txt_Sdescription.TabIndex = 73;
            this.txt_Sdescription.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label9.Location = new System.Drawing.Point(54, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 72;
            this.label9.Text = "Description";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_STarget
            // 
            this.txt_STarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_STarget.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STarget.Location = new System.Drawing.Point(548, 454);
            this.txt_STarget.Name = "txt_STarget";
            this.txt_STarget.Size = new System.Drawing.Size(242, 22);
            this.txt_STarget.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label11.Location = new System.Drawing.Point(445, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "Target Price";
            // 
            // lbl_Pair
            // 
            this.lbl_Pair.AutoSize = true;
            this.lbl_Pair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.lbl_Pair.Location = new System.Drawing.Point(69, 375);
            this.lbl_Pair.Name = "lbl_Pair";
            this.lbl_Pair.Size = new System.Drawing.Size(41, 16);
            this.lbl_Pair.TabIndex = 60;
            this.lbl_Pair.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(69, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Pair";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(436, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Entry Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(445, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Stop Loss";
            // 
            // cmb_SBS
            // 
            this.cmb_SBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cmb_SBS.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SBS.FormattingEnabled = true;
            this.cmb_SBS.Items.AddRange(new object[] {
            "BUY",
            "SELL"});
            this.cmb_SBS.Location = new System.Drawing.Point(157, 450);
            this.cmb_SBS.Name = "cmb_SBS";
            this.cmb_SBS.Size = new System.Drawing.Size(242, 23);
            this.cmb_SBS.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.label10.Location = new System.Drawing.Point(69, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "Buy/Sell";
            // 
            // Sdate
            // 
            this.Sdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.Sdate.CustomFormat = "yyyy/MM/dd";
            this.Sdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Sdate.Location = new System.Drawing.Point(157, 370);
            this.Sdate.Name = "Sdate";
            this.Sdate.Size = new System.Drawing.Size(242, 22);
            this.Sdate.TabIndex = 64;
            // 
            // cmb_SPair
            // 
            this.cmb_SPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cmb_SPair.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SPair.FormattingEnabled = true;
            this.cmb_SPair.Items.AddRange(new object[] {
            "EURUSD",
            "AUDUSD",
            "USDCHF",
            "GBPUSD",
            "USDCAD"});
            this.cmb_SPair.Location = new System.Drawing.Point(157, 410);
            this.cmb_SPair.Name = "cmb_SPair";
            this.cmb_SPair.Size = new System.Drawing.Size(242, 23);
            this.cmb_SPair.TabIndex = 65;
            // 
            // txt_SEntry
            // 
            this.txt_SEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_SEntry.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SEntry.Location = new System.Drawing.Point(548, 370);
            this.txt_SEntry.Name = "txt_SEntry";
            this.txt_SEntry.Size = new System.Drawing.Size(242, 22);
            this.txt_SEntry.TabIndex = 66;
            // 
            // txt_SStopLoss
            // 
            this.txt_SStopLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txt_SStopLoss.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SStopLoss.Location = new System.Drawing.Point(548, 411);
            this.txt_SStopLoss.Name = "txt_SStopLoss";
            this.txt_SStopLoss.Size = new System.Drawing.Size(242, 22);
            this.txt_SStopLoss.TabIndex = 67;
            // 
            // signalDataGrid
            // 
            this.signalDataGrid.AllowUserToAddRows = false;
            this.signalDataGrid.AllowUserToDeleteRows = false;
            this.signalDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.signalDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.signalDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.signalDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.signalDataGrid.Location = new System.Drawing.Point(23, 56);
            this.signalDataGrid.Name = "signalDataGrid";
            this.signalDataGrid.ReadOnly = true;
            this.signalDataGrid.Size = new System.Drawing.Size(942, 291);
            this.signalDataGrid.TabIndex = 74;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SignalID";
            this.Column1.HeaderText = "Signal ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SDate";
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SPair";
            this.Column3.HeaderText = "Pair";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SBS";
            this.Column4.HeaderText = "Buy/Sell";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SEntry";
            this.Column5.HeaderText = "Entry Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SSL";
            this.Column6.HeaderText = "Stop Loss";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "STarget";
            this.Column7.HeaderText = "Initial Target";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "SDescript";
            this.Column8.HeaderText = "Description";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SAID";
            this.Column9.HeaderText = "Admin";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // btn_TradeSubmit
            // 
            this.btn_TradeSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.btn_TradeSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TradeSubmit.ForeColor = System.Drawing.Color.Snow;
            this.btn_TradeSubmit.Location = new System.Drawing.Point(282, 630);
            this.btn_TradeSubmit.Name = "btn_TradeSubmit";
            this.btn_TradeSubmit.Size = new System.Drawing.Size(117, 33);
            this.btn_TradeSubmit.TabIndex = 75;
            this.btn_TradeSubmit.Text = "Submit";
            this.btn_TradeSubmit.UseVisualStyleBackColor = false;
            this.btn_TradeSubmit.Click += new System.EventHandler(this.btn_TradeSubmit_Click);
            // 
            // btn_Editdelete
            // 
            this.btn_Editdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.btn_Editdelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editdelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Editdelete.Location = new System.Drawing.Point(434, 628);
            this.btn_Editdelete.Name = "btn_Editdelete";
            this.btn_Editdelete.Size = new System.Drawing.Size(90, 35);
            this.btn_Editdelete.TabIndex = 76;
            this.btn_Editdelete.Text = "Delete";
            this.btn_Editdelete.UseVisualStyleBackColor = false;
            this.btn_Editdelete.Click += new System.EventHandler(this.btn_Editdelete_Click);
            // 
            // btn_SRefresh
            // 
            this.btn_SRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.btn_SRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_SRefresh.Location = new System.Drawing.Point(573, 628);
            this.btn_SRefresh.Name = "btn_SRefresh";
            this.btn_SRefresh.Size = new System.Drawing.Size(90, 35);
            this.btn_SRefresh.TabIndex = 77;
            this.btn_SRefresh.Text = "Refresh";
            this.btn_SRefresh.UseVisualStyleBackColor = false;
            this.btn_SRefresh.Click += new System.EventHandler(this.btn_SRefresh_Click);
            // 
            // Signals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_SRefresh);
            this.Controls.Add(this.btn_Editdelete);
            this.Controls.Add(this.btn_TradeSubmit);
            this.Controls.Add(this.signalDataGrid);
            this.Controls.Add(this.txt_Sdescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_STarget);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_Pair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_SBS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Sdate);
            this.Controls.Add(this.cmb_SPair);
            this.Controls.Add(this.txt_SEntry);
            this.Controls.Add(this.txt_SStopLoss);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signals";
            this.Load += new System.EventHandler(this.Signals_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txt_Sdescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_STarget;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Pair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_SBS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Sdate;
        private System.Windows.Forms.ComboBox cmb_SPair;
        private System.Windows.Forms.TextBox txt_SEntry;
        private System.Windows.Forms.TextBox txt_SStopLoss;
        private System.Windows.Forms.DataGridView signalDataGrid;
        private System.Windows.Forms.Button btn_TradeSubmit;
        private System.Windows.Forms.Button btn_Editdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btn_SRefresh;
    }
}