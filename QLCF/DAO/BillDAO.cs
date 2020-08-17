using QLCF.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }

        public int GetBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHEREW idTable = " + id + " AND status = 0");
            //Điều kiện if nếu thành công trả ra id của bill, nếu thất bại trả về -1
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID1;
            }
            return -1;
        }
    }
}
