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
        private MetodePembayaran metodePembayaran;
        private string statusKirim;
        #endregion

        #region Constructors
        public Order(int id, DateTime tanggalWaktu, string alamatTujuan, float ongkosKirim, float totalBayar, string caraBayar, Cabang cabang, Driver driver, Pelanggan pelanggan, Promo promo, string status, MetodePembayaran metodePembayaran, string statusKirim)
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
            this.StatusKirim = statusKirim;
        }

        public Order(string alamatTujuan, float ongkosKirim, float totalBayar, string caraBayar, Cabang cabang, Driver driver, Pelanggan pelanggan, Promo promo, string status, MetodePembayaran metodePembayaran, string statusKirim)
        {
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
            this.StatusKirim = statusKirim;
        }
        public Order()
        {
            this.Id = 0;
            this.AlamatTujuan = "";
            this.OngkosKirim = 0;
            this.TotalBayar = 0;
            this.CaraBayar = "";
            this.Cabang = null;
            this.Driver = null;
            this.Pelanggan = null;
            this.Promo = null;
            this.Status = "";
            this.MetodePembayaran = null;
            this.StatusKirim = "";
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
        public MetodePembayaran MetodePembayaran { get => metodePembayaran; set => metodePembayaran = value; }
        public string StatusKirim { get => statusKirim; set => statusKirim = value; }
        #endregion

        #region Methods
        public static List<Order> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan,o.ongkos_kirim, o.total_bayar,o.cara_bayar,c.id,c.nama,c.alamat,p.id, p.nama,p.email,p.password,p.telepon, d.id,d.nama,d.email,d.password,d.telepon,pe.id,pe.nama,pe.email,pe.password,pe.telepon,pe.saldo,pe.poin,pr.id,pr.tipe,pr.nama,pr.diskon,pr.diskon_max,pr.minimal_belanja,o.status,mp.nama,o.status_kirim from orders o inner join cabangs c on o.cabangs_id = c.id inner join pegawais p on c.pegawais_id = p.id inner join drivers d on o.drivers_id = d.id inner join promos pr on o.promo_id = pr.id  inner join pelanggans pe on o.pelanggans_id = pe.id inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id order by o.id DESC";
            }
            else
            {
                sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan,o.ongkos_kirim, o.total_bayar,o.cara_bayar,c.id,c.nama,c.alamat,p.id, p.nama,p.email,p.password,p.telepon, d.id,d.nama,d.email,d.password,d.telepon,pe.id,pe.nama,pe.email,pe.password,pe.telepon,pe.saldo,pe.poin,pr.id,pr.tipe,pr.nama,pr.diskon,pr.diskon_max,pr.minimal_belanja,o.status,mp.nama,o.status_kirim from orders o inner join cabangs c on o.cabangs_id = c.id inner join pegawais p on c.pegawais_id = p.id inner join drivers d on o.drivers_id = d.id inner join promos pr on o.promo_id = pr.id  inner join pelanggans pe on o.pelanggans_id = pe.id inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id where " + kriteria + " like '%" + nilaiKriteria + "%' order by o.id DESC";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<Order> listOrder = new List<Order>();

            while (hasil.Read() == true)
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12), hasil.GetString(13));
                Cabang cabang = new Cabang(hasil.GetInt32(6), hasil.GetString(7), hasil.GetString(8), pegawai);
                Driver driver = new Driver(hasil.GetInt32(14), hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18));
                Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(19), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23), hasil.GetFloat(24), hasil.GetInt32(25));
                Promo promo = new Promo(hasil.GetInt32(26), hasil.GetString(27), hasil.GetString(28), hasil.GetInt32(29), hasil.GetInt32(30), hasil.GetFloat(31));
                MetodePembayaran mp = new MetodePembayaran(hasil.GetString(33));
                Order o = new Order(hasil.GetInt32(0), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString(), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetValue(5).ToString(), cabang, driver, pelanggan, promo, hasil.GetString(32), mp, hasil.GetString(34));
                listOrder.Add(o);
            }
            return listOrder;
        }

        public static float KomisiDriver(float ongkoskirim)
        {
            float hasil = ongkoskirim * 80 / 100;
            return hasil;
        }

        public static Boolean UbahStatusKirim(string status, int id)
        {
            string sql = "update orders set status_kirim = '" + status + "'" +
                " where id = " + id;

            int berubah = Connection.JalankanPerintahDML(sql);
            if (berubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int HitungTotalHarga(int totalHarga, int ongkir, int diskon)
        {
            totalHarga += ongkir - diskon;
            return totalHarga;
        }

        public static void TambahData(Order o)
        {
            string sql = "insert into orders (tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, cabangs_id, drivers_id, pelanggans_id, promo_id, status, metode_pembayaran_id) " +
                "values ( Now(), '" + o.AlamatTujuan + "', '" + o.OngkosKirim + "', '" + o.TotalBayar + "', '" + o.CaraBayar + "', '" + o.Cabang.Id + "', '" + o.Driver.Id + "', '" +
                o.Pelanggan.Id + "', '" + o.Promo.Id + "', '" + o.Status + "', '" + o.MetodePembayaran.Id + "')";
            Connection.JalankanPerintahDML(sql);
        }
        public static Boolean UbahStatus(string status, int id)
        {
            string sql = "update orders set status = '" + status + "'" +
                " where id = " + id;

            int berubah = Connection.JalankanPerintahDML(sql);
            if (berubah == 0)
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
