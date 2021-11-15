using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Gift
    {
        #region Fields
        private int id;
        private string nama;
        private string jumlahPoin;
        #endregion

        #region Constructors
        public Gift(int id, string nama, string jumlahPoin)
        {
            this.Id = id;
            this.Nama = nama;
            this.JumlahPoin = jumlahPoin;
        }

        public Gift(string nama, string jumlahPoin)
        {
            this.Nama = nama;
            this.JumlahPoin = jumlahPoin;
        }
        public Gift()
        {
            this.Nama = "";
            this.JumlahPoin = "";
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string JumlahPoin { get => jumlahPoin; set => jumlahPoin = value; }
        #endregion

        #region Methods
        public static List<Gift> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from gifts";
            }
            else
            {
                sql = "select * from gifts where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            List<Gift> listGift = new List<Gift>();
            while (hasil.Read() == true)
            {
                Gift k = new Gift(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString());
                listGift.Add(k);
            }
            return listGift;
        }

        public static Boolean HapusData(string id)
        {
            string sql = "delete from gifts where id='" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
                return false;
            else
                return true;
        }

        public static void TambahData(Gift g)
        {
            string sql = "insert into gifts (nama, jumlah_poin) values ('" + g.Nama.Replace("'", "\\'") + "', '"
                + g.JumlahPoin + "')";
            Connection.JalankanPerintahDML(sql);
        }

        public static void UbahData(Gift g)
        {
            string sql = "update gifts set nama = '" + g.Nama.Replace("'", "\\'")
                + "', jumlah_poin = '" + g.JumlahPoin +
                "' where id = " + g.Id;
            Connection.JalankanPerintahDML(sql);
        }

        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
