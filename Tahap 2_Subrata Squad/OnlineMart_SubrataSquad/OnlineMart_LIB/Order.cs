using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Order
    {
        #region Fields
        private int id;
        private DateTime tanggalWaktu;
        private string alamatTujuan;
        private float ongkosKirim;
        private float totalBayar;
        private string caraBayar;
        private Cabang cabang;
        private Driver driver;
        private Pelanggan pelanggan;
        private Promo promo;
        private string status;
        private string metodePembayaran;
        #endregion

        #region Constructors
        public Order(int id, DateTime tanggalWaktu, string alamatTujuan, float ongkosKirim, float totalBayar, string caraBayar, Cabang cabang, Driver driver, Pelanggan pelanggan, Promo promo, string status, string metodePembayaran)
        {
            this.Id = id;
            this.TanggalWaktu = tanggalWaktu;
            this.AlamatTujuan = alamatTujuan;
            this.OngkosKirim = ongkosKirim;
            this.TotalBayar = totalBayar;
            this.CaraBayar = caraBayar;
            this.Cabang = cabang;
            this.Driver = driver;
            this.Pelanggan = pelanggan;
            this.Promo = promo;
            this.Status = status;
            this.MetodePembayaran = metodePembayaran;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime TanggalWaktu { get => tanggalWaktu; set => tanggalWaktu = value; }
        public string AlamatTujuan { get => alamatTujuan; set => alamatTujuan = value; }
        public float OngkosKirim { get => ongkosKirim; set => ongkosKirim = value; }
        public float TotalBayar { get => totalBayar; set => totalBayar = value; }
        public string CaraBayar { get => caraBayar; set => caraBayar = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Promo Promo { get => promo; set => promo = value; }
        public string Status { get => status; set => status = value; }
        public string MetodePembayaran { get => metodePembayaran; set => metodePembayaran = value; }
        #endregion

        #region Methods
        public static List<Order> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan, o.ongkos_kirim, o.total_bayar, o.cara_bayar, c.id, d.id, pe.id, pr.id from orders o inner join cabangs c on o.cabangs_id = c.id inner join pegawais p on c.pegawais_id = p.id inner join driver d on o.drivers_id = d.id inner join promo pr on o.promos_id = pr.id inner join pelanggan pe on o.pelanggans_id = pe.id";
            }
            else
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan, o.ongkos_kirim, o.total_bayar, o.cara_bayar, c.id, d.id, pe.id, pr.id from orders o inner join cabangs c on o.cabangs_id = c.id inner join pegawais p on c.pegawais_id = p.id inner join driver d on o.drivers_id = d.id inner join promo pr on o.promos_id = pr.id inner join pelanggan pe on o.pelanggans_id = pe.id where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<Order> listOrder = new List<Order>();

            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12), hasil.GetString(13));
                Cabang cabang = new Cabang(hasil.GetInt32(6), hasil.GetString(7), hasil.GetString(8), pegawai);
                Driver driver = new Driver(hasil.GetInt32(14),  hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18));
                Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(19), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23), hasil.GetFloat(24), hasil.GetInt32(25));
                Promo promo = new Promo(hasil.GetInt32(26), hasil.GetString(27), hasil.GetString(28), hasil.GetInt32(29), hasil.GetInt32(30), hasil.GetFloat(31));
                Order o = new Order(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetValue(2).ToString(), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetValue(5).ToString(), cabang, driver, pelanggan, promo, hasil.GetString(32), hasil.GetString(33));
                listOrder.Add(o);
            }
            return listOrder;
        }
        #endregion
    }
}
