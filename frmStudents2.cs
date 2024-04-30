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
    public partial class frmStudents2 : Form
    {

        class 결과
        {
            public string 학번 { get; set; }
            public string 이름 { get; set; }
            public int 추가된줄수 { get; set; }
            public int 삭제된줄수 { get; set; }
            public int 결과줄수 { get { return 추가된줄수 - 삭제된줄수; } set { } }
        }

        static string SQL1 = @"
select t.학번, (select top 1 이름 from author o where o.학번 = t.학번) 이름,
  sum(추가된줄수) 추가된줄수, sum(삭제된줄수) 삭제된줄수
from (
  select a.학번, n.추가된줄수, n.삭제된줄수
  from [commit] c 
      join Numstat n on n.commitId = c.id
      join Author a on a.id = c.authorId
      join SourceFile f on n.sourceFileId = f.id and f.제외 = 0
  where c.projectId = {0} and ('{1}' = '전체' or c.branch = '{1}')
) t
group by 학번
";

        List<결과> list;

        public frmStudents2()
        {
            InitializeComponent();
        }

        int projectId;
        string branch;

        public frmStudents2(int projectId, string branch)
        {
            this.projectId = projectId;
            this.branch = branch;
            InitializeComponent();

            dataGridView1.AddStringColumn("학번");
            dataGridView1.AddStringColumn("이름");
            dataGridView1.AddIntColumn("추가된줄수", "추가줄수");
            dataGridView1.AddIntColumn("삭제된줄수", "삭제줄수");
            dataGridView1.AddIntColumn("결과줄수", "결과줄수");
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                var sql = string.Format(SQL1, projectId, cmbBranch.SelectedItem.ToString());
                list = db.ExecuteQuery<결과>(sql).ToList();
                결과 합계 = new 결과();
                foreach (var p in list)
                {
                    합계.추가된줄수 += p.추가된줄수;
                    합계.삭제된줄수 += p.삭제된줄수;
                }
                list.Add(합계);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
        }

        private void frmStudents2_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            cmbBranch.Items.Add("전체");
            foreach (var s in DBUtils.branch목록(projectId))
                cmbBranch.Items.Add(s);
            cmbBranch.SelectedIndex = cmbBranch.Items.IndexOf(branch);
            btn조회_Click(sender, e);
        }
    }
}
