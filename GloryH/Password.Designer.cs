namespace GloryH
{
    partial class Password
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
            this.label4 = new System.Windows.Forms.Label();
            this.saveb = new System.Windows.Forms.Button();
            this.old = new System.Windows.Forms.TextBox();
            this.new1 = new System.Windows.Forms.TextBox();
            this.new2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(711, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "密码修改";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(532, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "请输入旧密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(472, 472);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "请再次输入新密码：";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(532, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "请输入新密码：";
            // 
            // saveb
            // 
            this.saveb.Font = new System.Drawing.Font("宋体", 14.5F);
            this.saveb.Location = new System.Drawing.Point(748, 676);
            this.saveb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(168, 57);
            this.saveb.TabIndex = 32;
            this.saveb.Text = "确认修改";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.Button1_Click);
            // 
            // old
            // 
            this.old.Font = new System.Drawing.Font("宋体", 14.5F);
            this.old.Location = new System.Drawing.Point(765, 214);
            this.old.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.old.Name = "old";
            this.old.Size = new System.Drawing.Size(265, 41);
            this.old.TabIndex = 33;
            this.old.UseSystemPasswordChar = true;
            // 
            // new1
            // 
            this.new1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.new1.Location = new System.Drawing.Point(765, 344);
            this.new1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new1.Name = "new1";
            this.new1.Size = new System.Drawing.Size(265, 41);
            this.new1.TabIndex = 34;
            this.new1.UseSystemPasswordChar = true;
            // 
            // new2
            // 
            this.new2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.new2.Location = new System.Drawing.Point(765, 468);
            this.new2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.new2.Name = "new2";
            this.new2.Size = new System.Drawing.Size(265, 41);
            this.new2.TabIndex = 35;
            this.new2.UseSystemPasswordChar = true;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 954);
            this.Controls.Add(this.new2);
            this.Controls.Add(this.new1);
            this.Controls.Add(this.old);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Password";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.TextBox old;
        private System.Windows.Forms.TextBox new1;
        private System.Windows.Forms.TextBox new2;
    }
}