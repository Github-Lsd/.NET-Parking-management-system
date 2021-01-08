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
    public partial class CardAdd : Form
    {
        int search = 0;
        SearchCard searchCard = new SearchCard();
        DBHelper dBHelper = new DBHelper();
        public CardAdd()
        {
            InitializeComponent();
        }
        public CardAdd(int d,SearchCard searchCard)
        {
            search = d;
            InitializeComponent();
            this.searchCard = searchCard;
        }
        private void CardAdd_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (card_value1.TextLength == 0)
            {
                MessageBox.Show("请输入停车证号！");
                return;
            }
            else if (car_number1.TextLength == 0)
            {
                MessageBox.Show("请输入车牌号！");
                return;
            }
            else if (car_user1.TextLength == 0)
            {
                MessageBox.Show("请输入车主姓名！");
                return;
            }
            else if (idcard1.TextLength == 0)
            {
                MessageBox.Show("请输入身份证号！");
                return;
            }
            else if (!sex1.Checked && !sex2.Checked)
            {
                MessageBox.Show("请选择性别！");
                return;
            }
            else
            {
                AddCard();
            }
            if (search==1)
            {
                SearchCard searchCard = (SearchCard)this.Owner;
                searchCard.reLoad_method();
                this.Hide();
            }
        }
        public void AddCard()
        {
            parkcardinfo p = new parkcardinfo();
            p.Card_value = card_value1.Text;
            p.Name = car_user1.Text;
            p.Carnumber = car_number1.Text;
            p.Idcard = idcard1.Text;
            p.Sex = "男";

            if (sex1.Checked)
            {
                p.Sex = "男";
            }
            if (sex2.Checked)
            {
                p.Sex = "女";
            }
            DialogResult r = MessageBox.Show("您要办理的停车证信息如下：\n卡号："+p.Card_value+"\n姓名："+p.Name+"\n性别："+p.Sex+"\n车牌号："+p.Carnumber+"\n身份证号："+p.Idcard, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                p.insert();
                card_value1.Text = "";
                car_number1.Text = "";

                car_user1.Text = "";
                idcard1.Text = "";
                MessageBox.Show("办理成功，请提醒持有人妥善保管！");
            }
            

        }
    }
}
