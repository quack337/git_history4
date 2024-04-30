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
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        int projectId;
        List<Author> authors;

        public frmStudents(int projectId, string branch)
        {
            this.projectId = projectId;
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                authors = db.Author.Where(p => p.Commit.Any(c => c.projectId == projectId)).ToList();
                dataGridView1.DataSource = authors;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                foreach (var a1 in authors)
                {
                    var a0 = db.Author.First(a => a.id == a1.id);
                    if (a0.이름 == a1.이름 && a0.학번 == a1.학번) continue;
                    a0.이름 = a1.이름;
                    a0.학번 = a1.학번;
                }
                db.SubmitChanges();
            }
        }
    }
}
