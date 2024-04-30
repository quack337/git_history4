namespace git_history4
{
    partial class frmSourceFiles2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btn조회 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.종류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.라인수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.추가된줄수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.삭제된줄수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.btn조회);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 54);
            this.panel1.TabIndex = 0;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(34, 15);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 20);
            this.cmbBranch.TabIndex = 4;
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(161, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 23);
            this.btn조회.TabIndex = 0;
            this.btn조회.Text = "조회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.종류,
            this.라인수,
            this.추가된줄수,
            this.삭제된줄수});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(457, 563);
            this.dataGridView1.TabIndex = 1;
            // 
            // 종류
            // 
            this.종류.DataPropertyName = "종류";
            this.종류.HeaderText = "종류";
            this.종류.Name = "종류";
            // 
            // 라인수
            // 
            this.라인수.DataPropertyName = "라인수";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.라인수.DefaultCellStyle = dataGridViewCellStyle1;
            this.라인수.HeaderText = "라인수";
            this.라인수.Name = "라인수";
            // 
            // 추가된줄수
            // 
            this.추가된줄수.DataPropertyName = "추가된줄수";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.추가된줄수.DefaultCellStyle = dataGridViewCellStyle2;
            this.추가된줄수.HeaderText = "추가된줄수";
            this.추가된줄수.Name = "추가된줄수";
            // 
            // 삭제된줄수
            // 
            this.삭제된줄수.DataPropertyName = "삭제된줄수";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.삭제된줄수.DefaultCellStyle = dataGridViewCellStyle3;
            this.삭제된줄수.HeaderText = "삭제된줄수";
            this.삭제된줄수.Name = "삭제된줄수";
            // 
            // frmSourceFiles2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 617);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSourceFiles2";
            this.Text = "frmSourceFiles2";
            this.Load += new System.EventHandler(this.frmSourceFiles2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 라인수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 추가된줄수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 삭제된줄수;
        private System.Windows.Forms.ComboBox cmbBranch;
    }
}