using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Driver
    {
        #region Fields
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
        #endregion

        #region Constructors
        public Driver(int id, string nama, string email, string password, string telepon)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama 
        {
            get => nama;
            set
            {
                if (value != null && value != "")
                {
                    nama = value;
                }
                else
                {
                    throw new ArgumentException("Please input your name.");
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (value != null && value != "")
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Please input your email.");
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length >= 8 && value != null && value != "")
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password must be at least 8 char.");
                }
            }
        }
        public string Telepon
        {
            get => telepon;
            set
            {
                if (value != null && value != "")
                {
                    telepon = value;
                }
                else
                {
                    throw new ArgumentException("Please input your telepon.");
                }
            }
        }
        #endregion

        #region Methods
        public static List<Driver> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from drivers";
            }
            else
            {
                sql = "select * from drivers where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            List<Driver> listDriver = new List<Driver>();
            while (hasil.Read() == true)
            {
                Driver d = new Driver(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                listDriver.Add(d);
            }
            return listDriver;
        }

        public static void TambahData(Driver d)
        {
            string sql = "insert into drivers (nama, email, password, telepon)"
                + " values ('" + d.Nama + "', '" +
                d.Email + "', SHA2('" + d.Password +
                "', 512), '" + d.Telepon + "')";

            Connection.JalankanPerintahDML(sql);
        }
        public static void UbahData(Driver d)
        {
            string sql = "update drivers set password = SHA2('" + d.Password + "', 512) where email = '" + d.Email +"'";
            Connection.JalankanPerintahDML(sql);
        }
        public static Boolean HapusData(string code)
        {
            string sql = "delete from drivers where id='" + code + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
                return false;
            else
                return true;
        }
        public static Driver CekLogin(string username, string password)
        {
            string sql = "";
            sql = "select * from drivers" +
                    " where email = '" + username + "' and Password = SHA2('" + password + "', 512)";

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Driver d = new Driver(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(),
                    hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());

                return d;
            }
            return null;
        }
        public static Driver AmbilDriverByUsername(string username)
        {
            string sql = "select * from drivers where email = '" + username + "'";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Driver driver = new Driver(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                return driver;
            }
            return null;
        }
        public static double TotalKomisi(List<Order> listOrder)
        {
            double total = 0;
            foreach (Order o in listOrder)
            {
                total += (o.OngkosKirim * 0.8);
            }
            return total;
        }
        #endregion
    }
}
