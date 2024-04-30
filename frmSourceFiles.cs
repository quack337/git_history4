using git_history4.Properties;
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
    public partial class frmSourceFiles : Form
    {
        public frmSourceFiles()
        {
            InitializeComponent();
        }

        int projectId;
        string branch;

        public frmSourceFiles(int projectId, string branch)
        {
            this.projectId = projectId;
            this.branch = branch;            
            InitializeComponent();

            dataGridView1.Columns["최근수정"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            dataGridView1.Columns["최초수정"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            this.branch = branch;
        }

        private void frmSourceFiles_Load(object sender, EventArgs e)
        {
            dataGridView1.DoubleBuffered(true);
            cmbBranch.Items.Add("전체");
            foreach (var s in DBUtils.branch목록(projectId))
                cmbBranch.Items.Add(s);
            cmbBranch.SelectedIndex = cmbBranch.Items.IndexOf(branch);
            if (cmbBranch.SelectedIndex == -1)
            {
                MessageBox.Show("브랜치에 속한 커밋이 없습니다");
                cmbBranch.SelectedIndex = 0;
            }
            btn조회_Click(sender, e);            
        }

        class 결과
        {
            public int id { get; set; }
            public int projectId { get; set; }
            public string 경로명 { get; set; }
            public float 가중치 { get; set; }
            public string 종류 { get; set; }
            public bool 이진파일 { get; set; }
            public string 이전경로명 { get; set; }
            public int 라인수 { get; set; }
            public bool 스터디자료 { get; set; }
            public DateTime 최근수정 { get; set; }
            public DateTime 최초수정 { get; set; }
            public int 추가된줄수 { get; set; }
            public int 삭제된줄수 { get; set; }
            public int 작업수 { get; set; }
            public string branch { get; set; }
        }

        List<결과> list;
        결과 합계;

        static string SQL1 = @"
select f.*,
  (select max(시각) from [commit] c where c.id = (select top 1 commitId from Numstat n where n.sourceFileId = f.id)) 최근수정,
  (select min(시각) from [commit] c where c.id = (select top 1 commitId from Numstat n where n.sourceFileId = f.id)) 최초수정,
  (select sum(추가된줄수) from Numstat n where n.sourceFileId = f.id) 추가된줄수,
  (select sum(삭제된줄수) from Numstat n where n.sourceFileId = f.id) 삭제된줄수,
  (select count(n.id) from Numstat n where n.sourceFileId = f.id) 작업수
from SourceFile f
where projectId = {0} and ('{1}' = '전체' or branch = '{1}') and 제외 = {2}
order by 종류";

        private void btn조회_Click(object sender, EventArgs e)
        {
            using (var db = new DBDataContext())
            {
                합계 = new 결과();
                var 제외항목 = chk제외항목.Checked ? 1 : 0;
                var sql = string.Format(SQL1, projectId, cmbBranch.SelectedItem.ToString(), 제외항목);
                list = db.ExecuteQuery<결과>(sql).ToList();
                foreach (var p in list)
                {
                    합계.라인수 += p.라인수;
                    합계.추가된줄수 += p.추가된줄수;
                    합계.삭제된줄수 += p.삭제된줄수;
                }
                합계.경로명 = "합계";
                list.Add(합계);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = list;
            }
        }

        int[] 제목클릭 = null;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (제목클릭 == null) 제목클릭 = new int[dataGridView1.Columns.Count];
                int index = e.ColumnIndex;
                if (제목클릭[index] == 0) 제목클릭[index] = 1;
                else 제목클릭[index] *= -1;
                var propertyName = dataGridView1.Columns[index].DataPropertyName;
                list.RemoveAt(list.Count - 1);
                switch (propertyName)
                {
                    case "경로명": list.Sort((a, b) => 제목클릭[index] * a.경로명.CompareTo(b.경로명)); break;
                    case "종류": list.Sort((a, b) => 제목클릭[index] * (a.종류 ?? "").CompareTo((b.종류 ?? ""))); break;
                    case "라인수": list.Sort((a, b) => 제목클릭[index] * (a.라인수 - b.라인수)); break;
                    case "최근수정": list.Sort((a, b) => 제목클릭[index] * a.최근수정.CompareTo(b.최근수정)); break;
                    case "최초수정": list.Sort((a, b) => 제목클릭[index] * a.최초수정.CompareTo(b.최초수정)); break;
                    case "추가된줄수": list.Sort((a, b) => 제목클릭[index] * (a.추가된줄수 - b.추가된줄수)); break;
                    case "삭제된줄수": list.Sort((a, b) => 제목클릭[index] * (a.삭제된줄수 - b.삭제된줄수)); break;
                    case "작업수": list.Sort((a, b) => 제목클릭[index] * (a.작업수 - b.작업수)); break;
                }
                list.Add(합계);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            else
            {
                int index = e.RowIndex;
                int sourceFileId = list[index].id;
                if (MessageBox.Show("이 소스파일을 제외 상태를 변경할까요?", "제외하기", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    using (var db = new DBDataContext()) {
                        var n = db.SourceFile.FirstOrDefault(p => p.id == sourceFileId);
                        if (n != null) {
                            n.제외 = !n.제외;
                            db.SubmitChanges();
                            btn조회_Click(null, null);
                        }
                    }
                }
            }
        }

    }
}
