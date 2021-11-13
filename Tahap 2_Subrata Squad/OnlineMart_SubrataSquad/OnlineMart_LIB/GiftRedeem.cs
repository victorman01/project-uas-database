using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class GiftRedeem
    {
        #region Fields
        private int id;
        private DateTime waktu;
        private int poinRedeem;
        private Gift gift;
        private Order order;
        #endregion

        #region Constructors
        public GiftRedeem(int id, DateTime waktu, int poinRedeem, Gift gift, Order order)
        {
            this.Id = id;
            this.Waktu = waktu;
            this.PoinRedeem = poinRedeem;
            this.Gift = gift;
            this.Order = order;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime Waktu { get => waktu; set => waktu = value; }
        public int PoinRedeem { get => poinRedeem; set => poinRedeem = value; }
        public Gift Gift { get => gift; set => gift = value; }
        public Order Order { get => order; set => order = value; }
        #endregion

        #region Methods
        public static List<GiftRedeem> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from gift_redeems";
            }
            else
            {
                sql = "select * from gift_redeems where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            List<GiftRedeem> listGiftRedeem = new List<GiftRedeem>();
            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetString(19));
                Cabang cabang = new Cabang(hasil.GetInt32(12), hasil.GetString(13), hasil.GetString(14), pegawai);
                Driver driver = new Driver(hasil.GetInt32(20), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24));
                Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(25), hasil.GetString(26), hasil.GetString(27), hasil.GetString(28), hasil.GetString(29), hasil.GetFloat(30), hasil.GetInt32(31));
                Promo promo = new Promo(hasil.GetInt32(32), hasil.GetString(33), hasil.GetString(34), hasil.GetInt32(35), hasil.GetInt32(36), hasil.GetFloat(37));
                Gift g = new Gift(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5));
                MetodePembayaran mp = new MetodePembayaran(hasil.GetString(39));
                Order order = new Order(hasil.GetInt32(6), hasil.GetDateTime(7), hasil.GetString(8), hasil.GetFloat(9), hasil.GetFloat(10), hasil.GetString(11), cabang, driver, pelanggan, promo, hasil.GetString(38), mp, hasil.GetString(40));
                GiftRedeem gr = new GiftRedeem(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetInt32(2), g, order);
                listGiftRedeem.Add(gr);
            }
            return listGiftRedeem;
        }
        #endregion
    }
}
