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
    public partial class frmSourceFiles2 : Form
    {
        public frmSourceFiles2()
        {
            InitializeComponent();
        }

        int projectId;
        string branch;

        public frmSourceFiles2(int projectId, string branch)
        {
            this.projectId = projectId;
            this.branch = branch;
            InitializeComponent();
        }

        private void frmSourceFiles2_Load(object sender, EventArgs e)
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
            public string 종류 { get; set; }
            public int 라인수 { get; set; }
            public int 추가된줄수 { get; set; }
            public int 삭제된줄수 { get; set; }
        }

        List<결과> list;

        static string SQL1 = @"
select 종류, sum(라인수) 라인수, sum(추가된줄수) 추가된줄수, sum(삭제된줄수) 삭제된줄수
from (
  select f.*,
    (select sum(추가된줄수) from Numstat n where n.sourceFileId = f.id) 추가된줄수,
    (select sum(삭제된줄수) from Numstat n where n.sourceFileId = f.id) 삭제된줄수
  from SourceFile f
  where projectId = {0} and ('{1}' = '전체' or branch = '{1}') and 제외 = 0
) t
group by 종류
order by sum(라인수) desc
";

        private void btn조회_Click(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                var sql = string.Format(SQL1, projectId, cmbBranch.SelectedItem.ToString());
                list = db.ExecuteQuery<결과>(sql).ToList();
                결과 합계 = new 결과();
                foreach (var p in list)
                {
                    합계.라인수 += p.라인수;
                    합계.추가된줄수 += p.추가된줄수;
                    합계.삭제된줄수 += p.삭제된줄수;
                }
                list.Add(합계);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
        }

    }
}
