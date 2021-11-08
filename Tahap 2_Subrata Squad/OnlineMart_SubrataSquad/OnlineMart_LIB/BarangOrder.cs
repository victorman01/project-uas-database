using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class BarangOrder
    {
        #region Fields
        private string barangId;
        private string orderId;
        private string jumlah;
        private string harga;
        #endregion

        #region Constructors
        public BarangOrder(string barangId, string orderId, string jumlah, string harga)
        {
            this.BarangId = barangId;
            this.OrderId = orderId;
            this.Jumlah = jumlah;
            this.Harga = harga;
        }
        #endregion

        #region Properties
        public string BarangId { get => barangId; set => barangId = value; }
        public string OrderId { get => orderId; set => orderId = value; }
        public string Jumlah { get => jumlah; set => jumlah = value; }
        public string Harga { get => harga; set => harga = value; }
        #endregion

        #region Methods
        public static List<BarangOrder> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from barangs_orders";
            }
            else
            {
                sql = "select * from barangs_orders where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<BarangOrder> listBarangOrder = new List<BarangOrder>();

            while (hasil.Read() == true)
            {
                BarangOrder p = new BarangOrder(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                listBarangOrder.Add(p);
            }
            return listBarangOrder;
        }
        #endregion
    }
}
