using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class fTableManeger : Form
    {
        public fTableManeger()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method
        void LoadTable(){
            List<Talble> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList){
             Button btn = new Button(){
             Width = TableDAO.TableWitdh, Height= TableDAO.TableHeight};
                btn.Text = item.Name + Enviroment.NewLine + item.Status;
                switch(item.Status){
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                        default:
                        BackColor = Color.LightPink;
                        break;
                        }
             flpTable.Controls.Add(btn);
                
        }
        #endregion


        #region Events
        private void nmFoodCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fTableManeger_Load(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        #endregion
    }
}
