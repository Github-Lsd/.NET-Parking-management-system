﻿namespace GloryH
{
    partial class SearchCard
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
            this.del = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.searchb = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sexpanel = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.statepanel = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.sexpanel.SuspendLayout();
            this.statepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("宋体", 12F);
            this.del.Location = new System.Drawing.Point(982, 717);
            this.del.Margin = new System.Windows.Forms.Padding(4);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(128, 40);
            this.del.TabIndex = 37;
            this.del.Text = "注销";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.Del_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("宋体", 12F);
            this.add.Location = new System.Drawing.Point(705, 717);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(128, 40);
            this.add.TabIndex = 36;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // index
            // 
            this.index.Font = new System.Drawing.Font("宋体", 14.5F);
            this.index.Location = new System.Drawing.Point(663, 212);
            this.index.Margin = new System.Windows.Forms.Padding(4);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(211, 41);
            this.index.TabIndex = 34;
            this.index.Visible = false;
            this.index.TextChanged += new System.EventHandler(this.Index_TextChanged);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("宋体", 12F);
            this.edit.Location = new System.Drawing.Point(375, 717);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(128, 40);
            this.edit.TabIndex = 33;
            this.edit.Text = "编辑";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // searchb
            // 
            this.searchb.Font = new System.Drawing.Font("宋体", 14.5F);
            this.searchb.Location = new System.Drawing.Point(969, 207);
            this.searchb.Margin = new System.Windows.Forms.Padding(4);
            this.searchb.Name = "searchb";
            this.searchb.Size = new System.Drawing.Size(141, 54);
            this.searchb.TabIndex = 32;
            this.searchb.Text = "搜索";
            this.searchb.UseVisualStyleBackColor = true;
            this.searchb.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.card_value,
            this.name,
            this.idcard,
            this.carnumber,
            this.state,
            this.sex});
            this.dataGridView2.Location = new System.Drawing.Point(256, 290);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1118, 384);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "编号";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // card_value
            // 
            this.card_value.DataPropertyName = "card_value";
            this.card_value.HeaderText = "停车证号";
            this.card_value.MinimumWidth = 8;
            this.card_value.Name = "card_value";
            this.card_value.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "车主姓名";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // idcard
            // 
            this.idcard.DataPropertyName = "idcard";
            this.idcard.HeaderText = "身份证号";
            this.idcard.MinimumWidth = 8;
            this.idcard.Name = "idcard";
            this.idcard.Width = 150;
            // 
            // carnumber
            // 
            this.carnumber.DataPropertyName = "carnumber";
            this.carnumber.HeaderText = "车牌号";
            this.carnumber.MinimumWidth = 8;
            this.carnumber.Name = "carnumber";
            this.carnumber.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "证件状态";
            this.state.MinimumWidth = 8;
            this.state.Name = "state";
            this.state.Width = 150;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.MinimumWidth = 8;
            this.sex.Name = "sex";
            this.sex.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(566, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "检索";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "车主姓名",
            "停车证号"});
            this.comboBox1.Location = new System.Drawing.Point(375, 216);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 37);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(322, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "按";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(610, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 44);
            this.label1.TabIndex = 25;
            this.label1.Text = "停车证信息查询";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label5.Location = new System.Drawing.Point(1377, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(1150, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "证件状态：";
            // 
            // sexpanel
            // 
            this.sexpanel.Controls.Add(this.radioButton6);
            this.sexpanel.Controls.Add(this.radioButton5);
            this.sexpanel.Controls.Add(this.radioButton4);
            this.sexpanel.Location = new System.Drawing.Point(1383, 130);
            this.sexpanel.Margin = new System.Windows.Forms.Padding(4);
            this.sexpanel.Name = "sexpanel";
            this.sexpanel.Size = new System.Drawing.Size(158, 150);
            this.sexpanel.TabIndex = 39;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton6.Location = new System.Drawing.Point(27, 98);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(67, 33);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.Text = "女";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton5.Location = new System.Drawing.Point(27, 50);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 33);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "男";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton4.Location = new System.Drawing.Point(27, 4);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(96, 33);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "全部";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // statepanel
            // 
            this.statepanel.Controls.Add(this.radioButton3);
            this.statepanel.Controls.Add(this.radioButton1);
            this.statepanel.Controls.Add(this.radioButton2);
            this.statepanel.Location = new System.Drawing.Point(1156, 130);
            this.statepanel.Margin = new System.Windows.Forms.Padding(4);
            this.statepanel.Name = "statepanel";
            this.statepanel.Size = new System.Drawing.Size(176, 150);
            this.statepanel.TabIndex = 38;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton3.Location = new System.Drawing.Point(20, 4);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 33);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "全部";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton1.Location = new System.Drawing.Point(20, 50);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 33);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "正常";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.radioButton2.Location = new System.Drawing.Point(20, 94);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 33);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.Text = "挂失";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // SearchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 954);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sexpanel);
            this.Controls.Add(this.statepanel);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.index);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.searchb);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchCard";
            this.Text = "停车证信息查询";
            this.Load += new System.EventHandler(this.SearchCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.sexpanel.ResumeLayout(false);
            this.sexpanel.PerformLayout();
            this.statepanel.ResumeLayout(false);
            this.statepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button searchb;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel sexpanel;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel statepanel;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
    }
}