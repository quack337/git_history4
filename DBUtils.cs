using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_history4
{
    public class DBUtils
    {
        public static List<string> branch목록(int projectId)
        {
            using (var db = new DBDataContext())
            {
                return db.Project.First(p => p.id == projectId)
                    .Commit.Select(p => p.branch).Distinct().ToList();
            }
        }
    }
}
