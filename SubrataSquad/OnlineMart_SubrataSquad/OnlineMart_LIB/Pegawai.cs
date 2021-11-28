using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pegawai
    {
        #region Fields
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
        #endregion

        #region Constructors
        public Pegawai(int id, string nama, string email, string password, string telepon)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
        }

        public Pegawai(int id, string nama, string email, string telepon)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Telepon = telepon;
        }

        public Pegawai(string nama, string email, string password, string telepon)
        {
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        #endregion

        #region Methods
        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from pegawais";
            }
            else
            {
                sql = "select * from pegawais where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString());
                listPegawai.Add(p);
            }
            return listPegawai;
        }

        public static Pegawai CekLogin(string username, string password)
        {
            string sql = "select id, nama, email, password, telepon from pegawais where Email = '" +
                            username + "' AND Password = SHA2('" + password + "', 512)";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3),
                    hasil.GetString(4));
                return p;
            }

            return null;
        }
        public static void TambahData(Pegawai p)
        {
            string sql = "insert into pegawais (Nama, Email, Password, Telepon) " +
                "values ('" + p.Nama + "', '" + p.Email + "', SHA2('" + p.Password + "', 512), '" + p.Telepon + "')";
            Connection.JalankanPerintahDML(sql);
        }
        public static void UbahData(Pegawai p)
        {
            string sql = "update pegawais set nama = '" + p.Nama + "', email = '" + p.Email + "', password = SHA2('" + p.Password + "', 512), telepon = '" + p.Telepon + "' where id = '" + p.Id + "'";
            Connection.JalankanPerintahDML(sql);
        }
        public static Boolean HapusData(string id)
        {
            string perintah = "delete from pegawais where id='" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
