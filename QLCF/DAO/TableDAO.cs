using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyQuanCafe.DAO
{
	public class TableDAO
	{
		private static TableDAO instance;
		public static TableDAO Instance
        {
			get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
			private set { TableDAO.instance = value; }

		}
		public static int TableWidth = 50;
		public static int TableHeight = 50;
		private TableDAO() { }
		public List<Table> LoadTableList()
        {
			List<Table> tableList = new List<Table>();
			Datatable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
			foreach (DataRow = item in Data.Rows)
            {
				Table table = new Table(item);
				tableList.Add(table);
            }
			return tableList;
        }
	}
}
