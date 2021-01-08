using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloryH
{
    class Object
    {

    }
    class member        //用户
    {
        int id;
        string username;
        string password;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
    class admin : member        //管理员
    {
    }
    class employee : member     //员工
    {
        string name;
        int state=1;
        string sex;
        int age;

        public string Name { get => name; set => name = value; }
        public int State { get => state; set => state = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }

        public void insert()
        {
            string sql = "insert into employee(username,name,age,sex) values('" + Username + "','" + Name + "'," + Age + ",'" + Sex + "')";
            DBHelper dBHelper = new DBHelper();
            dBHelper.ADD(sql);
        }
    }

    class parkcardinfo          //停车证表
    {
        int id;
        string card_value;
        string name;
        string idcard;
        string carnumber;
        int state=0;        //0=正常1=挂失
        string sex;

        public int Id { get => id; set => id = value; }
        public string Card_value { get => card_value; set => card_value = value; }
        public string Name { get => name; set => name = value; }
        public string Idcard { get => idcard; set => idcard = value; }
        public string Carnumber { get => carnumber; set => carnumber = value; }
        public int State { get => state; set => state = value; }
        public string Sex { get => sex; set => sex = value; }


        DBHelper dBHelper = new DBHelper();
        public void insert()
        {
            string sql = "insert into parkcardinfo(card_value,name,carnumber,idcard,sex) values('" + Card_value + "','" + Name + "','" + Carnumber + "','" + Idcard + "','" + Sex + "')";
            dBHelper.ADD(sql);
        }

        public DataTable select(string car_number)
        {
            string sql = "select * from parkcardinfo where car_number ='" + car_number + "'";
            return dBHelper.SEA(sql);
        }

        public int update()
        {
            string sql = "UPDATE parkcardinfo SET  carnumber='" + Carnumber + "',name='" + Name + "',state=" + State + ",sex='" + Sex + "',idcard='" + Idcard + "' WHERE id = " + Id;
            return dBHelper.UPD(sql);
        }
    }

    class parking           //停车位表
    {
        int id;
        int parking_id;
        string card_value;
        string car_number;
        string car_user;
        int state=0;
        DateTime begin_time;

        public int Id { get => id; set => id = value; }
        public int Parking_id { get => parking_id; set => parking_id = value; }
        public string Card_value { get => card_value; set => card_value = value; }
        public string Car_number { get => car_number; set => car_number = value; }
        public string Car_user { get => car_user; set => car_user = value; }
        public int State { get => state; set => state = value; }
        public DateTime Begin_time { get => begin_time; set => begin_time = value; }

        DBHelper dBHelper = new DBHelper();
        public void insert()
        {
            string sql = "insert into parking(parking_id,card_value,car_user,car_number,state,begin_time) values(" + Parking_id + ",'" + Card_value + "','" + Car_user + "','" + Car_number + "'," + State + ",'" + begin_time + "')";
            dBHelper.ADD(sql);
        }

        public int update()
        {
            string sql = "UPDATE parking SET card_value = '" + Card_value + "', car_number='" + Car_number + "',car_user='" + Car_user + "',state=1,begin_time='" + DateTime.Now + "' WHERE parking_id = '" + parking_id + "'";
            return dBHelper.UPD(sql);
        }
        
        public int update1()
        {
            string sql = "UPDATE parking SET card_value = '" + Card_value + "', car_number='" + Car_number + "',car_user='" + Car_user + "',state=" + State + ",begin_time='" + Begin_time + "' WHERE parking_id = " + Parking_id;
            return dBHelper.UPD(sql);
        }


        public DataTable select()
        {
            string sql = "select parking_id from parking where state=0 ";
            return dBHelper.SEA(sql);
        }

        public DataTable selectAll()
        {
            string sql = "select * from parking where card_value= '" + Card_value + "'";
            return dBHelper.SEA(sql);
        }
    }

    class parkmoney             
    {
        int id;
        int hour;
        int day;
        int year;
        int month;

        public int Id { get => id; set => id = value; }
        public int Hour { get => hour; set => hour = value; }
        public int Day { get => day; set => day = value; }
        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }

        DBHelper dBHelper = new DBHelper();
        public int update()
        {
            string sql = "UPDATE parkmoney SET hour = " + Hour + ", day=" + Day + ",month=" + Month + ",year=" + Year + " WHERE id = 1";
            return dBHelper.UPD(sql);
        }
    }
}
