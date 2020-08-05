namespace QLCF
{
    partial class fTableManeger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBill = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount1 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBill);
            this.panel2.Location = new System.Drawing.Point(376, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 277);
            this.panel2.TabIndex = 1;
            // 
            // lstBill
            // 
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(2, 0);
            this.lstBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(228, 275);
            this.lstBill.TabIndex = 0;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(740, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(237, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 153);
            this.panel3.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 32);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.nmFoodCount_ValueChanged);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(152, 2);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(68, 24);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(225, 2);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(68, 44);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(376, 35);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 75);
            this.panel4.TabIndex = 3;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(115, 51);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(38, 20);
            this.nmFoodCount.TabIndex = 2;
            this.nmFoodCount.ValueChanged += new System.EventHandler(this.nmFoodCount_ValueChanged);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(158, 2);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(72, 67);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(2, 27);
            this.cbFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(152, 21);
            this.cbFood.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(2, 2);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(152, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(9, 35);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(363, 357);
            this.flpTable.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.btnDiscount1);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Location = new System.Drawing.Point(616, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 354);
            this.panel1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(9, 218);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(95, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.nmFoodCount_ValueChanged);
            // 
            // btnDiscount1
            // 
            this.btnDiscount1.Location = new System.Drawing.Point(9, 188);
            this.btnDiscount1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiscount1.Name = "btnDiscount1";
            this.btnDiscount1.Size = new System.Drawing.Size(95, 24);
            this.btnDiscount1.TabIndex = 2;
            this.btnDiscount1.Text = "Giảm giá";
            this.btnDiscount1.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(9, 100);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(95, 53);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::QLCF.Properties.Resources._91004798_1258034044385370_4554274249983918080_o;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(616, 35);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 75);
            this.panel5.TabIndex = 0;
            // 
            // fTableManeger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 397);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fTableManeger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm QUẢN LÍ QUÁN CAFE";
            this.Load += new System.EventHandler(this.fTableManeger_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button btnDiscount1;
    }
}