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
            LoadBillList();
            LoadTableList();
            loadFoodList();
            LoadAccountList();
        }

      
        private void btnCountSalary_Click(object sender, EventArgs e)
        {
            fCountSalary f = new fCountSalary();
            f.ShowDialog();
        }
        
        //hàm hiển thị danh sách tài khoản
        void LoadAccountList()
        {
            string query = "SELECT * FROM dbo.Account";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        //hàm hiển thị doanh thu
        void LoadBillList()
        {
            string query = "SELECT * FROM dbo.Bill";
            dtgvBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        
        //hàm hiển thị danh sách thức ăn
        void loadFoodList()
        {
            string query = "SELECT * FROM dbo.Food";
            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        //hàm hiển thị danh sách bàn ăn
        void LoadTableList()
        {
            string query = "SELECT * FROM dbo.TableFood";
            dtgvTable.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
