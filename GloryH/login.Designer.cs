namespace GloryH
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.adminLogin = new System.Windows.Forms.Button();
            this.employeeLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(233, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入工号和密码以验证身份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(248, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(248, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工密码：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Italic);
            this.username.Location = new System.Drawing.Point(408, 180);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(227, 36);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Italic);
            this.password.Location = new System.Drawing.Point(408, 254);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(227, 36);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            this.password.UseWaitCursor = true;
            // 
            // adminLogin
            // 
            this.adminLogin.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.adminLogin.Location = new System.Drawing.Point(253, 384);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(4);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(171, 35);
            this.adminLogin.TabIndex = 5;
            this.adminLogin.Text = "管理员登录";
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.Click += new System.EventHandler(this.adminLogin_Click);
            // 
            // employeeLogin
            // 
            this.employeeLogin.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.employeeLogin.Location = new System.Drawing.Point(465, 384);
            this.employeeLogin.Margin = new System.Windows.Forms.Padding(4);
            this.employeeLogin.Name = "employeeLogin";
            this.employeeLogin.Size = new System.Drawing.Size(171, 35);
            this.employeeLogin.TabIndex = 6;
            this.employeeLogin.Text = "员工登录";
            this.employeeLogin.UseVisualStyleBackColor = true;
            this.employeeLogin.Click += new System.EventHandler(this.EmployeeLogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.employeeLogin);
            this.Controls.Add(this.adminLogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button adminLogin;
        private System.Windows.Forms.Button employeeLogin;
    }
}