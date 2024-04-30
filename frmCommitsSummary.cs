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
    public partial class frmCommitsSummary : Form
    {
        public frmCommitsSummary()
        {
            InitializeComponent();
        }

        int projectId;
        string branch;

        public frmCommitsSummary(int projectId, string branch)
        {
            this.projectId = projectId;
            this.branch = branch;
            InitializeComponent();

            dataGridView1.AddStringColumn("학번");
            dataGridView1.AddStringColumn("이름");
            dataGridView1.AddDateTimeColumn("시각");
            dataGridView1.AddIntColumn("추가된줄수", "추가줄수");
            dataGridView1.AddIntColumn("삭제된줄수", "삭제줄수");
            dataGridView1.AddStringColumn("메모", 200);
            dataGridView1.AddStringColumn("commitNo");
            dataGridView1.AddStringColumn("merge1", 80);
            dataGridView1.AddStringColumn("merge2", 80);
            dataGridView1.AddStringColumn("branch", 90);
        }

        private void frmCommits_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            cmbBranch.Items.Add("전체");
            foreach (var s in DBUtils.branch목록(projectId)) 
                cmbBranch.Items.Add(s);
            cmbBranch.SelectedIndex = cmbBranch.Items.IndexOf(branch);
            btn조회_Click(sender, e);
        }

        class 결과
        {
            public int id { get; set; }
            public string commitNo { get; set; }
            public DateTime? 시각 { get; set; }
            public string 메모 { get; set; }
            public string merge1 { get; set; }
            public string merge2 { get; set; }
            public string 학번 { get; set; }
            public string 이름 { get; set; }
            public int? 추가된줄수 { get; set; }
            public int? 삭제된줄수 { get; set; }
            public string branch { get; set; }
        }

        List<결과> list;

        static string SQL1 = @"
select c.id, c.commitNo, c.시각, c.메모, c.merge1, c.merge2, c.branch, a.학번, a.이름,
  (select sum(추가된줄수) from numstat n where n.commitId = c.id) 추가된줄수,
  (select sum(삭제된줄수) from numstat n where n.commitId = c.id) 삭제된줄수
from [commit] c 
  join author a on a.id = c.authorId
where c.projectId = {0} and ('전체' = '{1}' or c.branch = '{1}')
order by 시각
";

        private void btn조회_Click(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                var sql = string.Format(SQL1, projectId, cmbBranch.SelectedItem.ToString());
                list = db.ExecuteQuery<결과>(sql).ToList();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
                var color1 = Color.FromArgb(255, 255, 255);
                var color2 = Color.FromArgb(255, 255, 240);
                var color = color1;
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = color;
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i].commitNo != list[i - 1].commitNo)
                        color = (color == color1) ? color2 : color1;
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = color;
                }
            }
        }
    }
}
