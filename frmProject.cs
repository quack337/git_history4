using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_history4
{
    public partial class frmProject : Form
    {
        public frmProject()
        {
            InitializeComponent();
        }

        List<Project> projects;

        private void reload(DBDataContext db)
        {
            projects = db.Project.ToList();
            cmbProject.Items.Clear();
            foreach (var p in projects)
                cmbProject.Items.Add(Download.GetProjectName(p.url));
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtPath.Text;
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                reload(db);
                cmbProject.SelectedIndex = cmbProject.Items.Count - 1;
            }
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbProject.SelectedIndex;
            if (index >= 0)
                txtPath.Text = projects[index].path;
        }

        private void btnNumstat_Click(object sender, EventArgs e)
        {
            int index = cmbProject.SelectedIndex;
            if (index < 0) return;

            ((Button)sender).Enabled = false;
            using (var db = new DBDataContext())
            {
                var path = txtPath.Text;
                var branch = txtBranch.Text;

                int projectId = projects[index].id;
                Download.createNumstat(path);
                Git.parseLog(db, path, projectId, branch);
            }
            ((Button)sender).Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = cmbProject.SelectedIndex;
            if (index < 0) return;

            using (var db = new DBDataContext())
            {
                var project = db.Project.First(p => p.id == projects[index].id);
                project.path = txtPath.Text;
                db.SubmitChanges();
            }
        }

        private void 열기_click(object sender, EventArgs e)
        {
            int index = cmbProject.SelectedIndex;
            if (index < 0) return;
            int projectId = projects[index].id;
            //string branch = txtBranch.Text; 
            string branch = "전체";
            switch (((Button)sender).Text)
            {
                case "학생": new frmStudents(projectId, branch).Show(); break;
                case "파일": new frmSourceFiles(projectId, branch).Show(); break;
                case "파일2": new frmSourceFiles2(projectId, branch).Show(); break;
                case "커밋": new frmCommits(projectId, branch).Show(); break;
                case "커밋2": new frmCommitsSummary(projectId, branch).Show(); break;
                case "학생2": new frmStudents2(projectId, branch).Show(); break;
            }
        }

        private void btn프로젝트내용지우기_Click(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                int index = cmbProject.SelectedIndex;
                int projectId = projects[index].id;
                db.프로젝트내용지우기(projectId);
                db.SubmitChanges();
            }
        }
    }
}
