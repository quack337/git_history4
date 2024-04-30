using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_history4
{
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public static void AddStringColumn(this DataGridView dgv, string name, int width = 100)
        {
            dgv.Columns.Add(name, name);
            dgv.Columns[name].DataPropertyName = name;
            dgv.Columns[name].Width = width;
        }

        public static void AddDateTimeColumn(this DataGridView dgv, string name)
        {
            dgv.Columns.Add(name, name);
            dgv.Columns[name].DataPropertyName = name;
            dgv.Columns[name].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
            dgv.Columns[name].Width = 120;
        }

        public static void AddIntColumn(this DataGridView dgv, string name, int width = 80)
        {
            dgv.Columns.Add(name, name);
            dgv.Columns[name].DataPropertyName = name;
            dgv.Columns[name].DefaultCellStyle.Format = "N0";
            dgv.Columns[name].Width = width;
            dgv.Columns[name].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        }

        public static void AddIntColumn(this DataGridView dgv, string name, string header, int width = 80)
        {
            dgv.Columns.Add(name, header);
            dgv.Columns[name].DataPropertyName = name;
            dgv.Columns[name].DefaultCellStyle.Format = "N0";
            dgv.Columns[name].Width = width;
            dgv.Columns[name].DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
        }
    }
}