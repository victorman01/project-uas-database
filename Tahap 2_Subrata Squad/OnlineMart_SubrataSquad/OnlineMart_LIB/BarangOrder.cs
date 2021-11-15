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
        private Barang barang;
        private Order order;
        private int jumlah;
        private string harga;
        #endregion

        #region Constructors
        public BarangOrder(Barang barang, Order order, int jumlah, string harga)
        {
            this.Barang = barang;
            this.Order = order;
            this.Jumlah = jumlah;
            this.Harga = harga;
        }
        #endregion

        #region Properties
        public Barang Barang { get => barang; set => barang = value; }
        public Order Order { get => order; set => order = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public string Harga { get => harga; set => harga = value; }
        #endregion

        #region Methods
        //public static List<BarangOrder> BacaData(string kriteria, string nilaiKriteria)
        //{
        //    string sql = "";

        //    if (kriteria == "")
        //    {
        //        sql = "select * from barangs_orders";
        //    }
        //    else
        //    {
        //        sql = "select * from barangs_orders where " + kriteria + " like '%" + nilaiKriteria + "%'";
        //    }

        //    MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
        //    List<BarangOrder> listBarangOrder = new List<BarangOrder>();

        //    while (hasil.Read() == true)
        //    {
        //        BarangOrder p = new BarangOrder(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
        //        listBarangOrder.Add(p);
        //    }
        //    return listBarangOrder;
        //}
        public static void TambahData(BarangOrder bo)
        {
            string sql = "insert into barangs_orders (barangs_id, orders_id, jumlah, harga)"
                + " values ('" + bo.Barang.Id + "', '" + bo.Order.Id + "', '" + bo.Jumlah + "', '" + bo.Harga + "')";

            Connection.JalankanPerintahDML(sql);
        }
        #endregion
    }
}
