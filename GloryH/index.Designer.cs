namespace GloryH
{
    partial class index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.图书管理系统 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.车位管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.carIn = new System.Windows.Forms.ToolStripMenuItem();
            this.carOut = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingInformationRetrieval = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingPermitManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForParkingPermit = new System.Windows.Forms.ToolStripMenuItem();
            this.handlingOfParkingPermit = new System.Windows.Forms.ToolStripMenuItem();
            this.staffManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.rates = new System.Windows.Forms.ToolStripMenuItem();
            this.changePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 图书管理系统
            // 
            resources.ApplyResources(this.图书管理系统, "图书管理系统");
            this.图书管理系统.Name = "图书管理系统";
            this.图书管理系统.Click += new System.EventHandler(this.Label1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车位管理,
            this.parkingInformationRetrieval,
            this.parkingPermitManagement,
            this.staffManagement,
            this.rates,
            this.changePassword,
            this.exit});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip2_ItemClicked);
            // 
            // 车位管理
            // 
            this.车位管理.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carIn,
            this.carOut});
            this.车位管理.Name = "车位管理";
            resources.ApplyResources(this.车位管理, "车位管理");
            // 
            // carIn
            // 
            this.carIn.Name = "carIn";
            resources.ApplyResources(this.carIn, "carIn");
            this.carIn.Click += new System.EventHandler(this.carIn_Click);
            // 
            // carOut
            // 
            this.carOut.Name = "carOut";
            resources.ApplyResources(this.carOut, "carOut");
            this.carOut.Click += new System.EventHandler(this.carOut_Click);
            // 
            // parkingInformationRetrieval
            // 
            this.parkingInformationRetrieval.Name = "parkingInformationRetrieval";
            resources.ApplyResources(this.parkingInformationRetrieval, "parkingInformationRetrieval");
            this.parkingInformationRetrieval.Click += new System.EventHandler(this.parkingRetrieval_Click);
            // 
            // parkingPermitManagement
            // 
            this.parkingPermitManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForParkingPermit,
            this.handlingOfParkingPermit});
            this.parkingPermitManagement.Name = "parkingPermitManagement";
            resources.ApplyResources(this.parkingPermitManagement, "parkingPermitManagement");
            this.parkingPermitManagement.Click += new System.EventHandler(this.parkingPermitManagement_Click);
            // 
            // searchForParkingPermit
            // 
            this.searchForParkingPermit.Name = "searchForParkingPermit";
            resources.ApplyResources(this.searchForParkingPermit, "searchForParkingPermit");
            this.searchForParkingPermit.Click += new System.EventHandler(this.searchForParkingPermit_Click);
            // 
            // handlingOfParkingPermit
            // 
            this.handlingOfParkingPermit.Name = "handlingOfParkingPermit";
            resources.ApplyResources(this.handlingOfParkingPermit, "handlingOfParkingPermit");
            this.handlingOfParkingPermit.Click += new System.EventHandler(this.handlingOfParkingPermit_Click);
            // 
            // staffManagement
            // 
            this.staffManagement.Name = "staffManagement";
            resources.ApplyResources(this.staffManagement, "staffManagement");
            this.staffManagement.Click += new System.EventHandler(this.staffManagement_Click);
            // 
            // rates
            // 
            this.rates.Name = "rates";
            resources.ApplyResources(this.rates, "rates");
            this.rates.Click += new System.EventHandler(this.rates_Click);
            // 
            // changePassword
            // 
            this.changePassword.Name = "changePassword";
            resources.ApplyResources(this.changePassword, "changePassword");
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            resources.ApplyResources(this.exit, "exit");
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.图书管理系统);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "index";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 图书管理系统;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 车位管理;
        private System.Windows.Forms.ToolStripMenuItem carIn;
        private System.Windows.Forms.ToolStripMenuItem carOut;
        private System.Windows.Forms.ToolStripMenuItem parkingPermitManagement;
        private System.Windows.Forms.ToolStripMenuItem handlingOfParkingPermit;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem parkingInformationRetrieval;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem searchForParkingPermit;
        private System.Windows.Forms.ToolStripMenuItem staffManagement;
        private System.Windows.Forms.ToolStripMenuItem rates;
        private System.Windows.Forms.ToolStripMenuItem changePassword;
    }
}

