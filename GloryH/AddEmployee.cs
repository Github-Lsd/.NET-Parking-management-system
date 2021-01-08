using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloryH
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Parking_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            employee e1 = new employee();
            e1.Username= username1.Text;
            e1.Name = name1.Text;
            e1.Age = int.Parse(age1.Value.ToString());
            e1.Sex = "男";

            if (sex1.Checked)
            {
                e1.Sex = "男";
            }
            if (sex2.Checked)
            {
                e1.Sex = "女";
            }
            if (e1.Username.Length == 0)
            {
                MessageBox.Show("请输入用户名！");
            }
            else
            {
                if (e1.Name.Length == 0)
                {
                    MessageBox.Show("请输入员工姓名！");
                }
                else
                {
                    if (!sex1.Checked && !sex2.Checked)
                    {
                        MessageBox.Show("请选择员工性别！");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("您要添加的员工信息如下：\n用户名："+e1.Username+"\n姓名："+e1.Name+"\n年龄："+e1.Age+"\n性别："+e1.Sex+"\n确定要添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            e1.insert();
                            MessageBox.Show("已将该员工信息添加至数据库，默认密码为000");
                            Employee searchParking = (Employee)this.Owner;
                            searchParking.reLoad_method();
                        }
                    }
                }
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
       
    }
}
