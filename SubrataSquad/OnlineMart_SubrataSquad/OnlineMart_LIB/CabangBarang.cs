using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class CabangBarang
    {
        #region Fields
        private Barang barang;
        private Cabang cabang;
        private int stok;
        #endregion

        #region Constructors
        public CabangBarang(Barang barang, Cabang cabang, int stok)
        {
            this.Barang = barang;
            this.Cabang = cabang;
            this.Stok = stok;
        }

        public CabangBarang()
        {
            this.Barang = null;
            this.Cabang = null;
            this.Stok = 0;
        }
        #endregion

        #region Properties
        public Barang Barang { get => barang; set => barang = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public int Stok { get => stok; set => stok = value; }
        #endregion

        #region Methods
        public static List<CabangBarang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select C.Id, C.Nama, C.Alamat, P.Id, P.Nama, P.Email, P.Password, P.Telepon, B.Id, B.Nama, B.Harga, " +
                    "K.Id, K.Nama, A.Stok from barangs as B inner join cabangs_barangs as A on B.id = A.barangs_id " +
                    "inner join cabangs as C on C.id = A.cabangs_id inner join pegawais as P on C.pegawais_id = P.id " +
                    "inner join kategoris as K on K.id = B.kategoris_id";
            }
            else
            {
                sql = "select C.Id, C.Nama, C.Alamat, P.Id, P.Nama, P.Email, P.Password, P.Telepon, B.Id, B.Nama, B.Harga, " +
                    "K.Id, K.Nama, A.Stok from barangs as B inner join cabangs_barangs as A on B.id = A.barangs_id " +
                    "inner join cabangs as C on C.id = A.cabangs_id inner join pegawais as P on C.pegawais_id = P.id " +
                    "inner join kategoris as K on K.id = B.kategoris_id where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            List<CabangBarang> listCabangBarang = new List<CabangBarang>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(3), hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString(),
                                    hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString());
                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), p);

                Kategori k = new Kategori(hasil.GetInt32(11), hasil.GetString(12));
                Barang b = new Barang(hasil.GetInt32(8), hasil.GetValue(9).ToString(), hasil.GetValue(10).ToString(), k);

                CabangBarang cb = new CabangBarang(b, c, hasil.GetInt32(13));

                listCabangBarang.Add(cb);
            }
            return listCabangBarang;
        }
        public static void TambahStok(CabangBarang cb)
        {
            string sql = "insert into cabangs_barangs (barangs_id, cabangs_id, stok)" + " values ('" + cb.Barang.Id + "', '" + cb.Cabang.Id + "', '" + cb.Stok + "')";

            Connection.JalankanPerintahDML(sql);
        }

        public static Boolean HapusStok(CabangBarang cb)
        {
            string perintah = "delete from cabangs_barangs where barangs_id = " + cb.Barang.Id + " and cabangs_id = " + cb.Cabang.Id; 
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            return true;
        }
        public static void UbahStok(CabangBarang cb)
        {
            string sql = "update cabangs_barangs set Stok = " + cb.Stok +" where barangs_id = " + 
                cb.Barang.Id + " and cabangs_id = " + cb.Cabang.Id;
            Connection.JalankanPerintahDML(sql);
        }

        #endregion
    }
}
