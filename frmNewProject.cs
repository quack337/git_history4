using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_history4
{
    public partial class frmNewProject : Form
    {
        public frmNewProject()
        {
            InitializeComponent();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;
            using (var db = new DBDataContext())
            {
                var url = txtURL.Text;
                var path = txtPath.Text;
                int projectId = 프로젝트생성(db, url, path);
            }
            ((Button)sender).Enabled = true;
        }

        private int 프로젝트생성(DBDataContext db, string url, string path)
        {
            var 프로젝트명 = Download.GetProjectName(url);
            var project = db.Project.FirstOrDefault(p => p.url == url);
            if (project == null)
            {
                project = new Project { url = url, path = path, 기타 = "" };
                db.Project.InsertOnSubmit(project);
                db.SubmitChanges();
            }
            return project.id;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
                txtPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
