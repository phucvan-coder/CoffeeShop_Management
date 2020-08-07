using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class DataProvider
    {
        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            
        }
    }
}
