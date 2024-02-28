-- MySQL dump 10.13  Distrib 5.7.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: nusoft_system
-- ------------------------------------------------------
-- Server version	5.7.29-log

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
-- Table structure for table `a_source`
--

DROP TABLE IF EXISTS `a_source`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `a_source` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(3) NOT NULL,
  `d_note` varchar(50) NOT NULL,
  `d_link` tinyint(1) DEFAULT NULL,
  `x_module` int(11) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code_asource` (`u_code`,`x_module`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `a_source`
--

LOCK TABLES `a_source` WRITE;
/*!40000 ALTER TABLE `a_source` DISABLE KEYS */;
INSERT INTO `a_source` VALUES (1,'KM','Bukti Kas Masuk',NULL,651410569),(2,'KK','Bukti Kas Keluar',NULL,651410569),(3,'BM','Bukti Bank Masuk',NULL,651410569),(4,'BK','Bukti Bank Keluar',NULL,651410569),(5,'JU','Jurnal Umum',NULL,651410569),(6,'JA','Jurnal Adjustment',NULL,651410569),(7,'LA','Load Administration',NULL,651410569),(8,'RV','Revaluasi Valas',NULL,651410569),(9,'SA','Saldo Awal',NULL,651410569),(10,'PD','Pengajuan Dana',NULL,651410569),(11,'FA','Fixet Asset',NULL,651410569),(12,'PB','Permintaan Barang',NULL,1454983174),(13,'ST','Mutasi Stock',NULL,1454983174),(14,'PS','Penyesuaian Stock',NULL,1454983174),(15,'AM','Produksi',NULL,1454983174),(16,'OS','Stock Opname',NULL,1454983174),(17,'BS','Saldo Awal Stock',NULL,1454983174),(18,'PR','Permintaan Pembelian',NULL,566130832),(19,'RQ','Permintaan Penawaran',NULL,566130832),(20,'PO','Order Pembelian',NULL,566130832),(21,'AP','Uang Muka Pembelian',NULL,566130832),(22,'GR','Penerimaan Stock',NULL,566130832),(23,'RI','Penerimaan Invoice Pembelian',NULL,566130832),(24,'VP','Pembayaran Hutang',NULL,566130832),(25,'DN','Pengiriman Barang Retur',NULL,566130832),(26,'PN','Retur Pembelian',NULL,566130832),(27,'SQ','Penawaran Penjualan',NULL,-1195955926),(28,'SO','Order Penjualan',NULL,-1195955926),(29,'DP','Uang Muka Penjualan',NULL,-1195955926),(30,'SJ','Surat Jalan',NULL,-1195955926),(31,'IV','Invoice Penjualan',NULL,-1195955926),(32,'CP','Penerimaan Pembayaran Penjualan',NULL,-1195955926),(33,'RN','Penerimaan Retur Penjualan',NULL,-1195955926),(34,'SR','Retur Penjualan',NULL,-1195955926);
/*!40000 ALTER TABLE `a_source` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `datalog_amain`
--

DROP TABLE IF EXISTS `datalog_amain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `datalog_amain` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `d_date` datetime NOT NULL,
  `d_user` varchar(100) NOT NULL,
  `d_kind` tinyint(1) unsigned NOT NULL COMMENT '0:Tambah, 1:Edit, 2:Delete, 3:Ekspor, 4:Print',
  `d_activity` varchar(100) NOT NULL,
  `d_useragent` varchar(255) NOT NULL,
  `d_userhostaddress` varchar(100) NOT NULL,
  `d_userhostname` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datalog_amain`
--

LOCK TABLES `datalog_amain` WRITE;
/*!40000 ALTER TABLE `datalog_amain` DISABLE KEYS */;
/*!40000 ALTER TABLE `datalog_amain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `datalog_bdetail`
--

DROP TABLE IF EXISTS `datalog_bdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `datalog_bdetail` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `f_main` bigint(20) unsigned NOT NULL,
  `property_name` varchar(100) NOT NULL,
  `value_old` text NOT NULL,
  `value_new` text NOT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_datalogbdetail_main` (`f_main`),
  CONSTRAINT `FK_datalog_bdetail_datalog_amain` FOREIGN KEY (`f_main`) REFERENCES `datalog_amain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datalog_bdetail`
--

LOCK TABLES `datalog_bdetail` WRITE;
/*!40000 ALTER TABLE `datalog_bdetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `datalog_bdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dblist`
--

DROP TABLE IF EXISTS `dblist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dblist` (
  `p_id` smallint(5) unsigned NOT NULL,
  `u_code` varchar(50) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_dbname` varchar(30) NOT NULL,
  `d_active` tinyint(1) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`),
  UNIQUE KEY `db` (`d_dbname`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel dibuat untuk mendata nama database tiap perusahaan.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dblist`
--

LOCK TABLES `dblist` WRITE;
/*!40000 ALTER TABLE `dblist` DISABLE KEYS */;
INSERT INTO `dblist` VALUES (1,'Nusoft','nusoft_x01','nusoft_x01',1,'2014-06-20 09:30:57','Jali','2016-04-20 15:32:58','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `dblist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `keypages`
--

DROP TABLE IF EXISTS `keypages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `keypages` (
  `unique_form` varchar(255) NOT NULL,
  `unique_rgnl` varchar(3) NOT NULL,
  PRIMARY KEY (`unique_form`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `keypages`
--

LOCK TABLES `keypages` WRITE;
/*!40000 ALTER TABLE `keypages` DISABLE KEYS */;
INSERT INTO `keypages` VALUES ('a6b755df708a3768d05694158ec9b5e2e1f994bdc5de121af65d736d3899d618714334f599ebed83ea3c835271f4402f615b9213b518639a1d58cfba96d969da','JKT');
/*!40000 ALTER TABLE `keypages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menulist`
--

DROP TABLE IF EXISTS `menulist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menulist` (
  `p_id` smallint(5) unsigned NOT NULL,
  `f_module` smallint(6) NOT NULL,
  `u_code` varchar(20) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_parent` smallint(5) unsigned DEFAULT NULL,
  `d_active` tinyint(1) NOT NULL DEFAULT '0',
  `d_order` smallint(5) unsigned NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_module`,`u_code`),
  KEY `fk_menulist_modulelist` (`f_module`),
  KEY `fk_menulist_parent` (`d_parent`),
  CONSTRAINT `FK_menulist_modulelist` FOREIGN KEY (`f_module`) REFERENCES `modulelist` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel dibuat untuk mendata menu program.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menulist`
--

LOCK TABLES `menulist` WRITE;
/*!40000 ALTER TABLE `menulist` DISABLE KEYS */;
INSERT INTO `menulist` VALUES (1,0,'00','NuSoftModSys',NULL,1,0,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(2,0,'0001','Regional',1,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(3,0,'0002','Divisi',1,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(4,0,'0003','Setting Perusahaan',1,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(1000,1,'01','Financial Management',NULL,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(1100,1,'0101','Transaksi',1000,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(1110,1,'0101.01','Pengajuan Dana (PD)',1100,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(1120,1,'0101.02','Finance',1100,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1121,1,'0101.02.01','Pre Payment (PP)',1120,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1122,1,'0101.02.02','Kas Masuk (KM)',1120,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1123,1,'0101.02.03','Kas Keluar (KK)',1120,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1124,1,'0101.02.04','Bank Masuk (BM)',1120,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1125,1,'0101.02.05','Bank Keluar (BK)',1120,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1126,1,'0101.02.06','Cash Opname (CO)',1120,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1127,1,'0101.02.07','Loan Administration (LA)',1120,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1128,1,'0101.02.08','Administrasi Giro',1120,1,8,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1129,1,'0101.02.09','Rekonsiliasi Bank',1120,1,9,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1130,1,'0101.03','Accounting',1100,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1131,1,'0101.03.01','Jurnal Umum (JU)',1130,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1132,1,'0101.03.02','Jurnal Adjusment (JA)',1130,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1133,1,'0101.03.03','Revaluasi Valuta Asing (RV)',1130,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1134,1,'0101.03.04','Prepaid Expense',1130,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1135,1,'0101.03.05','Aktiva Tetap',1130,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1136,1,'0101.03.06','Saldo Awal COA',1130,1,6,'2015-05-07 06:06:10','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1140,1,'0101.04','Budget Control',1100,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1141,1,'0101.04.01','Master Budget (BG)',1140,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1150,1,'0101.05','Tax Management',1100,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1151,1,'0101.05.01','Eksport e-Faktur',1150,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1152,1,'0101.05.02','Update Bukti Potong PPh 23',1150,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1153,1,'0101.05.03','Cetak Bukti Potong PPh 23',1150,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1196,1,'0101.96','Bukti Pemasukan',1100,0,96,'2015-07-10 14:07:21','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1197,1,'0101.97','Bukti Pengeluaran',1100,0,97,'2015-07-10 06:37:58','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1198,1,'0101.98','Memo',1100,0,98,'2015-07-10 06:37:58','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1200,1,'0102','Data-Data',1000,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1201,1,'0102.01','Transaksi - GL',1200,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1202,1,'0102.02','Buku Besar',1200,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1203,1,'0102.03','Saldo Piutang',1200,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1204,1,'0102.04','Saldo Hutang',1200,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1205,1,'0102.05','Statistik Keuangan',1200,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1206,1,'0102.06','Prediksi Kas & Bank',1200,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1207,1,'0102.07','Rasio Keuangan',1200,0,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1300,1,'0103','Master Data',1000,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1301,1,'0103.01','Chart Of Account',1300,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1302,1,'0103.02','Kontak',1300,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1303,1,'0103.03','Kategori Kontak',1300,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1304,1,'0103.04','Mata Uang',1300,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1305,1,'0103.05','Bank',1300,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1306,1,'0103.06','Proyek',1300,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1307,1,'0103.07','Kelompok Aktiva Tetap',1300,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1308,1,'0103.08','Aktiva Tetap',1300,1,8,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1309,1,'0103.09','Sub Proyek',1300,1,6,'2015-07-20 03:08:51','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1900,1,'0199','Setting',1000,1,99,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1910,1,'0199.01','GL',1900,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1920,1,'0199.02','Custom Report',1900,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1921,1,'0199.02.01','Neraca',1920,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1922,1,'0199.02.02','Laba Rugi',1920,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1923,1,'0199.02.03','HPP',1920,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(1924,1,'0199.02.04','Cash Flow',1920,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4001,4,'01','Inventory & Warehouse',NULL,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4002,4,'0101','Transaksi',4001,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4003,4,'0101.01','Permintaan Barang',4002,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4004,4,'0101.02','Mutasi Stock',4002,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4005,4,'0101.03','Pemakaian Barang',4002,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4006,4,'0101.04','Penyesuaian Stock',4002,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4007,4,'0101.05','Produksi (Assembly/Disassembly)x',4002,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4008,4,'0101.06','Stock Opname',4002,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4009,4,'0101.07','Posting Stock Opname',4002,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4010,4,'0101.08','Saldo Awal Stock',4002,1,8,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4200,4,'0102','Data-Data',4001,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4201,4,'0102.01','Cek Stock',4200,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4202,4,'0102.02','Statistik dan Analisa Data',4200,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4300,4,'0103','Master Data',4001,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4301,4,'0103.01','Tipe Transaksi',4300,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4302,4,'0103.02','Satuan',4300,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4303,4,'0103.03','Gudang',4300,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4304,4,'0103.04','Pajak',4300,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4305,4,'0103.05','Item',4300,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4306,4,'0103.06','Kontak',4300,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4307,4,'0103.07','Biaya Lain',4300,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4308,4,'0103.08','Kategori',4300,1,8,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4309,4,'0103.09','Sub Kategori',4300,1,9,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4310,4,'0103.10','Merek',4300,1,10,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4400,4,'0104','Seting',4001,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4401,4,'0104.01','Seting Inventory',4400,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(4402,4,'0104.02','Seting Item',4400,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5001,5,'01','Purchasing',NULL,0,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5100,5,'0101','Transaksi',5001,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5101,5,'0101.01','Permintaan Pembelian [PB]',5100,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5102,5,'0101.02','Permintaan Penawaran [RQ]',5100,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5103,5,'0101.03','Order Pembelian [PO]',5100,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5104,5,'0101.04','DP Pembelian [AP]',5100,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5105,5,'0101.05','Penerimaan Barang [GR]',5100,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5106,5,'0101.06','Penerimaan Invoice [RI]',5100,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5107,5,'0101.07','Pembayaran Invoice [VP]',5100,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5108,5,'0101.08','Saldo Awal hutang',5100,1,8,'2015-05-20 18:57:10','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5200,5,'0102','Data-Data',5001,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5201,5,'0102.01','Cek Status Transaksi',5200,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5202,5,'0102.02','Saldo Hutang',5200,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:21','NuSoft - NuSoft Administrator'),(5203,5,'0102.03','Umur Hutang',5200,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5204,5,'0102.04','Statistik dan Analisa Data',5200,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5300,5,'0103','Master Data',5001,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5301,5,'0103.01','Termin',5300,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5302,5,'0103.02','Satuan',5300,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5303,5,'0103.03','Gudang',5300,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5304,5,'0103.04','Pajak',5300,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5305,5,'0103.05','Item',5300,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5306,5,'0103.06','Kontak',5300,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5307,5,'0103.07','Via',5300,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5400,5,'0104','Seting',5001,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(5401,5,'0104.01','Seting Purchase',5400,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6001,6,'01','Sales & Distribution',NULL,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6100,6,'0101','Transaksi',6001,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6101,6,'0101.01','Penawaran Penjualan [SQ]',6100,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6102,6,'0101.02','Order Penjualan [SO]',6100,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6103,6,'0101.03','DP Penjualan [DP]',6100,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6104,6,'0101.04','Pengiriman Order [SJ]',6100,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:20','NuSoft - NuSoft Administrator'),(6105,6,'0101.05','Invoice Penjualan [IV]',6100,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6106,6,'0101.06','Penerimaan Pembayaran [CP]',6100,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6107,6,'0101.07','Saldo Awal Piutang',6100,1,7,'2015-05-22 10:36:12','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6108,6,'0101.08','Penerimaan Retur',6100,0,8,'2015-05-29 13:33:30','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6109,6,'0101.09','Retur Penjualan',6100,0,9,'2015-05-29 13:33:30','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6110,6,'0101.10','POS',6100,1,10,'2015-05-29 13:33:30','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6200,6,'0102','Data-Data',6001,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6201,6,'0102.01','Cek Status Data',6200,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6202,6,'0102.02','Saldo Piutang',6200,1,2,'2015-05-22 10:35:16','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6203,6,'0102.03','Umur Piutang',6200,1,3,'2015-05-22 10:35:16','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6204,6,'0102.04','Statistik dan Analisa Data',6200,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6300,6,'0103','Master Data',6001,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6301,6,'0103.01','Termin',6300,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6302,6,'0103.02','Satuan',6300,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6303,6,'0103.03','Gudang',6300,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6304,6,'0103.04','Pajak',6300,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6305,6,'0103.05','Item',6300,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6306,6,'0103.06','Kontak',6300,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6400,6,'0104','Seting',6001,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(6401,6,'0104.01','Seting Sales',6400,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8000,8,'01','Master Data',NULL,1,8,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8300,8,'0108','Master Data',8000,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8301,8,'0108.01','Mata Uang',8300,1,1,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8302,8,'0108.02','Bank',8300,1,2,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8303,8,'0108.03','Chart Of Account (COA/Akun)',8300,1,3,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8304,8,'0108.04','Kategori Kontak',8300,1,4,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8305,8,'0108.05','Kontak',8300,1,5,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8306,8,'0108.06','Kelompok Aktiva Tetap',8300,1,6,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8307,8,'0108.07','Aktiva Tetap',8300,1,7,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8308,8,'0108.08','Divisi',8300,1,8,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8309,8,'0108.09','Proyek',8300,1,9,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8310,8,'0108.10','Tipe Transaksi',8300,1,10,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8311,8,'0108.11','Satuan',8300,1,11,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8312,8,'0108.12','Gudang',8300,1,12,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8313,8,'0108.13','Pajak',8300,1,13,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8314,8,'0108.14','Barang & Jasa',8300,1,14,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8315,8,'0108.15','Biaya Lain-Lain',8300,1,15,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8316,8,'0108.16','Kategori',8300,1,16,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8317,8,'0108.17','Sub Kategori',8300,1,17,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8318,8,'0108.18','Merek',8300,1,18,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8319,8,'0108.19','Termin',8300,1,19,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8320,8,'0108.20','Via',8300,1,20,'2013-06-16 22:17:13','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8321,8,'0108.21','Proyek Sub',8300,1,21,'2015-08-27 19:55:03','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator'),(8322,8,'0108.22','Akun z',8300,0,22,'2015-08-27 19:55:03','NuSoft - NuSoft Administrator','2016-01-08 19:23:22','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `menulist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modulelist`
--

DROP TABLE IF EXISTS `modulelist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modulelist` (
  `p_id` smallint(6) NOT NULL DEFAULT '0',
  `u_code` varchar(30) NOT NULL,
  `d_name` varchar(30) DEFAULT NULL,
  `d_description` varchar(150) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata modules.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modulelist`
--

LOCK TABLES `modulelist` WRITE;
/*!40000 ALTER TABLE `modulelist` DISABLE KEYS */;
INSERT INTO `modulelist` VALUES (0,'NuSoftModSys','NuSoft System Module',NULL,'2013-06-16 22:14:54','NuSoft - NuSoft Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator'),(1,'NuSoft001','Financial Management',NULL,'2013-06-15 07:58:07','SyBiru - SyBiru Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator'),(4,'NuSoft004','Inventory',NULL,'2014-03-11 18:40:15','NuSoft - NuSoft Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator'),(5,'NuSoft005','Procurement',NULL,'2014-03-11 18:40:15','NuSoft - NuSoft Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator'),(6,'NuSoft006','Sales',NULL,'2014-03-11 18:40:15','NuSoft - NuSoft Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator'),(7,'NuSoft007','Production',NULL,'2014-10-15 18:43:37','NuSoft - NuSoft Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator'),(8,'NuSoft008','Master Data',NULL,'2015-08-27 11:22:44','NuSoft - NuSoft Administrator','2015-08-31 05:10:37','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `modulelist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `npolog`
--

DROP TABLE IF EXISTS `npolog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `npolog` (
  `Id` bigint(20) unsigned NOT NULL,
  `ServerDate` datetime NOT NULL,
  `TableName` varchar(64) DEFAULT NULL,
  `RowId` bigint(20) unsigned DEFAULT NULL,
  `Changes` text NOT NULL,
  `User` varchar(100) NOT NULL,
  `Action` tinyint(2) NOT NULL COMMENT '0:Tambah, 1:Edit, 2:Delete, 3:Ekspor, 4:Print, 5:Info, 6:Error, 7:Warning',
  `UIAgent` varchar(255) NOT NULL,
  `HostAddress` varchar(100) NOT NULL,
  `HostName` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `logging_table_idx` (`TableName`),
  KEY `logging_row_idx` (`RowId`),
  KEY `logging_jenis_idx` (`Action`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `npolog`
--

LOCK TABLES `npolog` WRITE;
/*!40000 ALTER TABLE `npolog` DISABLE KEYS */;
INSERT INTO `npolog` VALUES (96233420425789441,'2015-08-30 20:45:57','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789442,'2015-08-30 20:46:03','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789443,'2015-08-30 20:46:08','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789444,'2015-08-30 20:46:48','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789445,'2015-08-30 20:47:02','',0,'Login Success user \'admin\'','admin',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789446,'2015-08-30 20:47:32','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789447,'2015-08-30 20:47:47','',0,'Login Success user \'admin\'','admin',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789448,'2015-08-30 20:49:04','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789449,'2015-08-31 04:01:54','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789450,'2015-08-31 05:46:15','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789451,'2015-08-31 05:46:21','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789452,'2015-08-31 07:04:14','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789453,'2015-08-31 07:25:27','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789454,'2015-08-31 14:04:12','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789455,'2015-08-31 14:26:42','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789465,'2015-08-31 15:49:08','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96233420425789473,'2015-08-31 16:18:20','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96234843905458176,'2015-08-31 20:00:43','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96234843905458177,'2015-09-01 15:09:45','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96234843905458178,'2015-09-01 15:10:49','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96234843905458179,'2015-09-01 20:09:04','',0,'User Id \'root\' tidak ditemukan ','root',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96234843905458180,'2015-09-01 20:09:14','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96234843905458181,'2015-09-01 20:09:36','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96240490495606784,'2015-09-04 19:12:40','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96240490495606785,'2015-09-04 22:12:01','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96240490495606786,'2015-09-04 22:59:26','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/44.0.2403.157 Safari/537.36','::1','::1'),(96240490495606787,'2015-09-05 01:28:36','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606788,'2015-09-05 05:21:30','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606790,'2015-09-05 05:58:24','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606791,'2015-09-05 05:59:48','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606793,'2015-09-05 08:47:42','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606794,'2015-09-05 08:48:20','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','192.168.0.101','192.168.0.101'),(96240490495606797,'2015-09-05 08:50:28','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','192.168.0.101','192.168.0.101'),(96240490495606799,'2015-09-05 09:08:01','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606800,'2015-09-05 16:46:36','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606801,'2015-09-05 18:32:29','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606802,'2015-09-05 18:37:38','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606803,'2015-09-06 06:14:49','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96240490495606804,'2015-09-06 09:51:42','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001216,'2015-09-08 12:59:28','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001217,'2015-09-08 14:16:55','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001218,'2015-09-08 15:16:44','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001219,'2015-09-09 05:14:28','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001227,'2015-09-09 07:17:53','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001232,'2015-09-09 08:28:51','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001233,'2015-09-09 15:04:31','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96244779205001236,'2015-09-09 15:07:46','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761664,'2015-09-10 10:23:22','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761665,'2015-09-10 10:23:27','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761666,'2015-09-10 10:23:31','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761667,'2015-09-10 10:23:35','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761668,'2015-09-10 10:24:05','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761669,'2015-09-10 10:24:06','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761670,'2015-09-10 10:24:07','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761671,'2015-09-10 10:24:07','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761672,'2015-09-10 10:24:07','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761673,'2015-09-10 10:24:08','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761674,'2015-09-10 10:24:08','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761675,'2015-09-10 10:24:08','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761676,'2015-09-10 10:24:08','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761677,'2015-09-10 10:25:00','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761678,'2015-09-10 10:25:01','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761679,'2015-09-10 10:25:02','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761680,'2015-09-10 10:25:19','',0,'Password untuk Id \'admin\' salah','admin',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761681,'2015-09-10 10:26:41','',0,'Password anda salah','nusoft',6,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248678699761682,'2015-09-10 10:29:19','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248997047435264,'2015-09-10 15:39:46','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1'),(96248997047435269,'2015-09-10 18:17:36','',0,'Login Success user \'nusoft\'','nusoft',5,'Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.85 Safari/537.36','::1','::1');
/*!40000 ALTER TABLE `npolog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reportlist`
--

DROP TABLE IF EXISTS `reportlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reportlist` (
  `p_id` smallint(5) unsigned NOT NULL,
  `f_module` smallint(6) NOT NULL,
  `u_code` varchar(20) NOT NULL,
  `d_name` varchar(100) NOT NULL,
  `d_parent` smallint(5) unsigned DEFAULT NULL,
  `d_filename` varchar(100) DEFAULT NULL,
  `d_active` tinyint(1) NOT NULL DEFAULT '0',
  `d_order` smallint(5) unsigned NOT NULL DEFAULT '0',
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`),
  KEY `reportlist_moduleslist` (`f_module`),
  KEY `reportlist_parent` (`d_parent`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel ini dibuat untuk mendata menu laporan.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reportlist`
--

LOCK TABLES `reportlist` WRITE;
/*!40000 ALTER TABLE `reportlist` DISABLE KEYS */;
INSERT INTO `reportlist` VALUES (1001,1,'1','Financial Management',NULL,NULL,1,1,NULL,'2010-11-02 20:51:17','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1002,1,'101','Voucher',1001,NULL,1,1,NULL,'2010-11-12 22:50:40','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1003,1,'10101','Bukti Kas Masuk',1002,'01BuktiKM.repx',1,1,NULL,'2010-11-12 22:50:40','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1004,1,'10102','Bukti Kas Keluar',1002,'01BuktiKK.repx',1,1,NULL,'2010-11-12 22:50:40','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1005,1,'10103','Bukti Bank Masuk',1002,'01BuktiBM.repx',1,3,NULL,'2010-11-12 22:50:40','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1006,1,'10104','Bukti Bank Keluar',1002,'01BuktiBK.repx',1,4,NULL,'2010-11-12 22:50:40','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1007,1,'10105','Bukti Jurnal Umum',1002,'01BuktiJU.repx',1,5,NULL,'2010-12-29 12:38:54','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1008,1,'10106','Jurnal Adjustment',1002,'01BuktiJA.repx',1,6,NULL,'2010-11-12 23:07:49','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1009,1,'10107','Pengajuan Dana',1002,'01BuktiPD.repx',1,7,NULL,'2010-11-12 23:08:46','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1010,1,'10108','Pencairan Giro',1002,'01BuktiPG.repx',1,8,NULL,'2010-11-12 23:08:46','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1011,1,'10109','Jurnal Voucher',1002,'01BuktiVoucher.repx',1,9,NULL,'2015-05-15 08:46:17','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1200,1,'102','Budget',1001,'',0,2,NULL,'2010-11-12 23:08:46','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1210,1,'10201','Budget vs Realisasi',1200,'01BudgetRealisasi.repx',0,1,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1300,1,'103','General Ledger',1001,'',1,3,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1310,1,'10301','Buku Besar (GL)',1300,'01GLBukuBesar.repx',1,1,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1320,1,'10302','Buku Besar Valas',1300,'01GLBukuBesarValas.repx',1,2,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1330,1,'10303','Buku Besar (GL)',1300,'01GLBukuBesarBebas.repx',1,3,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1340,1,'10304','Buku Besar Bank',1300,'01GLBukuBesarBank.repx',1,4,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1350,1,'10305','Jurnal Transaksi Harian',1300,'01GLJurnalTransaksi.repx',1,5,NULL,'2010-12-15 01:34:37','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1360,1,'10306','Cek / Giro',1300,'',1,6,NULL,'2010-12-15 00:44:14','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1361,1,'1030601','Daftar Cek / Giro',1360,'01GLCGDaftar.repx',1,1,NULL,'2010-12-15 00:44:14','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1362,1,'1030602','Umur Cek / Giro',1360,'01GLCGUmur.repx',1,2,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1370,1,'10307','Hutang / Piutang',1300,'',1,7,NULL,'2010-11-12 23:06:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1371,1,'1030701','Daftar Saldo Hutang',1370,'01GLHPDaftarH.repx',1,1,NULL,'2010-12-16 08:43:30','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1372,1,'1030702','Daftar Saldo Piutang',1370,'01GLHPDaftarP.repx',1,2,NULL,'2010-12-16 10:09:22','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1373,1,'1030703','Saldo Hutang Per Rekening Per Kontak (Detail)',1370,'01GLHPDaftarHCoa.repx',1,3,NULL,'2011-02-10 17:59:41','SyBiru - SyBiru Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1376,1,'1030704','Saldo Piutang Per Rekening Per Kontak (Detail)',1370,'01GLHPDaftarPCoa.repx',1,4,NULL,'2014-11-15 08:59:03','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1400,1,'104','Financial',1001,NULL,1,4,NULL,'2013-11-12 00:34:11','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1401,1,'10401','Neraca Saldo  Custom',1450,'01FNeracaSaldo.repx',1,1,NULL,'2013-11-12 00:35:13','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1402,1,'10402','Neraca Lajur',1400,'01FNeracaLajur.repx',1,2,NULL,'2013-11-12 00:35:13','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1403,1,'10403','Neraca Custom',1450,'01FNeraca.repx',1,3,NULL,'2013-11-12 00:36:10','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1404,1,'10404','Lampiran Neraca Custom',1450,'01FNeracaLampiran.repx',1,4,NULL,'2013-11-12 00:36:10','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1405,1,'10405','Neraca Perbandingan',1450,'01FNeracaPerbandingan.repx',0,5,NULL,'2013-11-12 00:38:04','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1406,1,'10406','Laba Rugi',1450,'01FLabaRugi.repx',1,6,NULL,'2013-11-12 00:38:04','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1407,1,'10407','Lampiran Laba Rugi',1450,'01FLabaRugiLampiran.repx',1,7,NULL,'2013-11-12 00:38:04','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1408,1,'10408','Laba Rugi Summary',1400,'01LabaRugiCoaSummary.repx',1,21,NULL,'2013-11-12 00:39:31','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1409,1,'10409','Laba Rugi 1 Tahun',1400,'01FLabaRugiTahun.repx',0,9,NULL,'2013-11-12 00:39:31','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1410,1,'10410','Perubahan Modal',1400,'01FModal.repx',0,10,NULL,'2013-11-12 00:41:13','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1411,1,'10411','HPP',1450,'01FHPP.repx',0,11,NULL,'2013-11-12 00:41:13','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1412,1,'10412','Lampiran HPP',1450,'01FHPPLampiran.repx',0,12,NULL,'2013-11-12 00:41:13','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1413,1,'10413','Cash Flow (Bulanan)',1450,'01FCFBulan.repx',0,13,NULL,'2013-11-12 00:44:35','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1414,1,'10414','Lampiran Cash FLow (Bulanan)',1450,'01FCFBulanLampiran.repx',0,14,NULL,'2013-11-12 00:44:35','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1415,1,'10415','Cash Flow (Triwulan)',1450,'01FCFTriwulan.repx',0,15,NULL,'2013-11-12 00:44:35','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1416,1,'10416','Lampiran Cash Flow (Triwulan)',1450,'01FCFTriwulanLampiran.repx',0,16,NULL,'2013-11-12 00:44:35','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1417,1,'10417','Rincian Cash Flow',1400,'01FCFRincian.repx',0,17,NULL,'2013-11-12 00:44:35','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1418,1,'10418','Neraca',1400,'01NeracaCoa.repx',1,18,NULL,'2014-11-05 20:08:06','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1419,1,'10419','Laba Rugi',1400,'01LabaRugiCoa.repx',1,19,NULL,'2014-11-07 08:41:53','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1420,1,'10420','Neraca Saldo',1400,'01NeracaSaldoCoa.repx',1,20,NULL,'2014-11-07 08:41:53','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1450,1,'10450','Custom',1400,NULL,1,50,NULL,'2015-07-21 05:20:35','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1500,1,'105','Proyek',1001,NULL,1,5,NULL,'2014-10-30 11:16:19','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1501,1,'10501','Buku Besar (GL)',1500,'01ProyekGLBukuBesar.repx',1,1,NULL,'2014-10-30 11:17:45','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1502,1,'10502','Laba Rugi Proyek COA',1500,'01ProyekLRCoa.repx',1,2,NULL,'2015-07-20 03:05:15','NuSoft - NuSoft Administrator','2015-07-25 21:03:23','NuSoft - NuSoft Administrator'),(1503,1,'10503','Laba Rugi Proyek Custom',1500,'01ProyekLRCustom.repx',1,3,NULL,'2015-07-25 21:03:24','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1900,1,'109','APP Pembayaran',1001,NULL,1,9,NULL,'2015-07-20 02:59:05','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1901,1,'10901','Rekap APP',1900,'01APPRekap.repx',1,1,NULL,'2015-07-20 03:02:28','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1902,1,'10902','Daftar APP - Terbit',1900,'01APPRekapTerbit.repx',1,2,NULL,'2015-07-20 03:02:28','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(1903,1,'10903','Daftar APP - Bayar',1900,'01APPRekapBayar.repx',1,3,NULL,'2015-07-20 03:02:28','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4001,4,'4','Inventory',NULL,NULL,1,4,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4100,4,'401','Voucher',4001,NULL,1,1,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4101,4,'40101','Permintaan Barang',4100,'04Voucher PB.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4102,4,'40102','Mutasi Stock',4100,'04Voucher ST.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4103,4,'40103','Pemakaian Barang',4100,'04Voucher CS.repx',1,3,NULL,'2014-08-25 06:32:57','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4104,4,'40104','Penyesuaian Stock',4100,'04Voucher PS.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4105,4,'40105','Produksi',4100,'04Voucher AM.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4200,4,'402','Rekap',4001,NULL,1,2,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4201,4,'40201','Kartu Stock',4200,'04Kartu Stock.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4202,4,'40202','Nilai Stock',4200,'04Nilai Stock.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4203,4,'40203','Buku Besar Stock',4200,'04Buku Besar Stock.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(4205,4,'40205','Blanko Stock Opname',4200,'04BlankoStockOpname.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5001,5,'5','Purchase',NULL,NULL,1,5,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5100,5,'501','Voucher',5001,NULL,1,1,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5101,5,'50101','Permintaan Stock',5100,'05Voucher PB.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5102,5,'50102','Permintaan Penawaran',5100,'05Voucher RQ.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5103,5,'50103','Order Pembelian',5100,'05Voucher PO.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5104,5,'50104','DP Pembelian',5100,'05Voucher AP.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5105,5,'50105','Penerimaan Barang',5100,'05Voucher GR.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5106,5,'50106','Penerimaan Invoice',5100,'05Voucher RI.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5107,5,'50107','Pembayaran Invoice',5100,'05Voucher VP.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5108,5,'50108','Pengiriman Retur',5100,'05Voucher VP.repx',1,8,NULL,'2014-10-14 06:28:44','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5200,5,'502','Rekap Data',5001,NULL,1,2,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5201,5,'50201','Permintaan Stock',5200,'05RekapPB.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5202,5,'50202','Permintaan Stock Detail',5200,'05RekapPB-Detail.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5203,5,'50203','Permintaan Penawaran',5200,'05RekapRQ.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5204,5,'50204','Permintaan Penawaran Detail',5200,'05RekapRQ-Detail.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5205,5,'50205','Order Pembelian',5200,'05RekapPO.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5206,5,'50206','Order Pembelian Detail',5200,'05RekapPO-Detail.repx',1,6,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5207,5,'50207','Order Pembelian per Vendor',5200,'05RekapPO-Vendor.repx',1,7,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5208,5,'50208','Penerimaan Barang',5200,'05RekapGR.repx',1,8,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5209,5,'50209','Penerimaan Barang Detail',5200,'05RekapGR-Detail.repx',1,9,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5210,5,'50210','Penerimaan Barang Per Vendor',5200,'05RekapGR-Vendor.repx',1,10,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5211,5,'50211','Penerimaan Invoice',5200,'05RekapRI.repx',1,11,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5212,5,'50212','Penerimaan Invoice Detail',5200,'05RekapRI-Detail.repx',1,12,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5213,5,'50213','Pembayaran Invoice',5200,'05RekapVP.repx',1,13,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5214,5,'50214','Pembayaran Invoice Detail',5200,'05RekapVP-Detail.repx',1,14,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5300,5,'503','Data & Analisa',5001,NULL,1,3,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5301,5,'50301','Kartu Hutang',5300,'05KartuHutang.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5302,5,'50302','Kartu Hutang Detail',5300,'05KartuHutangDetail.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5303,5,'50303','Daftar Hutang',5300,'05DaftarHutang.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5304,5,'50304','Umur Hutang',5300,'05UmurHutang.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5305,5,'50305','Lead Time Penerimaan Barang',5300,'05LeadTimeGR.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(5306,5,'50306','Analisa Barang Yang Harus diOrder',5300,'05AnalisaBarangOrder.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6001,6,'6','Sales',NULL,NULL,1,6,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6100,6,'601','Voucher',6001,NULL,1,1,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6101,6,'60101','Penawaran Penjualan',6100,'06Voucher SQ.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6102,6,'60102','Order Penjualan',6100,'06Voucher SO.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6103,6,'60103','Uang Muka Penjualan',6100,'06Voucher DP.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6104,6,'60104','Pengiriman Barang',6100,'06Voucher SJ.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6105,6,'60105','Invoice Penjualan',6100,'06Voucher IV.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6106,6,'60106','Pembayaran Penjualan',6100,'06Voucher CP.repx',1,6,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6107,6,'60107','Faktur Pajak',6100,'06Voucher FP.repx',1,7,NULL,'2014-08-25 07:30:46','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6108,6,'60108','Faktur Pajak Valas',6100,'06Voucher FP2.repx',1,8,NULL,'2014-09-25 11:37:06','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6109,6,'60109','Penerimaan Retur Penjualan',6100,'06Voucher FP2.repx',1,9,NULL,'2014-10-14 06:08:53','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6200,6,'602','Rekap Data',6001,NULL,1,2,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6201,6,'60201','Penawaran Penjualan',6200,'06RekapSQ.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6202,6,'60202','Penawaran Penjualan Detail',6200,'06RekapSQDetail.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6203,6,'60203','Order Penjualan',6200,'06RekapSO.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6204,6,'60204','Order Penjualan Detail',6200,'06RekapSQDetail.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6205,6,'60205','Uang Muka Penjualan',6200,'06RekapDP.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6206,6,'60206','Pengiriman Barang',6200,'06RekapSJ.repx',1,6,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6207,6,'60207','Pengiriman Barang Detail',6200,'06RekapSJDetail.repx',1,7,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6208,6,'60208','Invoice Penjualan',6200,'06RekapIV.repx',1,8,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6209,6,'60209','Invoice Penjualan Detail',6200,'06RekapIVDetail.repx',1,9,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6210,6,'60210','Pembayaran Penjualan',6200,'06RekapCP.repx',1,10,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6211,6,'60211','Pembayaran Penjualan Detail',6200,'06RekapCPDetail.repx',1,11,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6300,6,'603','Data & Analisa',6001,NULL,1,3,NULL,'2014-05-06 05:31:23','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6301,6,'60301','Surat Piutang',6300,'06SuratPiutang.repx',1,1,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6302,6,'60302','Kartu Piutang',6300,'06KartuPiutang.repx',1,2,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6303,6,'60303','Kartu Piutang Detail',6300,'06KartuPiutangDetail.repx',1,3,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6304,6,'60304','Daftar Piutang',6300,'06DaftarPiutang.repx',1,4,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6305,6,'60305','Umur Piutang',6300,'06UmurPiutang.repx',1,5,NULL,'2014-05-06 05:32:12','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6306,6,'60306','Laba Rugi Per Invoice',6300,'06LabaRugiInvoice.repx',1,6,NULL,'2015-06-12 13:54:41','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6307,6,'60307','Laba Rugi POS',6300,'06LabaRugiPOS.repx',1,7,NULL,'2015-06-13 07:02:25','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6308,6,'60308','Laba Rugi Per Barang',6300,'06LabaRugiPerBarang.repx',1,8,NULL,'2015-06-13 07:02:25','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6309,6,'60309','Laba Rugi Penjualan Per Hari',6300,'06LabaRugiPerHari.repx',1,9,NULL,'2015-06-13 07:02:25','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator'),(6310,6,'60310','Laba Rugi Penjualan Per Bulan',6300,'06LabaRugiPerBulan.repx',1,10,NULL,'2015-06-13 07:02:25','NuSoft - NuSoft Administrator','2015-07-25 21:03:24','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `reportlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `setting`
--

DROP TABLE IF EXISTS `setting`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `setting` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Code` varchar(30) NOT NULL,
  `Value` varchar(100) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `setting`
--

LOCK TABLES `setting` WRITE;
/*!40000 ALTER TABLE `setting` DISABLE KEYS */;
INSERT INTO `setting` VALUES (1,'LayoutLaporanTerpisah','False','2014-10-25 10:01:11','NuSoft - NuSoft Administrator','2015-10-21 13:36:02','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `setting` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userdivision`
--

DROP TABLE IF EXISTS `userdivision`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userdivision` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_user` int(10) unsigned NOT NULL,
  `f_div` smallint(5) unsigned NOT NULL,
  `f_db` smallint(5) unsigned NOT NULL,
  `d_open` tinyint(1) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_user`,`f_div`,`f_db`),
  KEY `fk_userdivision_user` (`f_user`),
  KEY `fk_userdivision_db` (`f_db`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userdivision`
--

LOCK TABLES `userdivision` WRITE;
/*!40000 ALTER TABLE `userdivision` DISABLE KEYS */;
/*!40000 ALTER TABLE `userdivision` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlist`
--

DROP TABLE IF EXISTS `userlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userlist` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(30) NOT NULL,
  `d_name` varchar(100) NOT NULL,
  `d_password` varchar(255) NOT NULL,
  `d_level` tinyint(4) NOT NULL DEFAULT '1',
  `d_active` tinyint(1) NOT NULL DEFAULT '1',
  `d_limited` tinyint(1) NOT NULL DEFAULT '0',
  `d_limitdivision` tinyint(1) NOT NULL DEFAULT '0',
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel dibuat untuk mendata user.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlist`
--

LOCK TABLES `userlist` WRITE;
/*!40000 ALTER TABLE `userlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `userlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usermenu`
--

DROP TABLE IF EXISTS `usermenu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usermenu` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_user` int(10) unsigned NOT NULL,
  `f_menu` smallint(5) unsigned NOT NULL,
  `f_db` smallint(5) unsigned NOT NULL,
  `d_open` tinyint(1) NOT NULL DEFAULT '0',
  `d_add` tinyint(1) NOT NULL DEFAULT '0',
  `d_edit` tinyint(1) NOT NULL DEFAULT '0',
  `d_delete` tinyint(1) NOT NULL DEFAULT '0',
  `d_export` tinyint(1) NOT NULL DEFAULT '0',
  `d_print` tinyint(1) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_user`,`f_menu`,`f_db`),
  KEY `usermenu_userslist` (`f_user`),
  KEY `usermenu_menuslist` (`f_menu`),
  KEY `usermenu_dblist` (`f_db`),
  CONSTRAINT `FK_usermenu_menulist` FOREIGN KEY (`f_menu`) REFERENCES `menulist` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_usermenu_userlist` FOREIGN KEY (`f_user`) REFERENCES `userlist` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata menu';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usermenu`
--

LOCK TABLES `usermenu` WRITE;
/*!40000 ALTER TABLE `usermenu` DISABLE KEYS */;
/*!40000 ALTER TABLE `usermenu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userregional`
--

DROP TABLE IF EXISTS `userregional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userregional` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_user` int(10) unsigned NOT NULL,
  `f_wil` smallint(5) unsigned NOT NULL,
  `f_db` smallint(5) unsigned NOT NULL,
  `d_open` tinyint(1) NOT NULL DEFAULT '0',
  `d_default` tinyint(1) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_userregional_userslist` (`f_user`),
  KEY `fk_userregional_db` (`f_db`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata tabel hak akses wilayah untuk user';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userregional`
--

LOCK TABLES `userregional` WRITE;
/*!40000 ALTER TABLE `userregional` DISABLE KEYS */;
/*!40000 ALTER TABLE `userregional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userreport`
--

DROP TABLE IF EXISTS `userreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userreport` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_user` int(10) unsigned NOT NULL,
  `f_report` smallint(5) unsigned NOT NULL,
  `f_db` smallint(5) unsigned NOT NULL,
  `d_open` tinyint(1) NOT NULL DEFAULT '0',
  `d_export` tinyint(1) NOT NULL DEFAULT '0',
  `d_print` tinyint(1) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_user`,`f_report`,`f_db`),
  KEY `userreport_userslist` (`f_user`),
  KEY `userreport_reportlist` (`f_report`),
  KEY `userreport_dblist` (`f_db`),
  CONSTRAINT `FK_userreport_reportlist` FOREIGN KEY (`f_report`) REFERENCES `reportlist` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_userreport_userlist` FOREIGN KEY (`f_user`) REFERENCES `userlist` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata user report.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userreport`
--

LOCK TABLES `userreport` WRITE;
/*!40000 ALTER TABLE `userreport` DISABLE KEYS */;
/*!40000 ALTER TABLE `userreport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `xpobjecttype`
--

DROP TABLE IF EXISTS `xpobjecttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `xpobjecttype` (
  `OID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `TypeName` varchar(255) DEFAULT NULL,
  `AssemblyName` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`OID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `xpobjecttype`
--

LOCK TABLES `xpobjecttype` WRITE;
/*!40000 ALTER TABLE `xpobjecttype` DISABLE KEYS */;
/*!40000 ALTER TABLE `xpobjecttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'nusoft_system'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-20 16:51:54
