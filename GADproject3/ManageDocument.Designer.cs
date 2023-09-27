
namespace GADproject3
{
    partial class ManageDocuments
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
            this.docdatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_AddDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DocView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DocUpload = new System.Windows.Forms.Button();
            this.btn_DocDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docdatagrid)).BeginInit();
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
            this.btn_home.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_home.Location = new System.Drawing.Point(75, 0);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(55, 40);
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
            this.panel2.TabIndex = 3;
            // 
            // docdatagrid
            // 
            this.docdatagrid.AllowUserToAddRows = false;
            this.docdatagrid.AllowUserToDeleteRows = false;
            this.docdatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.docdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.docdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.docdatagrid.Location = new System.Drawing.Point(397, 62);
            this.docdatagrid.Name = "docdatagrid";
            this.docdatagrid.ReadOnly = true;
            this.docdatagrid.Size = new System.Drawing.Size(575, 403);
            this.docdatagrid.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DocID";
            this.Column1.HeaderText = "Document ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "DocDescription";
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txt_AddDescription
            // 
            this.txt_AddDescription.Location = new System.Drawing.Point(14, 61);
            this.txt_AddDescription.Multiline = true;
            this.txt_AddDescription.Name = "txt_AddDescription";
            this.txt_AddDescription.Size = new System.Drawing.Size(377, 404);
            this.txt_AddDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Description";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_DocView
            // 
            this.btn_DocView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.btn_DocView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DocView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DocView.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DocView.Location = new System.Drawing.Point(799, 510);
            this.btn_DocView.Name = "btn_DocView";
            this.btn_DocView.Size = new System.Drawing.Size(121, 41);
            this.btn_DocView.TabIndex = 7;
            this.btn_DocView.Text = "Refresh";
            this.btn_DocView.UseVisualStyleBackColor = false;
            this.btn_DocView.Click += new System.EventHandler(this.btn_DocView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uploaded Documents";
            // 
            // btn_DocUpload
            // 
            this.btn_DocUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.btn_DocUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DocUpload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DocUpload.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DocUpload.Location = new System.Drawing.Point(420, 510);
            this.btn_DocUpload.Name = "btn_DocUpload";
            this.btn_DocUpload.Size = new System.Drawing.Size(121, 41);
            this.btn_DocUpload.TabIndex = 9;
            this.btn_DocUpload.Text = "Upload";
            this.btn_DocUpload.UseVisualStyleBackColor = false;
            this.btn_DocUpload.Click += new System.EventHandler(this.btn_DocUpload_Click);
            // 
            // btn_DocDelete
            // 
            this.btn_DocDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.btn_DocDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DocDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DocDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_DocDelete.Location = new System.Drawing.Point(622, 510);
            this.btn_DocDelete.Name = "btn_DocDelete";
            this.btn_DocDelete.Size = new System.Drawing.Size(121, 41);
            this.btn_DocDelete.TabIndex = 10;
            this.btn_DocDelete.Text = "Delete";
            this.btn_DocDelete.UseVisualStyleBackColor = false;
            this.btn_DocDelete.Click += new System.EventHandler(this.btn_DocDelete_Click);
            // 
            // ManageDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.btn_DocDelete);
            this.Controls.Add(this.btn_DocUpload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DocView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AddDescription);
            this.Controls.Add(this.docdatagrid);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDocuments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Documents";
            this.Load += new System.EventHandler(this.ManageDocuments_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView docdatagrid;
        private System.Windows.Forms.TextBox txt_AddDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DocView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DocUpload;
        private System.Windows.Forms.Button btn_DocDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}