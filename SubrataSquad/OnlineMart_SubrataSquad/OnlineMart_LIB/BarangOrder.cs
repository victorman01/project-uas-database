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
        public static List<BarangOrder> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan,o.ongkos_kirim, o.total_bayar,o.cara_bayar," +
                    " c.id,c.nama,c.alamat," +
                    " p.id, p.nama,p.email,p.password,p.telepon," +
                    " d.id,d.nama,d.email,d.password,d.telepon," +
                    " pe.id,pe.nama,pe.email,pe.password,pe.telepon,pe.saldo,pe.poin," +
                    " pr.id,pr.tipe,pr.nama,pr.diskon,pr.diskon_max,pr.minimal_belanja," +
                    " o.status,mp.nama,o.status_kirim," +
                    " b.id, b.nama, b.harga, b.kategoris_id," +
                    " k.nama," +
                    " bo.jumlah, bo.harga" +
                    " from orders o inner join cabangs c on o.cabangs_id = c.id" +
                    " inner join pegawais p on c.pegawais_id = p.id" +
                    " inner join drivers d on o.drivers_id = d.id" +
                    " inner join promos pr on o.promo_id = pr.id" +
                    " inner join pelanggans pe on o.pelanggans_id = pe.id" +
                    " inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id" +
                    " inner join barangs_orders bo on bo.orders_id = o.id" +
                    " inner join barangs b on bo.barangs_id = b.id" +
                    " inner join kategoris k on b.kategoris_id = k.id";
            }
            else
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan,o.ongkos_kirim, o.total_bayar,o.cara_bayar," +
                    " c.id,c.nama,c.alamat," +
                    " p.id, p.nama,p.email,p.password,p.telepon," +
                    " d.id,d.nama,d.email,d.password,d.telepon," +
                    " pe.id,pe.nama,pe.email,pe.password,pe.telepon,pe.saldo,pe.poin," +
                    " pr.id,pr.tipe,pr.nama,pr.diskon,pr.diskon_max,pr.minimal_belanja," +
                    " o.status,mp.nama,o.status_kirim," +
                    " b.id, b.nama, b.harga, b.kategoris_id," +
                    " k.nama," +
                    " bo.jumlah, bo.harga" +
                    " from orders o inner join cabangs c on o.cabangs_id = c.id" +
                    " inner join pegawais p on c.pegawais_id = p.id" +
                    " inner join drivers d on o.drivers_id = d.id" +
                    " inner join promos pr on o.promo_id = pr.id" +
                    " inner join pelanggans pe on o.pelanggans_id = pe.id" +
                    " inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id" +
                    " inner join barangs_orders bo on bo.orders_id = o.id" +
                    " inner join barangs b on bo.barangs_id = b.id" +
                    " inner join kategoris k on b.kategoris_id = k.id" +
                    " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<BarangOrder> listBarangOrder = new List<BarangOrder>();

            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12), hasil.GetString(13));
                Cabang cabang = new Cabang(hasil.GetInt32(6), hasil.GetString(7), hasil.GetString(8), pegawai);
                Driver driver = new Driver(hasil.GetInt32(14), hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18));
                Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(19), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23), hasil.GetFloat(24), hasil.GetInt32(25));
                Promo promo = new Promo(hasil.GetInt32(26), hasil.GetString(27), hasil.GetString(28), hasil.GetInt32(29), hasil.GetInt32(30), hasil.GetFloat(31));
                MetodePembayaran mp = new MetodePembayaran(hasil.GetString(33));
                Order o = new Order(hasil.GetInt32(0), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString(), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetValue(5).ToString(), cabang, driver, pelanggan, promo, hasil.GetString(32), mp, hasil.GetString(34));
                Kategori k = new Kategori(hasil.GetInt32(38), hasil.GetString(39));
                Barang b = new Barang(hasil.GetInt32(35), hasil.GetString(36), hasil.GetString(37), k);
                BarangOrder bo = new BarangOrder(b, o, hasil.GetInt32(40), hasil.GetString(41));
                listBarangOrder.Add(bo);
            }
            return listBarangOrder;
        }
        public static void TambahData(BarangOrder bo)
        {
            string sql = "insert into barangs_orders (barangs_id, orders_id, jumlah, harga)"
                + " values ('" + bo.Barang.Id + "', '" + bo.Order.Id + "', '" + bo.Jumlah + "', '" + bo.Harga + "')";

            Connection.JalankanPerintahDML(sql);
        }
        #endregion
    }
}
