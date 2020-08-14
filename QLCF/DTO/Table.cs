using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        private string status;

        private string name;

        private int iD;
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }

        public int ID
        {
            get { return iD};
            set { iD = value; }
}

        public string Name 
        { 
            get { return name;}
            set{ name = value; }
        }
       
        public string Status
        {
            get { return status; }
            set { status = value; }
    }
