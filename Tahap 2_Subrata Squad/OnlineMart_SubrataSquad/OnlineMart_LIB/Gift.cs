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
        #endregion
    }
}
