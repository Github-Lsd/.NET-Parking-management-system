namespace GloryH
{
    partial class Carout
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
            this.caroutb = new System.Windows.Forms.Button();
            this.searchb = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parking_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begin_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verify1 = new System.Windows.Forms.TextBox();
            this.type1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // caroutb
            // 
            this.caroutb.Font = new System.Drawing.Font("宋体", 14.5F);
            this.caroutb.Location = new System.Drawing.Point(760, 590);
            this.caroutb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caroutb.Name = "caroutb";
            this.caroutb.Size = new System.Drawing.Size(180, 57);
            this.caroutb.TabIndex = 18;
            this.caroutb.Text = "驶出并计费";
            this.caroutb.UseVisualStyleBackColor = true;
            this.caroutb.Visible = false;
            this.caroutb.Click += new System.EventHandler(this.Button2_Click);
            // 
            // searchb
            // 
            this.searchb.Font = new System.Drawing.Font("宋体", 14.5F);
            this.searchb.Location = new System.Drawing.Point(1190, 250);
            this.searchb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchb.Name = "searchb";
            this.searchb.Size = new System.Drawing.Size(112, 39);
            this.searchb.TabIndex = 17;
            this.searchb.Text = "查询";
            this.searchb.UseVisualStyleBackColor = true;
            this.searchb.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(686, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "对应信息如下：";
            this.label4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.parking_id,
            this.card_value,
            this.car_number,
            this.car_name,
            this.begin_time,
            this.state});
            this.dataGridView1.Location = new System.Drawing.Point(398, 384);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(964, 111);
            this.dataGridView1.TabIndex = 15;
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
            // parking_id
            // 
            this.parking_id.DataPropertyName = "parking_id";
            this.parking_id.HeaderText = "车位编号";
            this.parking_id.MinimumWidth = 8;
            this.parking_id.Name = "parking_id";
            this.parking_id.Width = 150;
            // 
            // card_value
            // 
            this.card_value.DataPropertyName = "card_value";
            this.card_value.HeaderText = "停车证号";
            this.card_value.MinimumWidth = 8;
            this.card_value.Name = "card_value";
            this.card_value.Width = 150;
            // 
            // car_number
            // 
            this.car_number.DataPropertyName = "car_number";
            this.car_number.HeaderText = "车牌号";
            this.car_number.MinimumWidth = 8;
            this.car_number.Name = "car_number";
            this.car_number.Width = 150;
            // 
            // car_name
            // 
            this.car_name.DataPropertyName = "car_user";
            this.car_name.HeaderText = "车主姓名";
            this.car_name.MinimumWidth = 8;
            this.car_name.Name = "car_name";
            this.car_name.Width = 150;
            // 
            // begin_time
            // 
            this.begin_time.DataPropertyName = "begin_time";
            this.begin_time.HeaderText = "停入时间";
            this.begin_time.MinimumWidth = 8;
            this.begin_time.Name = "begin_time";
            this.begin_time.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "车位状态";
            this.state.MinimumWidth = 8;
            this.state.Name = "state";
            this.state.Width = 150;
            // 
            // verify1
            // 
            this.verify1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.verify1.Location = new System.Drawing.Point(884, 244);
            this.verify1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verify1.Name = "verify1";
            this.verify1.Size = new System.Drawing.Size(234, 41);
            this.verify1.TabIndex = 14;
            this.verify1.TextChanged += new System.EventHandler(this.Verify1_TextChanged);
            // 
            // type1
            // 
            this.type1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type1.Font = new System.Drawing.Font("宋体", 15F);
            this.type1.FormattingEnabled = true;
            this.type1.Items.AddRange(new object[] {
            "车牌号",
            "证件号"});
            this.type1.Location = new System.Drawing.Point(714, 248);
            this.type1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(128, 38);
            this.type1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(549, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "信息验证：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(684, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "车辆驶出";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Carout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 954);
            this.Controls.Add(this.caroutb);
            this.Controls.Add(this.searchb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.verify1);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Carout";
            this.Text = "车辆驶出";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button caroutb;
        private System.Windows.Forms.Button searchb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox verify1;
        private System.Windows.Forms.ComboBox type1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn parking_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn begin_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}