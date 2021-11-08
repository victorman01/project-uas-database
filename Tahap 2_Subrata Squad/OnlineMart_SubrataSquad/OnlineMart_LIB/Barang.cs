using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Barang
    {
        #region Fields
        private int id;
        private string nama;
        private string harga;
        private Kategori kategori;
        #endregion

        #region Constructors
        public Barang(int id, string nama, string harga, Kategori kategori)
        {
            this.Id = id;
            this.Nama = nama;
            this.Harga = harga;
            this.Kategori = kategori;
        }
        public Barang(string nama, string harga, Kategori kategori)
        {
            this.Nama = nama;
            this.Harga = harga;
            this.Kategori = kategori;
        }
        public Barang()
        {
            this.Nama = "";
            this.Harga = "";
            this.Kategori = null;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Harga { get => harga; set => harga = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        #endregion

        #region Methods
        public static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select B.id, B.Nama, B.Harga, K.id, K.Nama as Nama from barangs B inner join kategoris K on B.kategoris_id = K.id";
            }
            else
            {
                sql = "select B.id, B.Nama, B.Harga, K.id, K.Nama as Nama from barangs B inner join kategoris K on B.kategoris_id = K.id where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<Barang> listBarang = new List<Barang>();

            while (hasil.Read() == true)
            {
                Kategori k = new Kategori(hasil.GetInt32(3), hasil.GetString(4));
                Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k);
                listBarang.Add(b);
            }
            return listBarang;
        }

        public static void TambahData(Barang b)
        {
            string sql = "insert into barangs (Nama, Harga, Kategoris_Id)" +
                " values ('" + b.Nama + "', '" + b.Harga + "', '" + b.Kategori.Id+ "')";

            Connection.JalankanPerintahDML(sql);
        }

        public static Barang AmbilDataByKode(string kode)
        {
            string sql = "select * from barangs where Id = '" + kode + "'";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                Kategori k = new Kategori(hasil.GetInt32(3), hasil.GetString(4));
                Barang b = new Barang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k);
                return b;
            }
            else
            {
                return null;
            }
        }

        public static void UbahData(Barang b)
        {
            string sql = "update barangs set Nama = '" + b.Nama + "', Harga = '" + b.Harga +
                "', kategoris_id = " + b.Kategori.Id + " where id = " + b.id;
            Connection.JalankanPerintahDML(sql);
        }

        public static Boolean HapusData(string id)
        {
            string perintah = "delete from barangs where id = '" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
