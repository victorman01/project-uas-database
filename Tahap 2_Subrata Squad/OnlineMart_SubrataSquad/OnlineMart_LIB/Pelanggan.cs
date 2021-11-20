﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pelanggan
    {
        #region Fields
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
        private float saldo;
        private int poin;
        #endregion

        #region Constructors
        public Pelanggan(int id, string nama, string email, string password, string telepon, float saldo, int poin)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Telepon = telepon;
            this.Saldo = saldo;
            this.Poin = poin;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama 
        { 
            get => nama;
            set
            {
                if(value != null && value != "")
                {
                    nama = value;
                }
                else
                {
                    throw new ArgumentException("Please input your name.");
                }
            } 
        }
        public string Email 
        { 
            get => email;
            set
            {
                if (value != null && value != "")
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Please input your email.");
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (value.Length >=8)
                {
                    password = value;
                }
                else
                {
                    throw new ArgumentException("Password must be at least 8 char.");
                }
            }
        }
        public string Telepon { get => telepon; set => telepon = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int Poin { get => poin; set => poin = value; }
        #endregion

        #region Methods
        public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "select * from pelanggans";
            }
            else
            {
                sql = "select * from pelanggans where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);

            List<Pelanggan> listPelanggan = new List<Pelanggan>();
            while (hasil.Read() == true)
            {
                Pelanggan k = new Pelanggan(hasil.GetInt32(0), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(), hasil.GetFloat(5), hasil.GetInt32(6));
                listPelanggan.Add(k);
            }
            return listPelanggan;
        }
        public static Pelanggan CekLogin(string username, string password)
        {
            string sql = "select id, nama, email, password, telepon, saldo, poin from pelanggans where Email = '" +
                username + "' AND Password = SHA2('" + password + "', 512)";
            MySqlDataReader hasil = Connection.JalankanPerintahQuery(sql);
            while (hasil.Read() == true)
            {
                Pelanggan pel = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3),
                    hasil.GetString(4), hasil.GetFloat(5), hasil.GetInt32(6));
                return pel;
            }
            return null;
        }
        public static void TambahData(Pelanggan pel)
        {
            string sql = "insert into pelanggans (Nama, Email, Password, Telepon, Saldo, Poin) " +
                "values ('" + pel.Nama + "', '" + pel.Email + "', SHA2('" + pel.password + "', 512), '" + pel.Telepon +
                "', '" + pel.saldo + "', '" + pel.Poin + "')";
            Connection.JalankanPerintahDML(sql);
        }
        public static void UbahData(Pelanggan p)
        {
            string sql = "update pelanggans set nama = '" + p.Nama + "', email = '" + p.Email + "', Password = SHA2('" + p.password + "', 512) , telepon = '" + p.Telepon + "', saldo = '" + p.Saldo + "', poin = '" + p.Poin + "' where id = '" + p.Id + "'";
            Connection.JalankanPerintahDML(sql);
        }
        public static Boolean HapusData(string id)
        {
            string perintah = "delete from pelanggans where id='" + id + "'";
            int jumlahDataBerubah = Connection.JalankanPerintahDML(perintah);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void UpdateSaldo(float nominal, int id)
        {
            string sql = "update pelanggans set saldo = saldo + " + nominal + " where id = " + id;
            Connection.JalankanPerintahDML(sql);
        }

        public static void TambahPoin(float totalHarga, Pelanggan p)
        {
            p.Poin += (int)totalHarga / 10000;
            string sql = "update pelanggans set poin = " + p.Poin + " where id = " + p.Id;
            Connection.JalankanPerintahDML(sql);
        }
        //public void TambahKeranjang(Pelanggan pelanggan, Barang barang, Cabang cabang, int jumlah)
        //{
        //    Keranjang keranjang = new Keranjang(pelanggan, barang, cabang, jumlah);

        //    listKeranjang.Add(keranjang);
        //}

        //public List<Keranjang> BacaDataKeranjang()
        //{
        //    return listKeranjang;
        //}

        //public static void MasukkanKeranjangKeDatabase(Pelanggan pel)
        //{
        //    //Tambah Barang ke Keranjang
        //    foreach (Keranjang keranjang in pel.listKeranjang)
        //    {
        //        string sql = "insert into Keranjangs(Pelanggans_id, Cabangs_id, Barangs_id, Jumlah)" +
        //            "values ('" + keranjang.Pelanggan.id + "', '" + keranjang.Barang.Id + "', '" + keranjang.Cabang.Id + "', '" + keranjang.Jumlah + "')";
        //        Connection.JalankanPerintahDML(sql);
        //    }
        //}
        #endregion
    }
}
