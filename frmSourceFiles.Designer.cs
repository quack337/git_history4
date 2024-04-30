namespace git_history4
{
    partial class frmSourceFiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk제외항목 = new System.Windows.Forms.CheckBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btn조회 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.경로명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.가중치 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.종류 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이진파일 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.이전경로명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.라인수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최초수정 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.최근수정 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.추가된줄수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.삭제된줄수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.작업수 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.브랜치 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk제외항목);
            this.panel1.Controls.Add(this.cmbBranch);
            this.panel1.Controls.Add(this.btn조회);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 50);
            this.panel1.TabIndex = 0;
            // 
            // chk제외항목
            // 
            this.chk제외항목.AutoSize = true;
            this.chk제외항목.Location = new System.Drawing.Point(330, 15);
            this.chk제외항목.Name = "chk제외항목";
            this.chk제외항목.Size = new System.Drawing.Size(72, 16);
            this.chk제외항목.TabIndex = 4;
            this.chk제외항목.Text = "제외항목";
            this.chk제외항목.UseVisualStyleBackColor = true;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(51, 12);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(121, 20);
            this.cmbBranch.TabIndex = 3;
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(178, 9);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(75, 25);
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
            this.경로명,
            this.가중치,
            this.종류,
            this.이진파일,
            this.이전경로명,
            this.라인수,
            this.최초수정,
            this.최근수정,
            this.추가된줄수,
            this.삭제된줄수,
            this.작업수,
            this.브랜치});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1524, 888);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 경로명
            // 
            this.경로명.DataPropertyName = "경로명";
            this.경로명.HeaderText = "경로명";
            this.경로명.Name = "경로명";
            this.경로명.ReadOnly = true;
            this.경로명.Width = 500;
            // 
            // 가중치
            // 
            this.가중치.DataPropertyName = "가중치";
            this.가중치.HeaderText = "가중치";
            this.가중치.Name = "가중치";
            this.가중치.ReadOnly = true;
            this.가중치.Width = 70;
            // 
            // 종류
            // 
            this.종류.DataPropertyName = "종류";
            this.종류.HeaderText = "종류";
            this.종류.Name = "종류";
            this.종류.ReadOnly = true;
            this.종류.Width = 70;
            // 
            // 이진파일
            // 
            this.이진파일.DataPropertyName = "이진파일";
            this.이진파일.HeaderText = "이진파일";
            this.이진파일.Name = "이진파일";
            this.이진파일.ReadOnly = true;
            this.이진파일.Width = 80;
            // 
            // 이전경로명
            // 
            this.이전경로명.DataPropertyName = "이전경로명";
            this.이전경로명.HeaderText = "이전경로명";
            this.이전경로명.Name = "이전경로명";
            this.이전경로명.ReadOnly = true;
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
            this.라인수.ReadOnly = true;
            this.라인수.Width = 70;
            // 
            // 최초수정
            // 
            this.최초수정.DataPropertyName = "최초수정";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.최초수정.DefaultCellStyle = dataGridViewCellStyle2;
            this.최초수정.HeaderText = "최초수정";
            this.최초수정.Name = "최초수정";
            this.최초수정.ReadOnly = true;
            this.최초수정.Width = 120;
            // 
            // 최근수정
            // 
            this.최근수정.DataPropertyName = "최근수정";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.최근수정.DefaultCellStyle = dataGridViewCellStyle3;
            this.최근수정.HeaderText = "최근수정";
            this.최근수정.Name = "최근수정";
            this.최근수정.ReadOnly = true;
            this.최근수정.Width = 120;
            // 
            // 추가된줄수
            // 
            this.추가된줄수.DataPropertyName = "추가된줄수";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.추가된줄수.DefaultCellStyle = dataGridViewCellStyle4;
            this.추가된줄수.HeaderText = "추가줄수";
            this.추가된줄수.Name = "추가된줄수";
            this.추가된줄수.ReadOnly = true;
            this.추가된줄수.Width = 80;
            // 
            // 삭제된줄수
            // 
            this.삭제된줄수.DataPropertyName = "삭제된줄수";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.삭제된줄수.DefaultCellStyle = dataGridViewCellStyle5;
            this.삭제된줄수.HeaderText = "삭제줄수";
            this.삭제된줄수.Name = "삭제된줄수";
            this.삭제된줄수.ReadOnly = true;
            this.삭제된줄수.Width = 80;
            // 
            // 작업수
            // 
            this.작업수.DataPropertyName = "작업수";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.작업수.DefaultCellStyle = dataGridViewCellStyle6;
            this.작업수.HeaderText = "작업수";
            this.작업수.Name = "작업수";
            this.작업수.ReadOnly = true;
            this.작업수.Width = 80;
            // 
            // 브랜치
            // 
            this.브랜치.DataPropertyName = "branch";
            this.브랜치.HeaderText = "브랜치";
            this.브랜치.Name = "브랜치";
            this.브랜치.ReadOnly = true;
            // 
            // frmSourceFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 938);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmSourceFiles";
            this.Text = "frmSourceFiles";
            this.Load += new System.EventHandler(this.frmSourceFiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.CheckBox chk제외항목;
        private System.Windows.Forms.DataGridViewTextBoxColumn 경로명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 가중치;
        private System.Windows.Forms.DataGridViewTextBoxColumn 종류;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이진파일;
        private System.Windows.Forms.DataGridViewTextBoxColumn 이전경로명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 라인수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최초수정;
        private System.Windows.Forms.DataGridViewTextBoxColumn 최근수정;
        private System.Windows.Forms.DataGridViewTextBoxColumn 추가된줄수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 삭제된줄수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 작업수;
        private System.Windows.Forms.DataGridViewTextBoxColumn 브랜치;
    }
}