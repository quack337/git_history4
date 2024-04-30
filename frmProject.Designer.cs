namespace git_history4
{
    partial class frmProject
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.brn학생 = new System.Windows.Forms.Button();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.btnNumstat = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn파일 = new System.Windows.Forms.Button();
            this.btn파일2 = new System.Windows.Forms.Button();
            this.btn커밋 = new System.Windows.Forms.Button();
            this.btn학생2 = new System.Windows.Forms.Button();
            this.btn프로젝트내용지우기 = new System.Windows.Forms.Button();
            this.btn커밋2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(723, 55);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(50, 29);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(77, 56);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(646, 24);
            this.txtPath.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Project";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(77, 26);
            this.cmbProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(299, 23);
            this.cmbProject.TabIndex = 15;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\PJ2\\git_history";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "branch";
            // 
            // brn학생
            // 
            this.brn학생.Location = new System.Drawing.Point(73, 168);
            this.brn학생.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brn학생.Name = "brn학생";
            this.brn학생.Size = new System.Drawing.Size(55, 29);
            this.brn학생.TabIndex = 23;
            this.brn학생.Text = "학생";
            this.brn학생.UseVisualStyleBackColor = true;
            this.brn학생.Click += new System.EventHandler(this.열기_click);
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(77, 90);
            this.txtBranch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(85, 24);
            this.txtBranch.TabIndex = 21;
            this.txtBranch.Text = "main";
            // 
            // btnNumstat
            // 
            this.btnNumstat.Location = new System.Drawing.Point(168, 86);
            this.btnNumstat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNumstat.Name = "btnNumstat";
            this.btnNumstat.Size = new System.Drawing.Size(86, 29);
            this.btnNumstat.TabIndex = 20;
            this.btnNumstat.Text = "Numstat";
            this.btnNumstat.UseVisualStyleBackColor = true;
            this.btnNumstat.Click += new System.EventHandler(this.btnNumstat_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(776, 55);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 29);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn파일
            // 
            this.btn파일.Location = new System.Drawing.Point(134, 168);
            this.btn파일.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn파일.Name = "btn파일";
            this.btn파일.Size = new System.Drawing.Size(55, 29);
            this.btn파일.TabIndex = 25;
            this.btn파일.Text = "파일";
            this.btn파일.UseVisualStyleBackColor = true;
            this.btn파일.Click += new System.EventHandler(this.열기_click);
            // 
            // btn파일2
            // 
            this.btn파일2.Location = new System.Drawing.Point(195, 168);
            this.btn파일2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn파일2.Name = "btn파일2";
            this.btn파일2.Size = new System.Drawing.Size(55, 29);
            this.btn파일2.TabIndex = 26;
            this.btn파일2.Text = "파일2";
            this.btn파일2.UseVisualStyleBackColor = true;
            this.btn파일2.Click += new System.EventHandler(this.열기_click);
            // 
            // btn커밋
            // 
            this.btn커밋.Location = new System.Drawing.Point(256, 168);
            this.btn커밋.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn커밋.Name = "btn커밋";
            this.btn커밋.Size = new System.Drawing.Size(55, 29);
            this.btn커밋.TabIndex = 27;
            this.btn커밋.Text = "커밋";
            this.btn커밋.UseVisualStyleBackColor = true;
            this.btn커밋.Click += new System.EventHandler(this.열기_click);
            // 
            // btn학생2
            // 
            this.btn학생2.Location = new System.Drawing.Point(378, 168);
            this.btn학생2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn학생2.Name = "btn학생2";
            this.btn학생2.Size = new System.Drawing.Size(55, 29);
            this.btn학생2.TabIndex = 28;
            this.btn학생2.Text = "학생2";
            this.btn학생2.UseVisualStyleBackColor = true;
            this.btn학생2.Click += new System.EventHandler(this.열기_click);
            // 
            // btn프로젝트내용지우기
            // 
            this.btn프로젝트내용지우기.Location = new System.Drawing.Point(73, 224);
            this.btn프로젝트내용지우기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn프로젝트내용지우기.Name = "btn프로젝트내용지우기";
            this.btn프로젝트내용지우기.Size = new System.Drawing.Size(163, 29);
            this.btn프로젝트내용지우기.TabIndex = 29;
            this.btn프로젝트내용지우기.Text = "프로젝트 내용 지우기";
            this.btn프로젝트내용지우기.UseVisualStyleBackColor = true;
            this.btn프로젝트내용지우기.Click += new System.EventHandler(this.btn프로젝트내용지우기_Click);
            // 
            // btn커밋2
            // 
            this.btn커밋2.Location = new System.Drawing.Point(317, 168);
            this.btn커밋2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn커밋2.Name = "btn커밋2";
            this.btn커밋2.Size = new System.Drawing.Size(55, 29);
            this.btn커밋2.TabIndex = 30;
            this.btn커밋2.Text = "커밋2";
            this.btn커밋2.UseVisualStyleBackColor = true;
            this.btn커밋2.Click += new System.EventHandler(this.열기_click);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 266);
            this.Controls.Add(this.btn커밋2);
            this.Controls.Add(this.btn프로젝트내용지우기);
            this.Controls.Add(this.btn학생2);
            this.Controls.Add(this.btn커밋);
            this.Controls.Add(this.btn파일2);
            this.Controls.Add(this.btn파일);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.brn학생);
            this.Controls.Add(this.txtBranch);
            this.Controls.Add(this.btnNumstat);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbProject);
            this.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProject";
            this.Text = "frmProject";
            this.Load += new System.EventHandler(this.frmProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button brn학생;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Button btnNumstat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn파일;
        private System.Windows.Forms.Button btn파일2;
        private System.Windows.Forms.Button btn커밋;
        private System.Windows.Forms.Button btn학생2;
        private System.Windows.Forms.Button btn프로젝트내용지우기;
        private System.Windows.Forms.Button btn커밋2;
    }
}