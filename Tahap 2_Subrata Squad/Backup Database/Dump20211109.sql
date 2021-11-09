-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: online_mart
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.21-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `barangs`
--

DROP TABLE IF EXISTS `barangs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `barangs` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  `harga` varchar(45) DEFAULT NULL,
  `kategoris_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_barangs_kategoris_idx` (`kategoris_id`),
  CONSTRAINT `fk_barangs_kategoris` FOREIGN KEY (`kategoris_id`) REFERENCES `kategoris` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `barangs`
--

LOCK TABLES `barangs` WRITE;
/*!40000 ALTER TABLE `barangs` DISABLE KEYS */;
INSERT INTO `barangs` VALUES (1,'coki-coki','20000000',2),(2,'petelot','20000',1),(3,'samyang','10000',2),(4,'bolpen','20000',1),(5,'penghapus','20000',1),(6,'stipo','20000',1),(7,'Microwave','1000000',5),(8,'Soju','50000',3),(9,'Sasa','5000',4),(10,'laptop','10000000',5),(11,'Komputer','10000000',5);
/*!40000 ALTER TABLE `barangs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `barangs_orders`
--

DROP TABLE IF EXISTS `barangs_orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `barangs_orders` (
  `barangs_id` int(11) unsigned NOT NULL,
  `orders_id` int(11) unsigned NOT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `harga` float DEFAULT NULL,
  PRIMARY KEY (`barangs_id`,`orders_id`),
  KEY `fk_barangs_orders_orders1_idx` (`orders_id`),
  KEY `fk_barangs_orders_barangs1_idx` (`barangs_id`),
  CONSTRAINT `fk_barangs_orders_barangs` FOREIGN KEY (`barangs_id`) REFERENCES `barangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_barangs_orders_orders` FOREIGN KEY (`orders_id`) REFERENCES `orders` (`cabangs_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `barangs_orders`
--

LOCK TABLES `barangs_orders` WRITE;
/*!40000 ALTER TABLE `barangs_orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `barangs_orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cabangs`
--

DROP TABLE IF EXISTS `cabangs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cabangs` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  `alamat` varchar(45) DEFAULT NULL,
  `pegawais_id` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_cabangs_pewagais_idx` (`pegawais_id`),
  CONSTRAINT `fk_cabagns_pegawais` FOREIGN KEY (`pegawais_id`) REFERENCES `pegawais` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cabangs`
--

LOCK TABLES `cabangs` WRITE;
/*!40000 ALTER TABLE `cabangs` DISABLE KEYS */;
INSERT INTO `cabangs` VALUES (1,'Tenggilis','Jalan Tenggilis Utara 12',1),(2,'Rungkut','Jalan Kali Rungkut VI/12',2),(3,'Sidodadi','Jalan Sidodadi Baru 12',8),(4,'Kaliasin','Jalan Kaliasin Waron IV/12',7),(5,'Waru','Jalan Teknik V/112',6),(6,'Mulyerjo','Jalan Mulyorejo 12',6);
/*!40000 ALTER TABLE `cabangs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cabangs_barangs`
--

DROP TABLE IF EXISTS `cabangs_barangs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cabangs_barangs` (
  `barangs_id` int(11) unsigned NOT NULL,
  `cabangs_id` int(11) unsigned NOT NULL,
  `stok` int(11) DEFAULT NULL,
  PRIMARY KEY (`barangs_id`,`cabangs_id`),
  KEY `fk_cabangs_barangs_cabangs_idx` (`cabangs_id`),
  CONSTRAINT `fk_cabags_barangs_cabangs` FOREIGN KEY (`cabangs_id`) REFERENCES `cabangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_cabangs_barangs_barangs1` FOREIGN KEY (`barangs_id`) REFERENCES `barangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cabangs_barangs`
--

LOCK TABLES `cabangs_barangs` WRITE;
/*!40000 ALTER TABLE `cabangs_barangs` DISABLE KEYS */;
INSERT INTO `cabangs_barangs` VALUES (1,1,20),(1,3,10),(1,5,20),(3,1,20),(4,1,14),(8,3,15),(9,2,20),(11,1,10);
/*!40000 ALTER TABLE `cabangs_barangs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drivers`
--

DROP TABLE IF EXISTS `drivers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `drivers` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `telepon` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drivers`
--

LOCK TABLES `drivers` WRITE;
/*!40000 ALTER TABLE `drivers` DISABLE KEYS */;
INSERT INTO `drivers` VALUES (1,'alvin','alvin@gmail.com','162169d18ecfd9704f15916994becca7af85aeb7078bd43313d2c7c5f735ea62d7725a5906b27cccf6db67427ac30be52921522902ff037426133a764e84d924','086755787818'),(2,'subrata','subrata@gmail.com','7ba0947061f47b9f0ebcfcdb22d37e1ce30125366e7723f11aa165e7141fc7c92ea33af7d3ebe397b3a0c00f7e09a9203364ca2c39d232b9998197e83ac2bead','098709870987'),(3,'victor','victor@gmail.com','cf61275903fbbf194e443864390bda791207150d908a372d8233ae00ed62ebe495403f3c132b607c8828317374f74c8ba0f3aa8653705bced9acf2ad0dcaac6e','098909097878'),(4,'jeremy','jeremy@gmail.com','37ba886f20c70d559261fe1c58efd70f8b8f65cf68f567ab979b9ed96f65051545f6afb40a5ecbca7d7953f8bbecc5bfd7d6eea1f75ee66ca3e2bee97229f559','098765654545'),(5,'Roni','roni@gmail.com','da6701564323892419e7f28dbac818bb0fa48f7c1f7f12e8c8dfbf5a3f9aa4e24261b39cee2452e97b7ba5cd25e1dcf9599fe6ee682926e551ed4442cb4931a2','096756463636'),(11,'michael','michael@gmail.com','625a52f390b45d1f7df407dcce41551792bac1cea540bd17f6c9b1f26929afdce4dace0ec85e93894fae35cacd8633ebd857398494e9620cbc127208e0736503','0989866772');
/*!40000 ALTER TABLE `drivers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gift_redeems`
--

DROP TABLE IF EXISTS `gift_redeems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gift_redeems` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `waktu` datetime DEFAULT NULL,
  `poin_redeem` int(11) DEFAULT NULL,
  `gifts_id` int(11) NOT NULL,
  `orders_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_gift_redeems_gifts_idx` (`gifts_id`),
  KEY `fk_gift_redeems_orders_idx` (`orders_id`),
  CONSTRAINT `fk_gift_redeems_gifts` FOREIGN KEY (`gifts_id`) REFERENCES `gifts` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_gift_redeems_orders` FOREIGN KEY (`orders_id`) REFERENCES `orders` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gift_redeems`
--

LOCK TABLES `gift_redeems` WRITE;
/*!40000 ALTER TABLE `gift_redeems` DISABLE KEYS */;
/*!40000 ALTER TABLE `gift_redeems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gifts`
--

DROP TABLE IF EXISTS `gifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gifts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  `jumlah_poin` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gifts`
--

LOCK TABLES `gifts` WRITE;
/*!40000 ALTER TABLE `gifts` DISABLE KEYS */;
INSERT INTO `gifts` VALUES (2,'Boneka','10');
/*!40000 ALTER TABLE `gifts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kategoris`
--

DROP TABLE IF EXISTS `kategoris`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kategoris` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kategoris`
--

LOCK TABLES `kategoris` WRITE;
/*!40000 ALTER TABLE `kategoris` DISABLE KEYS */;
INSERT INTO `kategoris` VALUES (1,'Alat tulis'),(2,'Makanan'),(3,'Minuman'),(4,'Bumbu Masakan'),(5,'Elektronik'),(6,'Alat Makan'),(7,'Makanan keras');
/*!40000 ALTER TABLE `kategoris` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tanggal_waktu` datetime DEFAULT NULL,
  `alamat_tujuan` varchar(45) DEFAULT NULL,
  `ongkos_kirim` float DEFAULT NULL,
  `total_bayar` float DEFAULT NULL,
  `cara_bayar` varchar(45) DEFAULT NULL,
  `cabangs_id` int(11) unsigned NOT NULL,
  `drivers_id` int(11) unsigned NOT NULL,
  `pelanggans_id` int(11) unsigned NOT NULL,
  `promo_id` int(11) NOT NULL,
  `status` enum('Menunggu Pembayaran','Pesanan Diproses') DEFAULT NULL,
  `metode_pembayaran` enum('Ovo','ShopeePa') DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_orders_cabangs_idx` (`cabangs_id`),
  KEY `fk_orders_drivers1_idx` (`drivers_id`),
  KEY `fk_ortders_pelanggans_idx` (`pelanggans_id`),
  KEY `fk_orders_promos_idx` (`promo_id`),
  CONSTRAINT `fk_orders_cabangs` FOREIGN KEY (`cabangs_id`) REFERENCES `cabangs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_orders_drivers1` FOREIGN KEY (`drivers_id`) REFERENCES `drivers` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_orders_pelanggans` FOREIGN KEY (`pelanggans_id`) REFERENCES `pelanggans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_orders_promos` FOREIGN KEY (`promo_id`) REFERENCES `promos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2021-09-01 12:09:01','jl. Diponegoro',20000,50000,'Cash',1,1,1,1,'Menunggu Pembayaran','Ovo');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pegawais`
--

DROP TABLE IF EXISTS `pegawais`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pegawais` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `telepon` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pegawais`
--

LOCK TABLES `pegawais` WRITE;
/*!40000 ALTER TABLE `pegawais` DISABLE KEYS */;
INSERT INTO `pegawais` VALUES (1,'admin','admin@gmail.com','c7ad44cbad762a5da0a452f9e854fdc1e0e7a52a38015','085102104'),(2,'admin12','admin12@gmail.com','c7ad44cbad762a5da0a452f9e854fdc1e0e7a52a38015f23f3eab1d80b931dd472634dfac71cd34ebc35d16ab7fb8a90c81f975113d6c7538dc69dd8de9077ec','085102104'),(6,'tiotio','tiotio@gmail.com','b9c133877bc4a26666974feac3ca1d8d5dd36b8c67fdb86a5e5479fde88e0ea3cfd8d73dde5332b8efb2cf133c6c71a017d3baebbdd13e6001e706a70bb418b8','098765432112'),(7,'michael','michael@gmail.com','625a52f390b45d1f7df407dcce41551792bac1cea540bd17f6c9b1f26929afdce4dace0ec85e93894fae35cacd8633ebd857398494e9620cbc127208e0736503','098990908767'),(8,'Sanjaya','sanjaya@gmail.com','9ccd7eac50c4b36a60e9c2c65170a6e20d33dce09defcef035160365bdc8e66bc18cdd94184b19e46f5ce5c2c9caceb5055ff5d061f9fc37686344a979207424','086757578909'),(9,'kelena','kelena@gmail.com','49a84c56a23a7ce2c0faa42fc81da3f27d03049a7f6758f80787cf8c3379b1322d71e7614ff679226dc675c43e80df3fbddfe21609f11d32f8835d7626af6847','098988776655'),(10,'kelven','kelven@gmail.com','4cc16d298635bef3ecca89b3cb29f91b1d7a156dfbab4452394fc310404476948c601e36b24fad70f9366635e318e4a883d55e84139d27f9017048be4b23ac82','0909889876');
/*!40000 ALTER TABLE `pegawais` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pelanggans`
--

DROP TABLE IF EXISTS `pelanggans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pelanggans` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `nama` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(128) NOT NULL,
  `telepon` varchar(45) DEFAULT NULL,
  `saldo` float DEFAULT NULL,
  `poin` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pelanggans`
--

LOCK TABLES `pelanggans` WRITE;
/*!40000 ALTER TABLE `pelanggans` DISABLE KEYS */;
INSERT INTO `pelanggans` VALUES (1,'Cella','cel@gmail.com','52b8532a44b6e26049e12fa7ca6ab5fcfc36715d6d53f6cf8333858c41727496df3563488dbcc88353348f269aa918aa0b5fefc07b13ab25b318d46910ce54dd','081289098765',0,0),(2,'Velicia','vels@gmail.com','62f4fc2f98ef358e7515dad7c0557ab10311ab608739f11d42363ba40c54b0e5e6a3f63bf8fc3e6c807737132b7973d595bf4e1239ae930cd7543ccd0ed22411','081234567890',0,0),(3,'Junita','jun@gmail.com','f2b823e4a0ad2b06ba841de2dd27a5fd4fd226dd07cf9cf6189071c3c45af9ddf013523f9e79f6d21c5ce0cde3010dc4603c22c44d2d4aef451583360f7bc5be','089180676564',0,0),(4,'Kevin','kev@gmail.com','73cba74c46bfb8e5bfb6b4b53e1ebbadcccba18e3ece04af8f80bfccb94e42666bd1217a3ec4955d3c78c24dfb7dbea3d2933f3dacaccfd2cb892c1f10bad3d6','081235276565',0,0),(5,'Alicia','alc@gmail.com','7a178967cad357711590fff07c308799e2ed57df7d5eb79b37624f9b0d82bafa16f883384d06b126980609d9960c49c91cf41e5260224ff7e0014e6d789f9bd5','08573345456768',0,0),(6,'albertus f','albertusf@gmail.com','d08928f1b08cc10152363550de3472690dcf47815c84422e719a762e6466bdb91f244aaa30006c6b16abddb43280874b9f345f45d559cb1601bcd51abdbc0352','098765432112',0,0),(7,'jericho j','jerichoj@gmail.com','04821f35016cc36e4c94fdc257c04d4e98f7a1694148869b46577de26c6c55eb7ddf49d0918b789ab56c11bc8f601612b9f497f7394e638a4583d22b8e9166c2','09876556789',0,0),(8,'kelvin f','kelvinf@gmail.com','78eb8e0a991a98eeae12dd96d5c674769045794e5347e06c05a94f603786914f64a9d29e430c1118ccf1b6a998e5c67237b6fc101ff23f1c8b829b8ad3d810e3','0989890976',0,0),(9,'cella j','cellaj@gmail.com','270df2dc1df40bc22786ef9898dad1270a07314e9c5ef91a630536fe8a5632daa875d3b178b4a43aac84926ef542232c38fa8b65e1636805cf588ed3027eb114','099090889',0,0);
/*!40000 ALTER TABLE `pelanggans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pemasukkan`
--

DROP TABLE IF EXISTS `pemasukkan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pemasukkan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tanggal` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pemasukkan`
--

LOCK TABLES `pemasukkan` WRITE;
/*!40000 ALTER TABLE `pemasukkan` DISABLE KEYS */;
/*!40000 ALTER TABLE `pemasukkan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `promos`
--

DROP TABLE IF EXISTS `promos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `promos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tipe` varchar(45) DEFAULT NULL,
  `nama` varchar(45) DEFAULT NULL,
  `diskon` int(11) DEFAULT NULL,
  `diskon_max` int(11) DEFAULT NULL,
  `minimal_belanja` float DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `promos`
--

LOCK TABLES `promos` WRITE;
/*!40000 ALTER TABLE `promos` DISABLE KEYS */;
INSERT INTO `promos` VALUES (1,'Ongkir','Over Diskon',10,10000,50000),(2,'Makanan','Big Deal',50,25000,80000);
/*!40000 ALTER TABLE `promos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `riwayat_isi_saldos`
--

DROP TABLE IF EXISTS `riwayat_isi_saldos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `riwayat_isi_saldos` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `waktu` datetime DEFAULT NULL,
  `isi_saldo` int(11) DEFAULT NULL,
  `pelanggans_id` int(11) unsigned NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_riwayat_isi_saldo_pelanggans_idx` (`pelanggans_id`),
  CONSTRAINT `fk_riwayat_isi_saldo_pelanggans` FOREIGN KEY (`pelanggans_id`) REFERENCES `pelanggans` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `riwayat_isi_saldos`
--

LOCK TABLES `riwayat_isi_saldos` WRITE;
/*!40000 ALTER TABLE `riwayat_isi_saldos` DISABLE KEYS */;
/*!40000 ALTER TABLE `riwayat_isi_saldos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-09 21:41:59
