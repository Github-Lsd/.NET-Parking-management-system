namespace GloryH
{
    partial class CarIn
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
            this.type1 = new System.Windows.Forms.ComboBox();
            this.verify1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.searchB = new System.Windows.Forms.Button();
            this.carinb = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(722, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "车辆驶入";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(544, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "信息验证：";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // type1
            // 
            this.type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type1.Font = new System.Drawing.Font("宋体", 15F);
            this.type1.FormattingEnabled = true;
            this.type1.Items.AddRange(new object[] {
            "车牌号",
            "证件号"});
            this.type1.Location = new System.Drawing.Point(710, 211);
            this.type1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(128, 38);
            this.type1.TabIndex = 2;
            this.type1.SelectedIndexChanged += new System.EventHandler(this.Type1_SelectedIndexChanged);
            // 
            // verify1
            // 
            this.verify1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.verify1.Location = new System.Drawing.Point(879, 208);
            this.verify1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verify1.Name = "verify1";
            this.verify1.Size = new System.Drawing.Size(234, 41);
            this.verify1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.card_value,
            this.name,
            this.idcard,
            this.carnum,
            this.state});
            this.dataGridView1.Location = new System.Drawing.Point(430, 346);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(969, 122);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
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
            this.name.HeaderText = "姓名";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // idcard
            // 
            this.idcard.DataPropertyName = "idcard";
            this.idcard.HeaderText = "身份证";
            this.idcard.MinimumWidth = 8;
            this.idcard.Name = "idcard";
            this.idcard.Width = 150;
            // 
            // carnum
            // 
            this.carnum.DataPropertyName = "carnumber";
            this.carnum.HeaderText = "车牌号";
            this.carnum.MinimumWidth = 8;
            this.carnum.Name = "carnum";
            this.carnum.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "证件状态";
            this.state.MinimumWidth = 8;
            this.state.Name = "state";
            this.state.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(723, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "对应信息如下：";
            this.label4.Visible = false;
            // 
            // searchB
            // 
            this.searchB.Font = new System.Drawing.Font("宋体", 14.5F);
            this.searchB.Location = new System.Drawing.Point(1157, 206);
            this.searchB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(112, 39);
            this.searchB.TabIndex = 7;
            this.searchB.Text = "查询";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.Button1_Click);
            // 
            // carinb
            // 
            this.carinb.Font = new System.Drawing.Font("宋体", 14.5F);
            this.carinb.Location = new System.Drawing.Point(1178, 555);
            this.carinb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carinb.Name = "carinb";
            this.carinb.Size = new System.Drawing.Size(162, 57);
            this.carinb.TabIndex = 8;
            this.carinb.Text = "停入";
            this.carinb.UseVisualStyleBackColor = true;
            this.carinb.Visible = false;
            this.carinb.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(602, 570);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "空余停车位";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(825, 566);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 37);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CarIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 954);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carinb);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.verify1);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarIn";
            this.Text = "车辆驶入";
            this.Load += new System.EventHandler(this.CarIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox type1;
        private System.Windows.Forms.TextBox verify1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Button carinb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}