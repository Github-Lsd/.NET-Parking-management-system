namespace GloryH
{
    partial class EditInfo
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
            this.saveb = new System.Windows.Forms.Button();
            this.idcard = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.carnumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sex1 = new System.Windows.Forms.RadioButton();
            this.sex2 = new System.Windows.Forms.RadioButton();
            this.card_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveb
            // 
            this.saveb.Font = new System.Drawing.Font("宋体", 14.5F);
            this.saveb.Location = new System.Drawing.Point(654, 644);
            this.saveb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(158, 57);
            this.saveb.TabIndex = 40;
            this.saveb.Text = "确认修改";
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.Button1_Click);
            // 
            // idcard
            // 
            this.idcard.Font = new System.Drawing.Font("宋体", 14.5F);
            this.idcard.Location = new System.Drawing.Point(484, 470);
            this.idcard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idcard.Name = "idcard";
            this.idcard.Size = new System.Drawing.Size(194, 41);
            this.idcard.TabIndex = 39;
            // 
            // state
            // 
            this.state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state.Font = new System.Drawing.Font("宋体", 14.5F);
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "正常状态",
            "挂失状态"});
            this.state.Location = new System.Drawing.Point(952, 474);
            this.state.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(194, 37);
            this.state.TabIndex = 38;
            this.state.SelectedIndexChanged += new System.EventHandler(this.State_SelectedIndexChanged);
            // 
            // carnumber
            // 
            this.carnumber.Font = new System.Drawing.Font("宋体", 14.5F);
            this.carnumber.Location = new System.Drawing.Point(952, 346);
            this.carnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carnumber.Name = "carnumber";
            this.carnumber.Size = new System.Drawing.Size(194, 41);
            this.carnumber.TabIndex = 37;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 14.5F);
            this.name.Location = new System.Drawing.Point(952, 231);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(194, 41);
            this.name.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label7.Location = new System.Drawing.Point(312, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "车主性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label6.Location = new System.Drawing.Point(780, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "车主姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label5.Location = new System.Drawing.Point(780, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "车牌号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(312, 472);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "身份证号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(780, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "证件状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(312, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "停车证号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(632, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 44);
            this.label1.TabIndex = 28;
            this.label1.Text = "信息编辑";
            // 
            // sex1
            // 
            this.sex1.AutoSize = true;
            this.sex1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.sex1.Location = new System.Drawing.Point(484, 346);
            this.sex1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(67, 33);
            this.sex1.TabIndex = 42;
            this.sex1.TabStop = true;
            this.sex1.Text = "男";
            this.sex1.UseVisualStyleBackColor = true;
            this.sex1.CheckedChanged += new System.EventHandler(this.Sex1_CheckedChanged);
            // 
            // sex2
            // 
            this.sex2.AutoSize = true;
            this.sex2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.sex2.Location = new System.Drawing.Point(585, 346);
            this.sex2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sex2.Name = "sex2";
            this.sex2.Size = new System.Drawing.Size(67, 33);
            this.sex2.TabIndex = 43;
            this.sex2.TabStop = true;
            this.sex2.Text = "女";
            this.sex2.UseVisualStyleBackColor = true;
            this.sex2.CheckedChanged += new System.EventHandler(this.Sex2_CheckedChanged);
            // 
            // card_value
            // 
            this.card_value.AutoSize = true;
            this.card_value.Font = new System.Drawing.Font("宋体", 14.5F);
            this.card_value.Location = new System.Drawing.Point(484, 236);
            this.card_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.card_value.Name = "card_value";
            this.card_value.Size = new System.Drawing.Size(0, 29);
            this.card_value.TabIndex = 44;
            // 
            // EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 930);
            this.Controls.Add(this.card_value);
            this.Controls.Add(this.sex2);
            this.Controls.Add(this.sex1);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.idcard);
            this.Controls.Add(this.state);
            this.Controls.Add(this.carnumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditInfo";
            this.Text = "EditInfo";
            this.Load += new System.EventHandler(this.EditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.TextBox idcard;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox carnumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sex1;
        private System.Windows.Forms.RadioButton sex2;
        private System.Windows.Forms.Label card_value;
    }
}