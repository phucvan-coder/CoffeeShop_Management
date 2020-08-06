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
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            
            string query = "SELECT * FROM dbo.Account";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dtgvAccount.DataSource = data;
        }
    }
}
