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
    public partial class Cost : Form
    {
        DBHelper dBHelper = new DBHelper();
        public Cost()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Cost_Load(object sender, EventArgs e)
        {
            string sql = "select * from parkmoney where id=1";
            DataTable dt = new DataTable();
            dt = dBHelper.SEA(sql);
            DataRowCollection coldrow = dt.Rows;
            DataRow dataRow;
            dataRow = coldrow[0];
            hour1.Text = dataRow[1].ToString();
            day1.Text = dataRow[2].ToString();
            month1.Text = dataRow[4].ToString();
            year1.Text = dataRow[3].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            parkmoney p = new parkmoney();
            p.Hour = int.Parse(hour1.Text);
            p.Month = int.Parse(month1.Text);
            p.Day = int.Parse(day1.Text);
            p.Year = int.Parse(year1.Text);
            int result = p.update();
            MessageBox.Show("修改成功！");
        }
    }
}
