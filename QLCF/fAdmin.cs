using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLCF.DAO;

namespace QLCF
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

      
        private void btnCountSalary_Click(object sender, EventArgs e)
        {
            fCountSalary f = new fCountSalary();
            f.ShowDialog();
        }
        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";
            DataProvider provider = new DataProvider();
            dtgvAccount.DataSource = provider.ExcuteQuery(query);
        }
    }
}
