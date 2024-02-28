-- MySQL dump 10.13  Distrib 5.7.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: nusoft_x01
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
-- Table structure for table `a_blob`
--

DROP TABLE IF EXISTS `a_blob`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `a_blob` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `d_filename` varchar(255) NOT NULL,
  `d_size` mediumint(8) unsigned NOT NULL DEFAULT '0',
  `d_blob` mediumblob NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan gambar dari semua module';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `a_blob`
--

LOCK TABLES `a_blob` WRITE;
/*!40000 ALTER TABLE `a_blob` DISABLE KEYS */;
/*!40000 ALTER TABLE `a_blob` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `a_division`
--

DROP TABLE IF EXISTS `a_division`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `a_division` (
  `p_id` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `d_name` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata data divisi.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `a_division`
--

LOCK TABLES `a_division` WRITE;
/*!40000 ALTER TABLE `a_division` DISABLE KEYS */;
INSERT INTO `a_division` VALUES (1,'Sales','2014-03-11 08:13:16','NuSoft - NuSoft Administrator','2014-03-20 15:20:23','NuSoft - NuSoft Administrator',NULL),(2,'Purchase','2014-03-20 15:20:23','NuSoft - NuSoft Administrator','2014-03-20 15:20:23','NuSoft - NuSoft Administrator',NULL),(3,'Service','2014-03-20 15:20:23','NuSoft - NuSoft Administrator','2014-03-20 15:20:23','NuSoft - NuSoft Administrator',NULL),(4,'Finance','2014-03-20 15:20:23','NuSoft - NuSoft Administrator','2014-03-20 15:20:23','NuSoft - NuSoft Administrator',NULL),(5,'Accounting','2014-03-20 15:20:23','NuSoft - NuSoft Administrator','2014-03-20 15:20:23','NuSoft - NuSoft Administrator',NULL),(6,'Umum','2014-03-20 15:20:23','NuSoft - NuSoft Administrator','2014-03-20 15:20:23','NuSoft - NuSoft Administrator',NULL);
/*!40000 ALTER TABLE `a_division` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `a_regional`
--

DROP TABLE IF EXISTS `a_regional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `a_regional` (
  `p_id` smallint(5) unsigned NOT NULL,
  `u_code` varchar(10) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_address` varchar(100) DEFAULT NULL,
  `d_city` varchar(30) DEFAULT NULL,
  `d_province` varchar(30) DEFAULT NULL,
  `d_postal` varchar(10) DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `d_coaar` int(10) unsigned DEFAULT NULL,
  `d_coaap` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata wilayah kerja';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `a_regional`
--

LOCK TABLES `a_regional` WRITE;
/*!40000 ALTER TABLE `a_regional` DISABLE KEYS */;
INSERT INTO `a_regional` VALUES (1,'JKT','Kantor Pusat Jakarta','a','Jakarta','DKI','12212','asdasd','2014-03-11 08:13:50','NuSoft - NuSoft Administrator','2015-05-23 05:32:37','NuSoft - NuSoft Administrator',NULL,NULL),(2,'SBY','Cabang Surabaya',NULL,NULL,NULL,NULL,NULL,'2014-03-11 08:14:06','NuSoft - NuSoft Administrator','2015-05-23 05:32:37','NuSoft - NuSoft Administrator',NULL,NULL),(3,'SMG','Cabang Semarang','a','a','a','a','a','2014-03-17 15:44:15','NuSoft - NuSoft Administrator','2015-05-23 05:32:37','NuSoft - NuSoft Administrator',NULL,NULL);
/*!40000 ALTER TABLE `a_regional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `a_setting`
--

DROP TABLE IF EXISTS `a_setting`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `a_setting` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_module` smallint(6) NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_value` varchar(100) DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_module`,`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=131 DEFAULT CHARSET=utf8 COMMENT='Tabel system untuk menyimpan setting aplikasi dari modul.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `a_setting`
--

LOCK TABLES `a_setting` WRITE;
/*!40000 ALTER TABLE `a_setting` DISABLE KEYS */;
INSERT INTO `a_setting` VALUES (1,0,'NamaPerusahaan','PT. Nusoft','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(2,0,'NamaAlias','PT. Nusantara Software','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(3,0,'BidangUsaha','Software Developer','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(4,0,'Slogan','New Software n Different','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(5,0,'Alamat1','Menara Rajawali, Level 7-1 JL. DR Ide Anak Agung Gde Agung','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(6,0,'Alamat2','Kawasan Mega Kuningan Jakarta Selatan','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(7,0,'KodePos','12950','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(8,0,'NoTelp','(021) 29557249','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(9,0,'NoFax','(021) 29557250','','2014-03-17 15:36:49','NuSoft - NuSoft Administrator','2014-04-02 09:17:15','NuSoft - NuSoft Administrator'),(10,1,'AwalPeriodeBulan','5','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(11,1,'AwalPeriodeTahun','2014','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(12,1,'MultiDivisi','True','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(13,1,'MultiMataUangPakai','True','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(14,1,'MultiMataUangAkunKurs','113','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(15,1,'MultiMataUangDefault','3','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(16,1,'FormatDigit','2','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(17,1,'FormatNomor','[R]-[S][Y2][M0][X4]','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(18,1,'NumericFormatString','{0:n2}','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(19,1,'NumericFormatToString','n2','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(20,1,'FormatAngka','#,##0.00','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(21,1,'FormatAngkaNegativMinus','#,##0.00;-#,##0.00','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(22,1,'FormatAngkaNegativKurung','#,##0.00;(#,##0.00)','','2014-03-19 12:16:08','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(38,5,'MultiPO','True','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(39,5,'FilterKontak','True','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(40,5,'TipeKontak','3','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(41,5,'AutoSearchKontak','0','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(42,5,'CoaHutangSementara','69','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(43,5,'CoaPPN','21','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(44,5,'CoaPPH','64','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(45,5,'CoaBiayaLain','224','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(46,5,'CoaBiayaPembulatan','234','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(47,5,'UraianRQ','Permintaan Penawaran','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(48,5,'UraianPO','Order Pembelian','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(49,5,'UraianAP','DP Pembelian','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(50,5,'UraianGR','Penerimaan Barang','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(51,5,'UraianRI','Invoice Pembelian','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(52,5,'UraianVP','Pembayaran Hutang','','2014-05-25 07:29:41','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(53,5,'CoaAdminBank','184','','2014-07-13 19:57:14','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(54,5,'CoaPendapatan','239','','2014-07-13 19:57:14','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(55,6,'MultiSO','False','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:51','NuSoft - NuSoft Administrator'),(56,6,'FilterKontak','True','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(57,6,'TipeKontak','2','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(58,6,'TipeHPP','0','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(59,6,'AutoSearchKontak','0','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(60,6,'UraianSQ','Penawaran Penjualan','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(61,6,'UraianSO','Order Penjualan','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(62,6,'UraianDP','Uang Muka Penjualan','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(63,6,'UraianDO','Surat Jalan','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(64,6,'UraianIV','Invoice Penjualan','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(65,6,'UraianCP','Penerimaan Piutang','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(66,6,'CoaPPN','80','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(67,6,'CoaPPH','38','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(68,6,'CoaBiayaLain','240','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(69,6,'CoaBiayaPembulatan','238','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(70,6,'CoaAdminBank','184','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(71,6,'CoaPendapatan','239','','2014-07-13 20:05:18','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(72,4,'LockProduksi','True','','2014-07-15 20:58:14','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(73,4,'UraianPermintaan','Permintaan Barang','','2014-07-15 20:58:14','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(74,4,'UraianMutasi','Mutasi Stock','','2014-07-15 20:58:14','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(75,4,'UraianPenyesuaian','Penyesuaian Stock','','2014-07-15 20:58:14','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(76,4,'UraianStockOpname','Stock Opname','','2014-07-15 20:58:14','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(77,4,'UraianProduksi','Produksi','','2014-07-15 20:58:14','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(78,4,'CustomItem1','Schedule','','2014-08-23 10:45:13','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(79,4,'CustomItem2','Ukuran','','2014-08-23 10:45:13','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(80,4,'CustomItem3','Class','','2014-08-23 10:45:13','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(81,4,'CustomItem4','Material','','2014-08-23 10:45:13','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(82,4,'CustomItem5','-','','2014-08-23 10:45:13','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(83,4,'AkunPersediaan','33','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(84,4,'AkunPendapatan','113','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(85,4,'AkunPenjualan','0','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-08-23 20:21:42','NuSoft - NuSoft Administrator'),(86,4,'AkunPembelian','0','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-08-23 20:21:42','NuSoft - NuSoft Administrator'),(87,4,'AkunDiscPenjualan','117','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(88,4,'AkunDiscPembelian','142','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(89,4,'PajakIN','2','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(90,4,'PajakOut','1','','2014-08-23 20:21:42','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(91,4,'AkunHPP','133','','2014-08-24 05:28:41','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(92,4,'AkunReturPenjualan','127','','2014-08-24 05:28:41','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(93,4,'AkunReturPembelian','145','','2014-08-24 05:28:41','NuSoft - NuSoft Administrator','2014-09-04 17:01:38','NuSoft - NuSoft Administrator'),(94,1,'MultiProyek','False','','2014-08-25 19:17:29','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(95,6,'PreviewSave','True','','2014-09-13 07:21:02','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(96,5,'PreviewReport','True','','2014-09-20 13:27:09','NuSoft - NuSoft Administrator','2015-06-20 05:53:05','admin - Administrator'),(97,4,'PreviewSave','True','','2014-09-23 20:27:02','NuSoft - NuSoft Administrator','2014-09-23 20:27:02','NuSoft - NuSoft Administrator'),(98,1,'PenampungSaldoAwal','246','','2014-09-28 06:09:41','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(99,6,'OpenPriceInvoice','False','','2014-10-30 09:30:00','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(100,6,'UraianRN','','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(101,6,'UraianSR','','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(102,6,'UraianBR','Saldo Awal Piutang','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(103,6,'UraianQS','Penjualan POS','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(104,6,'CoaCustom1','0','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(105,6,'CoaCustom2','0','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(106,6,'CoaCustom3','0','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(107,6,'CoaCustom4','0','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(108,6,'CoaCustom5','0','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(109,6,'OpenTaxIV','False','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(110,6,'POSCOACash','3','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(111,6,'POSCOADebit','9','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(112,6,'POSCOACredit','15','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(113,6,'POSPelanggan','3915','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(114,6,'POSPajak','2','','2015-05-30 14:40:13','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(115,6,'POSAddRowGrid','False','','2015-05-31 09:24:00','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(116,6,'POSCoaPendapatan','113','','2015-06-01 15:49:17','admin - Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(117,6,'POSGudang','1','','2015-06-01 15:49:17','admin - Administrator','2015-06-01 20:40:25','admin - Administrator'),(118,1,'CoaKasBankPadaJU','False','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(119,1,'UraianKM','Bukti Kas Masuk','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(120,1,'UraianKK','Bukti Kas Keluar','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(121,1,'UraianBM','Bukti Bank Masuk','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(122,1,'UraianBK','Bukti Bank Keluar','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(123,1,'UraianJU','Jurnal Umum','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(124,1,'UraianJA','Jurnal adjustment','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(125,1,'UraianSA','Saldo Awal','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(126,1,'UraianGM','Pencairan Giro masuk','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(127,1,'UraianGK','Pencairan Giro Keluar','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(128,1,'UraianPD','Pengajuan Dana','','2015-06-18 07:02:47','admin - Administrator','2015-06-18 07:09:45','admin - Administrator'),(129,6,'KaryawanDefault','0','','2016-06-21 06:42:52','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator'),(130,6,'GudangDefault','1','','2016-06-21 06:42:52','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `a_setting` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `a_source`
--

LOCK TABLES `a_source` WRITE;
/*!40000 ALTER TABLE `a_source` DISABLE KEYS */;
INSERT INTO `a_source` VALUES (1,'KM','Bukti Kas Masuk',NULL,651410569),(2,'KK','Bukti Kas Keluar',NULL,651410569),(3,'BM','Bukti Bank Masuk',NULL,651410569),(4,'BK','Bukti Bank Keluar',NULL,651410569),(5,'JU','Jurnal Umum',NULL,651410569),(6,'JA','Jurnal Adjustment',NULL,651410569),(7,'LA','Load Administration',NULL,651410569),(8,'RV','Revaluasi Valas',NULL,651410569),(9,'SA','Saldo Awal',NULL,651410569),(10,'PD','Pengajuan Dana',NULL,651410569),(11,'FA','Fixet Asset',NULL,651410569),(12,'PB','Permintaan Barang',NULL,1454983174),(13,'ST','Mutasi Stock',NULL,1454983174),(14,'PS','Penyesuaian Stock',NULL,1454983174),(15,'AM','Produksi',NULL,1454983174),(16,'OS','Stock Opname',NULL,1454983174),(17,'BS','Saldo Awal Stock',NULL,1454983174),(18,'PR','Permintaan Pembelian',NULL,566130832),(19,'RQ','Permintaan Penawaran',NULL,566130832),(20,'PO','Order Pembelian',NULL,566130832),(21,'AP','Uang Muka Pembelian',NULL,566130832),(22,'GR','Penerimaan Stock',NULL,566130832),(23,'RI','Penerimaan Invoice Pembelian',NULL,566130832),(24,'VP','Pembayaran Hutang',NULL,566130832),(25,'DN','Pengiriman Barang Retur',NULL,566130832),(26,'PN','Retur Pembelian',NULL,566130832),(27,'SQ','Penawaran Penjualan',NULL,-1195955926),(28,'SO','Order Penjualan',NULL,-1195955926),(29,'DP','Uang Muka Penjualan',NULL,-1195955926),(30,'SJ','Surat Jalan',NULL,-1195955926),(31,'IV','Invoice Penjualan',NULL,-1195955926),(32,'CP','Penerimaan Pembayaran Penjualan',NULL,-1195955926),(33,'RN','Penerimaan Retur Penjualan',NULL,-1195955926),(34,'SR','Retur Penjualan',NULL,-1195955926),(35,'PE','Prepaid Expense',NULL,651410569),(36,'CS','Consumtion Stock',NULL,1454983174),(37,'BP','Saldo Awal Hutang',NULL,566130832),(38,'BR','Saldo Awal Piutang',NULL,-1195955926),(39,'QS','Point Of Sale',NULL,-1195955926),(40,'GM','Giro Masuk',NULL,651410569),(41,'GK','Giro Keluar',NULL,651410569),(42,'PP','Pre Payment',NULL,651410569),(43,'PB','Permintaan Pembelian',NULL,566130832);
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datalog_amain`
--

LOCK TABLES `datalog_amain` WRITE;
/*!40000 ALTER TABLE `datalog_amain` DISABLE KEYS */;
INSERT INTO `datalog_amain` VALUES (1,'2021-02-20 13:03:20','NuSoft - NuSoft Administrator',0,'Tambah Data: m01cmaingl','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(2,'2021-02-20 13:03:20','NuSoft - NuSoft Administrator',0,'Tambah Data: m01dmaindetail','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(3,'2021-02-20 13:03:20','NuSoft - NuSoft Administrator',0,'Tambah Data: m01dmaindetail','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(4,'2021-02-20 16:06:42','NuSoft - NuSoft Administrator',0,'Tambah Data: m06cmainquotation','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(5,'2021-02-20 16:06:42','NuSoft - NuSoft Administrator',0,'Tambah Data: m06ddetailquotation','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(6,'2021-02-20 16:06:42','NuSoft - NuSoft Administrator',0,'Tambah Data: m06ddetailquotation','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(7,'2021-02-20 16:06:55','NuSoft - NuSoft Administrator',0,'Tambah Data: m06dmainorder','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(8,'2021-02-20 16:06:55','NuSoft - NuSoft Administrator',0,'Tambah Data: m06edetailorder','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(9,'2021-02-20 16:06:55','NuSoft - NuSoft Administrator',0,'Tambah Data: m06edetailorder','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(10,'2021-02-20 16:06:55','NuSoft - NuSoft Administrator',1,'Edit Data: m06cmainquotation','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(11,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator',0,'Tambah Data: m06emaininvoice','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(12,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator',0,'Tambah Data: m01cmaingl','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(13,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator',0,'Tambah Data: m01dmaindetail','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(14,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator',0,'Tambah Data: m01dmaindetail','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(15,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator',0,'Tambah Data: m05cmaininvoicereceipt','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(16,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator',0,'Tambah Data: m01cmaingl','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(17,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator',0,'Tambah Data: m05ddetailinvoicereceipt','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(18,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator',0,'Tambah Data: m01dmaindetail','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(19,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator',0,'Tambah Data: m01dmaindetail','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC'),(20,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator',1,'Edit Data: m04cstockmain','Microsoft Windows 10 Home|6.2.9200.0|1.1.0.1','localhost','JALI-PC');
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
  KEY `fk_datalogbdetail_main` (`f_main`)
) ENGINE=InnoDB AUTO_INCREMENT=190 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `datalog_bdetail`
--

LOCK TABLES `datalog_bdetail` WRITE;
/*!40000 ALTER TABLE `datalog_bdetail` DISABLE KEYS */;
INSERT INTO `datalog_bdetail` VALUES (1,1,'ModuleId','0','Fina'),(2,1,'Tanggal','01/01/0001 00.00.00','20/02/2021 13.03.00'),(3,1,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(4,1,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(5)'),(5,1,'Kode','<NULL>',''),(6,1,'MataUang','<NULL>','Rp'),(7,1,'Kurs','0','1'),(8,1,'Kontak','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(1661)'),(9,1,'KontakNama','<NULL>',''),(10,1,'Uraian','<NULL>','Jurnal Umum'),(11,1,'Catatan','<NULL>',''),(12,1,'Kode','','JKT-JU21020001'),(13,2,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.GlMain(0)'),(14,2,'Kurs','0','1'),(15,2,'Urutan','0','1'),(16,2,'Keterangan','<NULL>',''),(17,2,'Akun','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(19)'),(18,2,'MataUang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(19,2,'Debit','0','2222'),(20,3,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.GlMain(0)'),(21,3,'Kurs','0','1'),(22,3,'Urutan','0','2'),(23,3,'Keterangan','<NULL>',''),(24,3,'Akun','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(30)'),(25,3,'MataUang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(26,3,'Kredit','0','2222'),(27,4,'Tanggal','01/01/0001 00.00.00','20/02/2021 16.06.24'),(28,4,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(29,4,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(27)'),(30,4,'Pelanggan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(887)'),(31,4,'TipeTransaksi','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.TipeTransaksi(4)'),(32,4,'Kode','<NULL>',''),(33,4,'Via','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.Via(1)'),(34,4,'LeadTime','<NULL>','<Lead Time>'),(35,4,'Uang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(36,4,'Catatan','<NULL>','Penawaran Penjualan'),(37,4,'StatusTransaksi','Pending','Posting'),(38,4,'Kode','','JKT-SQ21020001'),(39,5,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Penawaran(0)'),(40,5,'Catatan','<NULL>',''),(41,5,'Barang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang(1)'),(42,5,'Satuan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Satuan(3)'),(43,5,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(2)'),(44,5,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(1)'),(45,5,'PPNp','0','10'),(46,5,'Qty','0','1'),(47,5,'Harga','0','2000'),(48,6,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Penawaran(0)'),(49,6,'Catatan','<NULL>',''),(50,6,'Barang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang(264)'),(51,6,'Satuan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Satuan(3)'),(52,6,'Harga','0','100000'),(53,6,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(2)'),(54,6,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(1)'),(55,6,'PPNp','0','10'),(56,6,'Qty','0','1'),(57,6,'Harga','100000','3000'),(58,7,'Tanggal','01/01/0001 00.00.00','20/02/2021 16.06.47'),(59,7,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(60,7,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(28)'),(61,7,'Pelanggan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(887)'),(62,7,'Kode','<NULL>',''),(63,7,'Via','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.Via(1)'),(64,7,'LeadTime','<NULL>','<Lead Time>'),(65,7,'Uang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(66,7,'Uraian','<NULL>','Order Penjualan'),(67,7,'Catatan','<NULL>',''),(68,7,'NoPenawaran','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.Penawaran(1)'),(69,7,'TipeTransaksi','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.TipeTransaksi(4)'),(70,7,'StatusTransaksi','Pending','Posting'),(71,7,'ReffNumber','<NULL>',''),(72,7,'Custom1','<NULL>',''),(73,7,'Custom2','<NULL>',''),(74,7,'Custom3','<NULL>',''),(75,7,'Custom4','<NULL>',''),(76,7,'Custom5','<NULL>',''),(77,7,'Kode','','JKT-SO21020001'),(78,8,'Barang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang(1)'),(79,8,'Qty','0','1'),(80,8,'Satuan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Satuan(3)'),(81,8,'Harga','0','2000'),(82,8,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(2)'),(83,8,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(1)'),(84,8,'PPNp','0','10'),(85,8,'Catatan','<NULL>',''),(86,8,'PenawaranDetail','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.PenawaranDetail(1)'),(87,8,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.OrderPenjualan(0)'),(88,9,'Barang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang(264)'),(89,9,'Qty','0','1'),(90,9,'Satuan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Satuan(3)'),(91,9,'Harga','0','3000'),(92,9,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(2)'),(93,9,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(1)'),(94,9,'PPNp','0','10'),(95,9,'Catatan','<NULL>',''),(96,9,'PenawaranDetail','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.PenawaranDetail(2)'),(97,9,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.OrderPenjualan(0)'),(98,10,'StatusTransaksi','Posting','Finish'),(99,11,'Gl','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.GlMain(0)'),(100,11,'Tanggal','01/01/0001 00.00.00','20/02/2021 16.07.07'),(101,11,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(102,11,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(29)'),(103,11,'Pelanggan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(887)'),(104,11,'Kode','<NULL>','JKT-DP21020001'),(105,11,'SO','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.OrderPenjualan(1)'),(106,11,'NilaiDPpersen','0','10'),(107,11,'Uang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(108,11,'Kurs','0','1'),(109,11,'Pajak','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(1)'),(110,11,'JenisPajak','HargaJual','UangMuka'),(111,11,'PajakSN','<NULL>','asd'),(112,11,'Keterangan','<NULL>','Uang Muka Penjualan'),(113,11,'StatusTransaksi','Pending','Posting'),(114,11,'TipeTransaksi','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.TipeTransaksi(4)'),(115,12,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(29)'),(116,12,'Tanggal','01/01/0001 00.00.00','20/02/2021 16.07.07'),(117,12,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(118,12,'Kode','<NULL>','JKT-DP21020001'),(119,12,'ModuleId','0','Purchase'),(120,12,'MataUang','<NULL>','Rp'),(121,12,'Kurs','0','1'),(122,12,'Kontak','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(887)'),(123,12,'KontakNama','<NULL>','ALLIANZ'),(124,12,'Uraian','<NULL>','Uang Muka Penjualan'),(125,13,'Akun','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(23)'),(126,13,'MataUang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(127,13,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.GlMain(0)'),(128,13,'Kredit','0','500'),(129,13,'Kurs','0','1'),(130,14,'Akun','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(74)'),(131,14,'MataUang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(132,14,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft006.Persistent.GlMain(0)'),(133,14,'Urutan','0','2'),(134,14,'Debit','0','500'),(135,14,'Kurs','0','1'),(136,15,'Gl','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.GlMain(0)'),(137,15,'Tanggal','01/01/0001 00.00.00','20/02/2021 16.12.22'),(138,15,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(139,15,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(23)'),(140,15,'Vendor','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(1223)'),(141,15,'Kode','<NULL>','JKT-RI21020001'),(142,15,'Uang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(143,15,'Kurs','0','1'),(144,15,'Termin','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.Termin(1)'),(145,15,'TanggalBerlaku','01/01/0001 00.00.00','07/03/2021 16.12.22'),(146,15,'JenisPajak','HargaJual','Penggantian'),(147,15,'NoSNPPN','<NULL>',''),(148,15,'NoSNPPh','<NULL>',''),(149,15,'Catatan','<NULL>','Invoice Pembelian'),(150,15,'NoReffVendor','<NULL>',''),(151,15,'Karyawan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(1069)'),(152,15,'NoOrder','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.OrderPembelian(2)'),(153,15,'StatusTransaksi','Pending','Posting'),(154,15,'CoaHutang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(65)'),(155,16,'Sumber','<NULL>','NuSoft.NPO.Modules.ModSys.SumberData(23)'),(156,16,'Tanggal','01/01/0001 00.00.00','20/02/2021 16.12.22'),(157,16,'Regional','<NULL>','NuSoft.NPO.Modules.ModSys.Regional(1)'),(158,16,'Kode','<NULL>','JKT-RI21020001'),(159,16,'ModuleId','0','Purchase'),(160,16,'MataUang','<NULL>','Rp'),(161,16,'Kurs','0','1'),(162,16,'Kontak','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Kontak(1223)'),(163,16,'KontakNama','<NULL>','Abbot'),(164,16,'Uraian','<NULL>','Invoice Pembelian'),(165,17,'Barang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Barang(154)'),(166,17,'Qty','0','1000'),(167,17,'Satuan','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Satuan(4)'),(168,17,'Harga','0','100000'),(169,17,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(2)'),(170,17,'PPNp','0','10'),(171,17,'PPN','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft004.Persistent.Pajak(1)'),(172,17,'Catatan','<NULL>',''),(173,17,'PenerimaanBarang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.PenerimaanBarangDetail(2)'),(174,17,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.PenerimaanInvoice(0)'),(175,18,'Akun','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(69)'),(176,18,'MataUang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(177,18,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.GlMain(0)'),(178,18,'Urutan','0','1'),(179,18,'Debit','0','100000000'),(180,18,'Keterangan','<NULL>',''),(181,18,'Kurs','0','1'),(182,19,'Akun','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.Coa(65)'),(183,19,'MataUang','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft001.Persistent.MataUang(3)'),(184,19,'Main','<NULL>','NuSoft.NUI.Win.Forms.Modules.NuSoft005.Persistent.GlMain(0)'),(185,19,'Urutan','0','2'),(186,19,'Kredit','0','100000000'),(187,19,'Keterangan','<NULL>',''),(188,19,'Kurs','0','1'),(189,20,'StatusTransaksi','Posting','Finish');
/*!40000 ALTER TABLE `datalog_bdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtaprovince`
--

DROP TABLE IF EXISTS `dtaprovince`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtaprovince` (
  `p_id` smallint(5) unsigned DEFAULT NULL,
  `u_code` varchar(50) DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtaprovince`
--

LOCK TABLES `dtaprovince` WRITE;
/*!40000 ALTER TABLE `dtaprovince` DISABLE KEYS */;
/*!40000 ALTER TABLE `dtaprovince` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtbdistrict`
--

DROP TABLE IF EXISTS `dtbdistrict`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtbdistrict` (
  `p_id` smallint(5) unsigned NOT NULL,
  `f_province` smallint(5) unsigned NOT NULL,
  `u_code` varchar(50) NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_province`,`u_code`),
  KEY `fk_dtbdistrict_province_idx` (`f_province`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data kabupaten';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtbdistrict`
--

LOCK TABLES `dtbdistrict` WRITE;
/*!40000 ALTER TABLE `dtbdistrict` DISABLE KEYS */;
/*!40000 ALTER TABLE `dtbdistrict` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtcsubdistrict`
--

DROP TABLE IF EXISTS `dtcsubdistrict`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtcsubdistrict` (
  `p_id` int(10) unsigned NOT NULL,
  `f_district` smallint(5) unsigned NOT NULL,
  `u_code` varchar(50) NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_district`,`u_code`),
  KEY `fk_dtbdistict_province` (`f_district`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data kecamatan';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtcsubdistrict`
--

LOCK TABLES `dtcsubdistrict` WRITE;
/*!40000 ALTER TABLE `dtcsubdistrict` DISABLE KEYS */;
/*!40000 ALTER TABLE `dtcsubdistrict` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dtdvillage`
--

DROP TABLE IF EXISTS `dtdvillage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dtdvillage` (
  `p_id` int(10) unsigned NOT NULL,
  `f_subdistrict` int(10) unsigned NOT NULL,
  `u_code` varchar(50) NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_subdistrict`,`u_code`),
  KEY `fk_dtbdistict_province` (`f_subdistrict`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data desa';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dtdvillage`
--

LOCK TABLES `dtdvillage` WRITE;
/*!40000 ALTER TABLE `dtdvillage` DISABLE KEYS */;
/*!40000 ALTER TABLE `dtdvillage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01abank`
--

DROP TABLE IF EXISTS `m01abank`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01abank` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(30) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_accno` varchar(20) NOT NULL,
  `d_owner` varchar(100) NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01bank` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata data bank';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01abank`
--

LOCK TABLES `m01abank` WRITE;
/*!40000 ALTER TABLE `m01abank` DISABLE KEYS */;
INSERT INTO `m01abank` VALUES (1,'BCA','Bank BCA','sadasd','sad','sad','2014-03-11 10:03:11','Admin - Administrator','2014-03-11 10:03:11','Admin - Administrator'),(2,'BNI','Bank BNI','sadasd','asdasd','asdasd','2014-03-11 10:03:11','Admin - Administrator','2014-03-11 10:03:11','Admin - Administrator');
/*!40000 ALTER TABLE `m01abank` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01acoalevel`
--

DROP TABLE IF EXISTS `m01acoalevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01acoalevel` (
  `p_id` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_level1` smallint(6) NOT NULL COMMENT '0: NERACA\n1: RUGILABA',
  `d_level2` smallint(6) NOT NULL COMMENT '0: AKTIVA\n1: HUTANG\n2: MODAL\n3: PENDAPATAN\n4: BIAYA',
  `d_dc` tinyint(4) NOT NULL DEFAULT '0' COMMENT '0: Debit, 1: Credit',
  `d_parameter` tinyint(4) NOT NULL DEFAULT '0' COMMENT '0: Blank\n1: KAS 2: BANK',
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01acoalevel` (`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel system untuk mendata tipe akun.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01acoalevel`
--

LOCK TABLES `m01acoalevel` WRITE;
/*!40000 ALTER TABLE `m01acoalevel` DISABLE KEYS */;
INSERT INTO `m01acoalevel` VALUES (1,'Kas',0,0,0,1),(2,'Bank',0,0,0,2),(3,'Piutang',0,0,0,0),(4,'Persediaan',0,0,0,0),(5,'Aktiva Lancar Lainnya',0,0,0,0),(6,'Aktiva Tetap',0,0,0,0),(7,'Akumulasi Penyusutan',0,0,0,0),(8,'Hutang',0,1,1,0),(9,'Hutang Lancar Lainnya',0,1,1,0),(10,'Hutang Jangka Panjang',0,1,1,0),(11,'Modal',0,2,1,0),(12,'Pendapatan',1,3,1,0),(13,'HPP',1,4,0,0),(14,'Biaya',1,4,0,0),(15,'Pendapatan Lain-Lain',1,3,1,0),(16,'Biaya Lain-Lain',1,4,0,0),(17,'Laba Ditahan',0,2,1,0),(18,'Laba Berjalan',0,2,1,0),(19,'Coa Pajak',1,4,0,0);
/*!40000 ALTER TABLE `m01acoalevel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01acontacttype`
--

DROP TABLE IF EXISTS `m01acontacttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01acontacttype` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_name` varchar(30) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01acontacttype` (`u_name`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01acontacttype`
--

LOCK TABLES `m01acontacttype` WRITE;
/*!40000 ALTER TABLE `m01acontacttype` DISABLE KEYS */;
INSERT INTO `m01acontacttype` VALUES (1,'Karyawan','2014-03-17 16:16:35','NuSoft - NuSoft Administrator','2014-03-17 16:16:35','NuSoft - NuSoft Administrator'),(2,'Customer','2014-03-17 16:16:35','NuSoft - NuSoft Administrator','2014-03-17 16:16:35','NuSoft - NuSoft Administrator'),(3,'Vendor','2014-03-17 16:16:35','NuSoft - NuSoft Administrator','2014-03-17 16:16:35','NuSoft - NuSoft Administrator'),(4,'Umum','2014-03-17 16:16:35','NuSoft - NuSoft Administrator','2014-03-17 16:16:35','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m01acontacttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01acurrency`
--

DROP TABLE IF EXISTS `m01acurrency`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01acurrency` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(3) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_country` varchar(50) NOT NULL,
  `d_symbol` varchar(3) NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `f_coapayable` int(11) DEFAULT NULL,
  `f_coareceivable` int(11) DEFAULT NULL,
  `f_coaadvancepurchase` int(11) DEFAULT NULL,
  `f_coaadvancesales` int(11) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01acurrency` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk dibuat untuk mendata mata uang.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01acurrency`
--

LOCK TABLES `m01acurrency` WRITE;
/*!40000 ALTER TABLE `m01acurrency` DISABLE KEYS */;
INSERT INTO `m01acurrency` VALUES (3,'IDR','Rupiah','Indonesia','Rp',NULL,'2014-03-10 08:16:09','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator',65,23,49,74),(4,'USD','Dollar','Amerika','$',NULL,'2014-03-11 10:09:30','Admin - Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator',66,24,50,75),(5,'UER','EURO','EURO','EUR','a','2014-03-17 05:45:27','NuSoft - NuSoft Administrator','2016-06-21 06:42:52','NuSoft - NuSoft Administrator',67,25,51,76);
/*!40000 ALTER TABLE `m01acurrency` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01alokasi`
--

DROP TABLE IF EXISTS `m01alokasi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01alokasi` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(30) NOT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01alokasi`
--

LOCK TABLES `m01alokasi` WRITE;
/*!40000 ALTER TABLE `m01alokasi` DISABLE KEYS */;
INSERT INTO `m01alokasi` VALUES (1,'P01 - Lokasi 1','P01 - Lokasi 1','2014-08-25 19:33:09','NuSoft - NuSoft Administrator','2014-08-25 19:33:09','NuSoft - NuSoft Administrator'),(2,'P01 - Lokasi 2','P01 - Lokasi 2','2014-08-25 19:33:09','NuSoft - NuSoft Administrator','2014-08-25 19:33:09','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m01alokasi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01aproject`
--

DROP TABLE IF EXISTS `m01aproject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01aproject` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(30) NOT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `f_customer` int(10) unsigned DEFAULT NULL,
  `d_nokontrak` varchar(255) DEFAULT NULL,
  `d_tglawal` date DEFAULT NULL,
  `d_tglakhir` date DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m01aproject_customer_idx` (`f_customer`),
  CONSTRAINT `fk_m01aproject_customer` FOREIGN KEY (`f_customer`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01aproject`
--

LOCK TABLES `m01aproject` WRITE;
/*!40000 ALTER TABLE `m01aproject` DISABLE KEYS */;
INSERT INTO `m01aproject` VALUES (1,'Proyek 1','Proyek 1','2014-08-25 19:32:39','NuSoft - NuSoft Administrator','2014-10-27 06:45:03','NuSoft - NuSoft Administrator',787,'hjkl','2014-10-27','2015-10-27'),(2,'Proyek 2','Proyek 2','2014-08-25 19:32:39','NuSoft - NuSoft Administrator','2014-08-25 19:32:39','NuSoft - NuSoft Administrator',788,'asdasd','2015-06-16','2015-06-18'),(3,'sadsa','asdasd','2014-09-16 16:27:01','NuSoft - NuSoft Administrator','2014-09-16 16:27:01','NuSoft - NuSoft Administrator',788,'sadas','2014-09-19','2014-09-11');
/*!40000 ALTER TABLE `m01aproject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01bcoa`
--

DROP TABLE IF EXISTS `m01bcoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01bcoa` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_type` smallint(5) unsigned NOT NULL,
  `u_code` varchar(20) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_cfp` varchar(50) DEFAULT NULL,
  `d_cfm` varchar(50) DEFAULT NULL,
  `d_parent` int(10) unsigned DEFAULT NULL,
  `d_active` tinyint(1) NOT NULL DEFAULT '1' COMMENT '0: NonAktif, 1:Aktif',
  `d_cfmerge` tinyint(1) NOT NULL DEFAULT '1',
  `d_note` varchar(255) DEFAULT NULL,
  `d_format` varchar(2) DEFAULT NULL,
  `d_linkaccount` tinyint(1) NOT NULL DEFAULT '0',
  `fk_currency` smallint(5) unsigned DEFAULT NULL,
  `fk_bank` smallint(5) unsigned DEFAULT NULL,
  `fk_division` smallint(5) unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `d_gd` tinyint(2) DEFAULT NULL,
  `f_coa1` int(10) unsigned DEFAULT NULL,
  `f_coa2` int(10) unsigned DEFAULT NULL,
  `f_coa3` int(10) unsigned DEFAULT NULL,
  `f_coa4` int(10) unsigned DEFAULT NULL,
  `d_level` tinyint(2) DEFAULT NULL,
  `f_cashflowout` int(10) unsigned DEFAULT NULL,
  `f_cashflowin` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01bcoa` (`u_code`),
  KEY `fk_02coa_coalevel_idx` (`f_type`),
  KEY `fk_02coa_currency_idx` (`fk_currency`),
  KEY `fk_02coa_bank_idx` (`fk_bank`),
  KEY `fk_02coa_paremt_idx` (`d_parent`),
  KEY `fk_02coa_division_idx` (`fk_division`),
  CONSTRAINT `fk_02coa_bank` FOREIGN KEY (`fk_bank`) REFERENCES `m01abank` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_02coa_coalevel` FOREIGN KEY (`f_type`) REFERENCES `m01acoalevel` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_02coa_division` FOREIGN KEY (`fk_division`) REFERENCES `a_division` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_02coa_parent` FOREIGN KEY (`d_parent`) REFERENCES `m01bcoa` (`p_id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=249 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata akun.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01bcoa`
--

LOCK TABLES `m01bcoa` WRITE;
/*!40000 ALTER TABLE `m01bcoa` DISABLE KEYS */;
INSERT INTO `m01bcoa` VALUES (1,1,'1-1100','KAS','','',NULL,1,1,'','KK',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3,1,'1-1101','Kas Kecil A','','',1,1,1,'','aa',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,1,'1-1102','Kas Kecil 2','','',1,1,1,'','ss',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,1,'1-1105','Kas Kecil Prawang IDR','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,1,'1-1106','Kas Kecil Bandung IDR','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(7,1,'1-1107','Kas Kecil Yogja IDR','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(8,1,'1-1112','Kas Kecil USD','','',1,1,0,'','-',0,4,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-10-03 19:35:13','ipul - Ipul',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(9,2,'1-1120','BCA Bisma IDR (5820032685) Jakarta','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(10,2,'1-1126','Mandiri Prawang (006000010660)','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(11,2,'1-1127','Tapres Bandung (5820339063)','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(12,2,'1-1128','Tapres Yogya','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(13,2,'1-1131','Mandiri USD','','',1,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,2,'1-1200','BANK','','',NULL,1,1,'','BB',0,3,1,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,2,'1-1201','Bank BCA USD','','',14,1,1,'','BB',0,4,1,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(16,2,'1-1202','Bank BCA UERO','','',14,1,1,'','a',0,5,1,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(17,2,'1-1203','Bank BCA Rupiah','','',14,1,1,'','BB',0,3,1,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(18,3,'1-1308','Piutang Belum Tertagih','','',22,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2015-06-08 16:54:55','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(19,3,'1-1305','Piutang DP IDR','','',22,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2015-06-08 16:52:32','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(20,3,'1-1306','Piutang DP EURO','','',22,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2015-06-08 16:52:42','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(21,3,'1-1307','Piutang DP USD','','',22,1,0,'','',0,4,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2015-06-08 16:54:33','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(22,3,'1-1300','PIUTANG DAGANG','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(23,3,'1-1301','Piutang Dagang Rupiah','','',22,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(24,3,'1-1302','Piutang Dagang USD','','',22,1,1,'','',0,4,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-10-03 19:48:15','ipul - Ipul',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(25,3,'1-1303','Piutang Dagang EUR','','',22,1,1,'','',0,5,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-10-03 19:48:10','ipul - Ipul',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(26,3,'1-1304','Piutang PPN','','',22,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(27,3,'1-1400','PIUTANG LAIN-LAIN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(28,3,'1-1401','Piutang Karyawan','','',27,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(29,4,'1-1403','Persediaan Relining','','',27,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(30,3,'1-1499','Piutang Lain-Lain','','',27,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(31,4,'1-1500','PERSEDIAAN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(32,4,'1-1501','Persediaan Sparepart','','',31,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(33,4,'1-1502','Persediaan Unit','','',31,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(34,3,'1-1600','PPN Masukan','','',NULL,1,1,'','',0,NULL,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-09-29 14:43:52','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(35,3,'1-1700','PAJAK DIBAYAR DIMUKA','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(36,3,'1-1701','PDM - PPH 21','','',36,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(37,3,'1-1702','PDM - PPH 22','','',36,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(38,3,'1-1703','PDM - PPH 23','','',36,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(39,3,'1-1704','PDM - PPH 25/29','','',36,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(40,5,'1-1800','BIAYA DIBAYAR DIMUKA','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(41,5,'1-1801','BDM - Sewa Kantor','','',40,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(42,5,'1-1802','BDM - Sewa Mess','','',40,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(43,5,'1-1803','BDM - Asuransi Kesehatan','','',40,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(44,5,'1-1806','Uang Muka - Voucher BBM','','',40,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(45,5,'1-1807','Uang Muka Valas','','',40,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(46,5,'1-1808','Uang Muka Transportasi & Akomodasi','','',40,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(47,5,'1-1809','Uang Muka Pre Finance','','',40,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(48,5,'1-1900','UANG MUKA','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(49,5,'1-1901','Uang Muka Pembelian Rupiah','','',48,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(50,5,'1-1902','Uang Muka Pembelian USD','','',48,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(51,5,'1-1903','Uang Muka Pembelian EUR','','',48,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(52,6,'1-2000','AKTIVA TETAP','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(53,6,'1-2001','Gedung dan Bangunan','','',52,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(54,6,'1-2002','Kendaraan','','',52,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(55,6,'1-2003','Inventaris Kantor','','',52,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(56,7,'1-2100','PENYUSUTAN AKTIVA TETAP','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(57,7,'1-2101','Gedung dan Bangunan','','',56,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(58,7,'1-2102','Kendaraan','','',56,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(59,7,'1-2103','Inventaris Kantor','','',56,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(60,6,'1-2200','AKTIVA LAIN-LAIN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(61,6,'1-2201','Deposit','','',60,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(62,6,'1-2202','Hak Guna Bangunan','','',60,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(63,6,'1-2203','Construction In Progress','','',60,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(64,8,'2-1100','HUTANG DAGANG','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(65,8,'2-1101','Hutang Dagang Rupiah','','',64,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(66,8,'2-1102','Hutang Dagang USD','','',64,1,1,'','',0,4,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2015-06-04 17:22:45','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(67,8,'2-1103','Hutang Dagang EUR','','',64,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(68,8,'2-1104','Hutang Dagang SGD','','',64,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(69,8,'2-1105','Hutang Belum Tertagih','','',64,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(70,8,'2-1106','Hutang DP IDR','','',64,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(71,8,'2-1107','Hutang DP EURO','','',64,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(72,8,'2-1108','Hutang DP USD','','',64,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(73,8,'2-1200','UANG MUKA PENJUALAN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2015-06-08 16:57:13','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(74,8,'2-1201','UM Penjualan Rupiah','','',73,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(75,8,'2-1202','UM Penjualan USD','','',73,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(76,8,'2-1203','UM Penjualan EUR','','',73,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(77,8,'2-1300','Hutang Jangka Pendek','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(78,8,'2-1301','Hutang Bank BCA','','',77,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(79,8,'2-1302','Hutang Leasing A','','',77,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(80,8,'2-1400','PPN Keluaran','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(81,8,'2-1500','HUTANG PAJAK','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(82,8,'2-1501','PPH Pasal 21','','',81,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(83,8,'2-1502','PPH Pasal 22','','',81,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(84,8,'2-1503','PPH Pasal 23','','',81,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(85,8,'2-1504','PPH Pasal 4 ayat (2)','','',81,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(86,8,'2-1505','PPH Pasal 25/29','','',81,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(87,8,'2-1506','Hutang PPN','','',81,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(88,8,'2-1509','Hutang Jamsostek dan Tapro','','',81,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(89,8,'2-1600','BEBAN YANG MASIH HARUS DIBAYAR','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(90,8,'2-1601','Hutang Biaya Gaji','','',89,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(91,8,'2-1602','Hutang Biaya Listrik, air, telephone','','',89,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(92,8,'2-1603','Hutang Biaya Fax dan Speedy','','',89,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(99,8,'2-1800','HUTANG LAIN-LAIN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(100,8,'2-1801','HLL - PT. xxx','','',99,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(101,8,'2-1899','Hutang Lain - Lain','','',99,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(102,8,'2-2100','Hutang Pemegang Saham','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(103,8,'2-2200','HUTANG BANK JANGKA PANJANG','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(104,8,'2-2201','Hutang Bank -','','',103,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(105,8,'2-2202','Hutang Leasing - PT.xxx','','',103,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(106,11,'3-1000','MODAL','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(107,11,'3-1100','Modal Disetor','','',106,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(108,18,'3-1200','Saldo Laba','','',106,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-11-07 05:03:14','admin - administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(109,17,'3-1300','Laba Ditahan','','',106,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-11-07 05:03:19','admin - administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(110,11,'3-1400','Prive','','',106,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(111,12,'4-1000','PENJUALAN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(112,12,'4-1100','PENJUALAN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(113,12,'4-1101','Penjualan UNIT','','',112,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(114,12,'4-1102','Penjualan Sparepart','','',112,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(115,12,'4-1103','Penjualan Jasa','','',112,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(116,12,'4-1200','DISCOUNT PENJUALAN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(117,12,'4-1201','Disc Penjualan UNIT','','',116,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(118,12,'4-1300','RETUR PENJUALAN','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(119,12,'4-1301','Retur Penjualan Unit','','',118,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(120,12,'4-1400','Penjualan Sewa','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(121,12,'4-2000','DISCOUNT PENJUALAN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(122,12,'4-2100','Discount Penjualan Unit','','',120,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(123,12,'4-2200','Discount Penjualan Sparepart','','',120,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(124,12,'4-2300','Discount Penjualan Jasa','','',120,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(125,12,'4-2400','Discount Penjualan Sewa','','',120,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(126,12,'4-3000','RETUR PENJUALAN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(127,12,'4-3100','Retur Penjualan Unit','','',126,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(128,12,'4-3200','Retur Penjualan Sparepart','','',126,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(129,12,'4-3300','Retur Penjualan Jasa','','',126,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(130,12,'4-3400','Retur Penjualan Sewa','','',126,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(131,13,'5-1000','HARGA POKOK PENJUALAN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(132,13,'5-1100','HPP','','',NULL,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(133,13,'5-1101','HPP Unit','','',132,1,1,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(134,13,'5-1200','HPP Penjualan Spareparts','','',132,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(135,13,'5-1300','HPP Penjualan Jasa','','',132,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(136,13,'5-1400','HPP Penjualan Rental/Sewa','','',132,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(137,13,'5-1500','Ass. Pengiriman Unit','','',132,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(138,13,'5-2000','PEMBELIAN BARANG DAGANGAN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(139,13,'5-2100','Pembeliaan Unit','','',138,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(140,13,'5-2200','Pembeliaan Sparepart','','',138,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(141,13,'5-3000','Discount Pembelian','','',138,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(142,13,'5-3100','Disc. Pembelian Unit','','',138,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(143,13,'5-3200','Disc. Pembeliaan Sparepart','','',138,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(144,13,'5-4000','RETURN PEMBELIAN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(145,13,'5-4100','Retur Pembeliaan Unit','','',144,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(146,13,'5-4200','Retur Pembeliaan Sparepart','','',144,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(147,13,'5-5000','BIAYA FREIGHT dan PNBP','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(148,13,'5-5100','Biaya Bea Masuk Unit','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(149,13,'5-5200','Biaya Bea Masuk Sparepart','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(150,13,'5-5300','Biaya PNBP Unit','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(151,13,'5-5400','Biaya PNBP Sparepart','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(152,13,'5-5500','Biaya Freight Unit','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(153,13,'5-5600','Biaya Freight Sparepart','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(154,13,'5-5700','Biaya Demmurage Unit','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(155,13,'5-5800','Biaya Demmurage Sparepart','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(156,13,'5-5900','Asuransi Pengiriman Unit','','',147,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(157,13,'5-6000','BIAYA PEMBELIAN LAIN-LAIN','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(158,13,'5-6100','Biaya Pembeliaan Lain-lain Unit','','',157,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(159,13,'5-6200','Biaya Pembeliaan lain-lain sparepart','','',157,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(160,14,'6-1000','BEBAN OPERASIONAL','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(161,14,'6-1100','BEBAN PENJUALAN','','',160,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(162,14,'6-1101','Biaya Ekspedisi Unit','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(163,14,'6-1102','Biaya Ekspedisi Sparepart','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(164,14,'6-1103','Biaya Pre Delivery','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(165,14,'6-1104','Biaya Ekspedisi Rental','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(166,14,'6-1105','Biaya Waranty','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(167,14,'6-1106','Biaya Promosi','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(168,14,'6-1107','Komisi / Fee Marketing','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(169,14,'6-1199','Lainnya','','',161,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(170,14,'6-2000','BEBAN NON OPERASIONAL','','',NULL,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(171,14,'6-2100','BEBAN ADMINISTRASI dan UMUM','','',170,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(172,14,'6-2101','Gaji Karyawan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(173,14,'6-2102','Tunjangan Uang Makan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(174,14,'6-2103','Tunjangan Transport','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(175,14,'6-2104','Tunjangan Pengobatan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(176,14,'6-2105','Tunjangan Lainnya','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(177,14,'6-2106','Uang Makan Karyawan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(178,14,'6-2107','Premi Tapro','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(179,14,'6-2108','Asuransi Karyawan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(180,14,'6-2109','Jamsostek','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(181,14,'6-2110','Cafetaria Kantor & Mess','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(182,14,'6-2111','Transportasi','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(183,14,'6-2112','Perjalanan Dinas','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(184,14,'6-2113','Biaya Bank','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(185,14,'6-2114','Telepon, Air, Listrik','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(186,14,'6-2115','Fax dan Internet','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(187,14,'6-2116','Sewa Alat Berat (Forklift)','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(188,14,'6-2117','Sewa Kantor','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(189,14,'6-2118','Alat Tulis Kantor (ATK)','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(190,14,'6-2119','Perlengkapan Kantor','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(191,14,'6-2120','Materai / Benda Pos','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(192,14,'6-2121','Percetakan & Fotocopy','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(193,14,'6-2122','Entertainment','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(194,14,'6-2123','Keamanan & Kebersihan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(195,13,'6-2124','Beban Tapro','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(196,14,'6-2125','Jasa Professional','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(197,14,'6-2126','Perizinan & Administrasi','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(198,14,'6-2127','R & M Kantor','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(199,14,'6-2128','R & M Kendaraan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(200,14,'6-2129','R & M Alat Berat','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(201,14,'6-2130','R & M Mesin','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(202,14,'6-2131','Sumbangan / Zakat ','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(203,14,'6-2132','Supplies','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(204,14,'6-2133','Oli dan Pelumas','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(205,14,'6-2134','PPh Ps.21','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(206,14,'6-2135','PPh. Ps 22','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(207,14,'6-2136','PPh Ps.23','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(208,14,'6-2137','PPh Ps.4 Ayat.2','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(209,14,'6-2138','PPh Ps. 25/29','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(210,14,'6-2139','Denda Pajak','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(211,14,'6-2140','Telepon Seluler','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(212,14,'6-2141','Pengobatan Karyawan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(213,14,'6-2142','HSE','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(214,14,'6-2143','Perlengkapan Gudang','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(215,14,'6-2144','Konsumsi Artikel','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(216,14,'6-2145','Kirim Dokument','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(217,14,'6-2146','Asuransi Kendaraan','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(218,14,'6-2147','Asuransi Alat Berat','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(219,14,'6-2148','PBB','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(220,14,'6-2149','Tunjangan Jamsostek','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(221,14,'6-2150','R & M Peralatan Kantor','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(222,14,'6-2199','Biaya Lainnya','','',171,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(223,14,'6-2200','BEBAN PENYUSUTAN','','',170,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(224,14,'6-2201','Beban Peny. Bangunan','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(225,14,'6-2202','Beban Peny. Infrastruktur','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(226,14,'6-2203','Beban Peny. Peralatan Kantor','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(227,14,'6-2204','Beban Peny. Komputer dan Periperal','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(228,14,'6-2205','Beban Peny. Peralatan Gudang','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(229,14,'6-2206','Beban Peny. Kendaraan','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(230,14,'6-2207','Beban Peny. Alat Berat','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(231,14,'6-2208','Beban Peny. Mesin','','',223,1,0,NULL,'',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(233,15,'8-0000','PENDAPATAN LAIN-LAIN','','',NULL,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(234,15,'8-1100','Pendapatan Jasa Giro','','',233,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(235,15,'8-1200','Pendapatan diluar usaha lainnya','','',233,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(236,15,'8-1300','Laba/Rugi Selisih Kurs','','',233,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(237,15,'8-1400','Laba/Rugi Penjualan Asset','','',233,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(238,15,'8-1500','Laba/Rugi Pembulatan','','',233,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(239,15,'8-1999','Pendapatan Lain-Lain','','',233,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(240,16,'9-0000','BIAYA LAIN-LAIN','','',NULL,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(241,16,'9-1100','Biaya Bunga Leasing','','',240,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(242,16,'9-1200','Biaya Bunga Bank','','',240,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(243,16,'9-1300','Biaya Provisi Leasing','','',240,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(244,16,'9-1400','Pajak Bunga Bank','','',240,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(245,16,'9-9000','Lainnya','','',240,1,0,'','',0,3,NULL,NULL,'2014-06-20 11:16:33','NuSoft - NuSoft Administrator','2014-06-20 11:16:33','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(246,11,'3-1900','Penampung Saldo Awal','dsf','sdf',106,1,1,'','',0,3,NULL,NULL,'2014-09-28 06:11:12','NuSoft - NuSoft Administrator','2014-09-28 06:11:12','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(247,3,'1-1309','Piutang Giro','','',22,1,1,'','',0,3,NULL,NULL,'2015-06-08 16:55:21','admin - Administrator','2015-06-08 16:55:21','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(248,8,'2-1109','Hutang Giro','','',64,1,1,'','',0,3,NULL,NULL,'2015-06-08 16:57:04','admin - Administrator','2015-06-08 16:57:04','admin - Administrator',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `m01bcoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01bcontactview`
--

DROP TABLE IF EXISTS `m01bcontactview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01bcontactview` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_contacttype` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_name` varchar(100) NOT NULL,
  `d_address` varchar(150) DEFAULT NULL,
  `f_province` int(100) DEFAULT NULL,
  `f_district` int(100) DEFAULT NULL,
  `d_postal` varchar(6) DEFAULT NULL,
  `d_phone` varchar(20) DEFAULT NULL,
  `d_fax` varchar(20) DEFAULT NULL,
  `d_phonecell1` varchar(20) DEFAULT NULL,
  `d_phonecell2` varchar(20) DEFAULT NULL,
  `d_email` varchar(30) DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `d_active` tinyint(1) NOT NULL DEFAULT '1' COMMENT '0: NonAktif, 1: Aktif',
  `d_npwp` varchar(30) DEFAULT NULL,
  `d_npkp` varchar(30) DEFAULT NULL,
  `d_addresstax` varchar(255) DEFAULT NULL,
  `d_limitar` decimal(18,4) DEFAULT NULL,
  `d_limitap` decimal(18,4) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `d_pembelianbatas` decimal(18,4) DEFAULT NULL,
  `f_pembeliantermin` tinyint(3) unsigned DEFAULT NULL,
  `f_pembeliankaryawan` int(10) unsigned DEFAULT NULL,
  `d_penjualanbatas` decimal(18,4) DEFAULT NULL,
  `f_penjualantermin` tinyint(3) unsigned DEFAULT NULL,
  `f_penjualankaryawan` int(10) unsigned DEFAULT NULL,
  `d_penjualanlevel` tinyint(3) unsigned NOT NULL,
  `d_jeniskelamin` tinyint(3) unsigned NOT NULL,
  `f_bank` smallint(5) unsigned DEFAULT NULL,
  `d_nobank` varchar(100) DEFAULT NULL,
  `d_tglkontrak` date DEFAULT NULL,
  `d_tgllahir` date DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `d_custom6` varchar(255) DEFAULT NULL,
  `d_custom7` varchar(255) DEFAULT NULL,
  `d_custom8` varchar(255) DEFAULT NULL,
  `d_custom9` varchar(255) DEFAULT NULL,
  `d_custom10` varchar(255) DEFAULT NULL,
  `d_aktif` smallint(6) DEFAULT NULL,
  `f_kategori` int(11) DEFAULT NULL,
  `f_subkategori` int(11) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01contactview` (`u_code`),
  KEY `fk_01bcontactview_type_idx` (`f_contacttype`),
  CONSTRAINT `fk_01bcontactview_type` FOREIGN KEY (`f_contacttype`) REFERENCES `m01acontacttype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3916 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata data kontak.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01bcontactview`
--

LOCK TABLES `m01bcontactview` WRITE;
/*!40000 ALTER TABLE `m01bcontactview` DISABLE KEYS */;
INSERT INTO `m01bcontactview` VALUES (786,3,'Intra','PT. Intra Teknika Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',1,'',NULL,'',0.0000,0.0000,'2014-06-20 13:05:05','Impor','2014-09-06 14:35:19','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(787,3,'Iwata','PT. Iwata','',NULL,NULL,'','','','','','','',1,'','','',0.0000,0.0000,'2014-06-20 13:05:05','Impor','2015-10-13 13:03:57','NuSoft - NuSoft Administrator',0.0000,NULL,NULL,0.0000,NULL,NULL,0,0,NULL,'',NULL,NULL,'','','','','','','','','','',NULL,NULL,NULL),(788,2,'Jitex','PT. Jitex Manufacturing Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(789,2,'Kakao','PT. Kakao',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(790,2,'Kaltim','PT. Kaltim Methanol',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(791,2,'Linfox','PT. Linfox',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(792,2,'Lucky','PT. Lucky Unggul Pratama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(793,2,'Mabua','PT. Mabua Detroid',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(794,2,'Margo','PT. Margo Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(795,2,'Merten','PT. Merten Intech',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(796,2,'MGH','PT. Mega Horizon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(797,2,'Menteng','PT. Menteng Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(798,2,'Mikatasa','PT. Mikasata Agung',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(800,2,'Dieselindo','PT. Multi Dieselindo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(801,2,'Nagasakti','PT. Nagasakti',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(802,2,'Pasific','PT. Pacific Motor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(803,2,'Pasindo','PT. Pasindo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(804,2,'Meratus','PT. Pelayaran Meratus',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(805,2,'Perkasa','PT. Perkasa Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(806,2,'Persada','PT. Persada Mitra Indotek',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(807,2,'Plastik','PT. Plastik Injection',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(808,2,'Ploss','PT. Ploss Asia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(809,2,'Prapat','PT. Prapat Tunggal Cipta',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(810,2,'Putra','PT. Putra Mataram',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(811,2,'Raya Indo','PT. Raya Indo Fortuna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(812,2,'Sanjaya','PT. Sanjaya Prima Mandiri',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(815,2,'Sindu','PT. Sindu Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(816,2,'Spektrum','PT. Spektrum Krisindo Electrika',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(817,2,'Surya','PT. Surya Mandiri Sukses',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(818,2,'Surya Mas','PT. Surya Mas Abadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(819,2,'Tirtamas','PT. Tirtamas',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(820,2,'Trias','PT. Trias Sentosa Tbk',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(821,2,'Trikarya','PT. Trikarya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(822,2,'Tunggal','PT. Tunggal Jayapari',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(823,2,'Union','PT. Union Motor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(824,2,'United Can','PT. United Can',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(825,2,'Yosada','PT. Yosada',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(826,2,'Yudhistira','PT. Yudhistira',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(827,2,'RMU','PT. Rasa Mutu Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(828,2,'Fersanindo','PT. Fersanindo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(829,2,'Henhart ','CV. Henhart Jaya Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(830,2,'Dharana','PT. Dharana Inti Boga  (Garudafood Makasar)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(831,2,'CT','PT. Cahaya Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(832,2,'Uni Rama','PT. Uni Rama Duta Niaga',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(833,2,'Cardig','PT. Cardig Express',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(834,2,'Pangan','PT. Pangan Sari Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(835,2,'Duta Nova','PT. Duta Nova',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(836,2,'TPN','PT. Tata Persada Nusantara',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(837,2,'Servindo','PT. Servindo Jasa Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(838,2,'Pre-Tech','PT. Pec-Tech Services Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(839,2,'Wijaya','PT. Wijaya Equipments',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(840,2,'Mitra','CV. Mitra Teknik Abadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(842,2,'Mitratama','PT. Mitratama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(843,2,'DDA','PT. Duta Dinasty Abadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(844,2,'Gie','PT. Gie Workshop',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(845,2,'Salam','PT. Salam Pacific Indonesia Lines',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(846,2,'Perintis','PT. Perintis Delta Tehnik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(847,2,'Ateja','PT. Ateja',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(848,2,'Bandarsyah','PT. Bandarsyah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(849,2,'Tehnik','PT. Tehnik Canggih',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(850,2,'Viktori','PT. Viktori Profindo Industri',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(851,2,'Dinamika','PT. Dinamika Plastindo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(852,2,'Heinz','PT. Heinz ABC',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(853,2,'Buana penta','PT. Buana Penta Prima',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(854,2,'Sakura','PT. Sakura Central Solution',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(855,2,'Printindo','PT. Printindo Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(856,2,'Flexico','PT. Flexico',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(857,2,'Trinitas','PT. Trinitas Sejahteratama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(858,2,'Candra Arta','PT. Candra Arta Mandiri',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(859,2,'Jaya Sentosa','PT. Jaya Sentosa Abadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(860,2,'Pelabuhan','PT. Pelabuhan Indonesia I (Persero) Cab Belawan (BICT)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(861,2,'Bumi','PT. Bumi Laras',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(862,2,'Prima','PT. Prima Power',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(863,3,'SR','Sumber Rejeki',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(864,2,'MHB','PT.MHB Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(865,2,'ASL','PT ANUGERAH SETIA LESTARI',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(866,2,'DS','PT. Damai Sejahtera',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(867,2,'FMD','PT. Ferro Mas Dinamika',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(868,2,'GTK','GT Kabel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(869,2,'Hankam','PT. Hankam',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(870,3,'DEPNAKER','DEPNAKER',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(871,3,'ALVA','ALVA VALASINDO',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(872,3,'QBE POOL','Assuransi QBE Pool Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(873,3,'PC PERAWANG','PC PERAWANG',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(874,3,'Multi Furniture','Multi Furniture',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(875,3,'SETIA JAYA','Setia Jaya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(876,3,'MAKMUR ABADI','Makmur Abadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(877,3,'ASTRA International','PT. ASTRA International Tbk',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(878,3,'IE','PT. Incomation Engineering',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(879,3,'IP','PT. Indo Power',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(880,3,'IGROS','Indogrosir',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(881,2,'Indomarco','PT. Indomarco',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(882,2,'KLI','PT. Kimberly Lever Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(883,2,'NF','PT. Nabisco Food',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(884,2,'Natra','PT. Natra Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(885,3,'Nabila Florist','NABILA FLORIST',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(886,3,'Galunggung Ban','GALUNGGUNG BAN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(887,2,'ALLIANZ','Asuransi Allianz Life Indonesia','jl aa no 8 Jakarta\r\njakarta 13245',NULL,NULL,'','','','','','','adsadsd',1,'asdasd','','asdasd',0.0000,0.0000,'2014-06-20 13:05:05','Impor','2015-05-25 07:21:36','admin - Administrator',0.0000,NULL,NULL,0.0000,NULL,NULL,0,0,NULL,'',NULL,NULL,'','','','','','','','','','',NULL,NULL,NULL),(889,3,'YUSUF','Yusuf Kain Majun',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(891,3,'PLN','PLN & TELKOM',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(892,3,'ARRONZ','ARRONZ AUTO',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(894,3,'MPM','Mega Prima Motor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(895,3,'Sales10','Awaludin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(897,2,'Prakarsa','Prakarsa Alam Segar',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(899,3,'GS TOUR','PT. Globalindo Wisata Tour & Travel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(900,3,'MASPION','PT. MASPION SURABAYA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(902,3,'CTS','CV. Tractor Service',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(903,3,'MANDIRI','IDR MANDIRI',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(904,3,'TAPRES SURABAYA','BCA SURABAYA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(905,3,'TAPRES PERAWANG','MANDIRI PERAWANG',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(906,3,'BISMA EURO','BCA BISMA EURO',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(907,3,'ANZ USD','ANZ USD',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(908,3,'ANZ EURO','ANZ EURO',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(910,3,'PRW','SATELITE PERAWANG',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(911,3,'SBYO','SATELITE SURABAYA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(912,2,'Java','CV. Java Protekindo Caraka',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(913,3,'HJ','Harapan Jaya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(917,2,'Borneo','PT. Borneo Adelia Pratama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(919,3,'JABABEKA','PT. Jababeka Infrastruktur',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(920,3,'LOGWIN','PT. Logwin Air & Ocean Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(921,2,'MEV','PT. MEV SOLUSINDO',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(922,3,'Lain-Lain','Lain-Lain',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(923,3,'BABINSA','Babinsa Kel. Pisangan Timur',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(924,3,'JTB','PT. Jaya Tirta Bersama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(925,3,'GERINDO','Union Bearing (GERINDO)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(926,3,'IQios','IQios.com',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(928,3,'AIRESS','PT. Airess Megah Utama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(929,3,'AJT','Adi Jaya Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(931,3,'BCA Fin','BCA Finance',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(933,2,'LF','LF Services Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(934,3,'ANTEK','ANUGERAH TEHNIK',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(935,3,'KWD','Karya Widjoyo Danula',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(936,3,'Berkah','UD. Berkah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(937,3,'Service19','Zaenal',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(938,3,'Cipinang Agency','Cipinang Agency',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(939,2,'GSC','PT. Global Success Chain',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(940,2,'PNS','PT. Putra Niaga Sejahtera',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(941,2,'Astra','PT. Astra Otoparts Tbk',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(942,3,'BAP','Bintara Andalan Motor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(943,2,'Manohara','PT. Manohara Asri',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(945,2,'Justin','Bp. Justin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(946,3,'ARROW','PT. Arrow Asia Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(947,2,'SUPRIADI','Bapak Supriadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(949,3,'SUDIN','Suku Dinas Tenaga Kerja Jakarta Timur',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(950,3,'CJM','PT. Cipta Jaya Mobilindo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(951,3,'Cepot','Cepot Trans',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(952,2,'Century','PT. Century Mitra Sukses Sejati',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(953,3,'JOG2','Sutadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(955,2,'FJP','CV. Fasindo Jaya Perkasa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(956,3,'Kec. Pulogadung','Kecamatan Pulogadung',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(957,3,'CAMAR','PT. Camar Khatulistiwa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(958,3,'Service20','Dwi Putra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(959,3,'GA4','Saeful',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(960,3,'Service21','M. Ridwan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(962,2,'Mitra Sukses','Cv. Mitra Sukses',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(964,3,'AGILITY','PT. AGILITY INTERNATIONAL',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(965,3,'MYRA YUWONO','Notaris Myra Yuwono, SH',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(966,3,'Evan Setiawan','Evan Setiawan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(967,3,'BDG','SATELITE BANDUNG',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(968,3,'TAPRES BANDUNG','BCA BANDUNG',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(969,3,'KALIMAS','PT. KALIMAS',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(970,2,'KEPPEL','PT. KEPPEL PUNINAR LOGISTICS',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(971,2,'FORISA','PT. FORISA NUSAPERSADA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(972,3,'JNB','Jakarta Notebook.com',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(974,3,'Sinergi CYBER','Sinergi CYBER',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(975,3,'BDG2','Tita Maharani',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(976,3,'PC BANDUNG','PC BANDUNG',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(977,3,'PC USD','PC USD',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(978,3,'PC SGD','PC SGD',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(979,3,'Anna','Anna (Pembersih Telepon)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(980,3,'FOOD STATION','PT. FOOD STATION TJIPINANG JAYA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(981,2,'ASTARI','PT. Astari Niagara Internasional',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(982,3,'FMS','PT. Fajar Mitra Negara',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(983,2,'Tonny Arifin','Tonny Arifin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(984,2,'TESLA','PT. Tesla Power Asia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(985,2,'Firna','PT. Firna Glass',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(986,2,'PBM OJA','PT. PBM Olah Jasa Andal',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(988,3,'PRW3','Afri. S',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(989,3,'GALAXY','GALAXY TECHNICAL SUPPLY',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(990,3,'PC JOGJA','PC JOGJA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(991,2,'Hartono','PT. Hartono Istana Teknologi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(992,2,'Mitra Pratama','PT. Mitra Pratama Sriwijaya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(993,2,'BS','PT. Bintang Sriwijaya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(994,3,'CBM Motor','CBM Motor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(995,3,'NOTARIS','notaris Maryanti Tirtowijoyo, S.H. M.Kn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(996,2,'OTTO','PT. OTTO PHARMACEUTICAL INDUSTRIES',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(997,2,'KUS','PT. KARUNIA USAHA SEJAHTERA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(998,2,'Asep','Bp. Asep',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(999,3,'BPI','Battery Power International Private Limited',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1000,3,'TIRTA','PT. TIRTA INVESTAMA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1002,3,'BDG3','Riyan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1004,2,'Papertech','PT. Papertech Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1005,3,'Service24','Malik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1006,3,'Service25','Didik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1007,2,'Hendra','Bp. Hendra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1008,3,'CKR6','Fahmi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1009,3,'CKP8','Endang',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1010,3,'ST','SUMBER TEKNIK',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1011,2,'Tunas','PT. Tunas Ruang Mesin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1012,2,'Flift','PT. Flift Lestari Makmur',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1013,2,'TRIO','PT. Trio Hutama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1014,2,'Mondelez','PT.MONDELEZ INDONESIA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1015,2,'Supra Genaral','PT. Supra General',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1016,3,'TAPRES JOGJA','TAPRES JOGJA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1017,2,'SKI','PT. Satyaraya Keramindoindah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1018,3,'Bimas','Bimas Kel. Pisangan Timur',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1019,3,'Wisman',' PT. Wisata Mancanegara Nugraha (Wisman Tour)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1020,3,'GA5','Nurhani (Pulung)',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1021,2,'Dinamic','PT. Dinamic Electrical Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1022,3,'SP','Sukses Plastik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1023,3,'KDJ','Kadin DKI Jakarta',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1024,3,'STK','Sumber Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1026,2,'RIF',' PT. Raya Indo Fortuna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1027,3,'Service26','Lukito',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1028,2,'Danola','PT. Danola Teknik Prima',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1029,3,'HP','PT.Handi Perkasa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1030,2,'FK','PT. Federal Karyatama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1031,2,'Helindo','PT. Helindo Tech Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1032,2,'TPI','PT. Toro Perkasa Industry',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1033,2,'henkel','PT. Henkel Adhesive Technologoies',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1034,3,'Sales11','Chariul',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1035,3,'Service27','Agi Rusmana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1036,2,'kianis','PT. Kianis Pratama',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1037,2,'Asahi','PT. Indofood Asahi Sukses Beverage',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1038,3,'YWN','Yuwono,H & Rekan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1039,2,'centra','PT. Centra Qualita',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1041,2,'Mondelez Manufacturing','PT. Mondelez Indonesia Manufacturing ',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1042,2,'putra pandawa','PT. Putra Pandawa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1043,3,'sumito','PT.Sumito Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1044,2,'Trisumber','PT. Trisumber Makmur Indah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1045,2,'Megasetia','PT. Megasetia Agung Kimia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1046,2,'suntory','PT. Suntory Garuda Beverage',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1047,2,'The First','PT. The First National Glassware',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1049,2,'Davis','CV. Davis Anugrah Teknik',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1050,2,'JPP','Jayatech Putra Perkasa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1051,2,'DMU','PT. DWI MITRA UNGGUL',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1052,2,'Indoperkasa','PT. Indoperkasa Abadi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1053,2,'CP','CV. PROLIFT',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1054,2,'Nestle','PT. Nestle Indonesia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1056,2,'BMS','PT. Bintang Mandiri',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1057,3,'Karya Rejeki','Karya Rejeki',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1058,2,'natura','PT. Natura Plastindo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1059,2,'Port','PT. PORT RUSH',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1060,2,'Mitra Berdikari','CV. Mitra Berdikari',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1062,3,'TPE','PT.Tutorial Prime Engineering ',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1063,3,'Service28','Dian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1065,2,'Citra Prima','PT. Citra Prima Diesel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1066,3,'Arca','PT. Arca Mandiri Ekspress',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1067,3,'Service29','Tri',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1068,3,'Service30','Erwin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,'2014-06-20 13:05:05','Impor','2014-06-20 13:05:05','Impor',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1069,1,'Paidi','Paidi','',NULL,NULL,'','','','','','','',0,'','','',0.0000,0.0000,'2014-09-04 17:14:18','NuSoft - NuSoft Administrator','2015-10-27 03:49:13','NuSoft - NuSoft Administrator',0.0000,NULL,NULL,0.0000,NULL,NULL,0,0,NULL,'',NULL,NULL,'','','','','','','','','','',NULL,NULL,NULL),(1070,1,'Soleh','M. Soleh','',NULL,NULL,'','','','','','','',0,'asdsad','','',0.0000,0.0000,'2014-09-06 14:39:03','NuSoft - NuSoft Administrator','2015-10-27 03:49:05','NuSoft - NuSoft Administrator',0.0000,NULL,NULL,0.0000,NULL,NULL,0,0,NULL,'',NULL,NULL,'','','','','','','','','','',NULL,NULL,NULL),(1071,2,'PT Jali','PT JALI',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',1,'',NULL,'asdasd',0.0000,0.0000,'2014-09-20 15:50:52','NuSoft - NuSoft Administrator','2014-09-20 15:50:52','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1072,2,'PT Nriman','PT Nriman',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',1,'',NULL,'dasd',0.0000,0.0000,'2014-09-20 15:51:29','NuSoft - NuSoft Administrator','2014-09-20 15:51:29','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1073,2,'PT TOHA','PT TOHA',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'',1,'',NULL,'asdasd',0.0000,0.0000,'2014-09-20 15:52:34','NuSoft - NuSoft Administrator','2014-09-20 15:52:34','NuSoft - NuSoft Administrator',NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1074,3,'Xander','Genevieve, Rina, Rigel, Ursa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1075,3,'Ezra','Brandon, Zachery, Debra, Samantha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1076,3,'Joseph','Stewart, Camden, Quincy, Jada',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1077,3,'Damon','Rudyard, Wylie, Audrey, Mikayla',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1078,3,'Xanthus','Malachi, Chiquita, Brady, Kyra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1079,3,'Eaton','Lara, Cedric, Austin, Connor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1080,3,'Graiden','Arthur, Whoopi, Quinlan, Avram',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1081,3,'Arden','Megan, Samantha, Alan, Marshall','',NULL,NULL,'','','','','','','',1,'','','',0.0000,0.0000,NULL,NULL,'2015-05-23 18:33:47','admin - Administrator',0.0000,NULL,NULL,0.0000,NULL,NULL,1,1,NULL,'',NULL,NULL,'','','','','','','','','','',NULL,NULL,NULL),(1082,3,'Todd','Amity, Kylee, Jack, Bell',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1084,3,'Edan','Arden, Hilda, Stella, Arthur',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1085,3,'Judah','Warren, Rose, Stuart, Lila',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1086,3,'Mohammad','Magee, Jerome, Hoyt, Nasim',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1087,3,'Darius','Montana, Hermione, Kaseem, Colby',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1088,3,'Omar','Kai, Joel, Jarrod, Cheryl',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1089,3,'Sawyer','Jonas, Breanna, Wynne, Cedric',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1090,3,'Axel','Lysandra, Ray, Ezra, Deacon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1091,3,'Amery','Halee, Madeson, Blair, Yen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1092,3,'Wayne','Rhiannon, Colton, Paki, Mohammad',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1093,3,'Christian','Ferdinand, Bree, Kaden, Emi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1094,3,'Erasmus','Eve, Arthur, Wendy, Keelie',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1095,3,'Dalton','Aiko, Keith, Samson, Hermione',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1096,3,'Adam','Katelyn, Walter, Illiana, Reed',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1097,3,'John','Portia, Clementine, Minerva, Ruby',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1098,3,'Hashim','Julian, Emily, Allistair, Cassidy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1099,3,'Cruz','Griffith, Colby, Raymond, Hedy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1100,3,'Salvador','Maryam, Ezra, Austin, Teagan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1101,3,'Norman','Vernon, Sierra, Carlos, May',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1102,3,'Stewart','Merrill, Marcia, Nash, Channing',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1103,3,'Amal','Vanna, Jordan, Alika, Castor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1104,3,'Dustin','Clayton, Uriel, Erasmus, Herman',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1105,3,'Brett','Holmes, Marvin, Anjolie, Emery',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1106,3,'Cedric','Skyler, Elaine, Blythe, Lysandra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1107,3,'Vladimir','Sylvester, Lois, Hanna, Charity',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1108,3,'Quinlan','Dennis, Kermit, Chantale, Wayne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1109,3,'Andrew','Hyacinth, Astra, Jermaine, Eden',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1110,3,'Uriel','Rudyard, Colt, Paula, Amal',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1111,3,'Lane','Lydia, Wesley, David, Bruce',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1112,3,'Timon','Ethan, Hayes, Celeste, Blaze',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1113,3,'Drake','Freya, Mira, Armando, Kirestin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1114,3,'Jesse','Kelsie, Cedric, Hedwig, Guy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1115,3,'Grady','Keith, Clinton, Christian, Evelyn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1118,3,'Mufutau','Irene, Harriet, Orli, Alice',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1119,3,'Jason','Mark, Edan, Jasmine, Kane',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1120,3,'Allistair','Devin, Igor, September, Mikayla',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1121,3,'Owen','Hanae, Marvin, Quyn, Mikayla',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1122,3,'Lance','Rama, Brett, Jin, Vance',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1123,3,'Graham','Dawn, Adena, Solomon, Roth',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1124,3,'Cairo','Alma, Blake, Dale, Adena',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1125,3,'Gavin','Mufutau, Ryder, August, Taylor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1126,3,'Charles','Amethyst, Richard, Josiah, Halee',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1128,3,'Cooper','Hedley, Lois, Dane, Chase',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1129,3,'Russell','Maggie, Yvette, Griffith, Ava',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1130,3,'Sean','Owen, Logan, Liberty, Edward',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1131,3,'Keane','Cade, Demetria, Daria, Rajah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1132,3,'Vincent','Marny, Azalia, Donna, Adrienne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1133,3,'Orson','Ava, Serina, Hollee, Glenna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1134,3,'Thor','Lael, Gay, Lionel, Hadley',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1135,3,'Hilel','Charde, Zena, Jolene, Amanda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1136,3,'Jerry','Gwendolyn, Ashton, Rylee, Brianna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1137,3,'Colton','Nola, Britanney, Ivy, Keane',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1138,3,'Dale','Damian, Ocean, Emma, Julie',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1139,3,'Oliver','Finn, Emma, Ginger, Kyle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1140,3,'Octavius','Daquan, Amena, Nora, Jessica',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1141,3,'Hayden','Justina, Yetta, Jaime, Macon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1142,3,'Baker','Burton, Xavier, Isabelle, Hilel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1143,3,'Deacon','Ignatius, Laura, Kennan, Christian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1144,3,'Dennis','Amir, Phyllis, Keane, Winifred',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1145,3,'Hamilton','Tarik, Harlan, Caldwell, Hayden',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1147,3,'Chase','Shana, Garrett, Leigh, Herman',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1148,3,'Hakeem','Rigel, Rhonda, Uriel, Stacy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1150,3,'Warren','Quentin, Yoshio, Lucas, Brett',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1151,3,'Noble','Yvette, Alden, Michelle, Hadassah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1153,3,'Merritt','Madison, Colt, Rachel, Rebecca',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1154,3,'Tyrone','Phelan, Brenna, Astra, Imelda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1155,3,'Perry','Avye, Candice, Cairo, Donna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1156,3,'Nissim','Naomi, Griffith, Zachery, Bertha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1157,3,'Brody','Chanda, Kiara, Uriah, Lilah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1158,3,'Rudyard','Fulton, Maile, Gail, Xavier',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1159,3,'Declan','Randall, Demetria, Wayne, Erica',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1160,3,'Jelani','Jade, Gail, Wesley, Montana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1161,3,'Malik','Raven, Kasimir, Glenna, Kalia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1164,3,'Nathan','Whilemina, Eagan, Barbara, Guinevere',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1165,3,'Kermit','Randall, Beau, Drew, Hashim',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1166,3,'Phelan','Melissa, Kane, Gil, Timothy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1167,3,'Linus','Kennan, Iola, Lila, Doris',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1168,3,'Emery','Quon, Germane, Ashely, Kerry',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1170,3,'Tanek','Quinn, Kenneth, Amy, Ella',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1171,3,'Zachary','Liberty, Vielka, Garrett, Skyler',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1172,3,'Berk','Winter, Katelyn, Ginger, Guy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1173,3,'Fletcher','Ishmael, Doris, Alan, Ocean',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1175,3,'Matthew','Kathleen, Myles, Patricia, Dolan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1176,3,'Keith','Cole, Adrienne, Kameko, Macon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1177,3,'Aquila','Yasir, Lucian, Dawn, Mara',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1178,3,'Jarrod','Cynthia, Rooney, Shelley, Garrett',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1181,3,'Hiram','Garrison, Marah, Debra, Angela',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1183,3,'Ezekiel','Cheryl, Brett, Kareem, Amela',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1184,3,'Solomon','Hanae, Zoe, Jade, Zahir',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1185,3,'Jasper','Aline, Noble, Kylan, Alexa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1186,3,'Carlos','Malik, Jena, Xantha, Brady',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1187,3,'Tobias','Hunter, Troy, Forrest, Gretchen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1188,3,'Buckminster','Nora, Sean, Tanisha, Len',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1189,3,'Jermaine','MacKenzie, Davis, Bryar, Bruno',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1190,3,'Kasper','Risa, Grace, Tatiana, Daphne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1191,3,'Arthur','Breanna, Zenaida, Dennis, Lucy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1192,3,'Rahim','Sean, Ignatius, Rebecca, Arsenio',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1193,3,'Lars','Jackson, Nomlanga, Helen, Chloe',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1194,3,'Micah','Drew, Fatima, Luke, Rafael',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1195,3,'Kamal','Blossom, Carol, Paula, Cole',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1197,3,'Sebastian','Leandra, Calvin, Sebastian, Lucian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1198,3,'Nathaniel','Meghan, Gareth, Lois, Sara',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1199,3,'Porter','Jane, Charles, Talon, Lucas',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1200,3,'Addison','Blythe, Anthony, Lacota, Alvin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1201,3,'Alexander','Chaney, Ignacia, Solomon, Byron',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1202,3,'Arsenio','Gregory, Yuli, Dolan, Teagan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1204,3,'Lionel','Nathan, Rahim, Macon, Sonya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1205,3,'William','Jameson, Cecilia, Moses, Ahmed',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1207,3,'Emmanuel','Lillian, Luke, Catherine, Karly',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1208,3,'Wang','Quinn, Ima, Nola, Brooke',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1210,3,'Kelly','Fatima, Roth, Fritz, Barrett',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1211,3,'Oren','August, Louis, Grace, Cassidy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1213,3,'Seth','Winifred, Kareem, Quemby, Aileen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1214,3,'Paul','Amaya, Amanda, Pamela, Pandora',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1215,3,'Alan','Candice, Dana, Keegan, Ariel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1216,3,'Carson','Thane, Jarrod, Burton, Cairo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1219,3,'Brandon','Russell, Asher, Gannon, Kitra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1220,3,'Macaulay','Shad, Benjamin, Blaine, Blair',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1222,3,'Alec','Kai, Bert, Joseph, Kuame',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1223,3,'Abbot','Raphael, Kimberley, Myra, Ferdinand',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1224,3,'Murphy','Lars, Jena, Shana, Ciaran',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1225,3,'Thomas','William, Lacey, Maggy, Mallory',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1226,3,'Walter','Athena, Moses, Ginger, Ferdinand',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1227,3,'Lawrence','Alika, Ivor, Deacon, Karen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1229,3,'Beck','Shaine, Claire, Germane, Wayne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1231,3,'Chaney','Kim, Meredith, Dorothy, Ashely',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1232,3,'Nigel','Axel, Cecilia, Preston, Zeus',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1233,3,'Nehru','Finn, Wyatt, Ori, Francesca',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1234,3,'Stone','Axel, Jaime, Catherine, Nevada',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1235,3,'Benjamin','Madaline, Idola, Karina, Kirsten',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1237,3,'Flynn','Ashely, Barrett, Eden, Donovan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1238,3,'Dean','Colleen, Leslie, Gil, Phoebe',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1240,3,'Mason','Damon, Keefe, Maite, Laurel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1241,3,'Gil','Jarrod, Myles, Zelenia, Jamalia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1242,3,'Fuller','Nicole, Craig, Ria, Odette',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1244,3,'Jared','Vance, Sade, Tad, Knox',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1248,3,'Sylvester','Ahmed, Xantha, Xyla, Eagan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1250,3,'Hedley','Jena, Dean, Marshall, Brian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1251,3,'Jacob','Jordan, Teegan, Cherokee, Marshall',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1252,3,'Zeus','Maxine, Victoria, Hadley, Serina',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1254,3,'Jackson','Harrison, Grant, Talon, Kiayada',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1255,3,'Donovan','Melodie, Macy, Charissa, Avye',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1256,3,'Harlan','Cally, Kaitlin, Signe, Mercedes',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1257,3,'Steel','Hop, Teagan, Kimberley, Alden',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1258,3,'Kenyon','Aristotle, Erich, Whilemina, Zia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1259,3,'Zephania','Reuben, Amos, Ross, Abbot',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1261,3,'Adrian','Zahir, Quinn, Arthur, Camille',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1263,3,'Blake','Zeus, Hamilton, Clio, Orli',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1264,3,'Basil','Peter, Raja, Jana, Quintessa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1265,3,'Lewis','Danielle, Taylor, Berk, Yasir',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1266,3,'Cadman','Macy, Jakeem, Yoshi, Unity',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1267,3,'Aladdin','Kelly, Malik, Ava, Uriel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1269,3,'Brian','Marvin, Peter, Tasha, Lester',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1273,3,'Garrett','Jermaine, Zeus, Remedios, Madeline',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1274,3,'Nicholas','Pearl, Erich, Leandra, Leo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1276,3,'Timothy','Jenette, Deirdre, Justine, Alvin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1279,3,'Clinton','Sandra, Kimberly, Tara, Leilani',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1280,3,'Talon','Alfonso, Zorita, Kieran, Clementine',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1281,3,'Thaddeus','Adele, Jamalia, Jarrod, Chester',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1283,3,'Burton','Ishmael, Alden, Madison, Chaim',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1284,3,'Kenneth','Ariel, Dominic, Zoe, Noah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1285,3,'Martin','Martin, Julian, Noelani, Abigail',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1286,3,'Ignatius','Grady, Angelica, Alvin, Benedict',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1288,3,'Jerome','Derek, Palmer, Lester, Aaron',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1289,3,'Ethan','Scarlet, August, Serina, Jenna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1290,3,'Lev','Daria, Deirdre, Wyatt, Gavin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1292,3,'Kirk','Evangeline, Callum, Mercedes, Gloria',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1293,3,'Vaughan','Charissa, Hu, Kirsten, Irene',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1294,3,'Daquan','Kimberly, Phelan, Janna, Hayley',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1295,3,'Jameson','Nelle, Noel, Macaulay, Caldwell',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1296,3,'Xavier','Orson, Priscilla, Katelyn, Xerxes',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1297,3,'Randall','Clayton, Simon, Inga, James',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1298,3,'Macon','Madeson, Maya, Barbara, Yardley',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1299,3,'Tiger','Ashton, Phyllis, Shellie, Ivor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1300,3,'Demetrius','Yael, Cheryl, Keane, Inez',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1302,3,'Francis','August, Althea, Beau, Quinlan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1304,3,'Austin','Chava, Candace, Lionel, Colette',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1305,3,'Jakeem','Quail, Melyssa, Simone, Orla',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1307,3,'Hamish','Sonia, Rinah, Francesca, Kevin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1310,3,'Ferdinand','Nadine, Quynn, Nelle, Naomi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1311,3,'Vance','Sierra, Eugenia, Idona, Violet',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1312,3,'Magee','Valentine, Macey, Kimberley, Melinda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1316,3,'Christopher','Demetria, Tyler, Sydnee, Austin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1319,3,'Cameron','Arthur, Gannon, Berk, Susan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1324,3,'Leo','Amity, Xandra, Amber, Holmes',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1326,3,'Howard','Alfonso, Hayden, Porter, Gwendolyn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1327,3,'Carter','Chloe, Deanna, Colleen, Clark',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1328,3,'Jonah','Stuart, Lois, Quinn, Branden',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1331,3,'Ryder','Faith, Orson, Daquan, Amber',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1332,3,'Chadwick','Vincent, Justin, Farrah, Zenaida',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1333,3,'Louis','Brielle, Virginia, Ursa, Cally',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1335,3,'Isaiah','Joshua, Cruz, Graiden, Yeo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1337,3,'Rooney','Olivia, Ian, Victor, Kadeem',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1339,3,'Thane','Heidi, Gil, Fuller, Rigel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1340,3,'Ali','Lee, Destiny, Dale, Chava',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1341,3,'Calvin','Merrill, Jacqueline, Jonah, Leonard',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1342,3,'Lee','Zelenia, Ross, Bryar, Jonah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1343,3,'Leonard','Castor, Ruby, Tatiana, Keiko',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1344,3,'Gage','Xantha, Dale, Deirdre, Colby',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1345,3,'Dante','Solomon, Price, Griffin, Tasha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1346,3,'Abraham','Nero, Shelly, Mara, Austin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1347,3,'Cyrus','Colette, Fuller, Kylynn, Chancellor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1350,3,'Jamal','Gillian, Gary, Dean, Odette',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1351,3,'Daniel','Conan, Jolie, Clio, Keane',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1352,3,'Duncan','Fay, Seth, Mollie, Sharon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1354,3,'Walker','Jescie, Dustin, Justina, Galena',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1357,3,'Coby','Melinda, Holly, Quin, Ronan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1359,3,'Nash','Thane, August, Cooper, Davis',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1363,3,'Myles','Sierra, Eaton, Kristen, Amal',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1366,3,'Maxwell','Xena, Fulton, Dylan, Anne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1368,3,'Ashton','Adara, Ashely, Deanna, Damon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1369,3,'Kyle','Omar, Jared, Beck, Anika',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1371,3,'Geoffrey','Jenette, Kiona, Mufutau, Neil',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1374,3,'Bevis','Phyllis, Davis, Selma, Rhea',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1375,3,'Gregory','Shafira, Mia, Nasim, Maxine',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1378,3,'Simon','Sophia, Tate, Drake, Diana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1379,3,'Hyatt','Rana, Ulla, Marvin, Shoshana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1380,3,'Ulysses','Alec, Olivia, Virginia, Clementine',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1381,3,'Ciaran','Hunter, Ava, Keely, Jin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1384,3,'Conan','Yasir, Ian, Dean, Noelle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1386,3,'Hayes','Alea, Jena, Ahmed, Kiayada',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1387,3,'Merrill','Russell, Sage, Fitzgerald, Keane',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1389,3,'Elvis','Neve, Cain, Oscar, Evelyn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1390,3,'Elliott','Orlando, Tanek, Tatum, Upton',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1391,3,'Hunter','Charity, Yoko, Kameko, Maggy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1398,3,'Gray','Rachel, Jillian, Fiona, Dexter',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1400,3,'Channing','Maryam, September, Susan, Theodore',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1403,3,'Dieter','Meghan, Xenos, Nero, Stacy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1405,3,'Clayton','Ulric, Imani, Eugenia, Autumn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1407,3,'Elmo','Teegan, Isadora, Amos, Idona',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1408,3,'Tate','India, Portia, Ignatius, Harlan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1409,3,'Samuel','Allegra, Simone, Jade, Chelsea',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1410,3,'Blaze','Byron, Keith, Vera, Sopoline',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1412,3,'Robert','Xenos, Jaime, Suki, Eagan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1413,3,'Bruno','Bethany, Raymond, Zelenia, Kendall',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1415,3,'Raymond','Yardley, Lynn, Edan, Robert',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1416,3,'Colby','Hyatt, Lars, Ignacia, Felix',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1418,3,'Aidan','Alea, Ashely, Petra, Ariana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1419,3,'Brent','Paki, Leilani, Jamalia, Wade',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1421,3,'Cody','Cynthia, Uriel, Anjolie, Vladimir',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1422,3,'Dylan','Declan, Raja, Malik, Sage',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1425,3,'Eagan','Yuli, Cailin, Lillith, Kathleen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1426,3,'Derek','Damon, Chester, Tatum, Ursa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1429,3,'Eric','Hoyt, Beau, Kerry, Martena',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1430,3,'Jeremy','Mannix, Kim, Diana, Blaine',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1431,3,'James','Larissa, Christian, Carlos, Reece',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1432,3,'Jordan','Ferris, Blaine, Jessica, Barry',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1434,3,'Nasim','Zelenia, Hoyt, Conan, Guinevere',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1435,3,'Plato','Sharon, Jaime, Samantha, Brent',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1437,3,'Colin','Mechelle, Ross, Timothy, Keefe',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1438,3,'Garrison','Gail, Walter, Omar, Nerea',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1440,3,'Lyle','Anthony, Stacy, Yael, Mohammad',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1442,3,'Brock','Yen, Petra, Nero, Camille',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1443,3,'Quinn','Harriet, Leilani, Maia, Garrett',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1444,3,'Acton','Carissa, Tobias, Paul, Alisa',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1446,3,'Hop','Grady, Hedley, Cyrus, Davis',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1449,3,'Elton','Kelsie, Leroy, Orli, Priscilla',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1453,3,'Hu','James, Alvin, Darrel, Myra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1458,3,'Honorato','Seth, Karen, Oren, Lillith',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1465,3,'Chester','Odessa, Trevor, Rosalyn, Denton',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1468,3,'Akeem','Brock, Clare, Xenos, Kieran',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1471,3,'Kadeem','Kessie, Nathaniel, Melissa, Myles',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1472,3,'Dolan','Malik, Cyrus, Lillith, Farrah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1474,3,'Lucius','Germane, Grady, Portia, Leo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1477,3,'Cullen','Darrel, Brandon, Joelle, Imelda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1478,3,'Chandler','Nicole, Keegan, Burke, Karina',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1481,3,'Len','Carly, Oscar, Pearl, Steel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1485,3,'Valentine','Philip, Sylvia, Ulysses, Zoe',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1486,3,'Armando','Prescott, Allen, Maggy, Halee',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1488,3,'Uriah','Price, Hilda, Bianca, Neve',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1489,3,'Keaton','Keith, Noelani, Victoria, Veda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1491,3,'Harding','Xandra, Axel, Karina, Ciaran',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1493,3,'Scott','Alexander, Doris, Murphy, Garrison',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1498,3,'Driscoll','Cassady, Xaviera, Odette, Lareina',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1500,3,'Clarke','Jael, Casey, Harriet, Ryan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1502,3,'Zane','May, Regan, Solomon, Jerry',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1503,3,'Benedict','Brett, Gretchen, Alfonso, Forrest',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1507,3,'Lamar','Orli, Felix, Cecilia, Demetrius',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1511,3,'Castor','Indira, Judith, Mikayla, MacKenzie',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1516,3,'Vernon','Alden, Adrienne, Tatyana, Tucker',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1517,3,'Igor','Ian, Marny, Tucker, Harlan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1519,3,'Orlando','Iona, Imelda, Veronica, Rudyard',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1520,3,'Rigel','Urielle, Gil, Chloe, Lana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1522,3,'Reece','Yolanda, Rebecca, Zephania, Denton',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1523,3,'Quentin','Hayden, Imani, Ifeoma, Azalia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1527,3,'Tad','Karen, Serina, Derek, Maggy',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1529,3,'Anthony','Cassandra, Kato, Armando, Ima',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1530,3,'Dorian','Phyllis, Courtney, Autumn, Rylee',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1532,3,'Kennan','Brenna, Noah, Madeline, Erica',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1533,3,'Marvin','Keely, Maryam, Asher, Gregory',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1534,3,'Ishmael','Gareth, Hayfa, Paloma, Kasimir',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1535,3,'Amir','Slade, Jeanette, Carla, Zena',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1537,3,'Ian','Nora, Phyllis, Lee, Ebony',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1544,3,'Armand','Margaret, Raven, Colby, Olga',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1547,3,'Mannix','Elton, Orli, Randall, Dolan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1549,3,'Caesar','Drake, Elvis, Aquila, Suki',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1556,3,'Luke','Adrienne, Eden, Omar, Signe',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1559,3,'Fitzgerald','Nolan, Lillian, Ann, Armando',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1563,3,'Ferris','Hasad, Willow, Joshua, Yasir',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1565,3,'Tyler','Macey, Dominique, Charles, Samantha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1566,3,'Samson','Xaviera, Chiquita, Chester, Pandora',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1574,3,'Alvin','Galena, Galena, Connor, Salvador',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1576,3,'Bradley','Quail, Jelani, Teagan, Noelle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1578,3,'Phillip','Geraldine, Jena, Ann, Ryder',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1580,3,'Cole','Scott, Keith, Yeo, Dahlia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1581,3,'Aristotle','Timon, Tatum, Abraham, Summer',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1582,3,'Herman','Evelyn, Ebony, Jack, Ivana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1584,3,'Raja','Maxine, Stephanie, Scarlett, Cathleen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1585,3,'Brendan','Mara, Sopoline, Magee, Frances',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1589,3,'Keefe','Jaquelyn, Octavia, Blythe, Callum',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1593,3,'Ronan','Noelle, Marny, Darius, Nathaniel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1595,3,'Levi','Galena, Malcolm, Cairo, Sydney',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1596,3,'Bruce','Deirdre, Caryn, Cedric, Michael',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1597,3,'Avram','Reuben, Odessa, Savannah, Chiquita',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1601,3,'Ira','Upton, John, Jenette, Hanae',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1602,3,'Dominic','Sarah, Denton, Jasper, Vera',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1605,3,'Felix','Desiree, Haley, Bertha, Blake',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1606,3,'Boris','Keelie, Angelica, Zahir, Eden',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1607,3,'Kaseem','George, Yoko, Olivia, Xander',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1613,3,'Jin','Tallulah, Carla, Dane, Nolan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1615,3,'Grant','Nicole, Ruby, Hamilton, Colby',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1617,3,'Guy','Dean, Aquila, Harlan, Byron',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1618,3,'Kuame','Alisa, Buckminster, Macaulay, Sean',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1624,3,'Branden','Anne, Dillon, Lareina, Macon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1625,3,'Yuli','Nelle, Henry, Kimberley, Anne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1627,3,'Emerson','Kiayada, Stewart, Mechelle, Regina',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1628,3,'Marshall','Brooke, Vivian, Frances, Hannah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1632,3,'Gareth','Xaviera, Buckminster, Cedric, Perry',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1638,3,'Oscar','Buffy, Kylie, Aaron, Kirsten',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1639,3,'Hall','Aretha, Iola, Lionel, Blake',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1641,3,'Neville','Ariana, Oliver, Montana, Hasad',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1644,3,'Hasad','Whitney, Rina, Francis, Halee',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1645,3,'Kareem','Galvin, Troy, Serina, Britanni',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1654,3,'Dane','Adele, Chiquita, Nolan, Reed',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1656,3,'Holmes','Amy, Nora, Honorato, Lesley',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1658,3,'Callum','Eric, Inga, Ryan, Dale',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1661,3,'Abel','Meredith, Galvin, Raven, Dai',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1663,3,'Carl','Elmo, Cole, Beau, Claire',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1665,3,'Trevor','Cyrus, Harlan, Hayes, Quon',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1666,3,'Wallace','Signe, Orli, Sasha, Aristotle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1668,3,'Brennan','Stacey, Quynn, Zelda, Fay',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1671,3,'Cain','Kiona, Alec, Tobias, Danielle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1672,3,'Slade','Clio, Cheryl, Elmo, Calista',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1682,3,'Nolan','Frances, Farrah, Fallon, Carol',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1683,3,'David','Brandon, Travis, Orlando, Bruce',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1684,3,'Camden','Scott, Germaine, Melinda, Serena',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1685,3,'Tarik','Devin, Samuel, Anastasia, Sonya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1686,3,'Zahir','Craig, Gareth, Candice, Leslie',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1695,3,'Baxter','Claire, Shaeleigh, Ruth, Shafira',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1697,3,'Jonas','Gavin, Rashad, Carol, Isabelle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1701,3,'Price','Scott, Paki, Brielle, Remedios',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1702,3,'Allen','Serena, Declan, Kai, Cherokee',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1707,3,'Palmer','Holmes, Laurel, Rhea, Rogan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1710,3,'Rajah','Malachi, Edan, Ginger, Cecilia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1711,3,'Ray','Eve, Harding, Walker, Wing',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1717,3,'Julian','Jamal, Rhoda, Xaviera, Madison',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1720,3,'Asher','Vaughan, Macaulay, Quinn, Jacqueline',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1723,3,'Barrett','Leo, Irma, Dominique, Darryl',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1727,3,'Ahmed','Audra, Rudyard, Zephania, Emily',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1732,3,'Elijah','Robert, Abbot, Tanek, Isaac',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1737,3,'Garth','Sopoline, Athena, Haviva, Dalton',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1750,3,'Brenden','Frances, Tiger, Hayes, Evelyn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1756,3,'Burke','Aaron, Angelica, Melissa, Kevyn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1757,3,'Amos','Odette, Jordan, Ira, Vanna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1761,3,'Troy','Gwendolyn, Jolene, Susan, Daphne',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1763,3,'Laith','Dora, Kaden, Todd, Xander',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1775,3,'Wesley','Ian, Nehru, Rosalyn, Desiree',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1776,3,'Knox','Brittany, Hayden, Deirdre, Mark',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1778,3,'Zeph','Rhiannon, Allistair, Susan, Quamar',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1779,3,'Zachery','Amal, Axel, Kareem, Laura',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1780,3,'Wylie','Hope, Brody, Randall, Emery',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1782,3,'Peter','Travis, Lavinia, Gabriel, Scarlett',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1787,3,'Nero','Gisela, Charissa, Burton, Chantale',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1790,3,'Ivor','Avram, Sonya, Alisa, Louis',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1791,3,'Malachi','Lillian, Vanna, Caleb, Kieran',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1795,3,'Tucker','Zachary, Adrian, Amery, Amber',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1798,3,'Gannon','Karina, Wylie, Kylie, Dane',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1799,3,'Griffith','Oleg, Dawn, Emmanuel, Lee',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1819,3,'Upton','Katell, Mary, Justine, Madeson',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1824,3,'Bert','Colby, Evelyn, Camille, Virginia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1825,3,'Philip','Nissim, Avram, Jolie, Hammett',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1826,3,'Prescott','Emma, Fritz, Imani, Roary',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1827,3,'Shad','Erica, Emerson, Orlando, Colette',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1831,3,'Gary','Sylvia, Slade, Courtney, Tate',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1833,3,'Isaac','Jolene, Kylee, Austin, Martha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1837,3,'Richard','Joan, Perry, Hadley, Audra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1839,3,'Malcolm','Gretchen, Nayda, Rudyard, Brielle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1840,3,'Tanner','Kyle, Kylee, Shelley, Cooper',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1843,3,'Mark','Melanie, Levi, Felicia, Marsden',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1844,3,'Kennedy','Shelley, Amelia, Montana, Vaughan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1849,3,'Bernard','Richard, Kane, Kane, Illana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1855,3,'Damian','Kasimir, Claire, Devin, Susan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1858,3,'Ryan','Harper, Malik, Fleur, Giacomo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1859,3,'Reed','Barry, Jonas, Nathaniel, Gavin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1861,3,'Yasir','Xanthus, Stone, Heather, Adrian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1871,3,'Galvin','Jonas, Bethany, Wayne, Carlos',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1873,3,'Beau','Yvette, Amela, Carolyn, Howard',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1891,3,'Kasimir','Ora, Clare, Hu, Sage',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1892,3,'Kane','Piper, Maxwell, Keefe, Stewart',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1896,3,'Alden','Farrah, Hadassah, Imogene, Danielle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1913,3,'Reese','Philip, Christopher, Adena, Erich',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1933,3,'Aaron','Hashim, Liberty, Serena, Hyacinth',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1935,3,'Dillon','Brittany, Patricia, Thaddeus, Ingrid',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1937,3,'Harper','August, Martin, Jerome, Silas',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1945,3,'Hammett','Tanisha, Xantha, Hayfa, Sonya',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1952,3,'Odysseus','Yvonne, Kennan, Tasha, Sacha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1956,3,'Preston','Gwendolyn, Davis, Hayes, Nero',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1961,3,'Finn','Dominic, Bree, Orson, Lester',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1980,3,'Oleg','Dante, Louis, Sara, Kelsey',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(1982,3,'Erich','Harlan, Curran, Malcolm, Hedley',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2005,3,'Fulton','Clayton, Castor, Arsenio, Patrick',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2011,3,'Kieran','Bo, Fritz, Sierra, Abbot',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2025,3,'Colorado','Victor, Yen, Todd, Ishmael',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2031,3,'Quamar','Jayme, Zeus, Prescott, Philip',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2038,3,'Reuben','Elaine, Courtney, Samson, Karleigh',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2043,3,'Jack','Blake, Maggy, Mariam, Bertha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2048,3,'Kato','Caesar, Calvin, Laith, Aristotle',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2051,3,'George','Emma, Jaime, Otto, Xandra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2054,3,'Ulric','Jessica, Denton, Gemma, August',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2074,3,'Xenos','Derek, Jeremy, Cain, Ian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2105,3,'August','Melyssa, Aileen, Nasim, Marny',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2109,3,'Moses','Ima, Dillon, TaShya, Jada',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2112,3,'Ivan','Ruby, Berk, Gemma, Drew',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2114,3,'Kibo','Quinlan, Gary, Jerry, Raven',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2144,3,'Connor','Aidan, Ryan, Nita, Quinn',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2145,3,'Melvin','Ulysses, Cooper, Knox, Tanisha',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2150,3,'Travis','Olivia, Vernon, Pamela, Kermit',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2161,3,'Colt','Wynter, Roth, Ingrid, Mufutau',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2162,3,'Chancellor','Yetta, Matthew, Cally, Michael',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2182,3,'Marsden','Nicole, Orla, Cathleen, Hadassah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2189,3,'Clark','Amal, Grant, Vivien, Diana',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2194,3,'Edward','Jordan, Vanna, Robin, Morgan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2198,3,'Logan','Kibo, Giselle, Kennedy, Leah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2201,3,'Josiah','Scarlett, Benjamin, Berk, Darryl',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2205,3,'Fritz','Nadine, Sophia, Sydnee, Liberty',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2213,3,'Denton','Marsden, Tad, Ariel, Latifah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2220,3,'Stuart','Dennis, Timon, Nasim, Warren',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2230,3,'Caleb','Leila, Rylee, Noel, Naomi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2231,3,'Noah','Carolyn, Kelly, Ina, Blake',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2252,3,'Ross','Geoffrey, Graham, Kylan, Brian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2258,3,'Joshua','Jeanette, Quon, Cameron, Curran',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2263,3,'Lucas','Linus, Ferris, Jerry, Charity',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2269,3,'Patrick','Lavinia, Aaron, Carol, Jesse',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2271,3,'Neil','Jade, Graham, Barry, Rebekah',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2278,3,'Devin','Tarik, Lacota, Iliana, Wallace',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2279,3,'Evan','Ocean, Howard, Dakota, Allistair',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2281,3,'Drew','Martena, Jameson, Keegan, Keefe',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2285,3,'Harrison','Ezra, Byron, Regan, Maite',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2287,3,'Stephen','Rebekah, Jordan, Keelie, Ina',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2304,3,'Wyatt','Rogan, Shad, Francesca, Rudyard',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2306,3,'Giacomo','Brent, Alec, Wendy, Reagan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2344,3,'Leroy','Aubrey, Ferris, Ora, Amela',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2345,3,'Joel','Aileen, Wallace, Casey, Lisandra',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2356,3,'Barry','Alisa, Sigourney, Geoffrey, Chandler',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2382,3,'Brady','Reagan, Chandler, Cole, Maite',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2401,3,'Yoshio','Trevor, Julian, Louis, Justine',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2402,3,'Keegan','Quintessa, Daniel, Illana, Conan',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2403,3,'Hector','Brock, Jarrod, Olga, Christen',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2409,3,'Caldwell','Jonas, Ifeoma, Quemby, Echo',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2428,3,'Rafael','Doris, Pearl, Dale, Felicia',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2431,3,'Paki','Caldwell, Robin, Lev, Colette',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2459,3,'Wade','Orlando, Xantha, David, Miranda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2488,3,'Theodore','Harriet, Maite, Jaime, Geoffrey',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2499,3,'Dexter','Reed, Sybil, Bernard, Wyatt',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2508,3,'Lester','Jamal, Ishmael, Rina, Lane',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2528,3,'Kevin','Yoshi, Scarlett, Noah, Tad',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2571,3,'Byron','Phoebe, Angelica, Rhonda, Glenna',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2637,3,'Lucian','Victoria, Xerxes, Idona, Samson',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2647,3,'Forrest','Micah, Malik, Ella, India',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2675,3,'Rogan','Whitney, Britanni, Valentine, Nina',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2694,3,'Herrod','Courtney, Emma, Hilda, Carter',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2720,3,'Victor','Tate, Alexa, Iliana, Ali',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2726,3,'Wing','Evangeline, Halla, Olivia, Thor',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2752,3,'Roth','Yoko, Melyssa, Stuart, Audrey',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2755,3,'Abdul','Nomlanga, Herrod, Dacey, Adrian',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2799,3,'Michael','Rosalyn, Igor, Emily, Athena',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2811,3,'Raphael','Zena, Kadeem, Cynthia, Graham',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2813,3,'Cade','Gwendolyn, April, Bryar, Sybill',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2853,3,'Griffin','Zelenia, Kelly, Demetria, Malachi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2897,3,'Craig','Janna, Ruby, Signe, Cedric',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2954,3,'Curran','Neil, Russell, Alexa, Emi',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2967,3,'Ralph','Evelyn, Fletcher, Amela, Baxter',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2976,3,'Steven','Brett, Ori, Jordan, Nomlanga',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3058,3,'Henry','Xandra, Zachery, Leigh, Salvador',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3071,3,'Yardley','Britanni, Ezekiel, Jacqueline, Denton',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3176,3,'Chaim','Brent, Delilah, Petra, Remedios',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3248,3,'Barclay','Hadley, Adam, Kirk, Veda',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3400,3,'Hoyt','Chaney, Josephine, Amelia, Darrel',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3431,3,'Rashad','Kessie, Dana, Calvin, Cheryl',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3627,3,'Silas','Leonard, Dennis, Hoyt, September',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3686,3,'Gabriel','Chiquita, Scarlett, Wendy, Jermaine',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3914,3,'Alfonso','Nicole, Kitra, Eric, Galvin',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3915,2,'Tunai','Tunai','',NULL,NULL,'','','','','','','',0,'','','',0.0000,0.0000,'2015-05-30 14:45:12','NuSoft - NuSoft Administrator','2015-05-30 14:45:12','NuSoft - NuSoft Administrator',0.0000,NULL,NULL,0.0000,NULL,NULL,0,0,NULL,'',NULL,NULL,'','','','','','','','','','',NULL,NULL,NULL);
/*!40000 ALTER TABLE `m01bcontactview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01bcurrencykurs`
--

DROP TABLE IF EXISTS `m01bcurrencykurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01bcurrencykurs` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_date` date NOT NULL,
  `d_kurscurrency` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_kurstax` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01bcurrencykurs` (`f_currency`,`d_date`),
  KEY `fk_m01acurrencykurs_m01acurrency1_idx` (`f_currency`),
  CONSTRAINT `fk_m01acurrencykurs_m01acurrency1` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata kurs bank dan kurs pajak';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01bcurrencykurs`
--

LOCK TABLES `m01bcurrencykurs` WRITE;
/*!40000 ALTER TABLE `m01bcurrencykurs` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01bcurrencykurs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01budget`
--

DROP TABLE IF EXISTS `m01budget`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01budget` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `d_year` year(4) NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_value1` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value2` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value3` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value4` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value5` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value6` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value7` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value8` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value9` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value10` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value11` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_value12` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `created_date` datetime NOT NULL,
  `create_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01budget` (`d_year`,`f_coa`),
  KEY `fk_m01budget_m01bcoa1_idx` (`f_coa`),
  CONSTRAINT `fk_m01budget_m01bcoa1` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data anggaran';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01budget`
--

LOCK TABLES `m01budget` WRITE;
/*!40000 ALTER TABLE `m01budget` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01budget` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01carapsetup`
--

DROP TABLE IF EXISTS `m01carapsetup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01carapsetup` (
  `p_id` int(11) NOT NULL AUTO_INCREMENT,
  `f_coa` int(10) unsigned NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01carapsetup`
--

LOCK TABLES `m01carapsetup` WRITE;
/*!40000 ALTER TABLE `m01carapsetup` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01carapsetup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01ccashopname`
--

DROP TABLE IF EXISTS `m01ccashopname`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01ccashopname` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_date` date NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_value` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_note` varchar(150) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01ccashopname` (`p_date`,`f_coa`),
  KEY `fk_m01ccashopname_m01bcoa1_idx` (`f_coa`),
  CONSTRAINT `fk_m01ccashopname_m01bcoa1` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data cash opname';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01ccashopname`
--

LOCK TABLES `m01ccashopname` WRITE;
/*!40000 ALTER TABLE `m01ccashopname` DISABLE KEYS */;
INSERT INTO `m01ccashopname` VALUES (1,'2015-06-05',3,36.0000,'asd','2015-06-05 05:45:52','admin - Administrator','2015-06-05 05:45:52','admin - Administrator');
/*!40000 ALTER TABLE `m01ccashopname` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01ccontactaddress`
--

DROP TABLE IF EXISTS `m01ccontactaddress`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01ccontactaddress` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_contact` int(10) unsigned NOT NULL,
  `d_type` tinyint(4) NOT NULL DEFAULT '0' COMMENT 'untuk penyimpan tipe alamat\n0 : alamat kantor\n1 : alamat gudang',
  `d_code` varchar(25) NOT NULL,
  `d_address` varchar(255) NOT NULL,
  `d_phone` varchar(20) DEFAULT NULL,
  `d_fax` varchar(20) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_m01ccontactaddress_m01bcontactview1_idx` (`f_contact`),
  CONSTRAINT `fk_m01ccontactaddress_m01bcontactview1` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01ccontactaddress`
--

LOCK TABLES `m01ccontactaddress` WRITE;
/*!40000 ALTER TABLE `m01ccontactaddress` DISABLE KEYS */;
INSERT INTO `m01ccontactaddress` VALUES (1,887,0,'Pusat','Jl Tebet Timur Dalam 3i No 7\r\nTebet, Jakarta Selatan\r\nDKI JAKARTA 17312','021-8297832','021-8297832','2014-09-11 06:18:34','NuSoft - NuSoft Administrator','2015-05-23 20:06:32','admin - Administrator'),(2,887,1,'Gudang','Alamat gudangnya disini',NULL,NULL,'2014-09-11 06:18:34','NuSoft - NuSoft Administrator','2014-09-11 06:18:34','NuSoft - NuSoft Administrator'),(3,887,1,'Gudang2','alamat gudang 2 nya disini juga',NULL,NULL,'2014-09-11 06:18:34','NuSoft - NuSoft Administrator','2014-09-11 06:18:34','NuSoft - NuSoft Administrator'),(4,1081,0,'sadasd','sadasd','sad','sad','2015-05-23 18:33:47','admin - Administrator','2015-05-23 18:33:47','admin - Administrator');
/*!40000 ALTER TABLE `m01ccontactaddress` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01ccontactattention`
--

DROP TABLE IF EXISTS `m01ccontactattention`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01ccontactattention` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_contact` int(10) unsigned NOT NULL,
  `d_name` varchar(100) NOT NULL,
  `d_position` varchar(45) DEFAULT NULL,
  `d_phone` varchar(20) DEFAULT NULL,
  `d_mobile` varchar(20) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_m01ccontactattention_m01bcontactview1_idx` (`f_contact`),
  CONSTRAINT `fk_m01ccontactattention_m01bcontactview1` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01ccontactattention`
--

LOCK TABLES `m01ccontactattention` WRITE;
/*!40000 ALTER TABLE `m01ccontactattention` DISABLE KEYS */;
INSERT INTO `m01ccontactattention` VALUES (3,887,'Jali','a',NULL,NULL,'2015-05-23 20:04:24','admin - Administrator','2015-05-23 20:04:24','admin - Administrator'),(4,887,'Saiful','a',NULL,NULL,'2015-05-23 20:04:24','admin - Administrator','2015-05-23 20:04:24','admin - Administrator'),(5,887,'Toha','a',NULL,NULL,'2015-05-23 20:04:24','admin - Administrator','2015-05-23 20:04:24','admin - Administrator');
/*!40000 ALTER TABLE `m01ccontactattention` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01cloanmain`
--

DROP TABLE IF EXISTS `m01cloanmain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01cloanmain` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_year` smallint(5) unsigned DEFAULT NULL,
  `u_month` tinyint(3) unsigned DEFAULT NULL,
  `u_coa` int(10) unsigned DEFAULT NULL,
  `u_regional` smallint(5) unsigned DEFAULT NULL,
  `u_source` smallint(5) unsigned DEFAULT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date NOT NULL,
  `f_reg` smallint(5) unsigned NOT NULL,
  `f_contact` int(10) unsigned NOT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_debtvalue` decimal(18,4) unsigned NOT NULL DEFAULT '0.0000',
  `d_terms` tinyint(3) unsigned NOT NULL,
  `d_rate` decimal(18,4) unsigned NOT NULL DEFAULT '1.0000',
  `d_startdate` date NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01cloanmain1` (`u_code`),
  UNIQUE KEY `cd_m01cloanmain2` (`f_reg`,`u_year`,`u_month`,`u_sequence`),
  KEY `fk_m01cloanmain_m01bcontactview1_idx` (`f_contact`),
  KEY `fk_m01cloanmain_m01acurrency1_idx` (`f_currency`),
  KEY `fk_m01cloanmain_ucoa_idx` (`u_coa`),
  KEY `fk_m01cloanmain_ureg_idx` (`u_regional`),
  KEY `fk_m01cloanmain_usrc_idx` (`u_source`),
  CONSTRAINT `fk_m01cloanmain_contact` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cloanmain_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cloanmain_regional` FOREIGN KEY (`f_reg`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cloanmain_ucoa` FOREIGN KEY (`u_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cloanmain_ureg` FOREIGN KEY (`u_regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cloanmain_usrc` FOREIGN KEY (`u_source`) REFERENCES `a_source` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01cloanmain`
--

LOCK TABLES `m01cloanmain` WRITE;
/*!40000 ALTER TABLE `m01cloanmain` DISABLE KEYS */;
INSERT INTO `m01cloanmain` VALUES (1,2014,9,NULL,1,NULL,1,'KKS-14090001','2014-09-23',1,787,3,25000000.0000,36,2.0000,'2014-09-23','adsdsad','2014-09-23 20:30:45','NuSoft - NuSoft Administrator','2014-09-23 20:30:45','NuSoft - NuSoft Administrator'),(2,2014,10,NULL,1,NULL,1,'KKS-14100001','2014-10-20',1,786,3,36000000.0000,36,2.0000,'2014-10-20','sdsfdsf','2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul');
/*!40000 ALTER TABLE `m01cloanmain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01cmaingl`
--

DROP TABLE IF EXISTS `m01cmaingl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01cmaingl` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `u_year` smallint(5) unsigned DEFAULT NULL,
  `u_month` tinyint(3) unsigned DEFAULT NULL,
  `u_coa` int(10) unsigned DEFAULT NULL,
  `u_regional` smallint(5) unsigned DEFAULT NULL,
  `u_source` smallint(5) unsigned DEFAULT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date NOT NULL,
  `f_reg` smallint(5) unsigned NOT NULL,
  `f_coa` int(10) unsigned DEFAULT NULL,
  `f_source` smallint(5) unsigned NOT NULL,
  `f_contact` int(10) unsigned NOT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `d_type` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_description` varchar(255) NOT NULL,
  `d_payment` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_currency` varchar(3) DEFAULT NULL,
  `d_rate` decimal(18,4) unsigned DEFAULT '1.0000',
  `d_note` varchar(255) DEFAULT NULL,
  `d_director` varchar(100) DEFAULT NULL,
  `d_accounting` varchar(100) DEFAULT NULL,
  `d_cashier` varchar(100) DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_reconciliation` date DEFAULT NULL,
  `fk_cashadvance` bigint(20) unsigned DEFAULT NULL,
  `x_module` int(11) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_code`),
  UNIQUE KEY `id` (`u_year`,`u_month`,`u_coa`,`u_regional`,`u_source`,`u_sequence`),
  KEY `fk_02cmain_regional_idx` (`u_regional`),
  KEY `fk_02cmain_coa_idx` (`u_coa`),
  KEY `fk_m01cmaingl_m01bcontactview1_idx` (`f_contact`),
  KEY `fk_m01cmaingl_regional_idx` (`f_reg`),
  KEY `fk_m01cmaingl_coa_idx` (`f_coa`),
  KEY `fk_m01cmaingl_cashadvance_idx` (`fk_cashadvance`),
  KEY `fk_m01cmaingl_usrc_idx` (`u_source`),
  KEY `fk_m01cmaingl_source_idx` (`f_source`),
  CONSTRAINT `fk_m01cmaingl_cashadvance` FOREIGN KEY (`fk_cashadvance`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_contact` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_regional` FOREIGN KEY (`f_reg`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_source` FOREIGN KEY (`f_source`) REFERENCES `a_source` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_ucoa` FOREIGN KEY (`u_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_ureg` FOREIGN KEY (`u_regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cmaingl_usrc` FOREIGN KEY (`u_source`) REFERENCES `a_source` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata data transaksi jurnal. (Utama)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01cmaingl`
--

LOCK TABLES `m01cmaingl` WRITE;
/*!40000 ALTER TABLE `m01cmaingl` DISABLE KEYS */;
INSERT INTO `m01cmaingl` VALUES (1,2016,6,NULL,1,22,1,'JKT-GR16060001','2016-06-19',1,NULL,22,1223,'Abbot',0,'Penerimaan Barang',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,566130832,'2016-06-19 16:00:58','NuSoft - NuSoft Administrator','2016-06-19 16:00:58','NuSoft - NuSoft Administrator'),(3,2016,6,NULL,1,23,1,'JKT-RI16060001','2016-06-19',1,NULL,23,1223,'Abbot',0,'Invoice Pembelian',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,566130832,'2016-06-19 18:59:39','NuSoft - NuSoft Administrator','2016-06-19 18:59:39','NuSoft - NuSoft Administrator'),(4,2016,6,NULL,1,22,2,'JKT-GR16060002','2016-06-21',1,NULL,22,1223,'Abbot',0,'Penerimaan Barang',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,566130832,'2016-06-21 06:43:52','NuSoft - NuSoft Administrator','2016-06-21 06:43:52','NuSoft - NuSoft Administrator'),(9,2016,6,NULL,1,39,1,'JKT-QS16060001','2016-06-21',1,NULL,39,3915,'Tunai',0,'Penjualan POS',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,-1195955926,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator'),(10,2016,6,NULL,1,39,2,'JKT-QS16060002','2016-06-21',1,NULL,39,3915,'Tunai',0,'Penjualan POS',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,-1195955926,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator'),(11,2021,2,NULL,1,5,1,'JKT-JU21020001','2021-02-20',1,NULL,5,1661,'',0,'Jurnal Umum',0,'Rp',1.0000,'',NULL,NULL,NULL,0,NULL,NULL,651410569,'2021-02-20 13:03:20','NuSoft - NuSoft Administrator','2021-02-20 13:03:20','NuSoft - NuSoft Administrator'),(12,2021,2,NULL,1,29,1,'JKT-DP21020001','2021-02-20',1,NULL,29,887,'ALLIANZ',0,'Uang Muka Penjualan',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,566130832,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator','2021-02-20 16:07:27','NuSoft - NuSoft Administrator'),(13,2021,2,NULL,1,23,1,'JKT-RI21020001','2021-02-20',1,NULL,23,1223,'Abbot',0,'Invoice Pembelian',0,'Rp',1.0000,NULL,NULL,NULL,NULL,0,NULL,NULL,566130832,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator','2021-02-20 16:12:58','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m01cmaingl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01cmainprepayment`
--

DROP TABLE IF EXISTS `m01cmainprepayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01cmainprepayment` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_month` tinyint(3) unsigned DEFAULT NULL,
  `d_date` date NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned DEFAULT NULL,
  `u_regional` smallint(5) unsigned DEFAULT NULL,
  `u_coa` int(10) unsigned DEFAULT NULL,
  `u_year` smallint(5) unsigned DEFAULT NULL,
  `u_code` varchar(30) NOT NULL,
  `f_reg` smallint(5) unsigned DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `d_status` tinyint(2) unsigned DEFAULT NULL,
  `created_user` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `f_contact` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_prepayment_ureg_idx` (`u_regional`),
  KEY `fk_prepayment_usource_idx` (`u_source`),
  KEY `fk_prepayment_ucoa_idx` (`u_coa`),
  KEY `fk_prepayment_freg_idx` (`f_reg`),
  KEY `fk_m01cmainprepayment_contact_idx` (`f_contact`),
  CONSTRAINT `fk_m01cmainprepayment_contact` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_prepayment_freg` FOREIGN KEY (`f_reg`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_prepayment_ucoa` FOREIGN KEY (`u_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_prepayment_ureg` FOREIGN KEY (`u_regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_prepayment_usource` FOREIGN KEY (`u_source`) REFERENCES `a_source` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01cmainprepayment`
--

LOCK TABLES `m01cmainprepayment` WRITE;
/*!40000 ALTER TABLE `m01cmainprepayment` DISABLE KEYS */;
INSERT INTO `m01cmainprepayment` VALUES (3,6,'2015-06-12',1,42,1,NULL,2015,'JKT-PP15060001',1,'sadasd',0,'admin - Administrator','2015-06-12 08:19:19','admin - Administrator','2015-06-12 08:19:19',1661);
/*!40000 ALTER TABLE `m01cmainprepayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01cpaymentreqmain`
--

DROP TABLE IF EXISTS `m01cpaymentreqmain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01cpaymentreqmain` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `u_year` smallint(5) unsigned DEFAULT NULL,
  `u_month` tinyint(3) unsigned DEFAULT NULL,
  `u_coa` int(10) unsigned DEFAULT NULL,
  `u_regional` smallint(5) unsigned DEFAULT NULL,
  `u_source` smallint(5) unsigned DEFAULT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date NOT NULL,
  `f_reg` smallint(5) unsigned NOT NULL,
  `f_contact` int(10) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_status` tinyint(4) NOT NULL DEFAULT '0',
  `d_duedate` date DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `f_gl` bigint(20) unsigned DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01cpaymentreqmain1` (`u_code`),
  UNIQUE KEY `cd_m01cpaymentreqmain2` (`f_reg`,`u_year`,`u_month`,`u_sequence`,`f_coa`),
  KEY `fk_m01cpaymentreqmain_m01bcontactview1_idx` (`f_contact`),
  KEY `fk_m01cpaymentreqmain_m01bcoa1_idx` (`f_coa`),
  KEY `fk_m01cpaymentreqmain_ureg_idx` (`u_regional`),
  KEY `fk_m01cpaymentreqmain_ucoa_idx` (`u_coa`),
  KEY `fk_m01cpaymentreqmain_usrc_idx` (`u_source`),
  CONSTRAINT `fk_m01cpaymentreqmain_m01bcoa1` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cpaymentreqmain_m01bcontactview1` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cpaymentreqmain_regional` FOREIGN KEY (`f_reg`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cpaymentreqmain_ucoa` FOREIGN KEY (`u_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cpaymentreqmain_ureg` FOREIGN KEY (`u_regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cpaymentreqmain_usrc` FOREIGN KEY (`u_source`) REFERENCES `a_source` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01cpaymentreqmain`
--

LOCK TABLES `m01cpaymentreqmain` WRITE;
/*!40000 ALTER TABLE `m01cpaymentreqmain` DISABLE KEYS */;
INSERT INTO `m01cpaymentreqmain` VALUES (2,2015,6,NULL,1,10,2,'JKT-PD15060002','2015-06-01',1,1346,8,0,NULL,'asdasdasdsad','2015-06-01 05:55:30','admin - Administrator','2015-06-01 05:55:47','admin - Administrator',NULL),(3,2015,6,NULL,1,10,3,'JKT-PD15060003','2015-06-01',1,1346,7,0,NULL,'asdasd','2015-06-01 07:23:27','admin - Administrator','2015-06-01 07:23:27','admin - Administrator',NULL),(4,2015,6,NULL,1,10,4,'JKT-PD15060004','2015-06-05',1,1096,8,3,'2015-06-18','asdasd','2015-06-05 05:43:16','admin - Administrator','2015-06-23 13:20:30','admin - Administrator',145);
/*!40000 ALTER TABLE `m01cpaymentreqmain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01cprepaidmain`
--

DROP TABLE IF EXISTS `m01cprepaidmain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01cprepaidmain` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_gl` bigint(20) unsigned NOT NULL,
  `d_value` decimal(18,4) NOT NULL,
  `d_startdate` date NOT NULL,
  `d_age` smallint(5) unsigned NOT NULL,
  `f_coaprepaid` int(10) unsigned NOT NULL,
  `f_coaexpense` int(10) unsigned NOT NULL,
  `f_coacashbank` int(10) unsigned NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code_m01cprepaidmain` (`f_gl`),
  KEY `fk_m01cprepaidmain_m01bcoa1_idx` (`f_coaprepaid`),
  KEY `fk_m01cprepaidmain_m01bcoa2_idx` (`f_coaexpense`),
  KEY `fk_m01cprepaidmain_coacashbank_idx` (`f_coacashbank`),
  CONSTRAINT `fk_m01cprepaidmain_coacashbank` FOREIGN KEY (`f_coacashbank`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cprepaidmain_coaexpense` FOREIGN KEY (`f_coaexpense`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cprepaidmain_coaprepaid` FOREIGN KEY (`f_coaprepaid`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01cprepaidmain_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01cprepaidmain`
--

LOCK TABLES `m01cprepaidmain` WRITE;
/*!40000 ALTER TABLE `m01cprepaidmain` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01cprepaidmain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01crevalmain`
--

DROP TABLE IF EXISTS `m01crevalmain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01crevalmain` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_year` smallint(6) DEFAULT NULL,
  `u_month` tinyint(4) DEFAULT NULL,
  `u_regional` smallint(6) DEFAULT NULL,
  `u_source` smallint(6) DEFAULT NULL,
  `u_sequence` smallint(6) DEFAULT NULL,
  `u_coa` int(10) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `f_coa` int(10) unsigned DEFAULT NULL,
  `f_contact` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  UNIQUE KEY `u_revalman` (`u_year`,`u_month`),
  KEY `fk_m01crevalmain_m01bcoa1_idx` (`u_coa`),
  KEY `FK_m01crevalmain_m01bcoa` (`f_coa`),
  KEY `FK_m01crevalmain_m01bcontactview` (`f_contact`),
  CONSTRAINT `FK_m01crevalmain_m01bcoa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_m01crevalmain_m01bcontactview` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01crevalmain_m01bcoa1` FOREIGN KEY (`u_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01crevalmain`
--

LOCK TABLES `m01crevalmain` WRITE;
/*!40000 ALTER TABLE `m01crevalmain` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01crevalmain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01ddetailprepayment`
--

DROP TABLE IF EXISTS `m01ddetailprepayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01ddetailprepayment` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `d_type` tinyint(2) DEFAULT NULL,
  `d_reff` varchar(50) DEFAULT NULL,
  `f_contact` int(10) unsigned NOT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_value` decimal(18,4) unsigned DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m01ddetailprepayment_m01cmainprepayment1_idx` (`p_id`),
  KEY `fk_m01ddetailprepayment_m01bcontactview1_idx` (`f_contact`),
  KEY `fk_m01ddetailprepayment_m01acurrency1_idx` (`f_currency`),
  CONSTRAINT `fk_m01ddetailprepayment_m01acurrency1` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_m01ddetailprepayment_m01bcontactview1` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01ddetailprepayment_m01cmainprepayment1` FOREIGN KEY (`p_id`) REFERENCES `m01cmainprepayment` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01ddetailprepayment`
--

LOCK TABLES `m01ddetailprepayment` WRITE;
/*!40000 ALTER TABLE `m01ddetailprepayment` DISABLE KEYS */;
INSERT INTO `m01ddetailprepayment` VALUES (3,3,1,NULL,1346,3,25000000.0000,'','admin - Administrator','2015-06-12 08:19:19','admin - Administrator','2015-06-12 08:19:19');
/*!40000 ALTER TABLE `m01ddetailprepayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01dloandetail`
--

DROP TABLE IF EXISTS `m01dloandetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01dloandetail` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `d_seq` smallint(5) unsigned NOT NULL,
  `d_duedate` date NOT NULL,
  `d_valuedebt` decimal(18,4) NOT NULL,
  `d_valueinterest` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_valueremain` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_payment` tinyint(1) DEFAULT NULL,
  `d_note` varchar(100) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m01dloandetail_main_idx` (`p_id`),
  CONSTRAINT `fk_m01dloandetail_main` FOREIGN KEY (`p_id`) REFERENCES `m01cloanmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01dloandetail`
--

LOCK TABLES `m01dloandetail` WRITE;
/*!40000 ALTER TABLE `m01dloandetail` DISABLE KEYS */;
INSERT INTO `m01dloandetail` VALUES (1,1,1,'2014-10-23',694444.4444,13888.8889,24305555.5556,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(2,1,2,'2014-11-23',694444.4444,13888.8889,23611111.1111,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(3,1,3,'2014-12-23',694444.4444,13888.8889,22916666.6667,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(4,1,4,'2015-01-23',694444.4444,13888.8889,22222222.2222,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(5,1,5,'2015-02-23',694444.4444,13888.8889,21527777.7778,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(6,1,6,'2015-03-23',694444.4444,13888.8889,20833333.3333,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(7,1,7,'2015-04-23',694444.4444,13888.8889,20138888.8889,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(8,1,8,'2015-05-23',694444.4444,13888.8889,19444444.4444,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(9,1,9,'2015-06-23',694444.4444,13888.8889,18750000.0000,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(10,1,10,'2015-07-23',694444.4444,13888.8889,18055555.5556,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(11,1,11,'2015-08-23',694444.4444,13888.8889,17361111.1111,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(12,1,12,'2015-09-23',694444.4444,13888.8889,16666666.6667,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(13,1,13,'2015-10-23',694444.4444,13888.8889,15972222.2222,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(14,1,14,'2015-11-23',694444.4444,13888.8889,15277777.7778,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(15,1,15,'2015-12-23',694444.4444,13888.8889,14583333.3333,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(16,1,16,'2016-01-23',694444.4444,13888.8889,13888888.8889,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(17,1,17,'2016-02-23',694444.4444,13888.8889,13194444.4444,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(18,1,18,'2016-03-23',694444.4444,13888.8889,12500000.0000,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(19,1,19,'2016-04-23',694444.4444,13888.8889,11805555.5556,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(20,1,20,'2016-05-23',694444.4444,13888.8889,11111111.1111,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(21,1,21,'2016-06-23',694444.4444,13888.8889,10416666.6667,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(22,1,22,'2016-07-23',694444.4444,13888.8889,9722222.2222,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(23,1,23,'2016-08-23',694444.4444,13888.8889,9027777.7778,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(24,1,24,'2016-09-23',694444.4444,13888.8889,8333333.3333,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(25,1,25,'2016-10-23',694444.4444,13888.8889,7638888.8889,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(26,1,26,'2016-11-23',694444.4444,13888.8889,6944444.4444,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(27,1,27,'2016-12-23',694444.4444,13888.8889,6250000.0000,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(28,1,28,'2017-01-23',694444.4444,13888.8889,5555555.5556,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(29,1,29,'2017-02-23',694444.4444,13888.8889,4861111.1111,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(30,1,30,'2017-03-23',694444.4444,13888.8889,4166666.6667,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(31,1,31,'2017-04-23',694444.4444,13888.8889,3472222.2222,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(32,1,32,'2017-05-23',694444.4444,13888.8889,2777777.7778,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(33,1,33,'2017-06-23',694444.4444,13888.8889,2083333.3333,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(34,1,34,'2017-07-23',694444.4444,13888.8889,1388888.8889,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(35,1,35,'2017-08-23',694444.4444,13888.8889,694444.4444,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(36,1,36,'2017-09-23',694444.4444,13888.8889,0.0000,0,NULL,'2014-09-23 20:30:46','NuSoft - NuSoft Administrator','2014-09-23 20:30:46','NuSoft - NuSoft Administrator'),(37,2,1,'2014-11-20',1000000.0000,20000.0000,35000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(38,2,2,'2014-12-20',1000000.0000,20000.0000,34000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(39,2,3,'2015-01-20',1000000.0000,20000.0000,33000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(40,2,4,'2015-02-20',1000000.0000,20000.0000,32000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(41,2,5,'2015-03-20',1000000.0000,20000.0000,31000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(42,2,6,'2015-04-20',1000000.0000,20000.0000,30000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(43,2,7,'2015-05-20',1000000.0000,20000.0000,29000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(44,2,8,'2015-06-20',1000000.0000,20000.0000,28000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(45,2,9,'2015-07-20',1000000.0000,20000.0000,27000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(46,2,10,'2015-08-20',1000000.0000,20000.0000,26000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(47,2,11,'2015-09-20',1000000.0000,20000.0000,25000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(48,2,12,'2015-10-20',1000000.0000,20000.0000,24000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(49,2,13,'2015-11-20',1000000.0000,20000.0000,23000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(50,2,14,'2015-12-20',1000000.0000,20000.0000,22000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(51,2,15,'2016-01-20',1000000.0000,20000.0000,21000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(52,2,16,'2016-02-20',1000000.0000,20000.0000,20000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(53,2,17,'2016-03-20',1000000.0000,20000.0000,19000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(54,2,18,'2016-04-20',1000000.0000,20000.0000,18000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(55,2,19,'2016-05-20',1000000.0000,20000.0000,17000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(56,2,20,'2016-06-20',1000000.0000,20000.0000,16000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(57,2,21,'2016-07-20',1000000.0000,20000.0000,15000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(58,2,22,'2016-08-20',1000000.0000,20000.0000,14000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(59,2,23,'2016-09-20',1000000.0000,20000.0000,13000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(60,2,24,'2016-10-20',1000000.0000,20000.0000,12000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(61,2,25,'2016-11-20',1000000.0000,20000.0000,11000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(62,2,26,'2016-12-20',1000000.0000,20000.0000,10000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(63,2,27,'2017-01-20',1000000.0000,20000.0000,9000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(64,2,28,'2017-02-20',1000000.0000,20000.0000,8000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(65,2,29,'2017-03-20',1000000.0000,20000.0000,7000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(66,2,30,'2017-04-20',1000000.0000,20000.0000,6000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(67,2,31,'2017-05-20',1000000.0000,20000.0000,5000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(68,2,32,'2017-06-20',1000000.0000,20000.0000,4000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(69,2,33,'2017-07-20',1000000.0000,20000.0000,3000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(70,2,34,'2017-08-20',1000000.0000,20000.0000,2000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(71,2,35,'2017-09-20',1000000.0000,20000.0000,1000000.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul'),(72,2,36,'2017-10-20',1000000.0000,20000.0000,0.0000,0,NULL,'2014-10-20 12:56:34','ipul - Ipul','2014-10-20 12:56:34','ipul - Ipul');
/*!40000 ALTER TABLE `m01dloandetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01dmaindetail`
--

DROP TABLE IF EXISTS `m01dmaindetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01dmaindetail` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` bigint(20) unsigned NOT NULL,
  `p_order` tinyint(3) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_debit` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_credit` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_rate` decimal(18,4) unsigned NOT NULL DEFAULT '1.0000',
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_debitvalas` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_creditvalas` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `f_division` smallint(5) unsigned DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `d_rekonsiliasi` tinyint(1) DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `f_proyek` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  UNIQUE KEY `code` (`p_id`,`p_order`),
  KEY `fk_01dmaindetail_main_idx` (`p_id`),
  KEY `fk_01dmaindetail_coa_idx` (`f_coa`),
  KEY `fk_01dmaindetail_division_idx` (`f_division`),
  KEY `fk_01dmaindetail_currency_idx` (`f_currency`),
  CONSTRAINT `fk_01dmaindetail_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_01dmaindetail_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_01dmaindetail_division` FOREIGN KEY (`f_division`) REFERENCES `a_division` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_01dmaindetail_main` FOREIGN KEY (`p_id`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata data transaksi jurnal. (Detail)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01dmaindetail`
--

LOCK TABLES `m01dmaindetail` WRITE;
/*!40000 ALTER TABLE `m01dmaindetail` DISABLE KEYS */;
INSERT INTO `m01dmaindetail` VALUES (1,1,1,29,900000.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-19 16:00:58','NuSoft - NuSoft Administrator','2016-06-19 16:00:58','NuSoft - NuSoft Administrator',NULL),(2,1,3,69,0.0000,900000.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-19 16:00:58','NuSoft - NuSoft Administrator','2016-06-19 16:00:58','NuSoft - NuSoft Administrator',NULL),(6,3,1,69,900000.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,'',0,'2016-06-19 18:59:39','NuSoft - NuSoft Administrator','2016-06-19 18:59:39','NuSoft - NuSoft Administrator',NULL),(7,3,2,65,0.0000,900000.0000,1.0000,3,0.0000,0.0000,NULL,'',0,'2016-06-19 18:59:39','NuSoft - NuSoft Administrator','2016-06-19 18:59:39','NuSoft - NuSoft Administrator',NULL),(8,4,1,29,100000000.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:43:52','NuSoft - NuSoft Administrator','2016-06-21 06:43:52','NuSoft - NuSoft Administrator',NULL),(9,4,3,69,0.0000,100000000.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:43:52','NuSoft - NuSoft Administrator','2016-06-21 06:43:52','NuSoft - NuSoft Administrator',NULL),(30,9,1,133,100000.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator',NULL),(31,9,2,29,0.0000,100000.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator',NULL),(32,9,3,80,0.0000,90909.0909,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator',NULL),(33,9,4,3,999999.9999,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator',NULL),(34,9,5,113,0.0000,909090.9090,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator',NULL),(35,10,1,133,100000.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator',NULL),(36,10,2,29,0.0000,100000.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator',NULL),(37,10,3,80,0.0000,1010.0909,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator',NULL),(38,10,4,3,11111.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator',NULL),(39,10,5,113,0.0000,10100.9091,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator',NULL),(40,11,1,19,2222.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,'',0,'2021-02-20 13:03:20','NuSoft - NuSoft Administrator','2021-02-20 13:03:20','NuSoft - NuSoft Administrator',NULL),(41,11,2,30,0.0000,2222.0000,1.0000,3,0.0000,0.0000,NULL,'',0,'2021-02-20 13:03:20','NuSoft - NuSoft Administrator','2021-02-20 13:03:20','NuSoft - NuSoft Administrator',NULL),(42,12,0,23,0.0000,500.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator','2021-02-20 16:07:27','NuSoft - NuSoft Administrator',NULL),(43,12,2,74,500.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,NULL,0,'2021-02-20 16:07:27','NuSoft - NuSoft Administrator','2021-02-20 16:07:27','NuSoft - NuSoft Administrator',NULL),(44,13,1,69,100000000.0000,0.0000,1.0000,3,0.0000,0.0000,NULL,'',0,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator','2021-02-20 16:12:58','NuSoft - NuSoft Administrator',NULL),(45,13,2,65,0.0000,100000000.0000,1.0000,3,0.0000,0.0000,NULL,'',0,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator','2021-02-20 16:12:58','NuSoft - NuSoft Administrator',NULL);
/*!40000 ALTER TABLE `m01dmaindetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01dmaingiro`
--

DROP TABLE IF EXISTS `m01dmaingiro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01dmaingiro` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` bigint(20) unsigned NOT NULL,
  `f_idsetlement` bigint(20) unsigned DEFAULT NULL,
  `f_coagiro` int(10) unsigned NOT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_girono` varchar(50) NOT NULL,
  `d_bank` varchar(100) DEFAULT NULL,
  `d_bankacno` varchar(50) DEFAULT NULL,
  `d_duedate` date DEFAULT NULL,
  `d_value` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_kurs` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_status` tinyint(1) NOT NULL DEFAULT '0',
  `d_type` tinyint(2) DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m01dmaingiro_m01cmaingl1_idx` (`p_id`),
  KEY `fk_m01dmaingiro_m01cmaingl2_idx` (`f_idsetlement`),
  KEY `fk_m01dmaingiro_m01bcoa2_idx` (`f_coagiro`),
  KEY `fk_m01dmaingiro_m01acurrency1_idx` (`f_currency`),
  CONSTRAINT `fk_m01dmaingiro_m01acurrency1` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01dmaingiro_m01bcoa2` FOREIGN KEY (`f_coagiro`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01dmaingiro_m01cmaingl1` FOREIGN KEY (`p_id`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m01dmaingiro_m01cmaingl2` FOREIGN KEY (`f_idsetlement`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01dmaingiro`
--

LOCK TABLES `m01dmaingiro` WRITE;
/*!40000 ALTER TABLE `m01dmaingiro` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01dmaingiro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01dpaymentreqdetail`
--

DROP TABLE IF EXISTS `m01dpaymentreqdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01dpaymentreqdetail` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` bigint(20) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `f_division` smallint(5) unsigned DEFAULT NULL,
  `d_value` decimal(18,4) NOT NULL DEFAULT '0.0000',
  `d_rate` decimal(18,4) unsigned NOT NULL DEFAULT '1.0000',
  `d_currency` smallint(5) unsigned NOT NULL,
  `d_note` varchar(150) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `f_proyek` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  UNIQUE KEY `cd_m01dpaymentreqdetail` (`p_id`,`f_coa`),
  KEY `fk_m01dpaymentreqdetail_m01bcoa1_idx` (`f_coa`),
  KEY `fk_m01dpaymentregdetail_division_idx` (`f_division`),
  CONSTRAINT `fk_m01dpaymentregdetail_division` FOREIGN KEY (`f_division`) REFERENCES `a_division` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01dpaymentreqdetail_m01bcoa1` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_m01dpaymentrequestdetail_main` FOREIGN KEY (`p_id`) REFERENCES `m01cpaymentreqmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01dpaymentreqdetail`
--

LOCK TABLES `m01dpaymentreqdetail` WRITE;
/*!40000 ALTER TABLE `m01dpaymentreqdetail` DISABLE KEYS */;
INSERT INTO `m01dpaymentreqdetail` VALUES (1,2,148,NULL,2500000.0000,1.0000,3,'','2015-06-01 05:55:30','admin - Administrator','2015-06-01 05:55:30','admin - Administrator',NULL),(2,3,26,NULL,200000.0000,1.0000,3,'','2015-06-01 07:23:27','admin - Administrator','2015-06-01 07:23:27','admin - Administrator',NULL),(3,4,135,NULL,2000000.0000,1.0000,3,'','2015-06-05 05:43:16','admin - Administrator','2015-06-05 05:43:16','admin - Administrator',NULL);
/*!40000 ALTER TABLE `m01dpaymentreqdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01dprepaidamortization`
--

DROP TABLE IF EXISTS `m01dprepaidamortization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01dprepaidamortization` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `f_main` int(10) unsigned NOT NULL,
  `u_seq` smallint(5) unsigned NOT NULL,
  `d_date` date NOT NULL,
  `d_value` decimal(18,4) NOT NULL,
  `fk_gl` bigint(20) unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code_m01dprepaidamortization` (`f_main`,`u_seq`),
  KEY `fk_01dprepaidamortization_gl_idx` (`fk_gl`),
  CONSTRAINT `fk_01dprepaidamortization_gl` FOREIGN KEY (`fk_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_01dprepaidamortization_main` FOREIGN KEY (`f_main`) REFERENCES `m01cprepaidmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01dprepaidamortization`
--

LOCK TABLES `m01dprepaidamortization` WRITE;
/*!40000 ALTER TABLE `m01dprepaidamortization` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01dprepaidamortization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01drevalcoa`
--

DROP TABLE IF EXISTS `m01drevalcoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01drevalcoa` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_drevalcoa_crevalmain1_idx` (`p_id`),
  KEY `fk_drevalcoa_m01bcoa1_idx` (`f_coa`),
  CONSTRAINT `fk_drevalcoa_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_drevalcoa_main` FOREIGN KEY (`p_id`) REFERENCES `m01crevalmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01drevalcoa`
--

LOCK TABLES `m01drevalcoa` WRITE;
/*!40000 ALTER TABLE `m01drevalcoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01drevalcoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01drevaldetail`
--

DROP TABLE IF EXISTS `m01drevaldetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01drevaldetail` (
  `primary_main` int(11) NOT NULL,
  `p_id` int(10) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `f_contact` int(10) unsigned NOT NULL,
  `d_valuevalas` decimal(18,4) DEFAULT NULL,
  `d_value` decimal(18,4) DEFAULT NULL,
  `d_kurs` decimal(18,4) DEFAULT NULL,
  `d_valuereval` decimal(18,4) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_drevaldetail_crevalmain1_idx` (`p_id`),
  KEY `fk_drevaldetail_m01bcoa1_idx` (`f_coa`),
  KEY `fk_drevaldetail_m01bcontactview1_idx` (`f_contact`),
  CONSTRAINT `fk_drevaldetail_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_drevaldetail_contact` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_drevaldetail_main` FOREIGN KEY (`p_id`) REFERENCES `m01crevalmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01drevaldetail`
--

LOCK TABLES `m01drevaldetail` WRITE;
/*!40000 ALTER TABLE `m01drevaldetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01drevaldetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01drevalkurs`
--

DROP TABLE IF EXISTS `m01drevalkurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01drevalkurs` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_drevalkurs_crevalmain1_idx` (`p_id`),
  KEY `fk_drevalkurs_m01acurrency1_idx` (`f_currency`),
  CONSTRAINT `fk_drevalkurs_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_drevalkurs_main` FOREIGN KEY (`p_id`) REFERENCES `m01crevalmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01drevalkurs`
--

LOCK TABLES `m01drevalkurs` WRITE;
/*!40000 ALTER TABLE `m01drevalkurs` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01drevalkurs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01period`
--

DROP TABLE IF EXISTS `m01period`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01period` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_year` year(4) NOT NULL,
  `u_month` tinyint(3) unsigned NOT NULL,
  `d_lock` tinyint(1) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `cd_m01period` (`u_year`,`u_month`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel system untuk mengunci bulan akuntansi';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01period`
--

LOCK TABLES `m01period` WRITE;
/*!40000 ALTER TABLE `m01period` DISABLE KEYS */;
/*!40000 ALTER TABLE `m01period` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `m01varap`
--

DROP TABLE IF EXISTS `m01varap`;
/*!50001 DROP VIEW IF EXISTS `m01varap`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m01varap` AS SELECT 
 1 AS `id`,
 1 AS `f_coa`,
 1 AS `f_currency`,
 1 AS `f_contact`,
 1 AS `jumlah`,
 1 AS `bayar`,
 1 AS `jumlahvalas`,
 1 AS `bayarvalas`,
 1 AS `saldo`,
 1 AS `saldovalas`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m01vwcashadvanceremain`
--

DROP TABLE IF EXISTS `m01vwcashadvanceremain`;
/*!50001 DROP VIEW IF EXISTS `m01vwcashadvanceremain`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m01vwcashadvanceremain` AS SELECT 
 1 AS `p_id`,
 1 AS `u_code`,
 1 AS `d_date`,
 1 AS `d_contact`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m01vwcustomreport`
--

DROP TABLE IF EXISTS `m01vwcustomreport`;
/*!50001 DROP VIEW IF EXISTS `m01vwcustomreport`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m01vwcustomreport` AS SELECT 
 1 AS `Id`,
 1 AS `MainId`,
 1 AS `Tipe`,
 1 AS `Urutan`,
 1 AS `Nama`,
 1 AS `Level`,
 1 AS `Tanda`,
 1 AS `Akun`,
 1 AS `Saldo`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m01vwgiro`
--

DROP TABLE IF EXISTS `m01vwgiro`;
/*!50001 DROP VIEW IF EXISTS `m01vwgiro`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m01vwgiro` AS SELECT 
 1 AS `Id`,
 1 AS `NoBukti`,
 1 AS `NoBuktiCair`,
 1 AS `CoaGiro`,
 1 AS `Uang`,
 1 AS `NoGiro`,
 1 AS `Bank`,
 1 AS `NoACBank`,
 1 AS `TglJatuhTempo`,
 1 AS `Nilai`,
 1 AS `Kurs`,
 1 AS `Status`,
 1 AS `Tipe`,
 1 AS `SelisihHari`,
 1 AS `SelisihHariNama`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m01vwgl`
--

DROP TABLE IF EXISTS `m01vwgl`;
/*!50001 DROP VIEW IF EXISTS `m01vwgl`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m01vwgl` AS SELECT 
 1 AS `Id`,
 1 AS `SumberData`,
 1 AS `Tahun`,
 1 AS `Bulan`,
 1 AS `Tanggal`,
 1 AS `Kontak`,
 1 AS `NoBukti`,
 1 AS `AkunMain`,
 1 AS `AkunDetail`,
 1 AS `Urutan`,
 1 AS `SaldoAwal`,
 1 AS `Debit`,
 1 AS `Kredit`,
 1 AS `SaldoAwalValas`,
 1 AS `DebitValas`,
 1 AS `KreditValas`,
 1 AS `Keterangan`,
 1 AS `Proyek`,
 1 AS `ProyekSub`,
 1 AS `Divisi`,
 1 AS `Kurs`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m01vwsaldo`
--

DROP TABLE IF EXISTS `m01vwsaldo`;
/*!50001 DROP VIEW IF EXISTS `m01vwsaldo`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m01vwsaldo` AS SELECT 
 1 AS `id`,
 1 AS `tipe`,
 1 AS `kode`,
 1 AS `nama`,
 1 AS `induk`,
 1 AS `level1`,
 1 AS `level2`,
 1 AS `level3`,
 1 AS `level4`,
 1 AS `uang`,
 1 AS `saldoawal`,
 1 AS `mutasidebit`,
 1 AS `mutasikredit`,
 1 AS `saldoakhir`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `m01zcustomreport`
--

DROP TABLE IF EXISTS `m01zcustomreport`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01zcustomreport` (
  `p_id` int(10) unsigned NOT NULL,
  `u_kind` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT '1: AKTIVA\n2: PASSIVA\n3: PROFIT/LOSS\n4: COGS\n5: CASH FLOW\n6: PERBANDINGAN NERACA',
  `u_code` tinyint(3) unsigned NOT NULL,
  `d_order` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_name` varchar(50) NOT NULL,
  `d_level` tinyint(3) unsigned NOT NULL DEFAULT '0' COMMENT '0: HEADER\n1: DETAIL\n2: TOTAL',
  `d_space` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_sign` enum('+','-') NOT NULL DEFAULT '+',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`u_kind`,`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata setting laporan kustom.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01zcustomreport`
--

LOCK TABLES `m01zcustomreport` WRITE;
/*!40000 ALTER TABLE `m01zcustomreport` DISABLE KEYS */;
INSERT INTO `m01zcustomreport` VALUES (501,5,1,1,'ddsadsad',1,0,'+','2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m01zcustomreport` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01zcustomreportdetail`
--

DROP TABLE IF EXISTS `m01zcustomreportdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01zcustomreportdetail` (
  `p_id` int(10) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `f_main` int(10) unsigned NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `code` (`f_main`,`f_coa`),
  KEY `fk_02crdetail_crmain_idx` (`f_main`),
  KEY `fk_02crdetail_azcoa_idx` (`f_coa`),
  CONSTRAINT `fk_02crdetail_azcoa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_02crdetail_crmain` FOREIGN KEY (`f_main`) REFERENCES `m01zcustomreport` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata akun pada report kustom. (Khusus detail)';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01zcustomreportdetail`
--

LOCK TABLES `m01zcustomreportdetail` WRITE;
/*!40000 ALTER TABLE `m01zcustomreportdetail` DISABLE KEYS */;
INSERT INTO `m01zcustomreportdetail` VALUES (501003,3,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501004,4,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501005,5,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501006,6,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501007,7,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501008,8,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501009,9,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501010,10,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501011,11,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501012,12,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501013,13,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501015,15,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501016,16,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501017,17,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501018,18,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501019,19,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501020,20,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator'),(501021,21,501,'2014-09-30 11:21:56','NuSoft - NuSoft Administrator','2014-09-30 11:21:56','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m01zcustomreportdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m01zregional`
--

DROP TABLE IF EXISTS `m01zregional`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m01zregional` (
  `p_id` smallint(5) unsigned NOT NULL,
  `f_coacash` int(10) unsigned DEFAULT NULL,
  `d_format` varchar(3) DEFAULT NULL,
  `d_cashier` varchar(50) DEFAULT NULL,
  `d_cashierbank` varchar(50) DEFAULT NULL,
  `d_accounting` varchar(50) DEFAULT NULL,
  `d_director` varchar(50) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_02zregional_coacash_idx` (`f_coacash`),
  KEY `fk_02zregional_regional_idx` (`p_id`),
  CONSTRAINT `fk_02zregional_coacash` FOREIGN KEY (`f_coacash`) REFERENCES `m01bcoa` (`p_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_02zregional_regional` FOREIGN KEY (`p_id`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data format regional';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m01zregional`
--

LOCK TABLES `m01zregional` WRITE;
/*!40000 ALTER TABLE `m01zregional` DISABLE KEYS */;
INSERT INTO `m01zregional` VALUES (1,NULL,NULL,NULL,NULL,NULL,NULL,'2014-08-25 19:17:29','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(2,NULL,NULL,NULL,NULL,NULL,NULL,'2014-08-25 19:17:29','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator'),(3,NULL,NULL,NULL,NULL,NULL,NULL,'2014-08-25 19:17:29','NuSoft - NuSoft Administrator','2015-06-18 07:09:45','admin - Administrator');
/*!40000 ALTER TABLE `m01zregional` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m02aassettype`
--

DROP TABLE IF EXISTS `m02aassettype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m02aassettype` (
  `p_id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `u_name` varchar(50) NOT NULL,
  `d_age` tinyint(4) DEFAULT NULL,
  `d_type` tinyint(4) DEFAULT NULL COMMENT '0: tanpa penyusutan\n1 : garis lurus\n2 : saldo menurun',
  `f_coaasset` int(10) unsigned NOT NULL,
  `f_coadepr` int(10) unsigned NOT NULL,
  `f_coaakumdepr` int(10) unsigned NOT NULL,
  `f_coawriteoff` int(10) unsigned NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_name_UNIQUE` (`u_name`),
  KEY `fk_m01aassettype_m01bcoa1_idx` (`f_coaasset`),
  KEY `fk_m01aassettype_m01bcoa2_idx` (`f_coadepr`),
  KEY `fk_m01aassettype_m01bcoa3_idx` (`f_coaakumdepr`),
  KEY `fk_m01aassettype_m01bcoa4_idx` (`f_coawriteoff`),
  CONSTRAINT `fk_m01aassettype_m01bcoa1` FOREIGN KEY (`f_coaasset`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01aassettype_m01bcoa2` FOREIGN KEY (`f_coadepr`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01aassettype_m01bcoa3` FOREIGN KEY (`f_coaakumdepr`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m01aassettype_m01bcoa4` FOREIGN KEY (`f_coawriteoff`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m02aassettype`
--

LOCK TABLES `m02aassettype` WRITE;
/*!40000 ALTER TABLE `m02aassettype` DISABLE KEYS */;
INSERT INTO `m02aassettype` VALUES (1,'Mobil',48,1,54,199,58,245,'2015-03-24 09:08:46','NuSoft - NuSoft Administrator','2015-05-14 20:38:18','admin - admin'),(2,'Mobil2',60,2,53,139,59,136,'2015-05-13 08:54:30','NuSoft - NuSoft Administrator','2015-05-13 08:54:30','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m02aassettype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m02bassetview`
--

DROP TABLE IF EXISTS `m02bassetview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m02bassetview` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_type` tinyint(3) unsigned NOT NULL,
  `u_code` varchar(30) DEFAULT NULL,
  `d_name` varchar(150) DEFAULT NULL,
  `d_qtyin` tinyint(3) unsigned NOT NULL,
  `d_qtyout` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_price` decimal(18,4) unsigned DEFAULT '0.0000',
  `d_residuvalue` decimal(18,4) unsigned DEFAULT '0.0000',
  `d_bookvalue` decimal(18,4) unsigned DEFAULT '0.0000',
  `d_amortisasivalue` decimal(18,4) unsigned DEFAULT '0.0000',
  `d_datepurchase` date DEFAULT NULL,
  `d_dateused` date DEFAULT NULL,
  `f_divisi` int(10) unsigned DEFAULT NULL,
  `d_tgl15` tinyint(1) DEFAULT NULL,
  `d_intangible` tinyint(1) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `d_purchase` tinyint(1) DEFAULT '0',
  `d_dispose` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`p_id`),
  KEY `fk_m02bassetview_m02aassettype1_idx` (`f_type`),
  CONSTRAINT `fk_m02bassetview_type` FOREIGN KEY (`f_type`) REFERENCES `m02aassettype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m02bassetview`
--

LOCK TABLES `m02bassetview` WRITE;
/*!40000 ALTER TABLE `m02bassetview` DISABLE KEYS */;
INSERT INTO `m02bassetview` VALUES (9,1,'Mobil 1','Mobil 1',1,0,130000000.0000,10000000.0000,0.0000,0.0000,'2015-01-03','2015-01-03',NULL,0,0,'2015-05-14 20:38:53','admin - admin','2015-05-14 20:39:02','admin - admin',1,0);
/*!40000 ALTER TABLE `m02bassetview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m02cassetdepreciation`
--

DROP TABLE IF EXISTS `m02cassetdepreciation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m02cassetdepreciation` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_asset` int(10) unsigned NOT NULL,
  `d_seq` tinyint(3) unsigned NOT NULL,
  `d_year` smallint(5) unsigned NOT NULL,
  `d_month` tinyint(3) unsigned NOT NULL,
  `d_value` decimal(18,4) DEFAULT '0.0000',
  `d_begindate` date DEFAULT NULL,
  `d_enddate` date DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_m02cassetdepreciation_m02bassetview1_idx` (`f_asset`),
  CONSTRAINT `fk_m02cassetdepreciation_asset` FOREIGN KEY (`f_asset`) REFERENCES `m02bassetview` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m02cassetdepreciation`
--

LOCK TABLES `m02cassetdepreciation` WRITE;
/*!40000 ALTER TABLE `m02cassetdepreciation` DISABLE KEYS */;
INSERT INTO `m02cassetdepreciation` VALUES (48,9,1,2015,12,2500000.0000,'2015-01-03','2015-12-03','2015-05-14 20:38:53','admin - admin','2015-05-14 20:38:53','admin - admin'),(49,9,2,2016,12,2500000.0000,'2016-01-03','2016-12-03','2015-05-14 20:38:53','admin - admin','2015-05-14 20:38:53','admin - admin'),(50,9,3,2017,12,2500000.0000,'2017-01-03','2017-12-03','2015-05-14 20:38:53','admin - admin','2015-05-14 20:38:53','admin - admin'),(51,9,4,2018,12,2500000.0000,'2018-01-03','2018-12-03','2015-05-14 20:38:53','admin - admin','2015-05-14 20:38:53','admin - admin');
/*!40000 ALTER TABLE `m02cassetdepreciation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m02ctransactionmain`
--

DROP TABLE IF EXISTS `m02ctransactionmain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m02ctransactionmain` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_year` smallint(5) unsigned DEFAULT NULL,
  `u_month` tinyint(3) unsigned DEFAULT NULL,
  `u_coa` int(10) unsigned DEFAULT NULL,
  `u_regional` smallint(5) unsigned DEFAULT NULL,
  `u_source` smallint(5) unsigned DEFAULT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date NOT NULL,
  `f_contact` int(10) unsigned NOT NULL,
  `d_type` tinyint(4) DEFAULT NULL,
  `d_description` varchar(255) DEFAULT NULL,
  `f_gl` bigint(20) unsigned DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m02ctransactionmain_contact_idx` (`f_contact`),
  KEY `fk_m02ctransactionmain_gl_idx` (`f_gl`),
  CONSTRAINT `fk_m02ctransactionmain_contact` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m02ctransactionmain_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m02ctransactionmain`
--

LOCK TABLES `m02ctransactionmain` WRITE;
/*!40000 ALTER TABLE `m02ctransactionmain` DISABLE KEYS */;
/*!40000 ALTER TABLE `m02ctransactionmain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m02dtransactiondetail`
--

DROP TABLE IF EXISTS `m02dtransactiondetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m02dtransactiondetail` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_asset` int(10) unsigned NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_valuein` decimal(18,4) DEFAULT '0.0000',
  `d_valueout` decimal(18,4) DEFAULT '0.0000',
  `d_bookvalue` decimal(18,4) DEFAULT '0.0000',
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  UNIQUE KEY `U_m02dtransactiondetail` (`p_id`,`f_asset`),
  KEY `fk_m02dtransactiondetail_m02ctransactionmain1_idx` (`p_id`),
  KEY `fk_m02dtransactiondetail_m02bassetview1_idx` (`f_asset`),
  CONSTRAINT `fk_m02dtransactiondetail_m02bassetview1` FOREIGN KEY (`f_asset`) REFERENCES `m02bassetview` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_m02dtransactiondetail_m02ctransactionmain1` FOREIGN KEY (`p_id`) REFERENCES `m02ctransactionmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m02dtransactiondetail`
--

LOCK TABLES `m02dtransactiondetail` WRITE;
/*!40000 ALTER TABLE `m02dtransactiondetail` DISABLE KEYS */;
/*!40000 ALTER TABLE `m02dtransactiondetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `m02vwasset`
--

DROP TABLE IF EXISTS `m02vwasset`;
/*!50001 DROP VIEW IF EXISTS `m02vwasset`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m02vwasset` AS SELECT 
 1 AS `p_id`,
 1 AS `f_asset`,
 1 AS `d_price`,
 1 AS `d_residuvalue`,
 1 AS `d_amortization`,
 1 AS `d_bookvalue`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `m03project`
--

DROP TABLE IF EXISTS `m03project`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m03project` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m03project`
--

LOCK TABLES `m03project` WRITE;
/*!40000 ALTER TABLE `m03project` DISABLE KEYS */;
/*!40000 ALTER TABLE `m03project` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04acategory`
--

DROP TABLE IF EXISTS `m04acategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04acategory` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04acategory`
--

LOCK TABLES `m04acategory` WRITE;
/*!40000 ALTER TABLE `m04acategory` DISABLE KEYS */;
INSERT INTO `m04acategory` VALUES (1,'Kategori1','Kategori1','NuSoft - NuSoft Administrator','2015-05-29 13:28:14','admin - Administrator','2015-06-20 20:14:05'),(2,'Kategori2','Kategori2','NuSoft - NuSoft Administrator','2015-05-29 13:28:14','admin - Administrator','2015-06-20 20:14:05'),(3,'Bahan Baku','Bahan baku','admin - Administrator','2015-06-20 20:14:05','admin - Administrator','2015-06-20 20:14:05'),(4,'Bahan Jadi','Bahan Jadi','admin - Administrator','2015-06-20 20:14:05','admin - Administrator','2015-06-20 20:14:05');
/*!40000 ALTER TABLE `m04acategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04acost`
--

DROP TABLE IF EXISTS `m04acost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04acost` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `f_coacost` int(10) unsigned NOT NULL,
  `f_coaincome` int(10) unsigned NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04acost`
--

LOCK TABLES `m04acost` WRITE;
/*!40000 ALTER TABLE `m04acost` DISABLE KEYS */;
INSERT INTO `m04acost` VALUES (1,'Biaya Listrik','Biaya Listrik',142,113,'2014-07-17 14:12:11','NuSoft - NuSoft Administrator','2014-07-17 14:16:28','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m04acost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04amerk`
--

DROP TABLE IF EXISTS `m04amerk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04amerk` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04amerk`
--

LOCK TABLES `m04amerk` WRITE;
/*!40000 ALTER TABLE `m04amerk` DISABLE KEYS */;
INSERT INTO `m04amerk` VALUES (1,'Merek1','Merek1','NuSoft - NuSoft Administrator','2015-05-29 13:28:44','NuSoft - NuSoft Administrator','2015-05-29 13:28:44'),(2,'Merek2','Merek2','NuSoft - NuSoft Administrator','2015-05-29 13:28:44','NuSoft - NuSoft Administrator','2015-05-29 13:28:44');
/*!40000 ALTER TABLE `m04amerk` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04asubcategory`
--

DROP TABLE IF EXISTS `m04asubcategory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04asubcategory` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04asubcategory`
--

LOCK TABLES `m04asubcategory` WRITE;
/*!40000 ALTER TABLE `m04asubcategory` DISABLE KEYS */;
INSERT INTO `m04asubcategory` VALUES (1,'Sub Kategori1','Sub Kategori1','NuSoft - NuSoft Administrator','2015-05-29 13:28:30','NuSoft - NuSoft Administrator','2015-05-29 13:28:30'),(2,'Sub Kategori2','Sub Kategori2','NuSoft - NuSoft Administrator','2015-05-29 13:28:30','NuSoft - NuSoft Administrator','2015-05-29 13:28:30');
/*!40000 ALTER TABLE `m04asubcategory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04atax`
--

DROP TABLE IF EXISTS `m04atax`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04atax` (
  `p_id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_valuetax` decimal(18,4) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04atax`
--

LOCK TABLES `m04atax` WRITE;
/*!40000 ALTER TABLE `m04atax` DISABLE KEYS */;
INSERT INTO `m04atax` VALUES (1,'Non',0.0000,'jali - Jali','2014-03-30 15:55:21','jali - Jali','2014-03-30 15:55:21'),(2,'PPN',10.0000,'jali - Jali','2014-03-30 15:55:21','jali - Jali','2014-03-30 15:55:21'),(3,'PPH-23',2.0000,'jali - Jali','2014-03-30 15:55:21','jali - Jali','2014-03-30 15:55:21'),(4,'PPH-23N',4.0000,'jali - Jali','2014-03-30 15:55:21','jali - Jali','2014-03-30 15:55:21');
/*!40000 ALTER TABLE `m04atax` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04atype`
--

DROP TABLE IF EXISTS `m04atype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04atype` (
  `p_id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `f_coaincome` int(11) unsigned DEFAULT NULL,
  `f_coacost` int(11) unsigned DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `FK_m04atype_m01bcoa` (`f_coaincome`),
  KEY `FK_m04atype_cost` (`f_coacost`),
  CONSTRAINT `FK_m04atype_cost` FOREIGN KEY (`f_coacost`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_m04atype_m01bcoa` FOREIGN KEY (`f_coaincome`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04atype`
--

LOCK TABLES `m04atype` WRITE;
/*!40000 ALTER TABLE `m04atype` DISABLE KEYS */;
INSERT INTO `m04atype` VALUES (4,'Pemakaian Barang',113,158,'2015-06-20 11:11:11','admin - Administrator','2015-06-20 11:11:11','admin - Administrator'),(5,'Penjualan Part',114,133,'2015-06-20 11:11:26','admin - Administrator','2015-06-20 11:11:26','admin - Administrator'),(6,'Penjualan Unit',113,133,'2015-06-20 11:11:37','admin - Administrator','2015-06-20 11:11:37','admin - Administrator'),(7,'Stock Opname',117,136,'2015-06-20 11:11:51','admin - Administrator','2015-06-20 11:11:51','admin - Administrator');
/*!40000 ALTER TABLE `m04atype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04auom`
--

DROP TABLE IF EXISTS `m04auom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04auom` (
  `p_id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_name` varchar(50) NOT NULL,
  `d_value` decimal(18,4) DEFAULT '1.0000',
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04auom`
--

LOCK TABLES `m04auom` WRITE;
/*!40000 ALTER TABLE `m04auom` DISABLE KEYS */;
INSERT INTO `m04auom` VALUES (3,'LNG','Length',1.0000,'jali - Jali','2014-03-30 15:55:39','jali - Jali','2014-03-30 15:55:39'),(4,'EA','EA',1.0000,'jali - Jali','2014-03-30 15:55:39','jali - Jali','2014-03-30 15:55:39');
/*!40000 ALTER TABLE `m04auom` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04awarehouse`
--

DROP TABLE IF EXISTS `m04awarehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04awarehouse` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) DEFAULT NULL,
  `d_name` varchar(50) DEFAULT NULL,
  `d_address` varchar(255) DEFAULT NULL,
  `d_telp` varchar(50) DEFAULT NULL,
  `d_fax` varchar(50) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04awarehouse`
--

LOCK TABLES `m04awarehouse` WRITE;
/*!40000 ALTER TABLE `m04awarehouse` DISABLE KEYS */;
INSERT INTO `m04awarehouse` VALUES (1,'G-JKT','Gudang Jakarta',NULL,NULL,NULL,'jali - Jali','2014-03-30 15:56:31','NuSoft - NuSoft Administrator','2014-09-11 09:28:09'),(2,'G-m2m','mangga dua',NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2014-09-11 09:28:09','NuSoft - NuSoft Administrator','2014-09-11 09:28:09');
/*!40000 ALTER TABLE `m04awarehouse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04bitem`
--

DROP TABLE IF EXISTS `m04bitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04bitem` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(45) NOT NULL,
  `d_name` varchar(100) DEFAULT NULL,
  `d_jenis` tinyint(4) DEFAULT '0',
  `d_tipe` tinyint(4) DEFAULT '0',
  `f_uom` tinyint(3) unsigned NOT NULL,
  `f_uomd` tinyint(3) unsigned NOT NULL,
  `f_curency` smallint(5) unsigned NOT NULL,
  `d_pricelastpurchase` decimal(18,4) DEFAULT '0.0000',
  `d_priceselling1` decimal(18,4) DEFAULT '0.0000',
  `d_priceselling2` decimal(18,4) DEFAULT '0.0000',
  `d_priceselling3` decimal(18,4) DEFAULT '0.0000',
  `d_priceselling4` decimal(18,4) DEFAULT '0.0000',
  `d_priceselling5` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `f_coaincome` int(10) unsigned DEFAULT NULL,
  `f_coacost` int(10) unsigned DEFAULT NULL,
  `f_coastock` int(10) unsigned DEFAULT NULL,
  `f_coadiscincome` int(10) unsigned DEFAULT NULL,
  `f_coadisccost` int(10) unsigned DEFAULT NULL,
  `f_coareturnincome` int(10) unsigned DEFAULT NULL,
  `f_coareturncost` int(10) unsigned DEFAULT NULL,
  `d_stockmax` decimal(18,4) DEFAULT '0.0000',
  `d_stockmin` decimal(18,4) DEFAULT '0.0000',
  `d_stockcurrent` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_aktif` smallint(6) DEFAULT NULL,
  `d_stokreorder` decimal(18,4) DEFAULT '0.0000',
  `f_kategori` smallint(5) unsigned DEFAULT NULL,
  `f_subkategori` smallint(5) unsigned DEFAULT NULL,
  `f_merk` smallint(5) unsigned DEFAULT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `d_custom6` varchar(255) DEFAULT NULL,
  `d_custom7` varchar(255) DEFAULT NULL,
  `d_custom8` varchar(255) DEFAULT NULL,
  `d_custom9` varchar(255) DEFAULT NULL,
  `d_custom10` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) NOT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_kode_UNIQUE` (`u_code`),
  KEY `fk_m04bitem_uom_idx` (`f_uom`),
  KEY `fk_m04bitem_uomd_idx` (`f_uomd`),
  KEY `fk_m04bitem_taxin_idx` (`f_taxin`),
  KEY `fk_m04bitem_taxout_idx` (`f_taxout`),
  KEY `fk_m04bitem_currency_idx` (`f_curency`),
  KEY `fk_m04bitem_coaincome_idx` (`f_coaincome`),
  KEY `fk_m04bitem_coacost_idx` (`f_coacost`),
  KEY `fk_m04bitem_coastock_idx` (`f_coastock`),
  KEY `fk_m04bitem_coadiscincome_idx` (`f_coadiscincome`),
  KEY `fk_m04bitem_coadisccost_idx` (`f_coadisccost`),
  KEY `fk_m04bitem_coareturnincome_idx` (`f_coareturnincome`),
  KEY `fk_m04bitem_coareturncost_idx` (`f_coareturncost`),
  KEY `fk_m04bitem_m04acategory_idx` (`f_kategori`),
  KEY `fk_m04bitem_subcategory_idx` (`f_subkategori`),
  KEY `fk_m04bitem_merk_idx` (`f_merk`),
  CONSTRAINT `FK_m04bitem_merek` FOREIGN KEY (`f_merk`) REFERENCES `m04amerk` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `FK_m04bitem_subcategory` FOREIGN KEY (`f_subkategori`) REFERENCES `m04asubcategory` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_category` FOREIGN KEY (`f_kategori`) REFERENCES `m04acategory` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coacost` FOREIGN KEY (`f_coacost`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coadisccost` FOREIGN KEY (`f_coadisccost`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coadiscincome` FOREIGN KEY (`f_coadiscincome`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coaincome` FOREIGN KEY (`f_coaincome`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coareturncost` FOREIGN KEY (`f_coareturncost`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coareturnincome` FOREIGN KEY (`f_coareturnincome`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_coastock` FOREIGN KEY (`f_coastock`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_currency` FOREIGN KEY (`f_curency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04bitem_uomd` FOREIGN KEY (`f_uomd`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=277 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04bitem`
--

LOCK TABLES `m04bitem` WRITE;
/*!40000 ALTER TABLE `m04bitem` DISABLE KEYS */;
INSERT INTO `m04bitem` VALUES (1,'P1/8CS40','PIPE C/S SEAMLESS, API5L / A106 A53 GR B, 1/8 INCH SCH 40 @6MTR',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,111,133,29,111,131,111,131,0.0000,100.0000,0.0000,NULL,1,0.0000,NULL,NULL,NULL,'','40','1/8','6m','','','','','','','','NuSoft - NuSoft Administrator','2014-08-23 20:06:22','admin - Administrator','2015-06-19 09:22:03'),(2,'P1/4CS40','PIPE C/S SEAMLESS, API5L / A106 A53 GR B, 1/4 INCH SCH 40 @6MTR',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,111,133,29,111,131,111,131,0.0000,0.0000,0.0000,NULL,1,NULL,NULL,NULL,NULL,NULL,'40','1/4','6m',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2014-08-23 20:06:22','NuSoft - NuSoft Administrator','2014-08-25 11:29:11'),(3,'P3/8CS40','PIPE C/S SEAMLESS, API5L / A106 A53 GR B, 3/8 INCH SCH 40 @6MTR',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,111,133,29,111,131,111,131,0.0000,0.0000,0.0000,NULL,1,NULL,NULL,NULL,NULL,NULL,'40','3/8','6m',NULL,NULL,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2014-08-23 20:06:22','NuSoft - NuSoft Administrator','2014-08-25 11:29:11'),(154,'BV1','BALL VALVE',0,0,4,4,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,111,133,29,111,131,111,131,0.0000,0.0000,0.0000,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,'1\"',NULL,'SS316',NULL,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2014-08-23 20:06:22','NuSoft - NuSoft Administrator','2014-08-25 11:29:11'),(264,'1234','Barang 1234',0,0,3,3,3,100000.0000,100000.0000,0.0000,0.0000,0.0000,100000.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,NULL,NULL,NULL,'','','','','','','','','','','','NuSoft - NuSoft Administrator','2015-05-31 17:03:42','NuSoft - NuSoft Administrator','2015-05-31 17:03:42'),(265,'1235','Barang 1235',0,0,3,3,3,100000.0000,200000.0000,0.0000,0.0000,0.0000,200000.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,NULL,NULL,NULL,'','','','','','','','','','','','NuSoft - NuSoft Administrator','2015-05-31 17:03:53','NuSoft - NuSoft Administrator','2015-05-31 17:03:53'),(266,'Test','Test',0,0,3,3,3,100000.0000,100000.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,2000.0000,0.0000,NULL,1,0.0000,NULL,NULL,NULL,'','','','','','','','','','','','NuSoft - NuSoft Administrator','2015-06-13 08:17:04','admin - Administrator','2015-06-19 09:20:27'),(267,'Test2','Test2',0,0,3,3,3,100000.0000,200000.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,2000.0000,0.0000,NULL,1,0.0000,NULL,NULL,NULL,'','','','','','','','','','','','NuSoft - NuSoft Administrator','2015-06-13 08:24:11','admin - Administrator','2015-06-19 09:20:35'),(268,'Memori DDR 4GB','Memori DDR 4GB',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:14:46','admin - Administrator','2015-06-20 20:15:06'),(269,'Mainboard','Mainboard',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:15:27','admin - Administrator','2015-06-20 20:16:41'),(270,'Power Suply','Power Suply',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:15:47','admin - Administrator','2015-06-20 20:15:47'),(271,'Processor Intel Core i5','Processor Intel Core i5',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:16:17','admin - Administrator','2015-06-20 20:16:17'),(272,'Keyboard','Keyboard',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:16:26','admin - Administrator','2015-06-20 20:16:34'),(273,'Mouse','Mouse',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:16:54','admin - Administrator','2015-06-20 20:16:54'),(274,'Monitor 21\"','Monitor 21\"',0,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,3,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:17:16','admin - Administrator','2015-06-20 20:17:16'),(275,'Komputer Paket 1','Komputer Paket 1',2,0,3,3,3,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,4,NULL,NULL,'','','','','','','','','','','','admin - Administrator','2015-06-20 20:17:41','admin - Administrator','2015-06-22 15:44:05'),(276,'Jasa01','Jasa 01',1,0,3,3,3,0.0000,0.0000,0.0000,0.0000,0.0000,0.0000,2,1,113,133,33,117,142,127,145,0.0000,0.0000,0.0000,NULL,1,0.0000,NULL,NULL,NULL,'','','','','','','','','','','','NuSoft - NuSoft Administrator','2016-03-26 09:41:46','NuSoft - NuSoft Administrator','2016-03-26 09:41:46');
/*!40000 ALTER TABLE `m04bitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04citemassembly`
--

DROP TABLE IF EXISTS `m04citemassembly`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04citemassembly` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `f_item` int(10) unsigned NOT NULL,
  `f_itemconstituent` int(10) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '1.0000',
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_remarks` varchar(50) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_m04citemassembly_item_idx` (`f_item`),
  KEY `fk_m04citemassembly_itemconstituent_idx` (`f_itemconstituent`),
  KEY `fk_m04citemassembly_uom_idx` (`f_uom`),
  CONSTRAINT `fk_m04citemassembly_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m04citemassembly_itemconstituent` FOREIGN KEY (`f_itemconstituent`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04citemassembly_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04citemassembly`
--

LOCK TABLES `m04citemassembly` WRITE;
/*!40000 ALTER TABLE `m04citemassembly` DISABLE KEYS */;
INSERT INTO `m04citemassembly` VALUES (1,275,268,2.0000,3,'asd','2015-06-22 15:41:25','admin - Administrator','2015-06-22 15:44:05','admin - Administrator'),(2,275,269,1.0000,3,'asd','2015-06-22 15:41:25','admin - Administrator','2015-06-22 15:41:25','admin - Administrator'),(3,275,270,1.0000,3,'','2015-06-22 15:44:05','admin - Administrator','2015-06-22 15:44:05','admin - Administrator'),(4,275,271,1.0000,3,'','2015-06-22 15:44:05','admin - Administrator','2015-06-22 15:44:05','admin - Administrator'),(5,275,272,1.0000,3,'','2015-06-22 15:44:05','admin - Administrator','2015-06-22 15:44:05','admin - Administrator'),(6,275,273,1.0000,3,'','2015-06-22 15:44:05','admin - Administrator','2015-06-22 15:44:05','admin - Administrator'),(7,275,274,1.0000,3,'','2015-06-22 15:44:05','admin - Administrator','2015-06-22 15:44:05','admin - Administrator');
/*!40000 ALTER TABLE `m04citemassembly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04citemlocation`
--

DROP TABLE IF EXISTS `m04citemlocation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04citemlocation` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_warehouse` smallint(5) unsigned NOT NULL,
  `d_location` varchar(50) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04citemlocation_item_idx` (`p_id`),
  KEY `fk_m04citemlocation_warehouse_idx` (`f_warehouse`),
  CONSTRAINT `fk_m04citemlocation_item` FOREIGN KEY (`p_id`) REFERENCES `m04bitem` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m04citemlocation_warehouse` FOREIGN KEY (`f_warehouse`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04citemlocation`
--

LOCK TABLES `m04citemlocation` WRITE;
/*!40000 ALTER TABLE `m04citemlocation` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04citemlocation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04cmainrequest`
--

DROP TABLE IF EXISTS `m04cmainrequest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04cmainrequest` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `f_warehouse` smallint(5) unsigned NOT NULL,
  `f_employee` int(10) unsigned NOT NULL,
  `f_type` tinyint(3) unsigned DEFAULT NULL COMMENT '0 = Permintaan Mutasi, 1 = Permintaan Pembelian',
  `d_dateexpired` date DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_statusquotation` tinyint(1) DEFAULT '0',
  `d_statusorder` tinyint(1) DEFAULT '0',
  `d_statusreceive` tinyint(1) DEFAULT '0',
  `f_division` int(11) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m04cmainrequest_warehouse_idx` (`f_warehouse`),
  KEY `fk_m04cmainrequest_employee_idx` (`f_employee`),
  CONSTRAINT `fk_m04cmainrequest_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cmainrequest_warehouse` FOREIGN KEY (`f_warehouse`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04cmainrequest`
--

LOCK TABLES `m04cmainrequest` WRITE;
/*!40000 ALTER TABLE `m04cmainrequest` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04cmainrequest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04cmainstockopname`
--

DROP TABLE IF EXISTS `m04cmainstockopname`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04cmainstockopname` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `f_employee` int(10) unsigned NOT NULL,
  `f_warehouse` smallint(5) unsigned NOT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m04cmainstockopname_warehouse_idx` (`f_warehouse`),
  KEY `fk_m04cmainstockopname_employee_idx` (`f_employee`),
  CONSTRAINT `fk_m04cmainstockopname_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cmainstockopname_warehouse` FOREIGN KEY (`f_warehouse`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04cmainstockopname`
--

LOCK TABLES `m04cmainstockopname` WRITE;
/*!40000 ALTER TABLE `m04cmainstockopname` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04cmainstockopname` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04cstockmain`
--

DROP TABLE IF EXISTS `m04cstockmain`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04cstockmain` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `f_contact` int(10) unsigned DEFAULT NULL,
  `f_warehouse` smallint(5) unsigned NOT NULL,
  `f_type` tinyint(3) unsigned DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_person` varchar(45) DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `f_divisi` varchar(45) DEFAULT NULL,
  `f_address` int(11) DEFAULT NULL,
  `d_address` varchar(255) DEFAULT NULL,
  `f_warehouse2` smallint(5) unsigned DEFAULT NULL,
  `d_nodocument` varchar(150) DEFAULT NULL,
  `d_novehicle` varchar(50) DEFAULT NULL,
  `d_driver` varchar(50) DEFAULT NULL,
  `f_idrequest` int(10) unsigned DEFAULT NULL,
  `f_idso` int(10) unsigned DEFAULT NULL,
  `f_idpo` int(10) unsigned DEFAULT NULL,
  `f_currency` smallint(6) DEFAULT NULL,
  `d_kurs` decimal(18,4) DEFAULT NULL,
  `f_gl` bigint(20) unsigned DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `d_taxtype` tinyint(4) DEFAULT '0',
  `d_poscash` decimal(18,4) DEFAULT '0.0000',
  `d_posdebit` decimal(18,4) DEFAULT '0.0000',
  `d_poscredit` decimal(18,4) DEFAULT '0.0000',
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m04cmainadjustment_warehouse_idx` (`f_warehouse`),
  KEY `fk_m04cmainadjustment_type_idx` (`f_type`),
  KEY `fk_m04cstockmain_contact_idx` (`f_contact`),
  KEY `fk_m04cstockmain_warehouse2_idx` (`f_warehouse2`),
  KEY `fk_m04cstockmain_request_idx` (`f_idrequest`),
  KEY `fk_m04stockmain_employee_idx` (`f_employee`),
  KEY `fk_m04stockmain_gl_idx` (`f_gl`),
  CONSTRAINT `fk_m04cstockmain_contact` FOREIGN KEY (`f_contact`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cstockmain_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cstockmain_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cstockmain_request` FOREIGN KEY (`f_idrequest`) REFERENCES `m04cmainrequest` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cstockmain_type` FOREIGN KEY (`f_type`) REFERENCES `m04atype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cstockmain_warehouse` FOREIGN KEY (`f_warehouse`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04cstockmain_warehouse2` FOREIGN KEY (`f_warehouse2`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04cstockmain`
--

LOCK TABLES `m04cstockmain` WRITE;
/*!40000 ALTER TABLE `m04cstockmain` DISABLE KEYS */;
INSERT INTO `m04cstockmain` VALUES (1,1,22,2016,6,1,'JKT-GR16060001','2016-06-19',1223,1,NULL,'Penerimaan Barang',3,NULL,1069,NULL,NULL,NULL,NULL,'sd','asd','asd',NULL,NULL,1,3,1.0000,1,'NuSoft - NuSoft Administrator','2016-06-19 16:00:58','NuSoft - NuSoft Administrator','2016-06-19 18:59:39',0,0.0000,0.0000,0.0000),(2,1,22,2016,6,2,'JKT-GR16060002','2016-06-21',1223,1,NULL,'Penerimaan Barang',3,NULL,1069,NULL,NULL,NULL,NULL,'','','',NULL,NULL,2,3,1.0000,4,'NuSoft - NuSoft Administrator','2016-06-21 06:43:51','NuSoft - NuSoft Administrator','2021-02-20 16:12:58',0,0.0000,0.0000,0.0000),(7,1,39,2016,6,1,'JKT-QS16060001','2016-06-21',3915,1,NULL,'Penjualan POS',1,NULL,1069,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,3,1.0000,9,'NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06',2,999999.9999,0.0000,0.0000),(8,1,39,2016,6,2,'JKT-QS16060002','2016-06-21',3915,1,NULL,'Penjualan POS',1,NULL,1069,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,3,1.0000,10,'NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26',2,11111.0000,0.0000,0.0000);
/*!40000 ALTER TABLE `m04cstockmain` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04ddetailproductioncost`
--

DROP TABLE IF EXISTS `m04ddetailproductioncost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04ddetailproductioncost` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_value` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04ddetailproductionc_coa_idx` (`f_coa`),
  CONSTRAINT `fk_m04ddetailproductionc_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04ddetailproductioncost`
--

LOCK TABLES `m04ddetailproductioncost` WRITE;
/*!40000 ALTER TABLE `m04ddetailproductioncost` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04ddetailproductioncost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04ddetailrequest`
--

DROP TABLE IF EXISTS `m04ddetailrequest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04ddetailrequest` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_qtymutation` decimal(18,4) DEFAULT '0.0000',
  `d_qtymutation2` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04ddetailmutation_main_idx` (`p_id`),
  KEY `fk_m04ddetailrequest_item_idx` (`f_item`),
  KEY `fk_m04ddetailrequest_uom_idx` (`f_uom`),
  CONSTRAINT `fk_m04ddetailrequest_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m04ddetailrequest_main` FOREIGN KEY (`p_id`) REFERENCES `m04cmainrequest` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m04ddetailrequest_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04ddetailrequest`
--

LOCK TABLES `m04ddetailrequest` WRITE;
/*!40000 ALTER TABLE `m04ddetailrequest` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04ddetailrequest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04ddetailstockopname`
--

DROP TABLE IF EXISTS `m04ddetailstockopname`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04ddetailstockopname` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04ddetailstockopname_main_idx` (`p_id`),
  KEY `fk_m04ddetailstockopname_item_idx` (`f_item`),
  KEY `fk_m04ddetailstockopname_uom_idx` (`f_uom`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04ddetailstockopname`
--

LOCK TABLES `m04ddetailstockopname` WRITE;
/*!40000 ALTER TABLE `m04ddetailstockopname` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04ddetailstockopname` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04dstockcost`
--

DROP TABLE IF EXISTS `m04dstockcost`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04dstockcost` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` bigint(20) unsigned NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `f_cost` smallint(5) unsigned NOT NULL,
  `d_value` decimal(18,4) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04dstockcost_main_idx` (`p_id`),
  KEY `fk_m04dstockcost_m04acost1_idx` (`f_cost`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04dstockcost`
--

LOCK TABLES `m04dstockcost` WRITE;
/*!40000 ALTER TABLE `m04dstockcost` DISABLE KEYS */;
INSERT INTO `m04dstockcost` VALUES (1,14,'2015-05-23 14:49:28','admin - Administrator','2015-05-23 14:49:28','admin - Administrator',1,250000.0000,''),(2,26,'2015-06-21 07:09:18','admin - Administrator','2015-06-21 07:09:18','admin - Administrator',1,500000.0000,'');
/*!40000 ALTER TABLE `m04dstockcost` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04dstockdetail`
--

DROP TABLE IF EXISTS `m04dstockdetail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04dstockdetail` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` bigint(20) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_warehouse` smallint(5) unsigned NOT NULL,
  `f_location` int(10) unsigned DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qtyin` decimal(18,4) DEFAULT '0.0000',
  `d_qtyout` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `d_taxin` decimal(18,4) DEFAULT '0.0000',
  `d_taxout` decimal(18,4) DEFAULT '0.0000',
  `d_hppout` decimal(18,4) DEFAULT '0.0000',
  `f_idrequestd` int(10) unsigned DEFAULT NULL,
  `f_idsod` int(10) unsigned DEFAULT NULL,
  `f_idpod` int(10) unsigned DEFAULT NULL,
  `f_division` int(11) DEFAULT NULL,
  `f_warehouse2` int(11) DEFAULT NULL,
  `d_hppproduction` decimal(18,4) DEFAULT '0.0000',
  `f_proyek` int(10) unsigned DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04ddetailmutation_item_idx` (`f_item`),
  KEY `fk_m04ddetailmutation_uom_idx` (`f_uom`),
  KEY `fk_m04ddetailmutation_warehouse_idx` (`f_warehouse`),
  KEY `fk_m04ddetailmutation_request_idx` (`f_idrequestd`),
  KEY `fk_m04ddetailmutation_itemlocation_idx` (`f_location`),
  KEY `fk_m04dstockdetail_m04cmainstock1_idx` (`p_id`),
  CONSTRAINT `FK_m04dstockdetail_m04cstockmain` FOREIGN KEY (`p_id`) REFERENCES `m04cstockmain` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04dstockdetail`
--

LOCK TABLES `m04dstockdetail` WRITE;
/*!40000 ALTER TABLE `m04dstockdetail` DISABLE KEYS */;
INSERT INTO `m04dstockdetail` VALUES (1,1,1,1,NULL,'',3,1.0000,0.0000,900000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,NULL,NULL,1,NULL,NULL,0.0000,NULL,'2016-06-19 16:00:58','NuSoft - NuSoft Administrator','2016-06-19 16:00:58','NuSoft - NuSoft Administrator'),(2,2,154,1,NULL,'',4,1000.0000,0.0000,100000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,NULL,NULL,2,NULL,NULL,0.0000,NULL,'2016-06-21 06:43:52','NuSoft - NuSoft Administrator','2016-06-21 06:43:52','NuSoft - NuSoft Administrator'),(7,7,154,1,NULL,NULL,4,0.0000,1.0000,1000000.0000,0.0000,0.0000,0.0000,0.0000,0.0000,NULL,NULL,NULL,NULL,NULL,0.0000,NULL,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator'),(8,8,154,1,NULL,NULL,4,0.0000,1.0000,11111.0000,0.0000,0.0000,0.0000,0.0000,0.0000,NULL,NULL,NULL,NULL,NULL,0.0000,NULL,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m04dstockdetail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04dstockdetailserial`
--

DROP TABLE IF EXISTS `m04dstockdetailserial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04dstockdetailserial` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `d_length` decimal(18,4) DEFAULT '0.0000',
  `d_noserial` varchar(150) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04dstockdetailserial`
--

LOCK TABLES `m04dstockdetailserial` WRITE;
/*!40000 ALTER TABLE `m04dstockdetailserial` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04dstockdetailserial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04efilerequest`
--

DROP TABLE IF EXISTS `m04efilerequest`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04efilerequest` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `d_filename` varchar(50) DEFAULT NULL,
  `d_remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m04efilerequest_main_idx` (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04efilerequest`
--

LOCK TABLES `m04efilerequest` WRITE;
/*!40000 ALTER TABLE `m04efilerequest` DISABLE KEYS */;
/*!40000 ALTER TABLE `m04efilerequest` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m04estockhpp`
--

DROP TABLE IF EXISTS `m04estockhpp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m04estockhpp` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `f_idout` bigint(20) unsigned NOT NULL,
  `f_idin` bigint(20) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  KEY `fk_m04stockhpp_m04dstockdetail1_idx` (`f_idin`),
  KEY `fk_m04stockhpp_m04dstockdetail2_idx` (`f_idout`),
  CONSTRAINT `FK_m04estockhpp_m04dstockdetail` FOREIGN KEY (`f_idout`) REFERENCES `m04dstockdetail` (`primary_main`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_m04estockhpp_m04dstockdetailin` FOREIGN KEY (`f_idin`) REFERENCES `m04dstockdetail` (`primary_main`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m04estockhpp`
--

LOCK TABLES `m04estockhpp` WRITE;
/*!40000 ALTER TABLE `m04estockhpp` DISABLE KEYS */;
INSERT INTO `m04estockhpp` VALUES (5,7,2,1.0000,'2016-06-21 06:51:06','NuSoft - NuSoft Administrator','2016-06-21 06:51:06','NuSoft - NuSoft Administrator'),(6,8,2,1.0000,'2016-06-21 06:51:26','NuSoft - NuSoft Administrator','2016-06-21 06:51:26','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m04estockhpp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `m04vwhpp`
--

DROP TABLE IF EXISTS `m04vwhpp`;
/*!50001 DROP VIEW IF EXISTS `m04vwhpp`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m04vwhpp` AS SELECT 
 1 AS `primary_main`,
 1 AS `f_item`,
 1 AS `d_qtyin`,
 1 AS `d_qtyout`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m04vwhppavailable`
--

DROP TABLE IF EXISTS `m04vwhppavailable`;
/*!50001 DROP VIEW IF EXISTS `m04vwhppavailable`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m04vwhppavailable` AS SELECT 
 1 AS `id`,
 1 AS `f_item`,
 1 AS `f_warehouse`,
 1 AS `f_location`,
 1 AS `d_qtyin`,
 1 AS `d_qtyout`,
 1 AS `d_used`,
 1 AS `d_available`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m04vwitem`
--

DROP TABLE IF EXISTS `m04vwitem`;
/*!50001 DROP VIEW IF EXISTS `m04vwitem`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m04vwitem` AS SELECT 
 1 AS `id`,
 1 AS `barang`,
 1 AS `kode`,
 1 AS `nama`,
 1 AS `saldoawal`,
 1 AS `stockin`,
 1 AS `stockout`,
 1 AS `saldoakhir`,
 1 AS `stock1`,
 1 AS `stock2`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m04vwkartustock`
--

DROP TABLE IF EXISTS `m04vwkartustock`;
/*!50001 DROP VIEW IF EXISTS `m04vwkartustock`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m04vwkartustock` AS SELECT 
 1 AS `Id`,
 1 AS `SaldoAwal`,
 1 AS `SaldoAwalNilai`,
 1 AS `Masuk`,
 1 AS `Keluar`,
 1 AS `Harga`,
 1 AS `HPP`,
 1 AS `NoBukti`,
 1 AS `Tanggal`,
 1 AS `Barang`,
 1 AS `Uraian`,
 1 AS `Gudang`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m04vwsaldo`
--

DROP TABLE IF EXISTS `m04vwsaldo`;
/*!50001 DROP VIEW IF EXISTS `m04vwsaldo`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m04vwsaldo` AS SELECT 
 1 AS `Id`,
 1 AS `Kode`,
 1 AS `Nama`,
 1 AS `Satuan`,
 1 AS `Kategori`,
 1 AS `SubKategori`,
 1 AS `Merk`,
 1 AS `SaldoAwal`,
 1 AS `QtyIn`,
 1 AS `QtyOut`,
 1 AS `SaldoAwalNilai`,
 1 AS `QtyInNilai`,
 1 AS `QtyOutNilai`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `m05atermin`
--

DROP TABLE IF EXISTS `m05atermin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05atermin` (
  `p_id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `d_tempo` tinyint(4) DEFAULT NULL,
  `d_discount` tinyint(4) DEFAULT NULL,
  `d_discountp` decimal(18,4) DEFAULT NULL,
  `d_penalties` tinyint(4) DEFAULT NULL,
  `d_penaltiesp` decimal(18,4) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05atermin`
--

LOCK TABLES `m05atermin` WRITE;
/*!40000 ALTER TABLE `m05atermin` DISABLE KEYS */;
INSERT INTO `m05atermin` VALUES (1,'15 Hari',15,0,0.0000,0,0.0000,'NuSoft - NuSoft Administrator','2015-05-18 06:02:12','NuSoft - NuSoft Administrator','2015-05-18 06:02:12'),(2,'1 Bulan',30,0,0.0000,0,0.0000,'NuSoft - NuSoft Administrator','2015-05-18 06:02:17','NuSoft - NuSoft Administrator','2015-05-18 06:02:17');
/*!40000 ALTER TABLE `m05atermin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05avia`
--

DROP TABLE IF EXISTS `m05avia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05avia` (
  `p_id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(25) NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05avia`
--

LOCK TABLES `m05avia` WRITE;
/*!40000 ALTER TABLE `m05avia` DISABLE KEYS */;
INSERT INTO `m05avia` VALUES (1,'Via 1','2015-05-18 06:02:33','NuSoft - NuSoft Administrator','NuSoft - NuSoft Administrator','2015-05-18 06:02:33'),(2,'Via 2','2015-05-18 06:02:33','NuSoft - NuSoft Administrator','NuSoft - NuSoft Administrator','2015-05-18 06:02:33'),(3,'Via 3','2015-05-18 06:02:33','NuSoft - NuSoft Administrator','NuSoft - NuSoft Administrator','2015-05-18 06:02:33');
/*!40000 ALTER TABLE `m05avia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05cmaininvoicereceipt`
--

DROP TABLE IF EXISTS `m05cmaininvoicereceipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05cmaininvoicereceipt` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_vendor` int(10) unsigned NOT NULL,
  `p_idorder` int(10) unsigned DEFAULT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `d_address` varchar(255) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_tipe` tinyint(4) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT '1.0000',
  `d_externalnumber` varchar(50) DEFAULT NULL,
  `d_taxtype` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_taxcaption` tinyint(4) DEFAULT '0',
  `d_taxsnppn` varchar(50) DEFAULT NULL,
  `d_taxsnpph` varchar(50) DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `f_termin` tinyint(3) unsigned DEFAULT NULL,
  `d_duedate` date DEFAULT NULL,
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_othercost` decimal(18,4) DEFAULT '0.0000',
  `f_gl` bigint(20) unsigned NOT NULL DEFAULT '0',
  `f_dptax` tinyint(3) unsigned DEFAULT NULL,
  `d_dptaxp` decimal(18,4) DEFAULT NULL,
  `d_dppersen` decimal(18,4) DEFAULT '0.0000',
  `d_bbvalue` decimal(18,4) DEFAULT '0.0000',
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `d_custom6` varchar(255) DEFAULT NULL,
  `d_custom7` varchar(255) DEFAULT NULL,
  `d_custom8` varchar(255) DEFAULT NULL,
  `d_custom9` varchar(255) DEFAULT NULL,
  `d_custom10` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `f_coahutang` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m05cmaininvoicereceipt_order_idx` (`p_idorder`),
  KEY `fk_m05cmaininvoicereceipt_vendor_idx` (`f_vendor`),
  KEY `fk_m05cmaininvoicereceipt_employee_idx` (`f_employee`),
  KEY `fk_m05cmaininvoicereceipt_currency_idx` (`f_currency`),
  KEY `fk_m05cmaininvoicereceipt_termin_idx` (`f_termin`),
  KEY `fk_m05cmaininvoicereceipt_pajak_idx` (`f_dptax`),
  KEY `fk_m05cmaininvoicereceipt_gl_idx` (`f_gl`),
  CONSTRAINT `fk_m05cmaininvoicereceipt_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmaininvoicereceipt_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmaininvoicereceipt_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmaininvoicereceipt_order` FOREIGN KEY (`p_idorder`) REFERENCES `m05cmainorder` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmaininvoicereceipt_pajak` FOREIGN KEY (`f_dptax`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmaininvoicereceipt_termin` FOREIGN KEY (`f_termin`) REFERENCES `m05atermin` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmaininvoicereceipt_vendor` FOREIGN KEY (`f_vendor`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05cmaininvoicereceipt`
--

LOCK TABLES `m05cmaininvoicereceipt` WRITE;
/*!40000 ALTER TABLE `m05cmaininvoicereceipt` DISABLE KEYS */;
INSERT INTO `m05cmaininvoicereceipt` VALUES (2,1,23,2016,6,1,'JKT-RI16060001','2016-06-19',1,1223,1,NULL,NULL,'Invoice Pembelian',0,3,1.0000,NULL,0,1,'','',NULL,NULL,NULL,0.0000,0.0000,3,NULL,0.0000,0.0000,0.0000,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2016-06-19 18:59:39','NuSoft - NuSoft Administrator','2016-06-19 18:59:39',NULL),(3,1,23,2021,2,1,'JKT-RI21020001','2021-02-20',1,1223,2,NULL,NULL,'Invoice Pembelian',0,3,1.0000,'',0,1,'','',1069,1,'2021-03-07',0.0000,0.0000,13,NULL,0.0000,0.0000,0.0000,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2021-02-20 16:12:58','NuSoft - NuSoft Administrator','2021-02-20 16:12:58',65);
/*!40000 ALTER TABLE `m05cmaininvoicereceipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05cmainorder`
--

DROP TABLE IF EXISTS `m05cmainorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05cmainorder` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_type` tinyint(3) unsigned DEFAULT NULL,
  `f_idquotation` int(10) unsigned DEFAULT NULL,
  `f_idrequest` int(10) unsigned DEFAULT NULL,
  `f_vendor` int(10) unsigned NOT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `f_address` int(11) DEFAULT NULL,
  `d_address` varchar(100) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT NULL,
  `d_fob` tinyint(4) DEFAULT NULL,
  `d_leadtime` varchar(50) DEFAULT NULL,
  `f_termin` tinyint(3) unsigned DEFAULT NULL,
  `f_via` smallint(5) unsigned DEFAULT NULL,
  `d_efectivedate` date DEFAULT NULL,
  `d_taxtype` tinyint(4) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `f_warehouse` smallint(5) unsigned NOT NULL,
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_othercost` decimal(18,4) DEFAULT '0.0000',
  `d_description` varchar(255) DEFAULT NULL,
  `d_reffnumber` varchar(100) DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `d_custom6` varchar(255) DEFAULT NULL,
  `d_custom7` varchar(255) DEFAULT NULL,
  `d_custom8` varchar(255) DEFAULT NULL,
  `d_custom9` varchar(255) DEFAULT NULL,
  `d_custom10` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `d_remarksapp` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m05cmainorder_quotation_idx` (`f_idquotation`),
  KEY `fk_m05cmainorder_termin_idx` (`f_termin`),
  KEY `fk_m05cmainorder_vendor_idx` (`f_vendor`),
  KEY `fk_m05cmainorder_currency_idx` (`f_currency`),
  KEY `fk_m05cmainorder_type_idx` (`f_type`),
  KEY `fk_m05cmainorder_m05avia1_idx` (`f_via`),
  KEY `fk_m05cmainorder_warehouse_idx` (`f_warehouse`),
  KEY `fk_m05cmainorder_employee_idx` (`f_employee`),
  CONSTRAINT `fk_m05cmainorder_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainorder_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainorder_quotation` FOREIGN KEY (`f_idquotation`) REFERENCES `m05cmainquotation` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainorder_termin` FOREIGN KEY (`f_termin`) REFERENCES `m05atermin` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainorder_type` FOREIGN KEY (`f_type`) REFERENCES `m04atype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainorder_vendor` FOREIGN KEY (`f_vendor`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainorder_via` FOREIGN KEY (`f_via`) REFERENCES `m05avia` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_m05cmainorder_warehouse` FOREIGN KEY (`f_warehouse`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05cmainorder`
--

LOCK TABLES `m05cmainorder` WRITE;
/*!40000 ALTER TABLE `m05cmainorder` DISABLE KEYS */;
INSERT INTO `m05cmainorder` VALUES (1,1,20,2016,6,1,'JKT-PO16060001','2016-06-19',3,NULL,NULL,NULL,1223,NULL,NULL,NULL,3,1.0000,0,'<Lead Time>',NULL,1,NULL,0,'',NULL,1,0.0000,0.0000,'Order Pembelian','','','','','','',NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2016-06-19 16:00:43','NuSoft - NuSoft Administrator','2016-06-19 16:00:58',NULL),(2,1,20,2016,6,2,'JKT-PO16060002','2016-06-21',3,NULL,NULL,NULL,1223,NULL,NULL,NULL,3,1.0000,0,'<Lead Time>',1,1,NULL,0,'',1069,1,0.0000,0.0000,'Order Pembelian','','','','','','',NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2016-06-21 06:43:40','NuSoft - NuSoft Administrator','2016-06-21 06:43:52',NULL);
/*!40000 ALTER TABLE `m05cmainorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05cmainpayment`
--

DROP TABLE IF EXISTS `m05cmainpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05cmainpayment` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_vendor` int(10) unsigned NOT NULL,
  `d_taxpayment` tinyint(1) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT '1.0000',
  `d_value` decimal(18,4) DEFAULT '0.0000',
  `d_valuevalas` decimal(18,4) DEFAULT '0.0000',
  `d_bankadmin` decimal(18,4) DEFAULT '0.0000',
  `d_discount` decimal(18,4) DEFAULT '0.0000',
  `d_rounding` decimal(18,4) DEFAULT '0.0000',
  `d_pphvalue` decimal(18,4) DEFAULT '0.0000',
  `d_pphnumber` varchar(50) DEFAULT NULL,
  `d_typepayment` tinyint(4) DEFAULT NULL,
  `d_numberpayment` varchar(50) DEFAULT NULL,
  `d_bankaccountnumber` varchar(50) DEFAULT NULL,
  `d_tempo` date DEFAULT NULL,
  `f_gl` bigint(20) unsigned NOT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m05cmainpayment_vendor_idx` (`f_vendor`),
  KEY `fk_m05cmainpayment_coa_idx` (`f_coa`),
  KEY `fk_m05cmainpayment_gl_idx` (`f_gl`),
  CONSTRAINT `fk_m05cmainpayment_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainpayment_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainpayment_vendor` FOREIGN KEY (`f_vendor`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05cmainpayment`
--

LOCK TABLES `m05cmainpayment` WRITE;
/*!40000 ALTER TABLE `m05cmainpayment` DISABLE KEYS */;
/*!40000 ALTER TABLE `m05cmainpayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05cmainquotation`
--

DROP TABLE IF EXISTS `m05cmainquotation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05cmainquotation` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_type` tinyint(3) unsigned DEFAULT NULL,
  `f_vendor` int(10) unsigned NOT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_taxtype` tinyint(3) unsigned NOT NULL,
  `d_efectivedate` date DEFAULT NULL,
  `d_fob` tinyint(4) DEFAULT NULL,
  `d_leadtime` varchar(50) DEFAULT NULL,
  `f_termin` tinyint(3) unsigned DEFAULT NULL,
  `f_via` smallint(5) unsigned DEFAULT NULL,
  `f_warehouse` smallint(5) unsigned DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_othercost` decimal(18,4) DEFAULT '0.0000',
  `f_idrequest` int(10) unsigned DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `d_custom6` varchar(255) DEFAULT NULL,
  `d_custom7` varchar(255) DEFAULT NULL,
  `d_custom8` varchar(255) DEFAULT NULL,
  `d_custom9` varchar(255) DEFAULT NULL,
  `d_custom10` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m05cmainquotation_termin_idx` (`f_termin`),
  KEY `fk_m05cmainquotation_vendor_idx` (`f_vendor`),
  KEY `fk_m05cmainquotation_currency_idx` (`f_currency`),
  KEY `fk_m05cmainquotation_request_idx` (`f_idrequest`),
  KEY `fk_m05cmainquotation_type_idx` (`f_type`),
  KEY `fk_m05cmainquotation_m05avia1_idx` (`f_via`),
  KEY `fk_m05cmainquotation_warehouse_idx` (`f_warehouse`),
  KEY `fk_m05cmainquotation_employee_idx` (`f_employee`),
  CONSTRAINT `fk_m05cmainquotation_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_request` FOREIGN KEY (`f_idrequest`) REFERENCES `m04cmainrequest` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_termin` FOREIGN KEY (`f_termin`) REFERENCES `m05atermin` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_type` FOREIGN KEY (`f_type`) REFERENCES `m04atype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_vendor` FOREIGN KEY (`f_vendor`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_via` FOREIGN KEY (`f_via`) REFERENCES `m05avia` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05cmainquotation_warehouse` FOREIGN KEY (`f_warehouse`) REFERENCES `m04awarehouse` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05cmainquotation`
--

LOCK TABLES `m05cmainquotation` WRITE;
/*!40000 ALTER TABLE `m05cmainquotation` DISABLE KEYS */;
/*!40000 ALTER TABLE `m05cmainquotation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05ddetailinvoicereceipt`
--

DROP TABLE IF EXISTS `m05ddetailinvoicereceipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05ddetailinvoicereceipt` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_idgr` int(10) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `d_taxinp` decimal(18,4) DEFAULT '0.0000',
  `d_taxoutp` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_division` int(11) DEFAULT NULL,
  `f_proyek` int(10) unsigned DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m05ddetailinvoicereceipt_main_idx` (`p_id`),
  KEY `fk_m05ddetailinvoicereceipt_item_idx` (`f_item`),
  KEY `fk_m05ddetailinvoicereceipt_uom_idx` (`f_uom`),
  KEY `fk_m05ddetailinvoicereceipt_taxin_idx` (`f_taxin`),
  KEY `fk_m05ddetailinvoicereceipt_taxout_idx` (`f_taxout`),
  KEY `fk_m05ddetailinvoicereceipt_proyek_idx` (`f_proyek`),
  CONSTRAINT `fk_m05ddetailinvoicereceipt_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailinvoicereceipt_main` FOREIGN KEY (`p_id`) REFERENCES `m05cmaininvoicereceipt` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailinvoicereceipt_proyek` FOREIGN KEY (`f_proyek`) REFERENCES `m01aproject` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailinvoicereceipt_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailinvoicereceipt_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailinvoicereceipt_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05ddetailinvoicereceipt`
--

LOCK TABLES `m05ddetailinvoicereceipt` WRITE;
/*!40000 ALTER TABLE `m05ddetailinvoicereceipt` DISABLE KEYS */;
INSERT INTO `m05ddetailinvoicereceipt` VALUES (2,2,1,1,3,1.0000,0.0000,1000000.0000,100000.0000,10.0000,2,1,10.0000,0.0000,'',NULL,NULL,'2016-06-19 18:59:39','NuSoft - NuSoft Administrator','NuSoft - NuSoft Administrator','2016-06-19 18:59:39'),(3,3,2,154,4,1000.0000,0.0000,100000.0000,0.0000,0.0000,2,1,10.0000,0.0000,'',NULL,NULL,'2021-02-20 16:12:58','NuSoft - NuSoft Administrator','NuSoft - NuSoft Administrator','2021-02-20 16:12:58');
/*!40000 ALTER TABLE `m05ddetailinvoicereceipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05ddetailinvoicereceiptdp`
--

DROP TABLE IF EXISTS `m05ddetailinvoicereceiptdp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05ddetailinvoicereceiptdp` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `p_iddp` int(10) unsigned NOT NULL,
  `d_value` decimal(18,4) DEFAULT '0.0000',
  `d_valuetax` decimal(18,4) DEFAULT '0.0000',
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m05ddetailreceiptinvoicedp_main_idx` (`p_id`),
  KEY `fk_m05ddetailreceiptinvoicedp_dp_idx` (`p_iddp`),
  CONSTRAINT `fk_m05ddetailreceiptinvoicedp_dp` FOREIGN KEY (`p_iddp`) REFERENCES `m05cmaininvoicereceipt` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailreceiptinvoicedp_main` FOREIGN KEY (`p_id`) REFERENCES `m05cmaininvoicereceipt` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05ddetailinvoicereceiptdp`
--

LOCK TABLES `m05ddetailinvoicereceiptdp` WRITE;
/*!40000 ALTER TABLE `m05ddetailinvoicereceiptdp` DISABLE KEYS */;
/*!40000 ALTER TABLE `m05ddetailinvoicereceiptdp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05ddetailorder`
--

DROP TABLE IF EXISTS `m05ddetailorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05ddetailorder` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `d_taxinp` decimal(18,4) DEFAULT NULL,
  `d_taxoutp` decimal(18,4) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_idquotation` int(10) unsigned DEFAULT NULL,
  `f_proyek` int(10) unsigned DEFAULT NULL,
  `f_division` int(11) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m05ddetailorder_main_idx` (`p_id`),
  KEY `fk_m05ddetailorder_quotation_idx` (`f_idquotation`),
  KEY `fk_m05ddetailorder_item_idx` (`f_item`),
  KEY `fk_m05ddetailorder_uom_idx` (`f_uom`),
  KEY `fk_m05ddetailorder_taxin_idx` (`f_taxin`),
  KEY `fk_m05ddetailorder_taxout_idx` (`f_taxout`),
  KEY `fk_m05ddetailorder_proyek_idx` (`f_proyek`),
  CONSTRAINT `fk_m05ddetailorder_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailorder_main` FOREIGN KEY (`p_id`) REFERENCES `m05cmainorder` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailorder_proyek` FOREIGN KEY (`f_proyek`) REFERENCES `m01aproject` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailorder_quotation` FOREIGN KEY (`f_idquotation`) REFERENCES `m05ddetailquotation` (`primary_main`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailorder_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailorder_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailorder_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05ddetailorder`
--

LOCK TABLES `m05ddetailorder` WRITE;
/*!40000 ALTER TABLE `m05ddetailorder` DISABLE KEYS */;
INSERT INTO `m05ddetailorder` VALUES (1,1,1,3,1.0000,0.0000,1000000.0000,100000.0000,10.0000,2,1,10.0000,0.0000,'',NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2016-06-19 16:00:43','NuSoft - NuSoft Administrator','2016-06-19 16:00:43'),(2,2,154,4,1000.0000,0.0000,100000.0000,0.0000,0.0000,2,1,10.0000,0.0000,'',NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2016-06-21 06:43:40','NuSoft - NuSoft Administrator','2016-06-21 06:43:40');
/*!40000 ALTER TABLE `m05ddetailorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05ddetailpayment`
--

DROP TABLE IF EXISTS `m05ddetailpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05ddetailpayment` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `p_idinvoice` int(10) unsigned NOT NULL,
  `d_urutan` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_amount` decimal(18,4) DEFAULT '0.0000',
  `d_kurspayment` decimal(18,4) DEFAULT '1.0000',
  `d_amountcash` decimal(18,4) DEFAULT '0.0000',
  `d_amountreturn` decimal(18,4) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m05ddetailpayment_main_idx` (`p_id`),
  KEY `fk_m05ddetailpayment_invoice_idx` (`p_idinvoice`),
  CONSTRAINT `fk_m05ddetailpayment_invoice` FOREIGN KEY (`p_idinvoice`) REFERENCES `m05cmaininvoicereceipt` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailpayment_main` FOREIGN KEY (`p_id`) REFERENCES `m05cmainpayment` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05ddetailpayment`
--

LOCK TABLES `m05ddetailpayment` WRITE;
/*!40000 ALTER TABLE `m05ddetailpayment` DISABLE KEYS */;
/*!40000 ALTER TABLE `m05ddetailpayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m05ddetailquotation`
--

DROP TABLE IF EXISTS `m05ddetailquotation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m05ddetailquotation` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` varchar(15) DEFAULT '0',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `d_taxinp` decimal(18,4) DEFAULT '0.0000',
  `d_taxoutp` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_idrequest` int(10) unsigned DEFAULT NULL,
  `f_division` int(10) unsigned DEFAULT NULL,
  `f_project` int(10) unsigned DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m05ddetailquotation_main_idx` (`p_id`),
  KEY `fk_m05ddetailquotation_idrequest_idx` (`f_idrequest`),
  KEY `fk_m05ddetailquotation_taxin_idx` (`f_taxin`),
  KEY `fk_m05ddetailquotation_taxout_idx` (`f_taxout`),
  KEY `fk_m05ddetailquotation_item_idx` (`f_item`),
  KEY `fk_m05ddetailquotation_uom_idx` (`f_uom`),
  CONSTRAINT `fk_m05ddetailquotation_idrequest` FOREIGN KEY (`f_idrequest`) REFERENCES `m04ddetailrequest` (`primary_main`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailquotation_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailquotation_main` FOREIGN KEY (`p_id`) REFERENCES `m05cmainquotation` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailquotation_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailquotation_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m05ddetailquotation_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m05ddetailquotation`
--

LOCK TABLES `m05ddetailquotation` WRITE;
/*!40000 ALTER TABLE `m05ddetailquotation` DISABLE KEYS */;
/*!40000 ALTER TABLE `m05ddetailquotation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `m05vwaginginvoice`
--

DROP TABLE IF EXISTS `m05vwaginginvoice`;
/*!50001 DROP VIEW IF EXISTS `m05vwaginginvoice`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m05vwaginginvoice` AS SELECT 
 1 AS `p_id`,
 1 AS `NoInvoice`,
 1 AS `d_payment`,
 1 AS `d_different`,
 1 AS `d_differentdays`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m05vwinvoice`
--

DROP TABLE IF EXISTS `m05vwinvoice`;
/*!50001 DROP VIEW IF EXISTS `m05vwinvoice`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m05vwinvoice` AS SELECT 
 1 AS `Urutan`,
 1 AS `NoInvoice`,
 1 AS `Terbayar`,
 1 AS `NilaiBayarCash`,
 1 AS `OK`,
 1 AS `Kurs`,
 1 AS `Catatan`,
 1 AS `Pembayaran`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `m06avoucher`
--

DROP TABLE IF EXISTS `m06avoucher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06avoucher` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_code` varchar(45) DEFAULT NULL,
  `d_expired` date DEFAULT NULL,
  `d_status` tinyint(2) DEFAULT '0',
  `create_date` datetime DEFAULT NULL,
  `create_user` varchar(100) NOT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06avoucher`
--

LOCK TABLES `m06avoucher` WRITE;
/*!40000 ALTER TABLE `m06avoucher` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06avoucher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06cmainpos`
--

DROP TABLE IF EXISTS `m06cmainpos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06cmainpos` (
  `p_id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_customer` int(10) unsigned NOT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) NOT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) NOT NULL,
  `last_date` datetime DEFAULT NULL,
  `d_pcash` decimal(18,4) DEFAULT '0.0000',
  `d_pcreditcard` decimal(18,4) DEFAULT '0.0000',
  `d_pdebitcard` decimal(18,4) DEFAULT '0.0000',
  `d_pvoucher` decimal(18,4) DEFAULT '0.0000',
  `d_ppoint` decimal(18,4) DEFAULT '0.0000',
  `d_ppointvalue` decimal(18,4) DEFAULT '0.0000',
  `d_pcardnumber` varchar(45) DEFAULT NULL,
  `d_pcardname` varchar(45) DEFAULT NULL,
  `d_pcardbank` varchar(45) DEFAULT NULL,
  `d_pnote` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m05cmainquotation_vendor` (`f_customer`),
  KEY `fk_m05cmainquotation_currency` (`f_currency`),
  CONSTRAINT `fk_m06cmainpos_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06cmainpos_customer` FOREIGN KEY (`f_customer`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06cmainpos`
--

LOCK TABLES `m06cmainpos` WRITE;
/*!40000 ALTER TABLE `m06cmainpos` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06cmainpos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06cmainquotation`
--

DROP TABLE IF EXISTS `m06cmainquotation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06cmainquotation` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_jenis` tinyint(3) unsigned DEFAULT NULL,
  `f_customer` int(10) unsigned NOT NULL,
  `f_address` int(10) unsigned DEFAULT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_taxtype` tinyint(3) unsigned NOT NULL,
  `d_efectivedate` date DEFAULT NULL,
  `d_fob` tinyint(4) DEFAULT NULL,
  `d_leadtime` varchar(50) DEFAULT NULL,
  `f_termin` tinyint(3) unsigned DEFAULT NULL,
  `f_via` tinyint(4) DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_disc` decimal(18,4) DEFAULT NULL,
  `d_othercost` decimal(18,4) DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m06cmainquotation_vendor_idx` (`f_customer`),
  KEY `fk_m06cmainquotation_currency_idx` (`f_currency`),
  KEY `fk_m06cmainquotation_type_idx` (`f_jenis`),
  KEY `fk_m06cmainquotation_termin_idx` (`f_termin`),
  KEY `fk_m06cmainquotation_employee_idx` (`f_employee`),
  KEY `fk_m06cmainquotation_address_idx` (`f_address`),
  CONSTRAINT `fk_m06cmainquotation_address` FOREIGN KEY (`f_address`) REFERENCES `m01ccontactaddress` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06cmainquotation_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06cmainquotation_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06cmainquotation_termin` FOREIGN KEY (`f_termin`) REFERENCES `m05atermin` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06cmainquotation_type` FOREIGN KEY (`f_jenis`) REFERENCES `m04atype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06cmainquotation_vendor` FOREIGN KEY (`f_customer`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06cmainquotation`
--

LOCK TABLES `m06cmainquotation` WRITE;
/*!40000 ALTER TABLE `m06cmainquotation` DISABLE KEYS */;
INSERT INTO `m06cmainquotation` VALUES (1,1,27,2021,2,1,'JKT-SQ21020001','2021-02-20',3,4,887,NULL,NULL,3,0,NULL,0,'<Lead Time>',NULL,1,NULL,'Penawaran Penjualan',0.0000,0.0000,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2021-02-20 16:06:42','NuSoft - NuSoft Administrator','2021-02-20 16:06:55');
/*!40000 ALTER TABLE `m06cmainquotation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06ddetailpos`
--

DROP TABLE IF EXISTS `m06ddetailpos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06ddetailpos` (
  `primary_main` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` bigint(20) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m05ddetailquotation_item` (`f_item`),
  KEY `fk_m05ddetailquotation_uom` (`f_uom`),
  KEY `fk_m06ddetailpos_m06cmainpos1_idx` (`p_id`),
  CONSTRAINT `fk_m06ddetailpos_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06ddetailpos_m06cmainpos` FOREIGN KEY (`p_id`) REFERENCES `m06cmainpos` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m06ddetailpos_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06ddetailpos`
--

LOCK TABLES `m06ddetailpos` WRITE;
/*!40000 ALTER TABLE `m06ddetailpos` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06ddetailpos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06ddetailquotation`
--

DROP TABLE IF EXISTS `m06ddetailquotation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06ddetailquotation` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `d_taxinp` decimal(18,4) DEFAULT '0.0000',
  `d_taxoutp` decimal(18,4) DEFAULT '0.0000',
  `f_division` int(10) unsigned DEFAULT NULL,
  `f_project` int(10) unsigned DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m06ddetailquotation_main_idx` (`p_id`),
  KEY `fk_m06ddetailquotation_taxin_idx` (`f_taxin`),
  KEY `fk_m06ddetailquotation_taxout_idx` (`f_taxout`),
  KEY `fk_m06ddetailquotation_item_idx` (`f_item`),
  KEY `fk_m06ddetailquotation_uom_idx` (`f_uom`),
  CONSTRAINT `fk_m06ddetailquotation_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06ddetailquotation_main` FOREIGN KEY (`p_id`) REFERENCES `m06cmainquotation` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m06ddetailquotation_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06ddetailquotation_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06ddetailquotation_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06ddetailquotation`
--

LOCK TABLES `m06ddetailquotation` WRITE;
/*!40000 ALTER TABLE `m06ddetailquotation` DISABLE KEYS */;
INSERT INTO `m06ddetailquotation` VALUES (1,1,1,3,1.0000,0.0000,'',2000.0000,0.0000,0.0000,2,1,10.0000,0.0000,NULL,NULL,'2021-02-20 16:06:42','NuSoft - NuSoft Administrator','2021-02-20 16:06:42','NuSoft - NuSoft Administrator'),(2,1,264,3,1.0000,0.0000,'',3000.0000,0.0000,0.0000,2,1,10.0000,0.0000,NULL,NULL,'2021-02-20 16:06:42','NuSoft - NuSoft Administrator','2021-02-20 16:06:42','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m06ddetailquotation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06dmainorder`
--

DROP TABLE IF EXISTS `m06dmainorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06dmainorder` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_jenis` tinyint(3) unsigned DEFAULT NULL,
  `f_customer` int(10) unsigned NOT NULL,
  `f_idquotation` int(10) unsigned DEFAULT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `f_address` int(11) unsigned DEFAULT NULL,
  `d_address` varchar(100) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT NULL,
  `d_fob` tinyint(4) DEFAULT NULL,
  `d_leadtime` varchar(50) DEFAULT NULL,
  `f_termin` tinyint(3) unsigned DEFAULT NULL,
  `f_via` tinyint(4) DEFAULT NULL,
  `d_efectivedate` date DEFAULT NULL,
  `d_taxtype` tinyint(4) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `d_disc` decimal(18,4) DEFAULT NULL,
  `d_othercost` decimal(18,4) DEFAULT NULL,
  `d_description` varchar(245) DEFAULT NULL,
  `d_reffnumber` varchar(100) DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m06dmainorder_vendor_idx` (`f_customer`),
  KEY `fk_m06dmainorder_currency_idx` (`f_currency`),
  KEY `fk_m06dmainorder_type_idx` (`f_jenis`),
  KEY `fk_m06dmainorder_termin_idx` (`f_termin`),
  KEY `fk_m06dmainorder_employee_idx` (`f_employee`),
  KEY `fk_m06dmainorder_quotation_idx` (`f_idquotation`),
  KEY `I_m06dmainorder_address_idx` (`f_address`),
  CONSTRAINT `FK_m06dmainorder_address` FOREIGN KEY (`f_address`) REFERENCES `m01ccontactaddress` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06dmainorder_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06dmainorder_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06dmainorder_quotation` FOREIGN KEY (`f_idquotation`) REFERENCES `m06cmainquotation` (`p_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_m06dmainorder_termin` FOREIGN KEY (`f_termin`) REFERENCES `m05atermin` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06dmainorder_type` FOREIGN KEY (`f_jenis`) REFERENCES `m04atype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06dmainorder_vendor` FOREIGN KEY (`f_customer`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06dmainorder`
--

LOCK TABLES `m06dmainorder` WRITE;
/*!40000 ALTER TABLE `m06dmainorder` DISABLE KEYS */;
INSERT INTO `m06dmainorder` VALUES (1,1,28,2021,2,1,'JKT-SO21020001','2021-02-20',1,4,887,1,NULL,NULL,NULL,3,NULL,0,'<Lead Time>',NULL,1,NULL,0,'',NULL,NULL,0.0000,'Order Penjualan','','','','','','','NuSoft - NuSoft Administrator','2021-02-20 16:06:55','NuSoft - NuSoft Administrator','2021-02-20 16:06:55');
/*!40000 ALTER TABLE `m06dmainorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06edetailorder`
--

DROP TABLE IF EXISTS `m06edetailorder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06edetailorder` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_idquotation` int(10) unsigned DEFAULT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `d_taxinp` decimal(18,4) DEFAULT '0.0000',
  `d_taxoutp` decimal(18,4) DEFAULT '0.0000',
  `f_project` int(10) unsigned DEFAULT NULL,
  `f_division` int(11) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m06edetailorder_main_idx` (`p_id`),
  KEY `fk_m06edetailorder_item_idx` (`f_item`),
  KEY `fk_m06edetailorder_uom_idx` (`f_uom`),
  KEY `fk_m06edetailorder_taxin_idx` (`f_taxin`),
  KEY `fk_m06edetailorder_taxout_idx` (`f_taxout`),
  KEY `fk_m06edetailorder_quotation_idx` (`f_idquotation`),
  CONSTRAINT `fk_m06edetailorder_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06edetailorder_main` FOREIGN KEY (`p_id`) REFERENCES `m06dmainorder` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m06edetailorder_quotation` FOREIGN KEY (`f_idquotation`) REFERENCES `m06ddetailquotation` (`primary_main`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_m06edetailorder_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06edetailorder_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06edetailorder_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06edetailorder`
--

LOCK TABLES `m06edetailorder` WRITE;
/*!40000 ALTER TABLE `m06edetailorder` DISABLE KEYS */;
INSERT INTO `m06edetailorder` VALUES (1,1,1,1,3,1.0000,0.0000,2000.0000,0.0000,0.0000,2,1,10.0000,0.0000,NULL,NULL,'','2021-02-20 16:06:55','NuSoft - NuSoft Administrator','2021-02-20 16:06:55','NuSoft - NuSoft Administrator'),(2,1,2,264,3,1.0000,0.0000,3000.0000,0.0000,0.0000,2,1,10.0000,0.0000,NULL,NULL,'','2021-02-20 16:06:55','NuSoft - NuSoft Administrator','2021-02-20 16:06:55','NuSoft - NuSoft Administrator');
/*!40000 ALTER TABLE `m06edetailorder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06emaininvoice`
--

DROP TABLE IF EXISTS `m06emaininvoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06emaininvoice` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_jenis` tinyint(3) unsigned DEFAULT NULL,
  `f_jenis` tinyint(3) unsigned DEFAULT NULL,
  `f_customer` int(10) unsigned NOT NULL,
  `f_idorder` int(10) unsigned DEFAULT NULL,
  `d_contact` varchar(100) DEFAULT NULL,
  `f_address` int(10) unsigned DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_currency` smallint(5) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT '1.0000',
  `d_externalnumber` varchar(50) DEFAULT NULL,
  `d_taxtype` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `d_taxcaption` varchar(25) DEFAULT NULL,
  `d_taxsnppn` varchar(50) DEFAULT NULL,
  `d_taxsnpph` varchar(50) DEFAULT NULL,
  `f_employee` int(10) unsigned DEFAULT NULL,
  `f_termin` tinyint(3) unsigned DEFAULT NULL,
  `d_duedate` date DEFAULT NULL,
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_othercost` decimal(18,4) DEFAULT '0.0000',
  `d_note` varchar(255) DEFAULT NULL,
  `f_gl` bigint(20) unsigned NOT NULL,
  `f_dptax` tinyint(3) unsigned DEFAULT NULL,
  `d_dptaxp` decimal(18,4) DEFAULT NULL,
  `d_dppersen` decimal(18,4) DEFAULT NULL,
  `d_bbvalue` decimal(18,4) DEFAULT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `fk_m06emaininvoice_order_idx` (`f_idorder`),
  KEY `fk_m06emaininvoice_vendor_idx` (`f_customer`),
  KEY `fk_m06emaininvoice_employee_idx` (`f_employee`),
  KEY `fk_m06emaininvoice_currency_idx` (`f_currency`),
  KEY `fk_m06emaininvoice_type_idx` (`f_jenis`),
  KEY `fk_m06emaininvoice_idx` (`f_termin`),
  KEY `fk_m06emaininvoice_gl_idx` (`f_gl`),
  KEY `fk_m06emaininvoice_pajak_idx` (`f_dptax`),
  KEY `I_m06emaininvoice_address_idx` (`f_address`),
  CONSTRAINT `FK_m06emaininvoice_address` FOREIGN KEY (`f_address`) REFERENCES `m01ccontactaddress` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_currency` FOREIGN KEY (`f_currency`) REFERENCES `m01acurrency` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_employee` FOREIGN KEY (`f_employee`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_order` FOREIGN KEY (`f_idorder`) REFERENCES `m06dmainorder` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_pajak` FOREIGN KEY (`f_dptax`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_termin` FOREIGN KEY (`f_termin`) REFERENCES `m05atermin` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_type` FOREIGN KEY (`f_jenis`) REFERENCES `m04atype` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06emaininvoice_vendor` FOREIGN KEY (`f_customer`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06emaininvoice`
--

LOCK TABLES `m06emaininvoice` WRITE;
/*!40000 ALTER TABLE `m06emaininvoice` DISABLE KEYS */;
INSERT INTO `m06emaininvoice` VALUES (1,1,29,2021,2,1,'JKT-DP21020001','2021-02-20',1,NULL,4,887,1,NULL,NULL,'Uang Muka Penjualan',3,1.0000,NULL,0,'3','asd',NULL,NULL,NULL,NULL,0.0000,0.0000,NULL,12,1,0.0000,10.0000,NULL,NULL,NULL,NULL,NULL,NULL,'NuSoft - NuSoft Administrator','2021-02-20 16:07:27','NuSoft - NuSoft Administrator','2021-02-20 16:07:27');
/*!40000 ALTER TABLE `m06emaininvoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06fdetailinvoice`
--

DROP TABLE IF EXISTS `m06fdetailinvoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06fdetailinvoice` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `f_idsj` bigint(20) unsigned NOT NULL,
  `f_item` int(10) unsigned NOT NULL,
  `f_uom` tinyint(3) unsigned NOT NULL,
  `d_qty` decimal(18,4) DEFAULT '0.0000',
  `d_qty2` decimal(18,4) DEFAULT '0.0000',
  `d_price` decimal(18,4) DEFAULT '0.0000',
  `d_disc` decimal(18,4) DEFAULT '0.0000',
  `d_discp` decimal(18,4) DEFAULT '0.0000',
  `f_taxin` tinyint(3) unsigned NOT NULL,
  `f_taxout` tinyint(3) unsigned NOT NULL,
  `d_taxinp` decimal(18,4) DEFAULT '0.0000',
  `d_taxoutp` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_division` int(11) DEFAULT NULL,
  `f_project` int(11) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m06fdetailinvoice_main_idx` (`p_id`),
  KEY `fk_m06fdetailinvoice_item_idx` (`f_item`),
  KEY `fk_m06fdetailinvoice_uom_idx` (`f_uom`),
  KEY `fk_m06fdetailinvoice_taxin_idx` (`f_taxin`),
  KEY `fk_m06fdetailinvoice_taxout_idx` (`f_taxout`),
  KEY `fk_m06fdetailinvoice_sj_idx` (`f_idsj`),
  CONSTRAINT `fk_m06fdetailinvoice_item` FOREIGN KEY (`f_item`) REFERENCES `m04bitem` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fdetailinvoice_main` FOREIGN KEY (`p_id`) REFERENCES `m06emaininvoice` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fdetailinvoice_sj` FOREIGN KEY (`f_idsj`) REFERENCES `m04dstockdetail` (`primary_main`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fdetailinvoice_taxin` FOREIGN KEY (`f_taxin`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fdetailinvoice_taxout` FOREIGN KEY (`f_taxout`) REFERENCES `m04atax` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fdetailinvoice_uom` FOREIGN KEY (`f_uom`) REFERENCES `m04auom` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06fdetailinvoice`
--

LOCK TABLES `m06fdetailinvoice` WRITE;
/*!40000 ALTER TABLE `m06fdetailinvoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06fdetailinvoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06fdetailinvoicedp`
--

DROP TABLE IF EXISTS `m06fdetailinvoicedp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06fdetailinvoicedp` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `p_iddp` int(10) unsigned NOT NULL,
  `d_value` decimal(18,4) DEFAULT '0.0000',
  `d_valuetax` decimal(18,4) DEFAULT '0.0000',
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m06fdetailinvoicedp_main_idx` (`p_id`),
  KEY `fk_m06fdetailinvoicedp_dp_idx` (`p_iddp`),
  CONSTRAINT `fk_m06fdetailinvoicedp_dp` FOREIGN KEY (`p_iddp`) REFERENCES `m06emaininvoice` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fdetailinvoicedp_main` FOREIGN KEY (`p_id`) REFERENCES `m06emaininvoice` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06fdetailinvoicedp`
--

LOCK TABLES `m06fdetailinvoicedp` WRITE;
/*!40000 ALTER TABLE `m06fdetailinvoicedp` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06fdetailinvoicedp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06fmainpayment`
--

DROP TABLE IF EXISTS `m06fmainpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06fmainpayment` (
  `p_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `u_regional` smallint(5) unsigned NOT NULL,
  `u_source` smallint(5) unsigned NOT NULL,
  `u_year` smallint(5) unsigned NOT NULL,
  `u_month` smallint(5) unsigned NOT NULL,
  `u_sequence` smallint(5) unsigned NOT NULL,
  `u_code` varchar(30) NOT NULL,
  `d_date` date DEFAULT NULL,
  `d_status` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `f_customer` int(10) unsigned NOT NULL,
  `d_taxpayment` tinyint(1) DEFAULT NULL,
  `d_remarks` varchar(255) DEFAULT NULL,
  `f_coa` int(10) unsigned NOT NULL,
  `d_kurs` decimal(18,4) DEFAULT NULL,
  `d_value` decimal(18,4) DEFAULT NULL,
  `d_valuevalas` decimal(18,4) DEFAULT NULL,
  `d_bankadmin` decimal(18,4) DEFAULT NULL,
  `d_discount` decimal(18,4) DEFAULT NULL,
  `d_rounding` decimal(18,4) DEFAULT NULL,
  `d_pphvalue` decimal(18,4) DEFAULT NULL,
  `d_pphnumber` varchar(50) DEFAULT NULL,
  `d_typepayment` tinyint(4) DEFAULT NULL,
  `d_numberpayment` varchar(50) DEFAULT NULL,
  `d_bankaccountnumber` varchar(50) DEFAULT NULL,
  `d_tempo` date DEFAULT NULL,
  `f_gl` bigint(20) unsigned NOT NULL,
  `d_custom1` varchar(255) DEFAULT NULL,
  `d_custom2` varchar(255) DEFAULT NULL,
  `d_custom3` varchar(255) DEFAULT NULL,
  `d_custom4` varchar(255) DEFAULT NULL,
  `d_custom5` varchar(255) DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `u_code_UNIQUE` (`u_code`),
  KEY `m06fmainpayment_vendor_idx` (`f_customer`),
  KEY `m06fmainpayment_coa_idx` (`f_coa`),
  KEY `m06fmainpayment_gl_idx` (`f_gl`),
  CONSTRAINT `fk_m06fmainpayment_coa` FOREIGN KEY (`f_coa`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fmainpayment_gl` FOREIGN KEY (`f_gl`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06fmainpayment_vendor` FOREIGN KEY (`f_customer`) REFERENCES `m01bcontactview` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06fmainpayment`
--

LOCK TABLES `m06fmainpayment` WRITE;
/*!40000 ALTER TABLE `m06fmainpayment` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06fmainpayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `m06gdetailpayment`
--

DROP TABLE IF EXISTS `m06gdetailpayment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `m06gdetailpayment` (
  `primary_main` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `p_id` int(10) unsigned NOT NULL,
  `p_idinvoice` int(10) unsigned DEFAULT NULL,
  `p_iddp` int(10) unsigned DEFAULT NULL,
  `d_urutan` tinyint(4) DEFAULT NULL,
  `d_amount` decimal(18,4) DEFAULT '0.0000',
  `d_kurspayment` decimal(18,4) DEFAULT '1.0000',
  `d_amountcash` decimal(18,4) DEFAULT '0.0000',
  `d_amountreturn` decimal(18,4) DEFAULT '0.0000',
  `d_remarks` varchar(255) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `created_user` varchar(100) DEFAULT NULL,
  `last_date` datetime DEFAULT NULL,
  `last_modified` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`primary_main`),
  KEY `fk_m06gdetailpayment_main_idx` (`p_id`),
  KEY `fk_m06gdetailpayment_invoice_idx` (`p_idinvoice`),
  CONSTRAINT `fk_m06gdetailpayment_invoice` FOREIGN KEY (`p_idinvoice`) REFERENCES `m06emaininvoice` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_m06gdetailpaymentt_main` FOREIGN KEY (`p_id`) REFERENCES `m06fmainpayment` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `m06gdetailpayment`
--

LOCK TABLES `m06gdetailpayment` WRITE;
/*!40000 ALTER TABLE `m06gdetailpayment` DISABLE KEYS */;
/*!40000 ALTER TABLE `m06gdetailpayment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `m06vwaginginvoice`
--

DROP TABLE IF EXISTS `m06vwaginginvoice`;
/*!50001 DROP VIEW IF EXISTS `m06vwaginginvoice`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m06vwaginginvoice` AS SELECT 
 1 AS `p_id`,
 1 AS `NoInvoice`,
 1 AS `d_payment`,
 1 AS `d_different`,
 1 AS `d_differentdays`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `m06vwinvoice`
--

DROP TABLE IF EXISTS `m06vwinvoice`;
/*!50001 DROP VIEW IF EXISTS `m06vwinvoice`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `m06vwinvoice` AS SELECT 
 1 AS `Urutan`,
 1 AS `NoInvoice`,
 1 AS `Terbayar`,
 1 AS `NilaiBayarCash`,
 1 AS `OK`,
 1 AS `Kurs`,
 1 AS `Catatan`,
 1 AS `Pembayaran`*/;
SET character_set_client = @saved_cs_client;

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
  `Action` tinyint(2) NOT NULL,
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
INSERT INTO `npolog` VALUES (24235533345488898,'2015-10-11 15:26:49','m05cmainorder',9,'','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24235533345488899,'2015-10-11 15:26:49','m05ddetailorder',18,'','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24235533345488900,'2015-10-11 15:26:49','m05ddetailorder',18,'Main : Nusoft.Persistent.Modules.m05.OrderPembelian(9) ==> <NULL>\r\n','nusoft - Nusoft Administrator',1,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24235533345488901,'2015-10-11 15:26:56','m05cmainorder',10,'','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24235533345488902,'2015-10-11 15:26:56','m05ddetailorder',19,'','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24235533345488903,'2015-10-11 15:26:56','m05ddetailorder',19,'Main : Nusoft.Persistent.Modules.m05.OrderPembelian(10) ==> <NULL>\r\n','nusoft - Nusoft Administrator',1,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802919,'2015-10-12 18:39:35','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 18:39:35\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802920,'2015-10-12 18:39:46','m05ddetailorder',635802719808860799,'Id : 0 ==> 635802719808860799\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 1\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nCatatan : <NULL> ==> \r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802921,'2015-10-12 18:39:46','m05ddetailorder',635802719808890802,'Id : 0 ==> 635802719808890802\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(268)\r\nQty : 0 ==> 2\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nCatatan : <NULL> ==> \r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802922,'2015-10-12 18:39:46','m05cmainorder',0,'Kode : <NULL> ==> JKT-PO15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 18:39:35\r\nVendor : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(787)\r\nKontakPerson : <NULL> ==> \r\nTermin : <NULL> ==> Nusoft.Persistent.Modules.m00.Termin(1)\r\nUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nPajak : TanpaPajak ==> HargaBelumTermasuk\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nUraian : <NULL> ==> asdas\r\nReffNo : <NULL> ==> \r\nLeadTime : <NULL> ==> \r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802944,'2015-10-12 18:58:40','m04cmainrequest',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 18:58:40\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802945,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327887,'Id : 0 ==> 635802731203327887\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802946,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327886,'Id : 0 ==> 635802731203327886\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802947,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327885,'Id : 0 ==> 635802731203327885\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802948,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327884,'Id : 0 ==> 635802731203327884\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802949,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327883,'Id : 0 ==> 635802731203327883\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802950,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327882,'Id : 0 ==> 635802731203327882\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802951,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327881,'Id : 0 ==> 635802731203327881\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802952,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327880,'Id : 0 ==> 635802731203327880\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802953,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327879,'Id : 0 ==> 635802731203327879\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802954,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327877,'Id : 0 ==> 635802731203327877\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(1)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 2\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802955,'2015-10-12 18:58:57','m04ddetailrequest',635802731203327878,'Id : 0 ==> 635802731203327878\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(2)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 3\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802956,'2015-10-12 18:58:57','m04cmainrequest',0,'Kode : <NULL> ==> JKT-PB15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 18:58:40\r\nJenis : PermintaanMutasi ==> PermintaanPembelian\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nDivisi : <NULL> ==> Nusoft.Persistent.Modules.m00.Divisi(1)\r\nCatatan : <NULL> ==> asdasdasd\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802957,'2015-10-12 19:00:55','m04cmainrequest',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:00:55\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802958,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074974,'Id : 0 ==> 635802732551074974\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802959,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074973,'Id : 0 ==> 635802732551074973\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802960,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074972,'Id : 0 ==> 635802732551074972\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802961,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074971,'Id : 0 ==> 635802732551074971\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802962,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074970,'Id : 0 ==> 635802732551074970\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802963,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074969,'Id : 0 ==> 635802732551074969\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802964,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074968,'Id : 0 ==> 635802732551074968\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802965,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074967,'Id : 0 ==> 635802732551074967\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802966,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074966,'Id : 0 ==> 635802732551074966\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802967,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074965,'Id : 0 ==> 635802732551074965\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802968,'2015-10-12 19:01:03','m04ddetailrequest',635802732551074964,'Id : 0 ==> 635802732551074964\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(1)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 2\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802969,'2015-10-12 19:01:03','m04cmainrequest',0,'Kode : <NULL> ==> JKT-PB15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:00:55\r\nJenis : PermintaanMutasi ==> PermintaanPembelian\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nDivisi : <NULL> ==> Nusoft.Persistent.Modules.m00.Divisi(2)\r\nCatatan : <NULL> ==> sadasd\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802970,'2015-10-12 19:01:35','m04cmainrequest',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:01:35\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802971,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588340,'Id : 0 ==> 635802732959588340\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802972,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588339,'Id : 0 ==> 635802732959588339\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802973,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588338,'Id : 0 ==> 635802732959588338\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802974,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588337,'Id : 0 ==> 635802732959588337\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802975,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588336,'Id : 0 ==> 635802732959588336\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802976,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588335,'Id : 0 ==> 635802732959588335\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802977,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588334,'Id : 0 ==> 635802732959588334\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802978,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588333,'Id : 0 ==> 635802732959588333\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802979,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588332,'Id : 0 ==> 635802732959588332\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802980,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588331,'Id : 0 ==> 635802732959588331\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802981,'2015-10-12 19:01:50','m04ddetailrequest',635802732959588330,'Id : 0 ==> 635802732959588330\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(1)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 1\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802982,'2015-10-12 19:01:50','m04cmainrequest',0,'Kode : <NULL> ==> JKT-PB15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:01:35\r\nJenis : PermintaanMutasi ==> PermintaanPembelian\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nDivisi : <NULL> ==> Nusoft.Persistent.Modules.m00.Divisi(2)\r\nCatatan : <NULL> ==> asdasd\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802983,'2015-10-12 19:06:50','m04cmainrequest',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:06:50\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802984,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077965,'Id : 0 ==> 635802736100077965\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802985,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077964,'Id : 0 ==> 635802736100077964\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802986,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077963,'Id : 0 ==> 635802736100077963\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802987,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077962,'Id : 0 ==> 635802736100077962\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802988,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077961,'Id : 0 ==> 635802736100077961\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802989,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077960,'Id : 0 ==> 635802736100077960\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802990,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077959,'Id : 0 ==> 635802736100077959\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802991,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077958,'Id : 0 ==> 635802736100077958\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802992,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077957,'Id : 0 ==> 635802736100077957\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802993,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077956,'Id : 0 ==> 635802736100077956\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802994,'2015-10-12 19:06:58','m04ddetailrequest',635802736100077955,'Id : 0 ==> 635802736100077955\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(1)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 2\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802995,'2015-10-12 19:06:58','m04cmainrequest',0,'Kode : <NULL> ==> JKT-PB15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:06:50\r\nJenis : PermintaanMutasi ==> PermintaanPembelian\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nDivisi : <NULL> ==> Nusoft.Persistent.Modules.m00.Divisi(2)\r\nCatatan : <NULL> ==> asdasds\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802996,'2015-10-12 19:08:51','m01cmaingl',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:08:51\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(2)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802997,'2015-10-12 19:08:51','m01cmaingl',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:08:51\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(2)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802998,'2015-10-12 19:09:01','m01dmaindetail',635802737311357246,'Id : 0 ==> 635802737311357246\r\nUrutan : 0 ==> 10\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735802999,'2015-10-12 19:09:01','m01dmaindetail',635802737311357245,'Id : 0 ==> 635802737311357245\r\nUrutan : 0 ==> 9\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803000,'2015-10-12 19:09:01','m01dmaindetail',635802737311357244,'Id : 0 ==> 635802737311357244\r\nUrutan : 0 ==> 8\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803001,'2015-10-12 19:09:01','m01dmaindetail',635802737311357243,'Id : 0 ==> 635802737311357243\r\nUrutan : 0 ==> 7\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803002,'2015-10-12 19:09:01','m01dmaindetail',635802737311357242,'Id : 0 ==> 635802737311357242\r\nUrutan : 0 ==> 6\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803003,'2015-10-12 19:09:01','m01dmaindetail',635802737311357241,'Id : 0 ==> 635802737311357241\r\nUrutan : 0 ==> 5\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803004,'2015-10-12 19:09:01','m01dmaindetail',635802737311357240,'Id : 0 ==> 635802737311357240\r\nUrutan : 0 ==> 4\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803005,'2015-10-12 19:09:01','m01dmaindetail',635802737311357239,'Id : 0 ==> 635802737311357239\r\nUrutan : 0 ==> 3\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803006,'2015-10-12 19:09:01','m01dmaindetail',635802737311357238,'Id : 0 ==> 635802737311357238\r\nUrutan : 0 ==> 2\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803007,'2015-10-12 19:09:01','m01dmaindetail',635802737311347236,'Id : 0 ==> 635802737311347236\r\nUrutan : 0 ==> 1\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nMataUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKurs : 0 ==> 1\r\nDebit : 0 ==> 22222\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m01.GlMain(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803008,'2015-10-12 19:09:01','m01cmaingl',0,'ModuleId : 0 ==> Fina\r\nKode : <NULL> ==> JKT-KK15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:08:51\r\nKontak : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nKontakNama : <NULL> ==> PT. Intra Teknika Utama\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nMataUang : <NULL> ==> Rp\r\nKurs : 0 ==> 1\r\nUraian : <NULL> ==> sadasdasd\r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(2)\r\nUrutan : 0 ==> 1\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803009,'2015-10-12 19:09:01','m01dmaindetail',0,'Main : <NULL> ==> Nusoft.Persistent.Modules.m01.GlMain(0)\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nMataUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKredit : 0 ==> 22222\r\nKurs : 0 ==> 1\r\nKreditValas : 0 ==> 22222\r\nKeterangan : <NULL> ==> sadasdasd\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803010,'2015-10-12 19:10:33','m01cmaingl',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:10:33\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(2)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803011,'2015-10-12 19:10:33','m01cmaingl',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:10:33\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(2)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803012,'2015-10-12 19:10:46','m01dmaindetail',635802738337415933,'Id : 0 ==> 635802738337415933\r\nUrutan : 0 ==> 10\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803013,'2015-10-12 19:10:46','m01dmaindetail',635802738337415932,'Id : 0 ==> 635802738337415932\r\nUrutan : 0 ==> 9\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803014,'2015-10-12 19:10:46','m01dmaindetail',635802738337415931,'Id : 0 ==> 635802738337415931\r\nUrutan : 0 ==> 8\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803015,'2015-10-12 19:10:46','m01dmaindetail',635802738337415930,'Id : 0 ==> 635802738337415930\r\nUrutan : 0 ==> 7\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803016,'2015-10-12 19:10:46','m01dmaindetail',635802738337415929,'Id : 0 ==> 635802738337415929\r\nUrutan : 0 ==> 6\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803017,'2015-10-12 19:10:46','m01dmaindetail',635802738337415928,'Id : 0 ==> 635802738337415928\r\nUrutan : 0 ==> 5\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803018,'2015-10-12 19:10:46','m01dmaindetail',635802738337415927,'Id : 0 ==> 635802738337415927\r\nUrutan : 0 ==> 4\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803019,'2015-10-12 19:10:46','m01dmaindetail',635802738337415926,'Id : 0 ==> 635802738337415926\r\nUrutan : 0 ==> 3\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803020,'2015-10-12 19:10:46','m01dmaindetail',635802738337415925,'Id : 0 ==> 635802738337415925\r\nUrutan : 0 ==> 2\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803021,'2015-10-12 19:10:46','m01dmaindetail',635802738337415924,'Id : 0 ==> 635802738337415924\r\nUrutan : 0 ==> 1\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(4)\r\nMataUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKurs : 0 ==> 1\r\nDebit : 0 ==> 33333\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m01.GlMain(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803022,'2015-10-12 19:10:46','m01cmaingl',0,'ModuleId : 0 ==> Fina\r\nKode : <NULL> ==> JKT-KK15100002\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 01/10/2015 19:10:33\r\nKontak : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nKontakNama : <NULL> ==> PT. Intra Teknika Utama\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nMataUang : <NULL> ==> Rp\r\nKurs : 0 ==> 1\r\nUraian : <NULL> ==> sadasd\r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(2)\r\nUrutan : 0 ==> 2\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803023,'2015-10-12 19:10:46','m01dmaindetail',0,'Main : <NULL> ==> Nusoft.Persistent.Modules.m01.GlMain(0)\r\nAkun : <NULL> ==> Nusoft.Persistent.Modules.m00.Coa(3)\r\nMataUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKredit : 0 ==> 33333\r\nKurs : 0 ==> 1\r\nKreditValas : 0 ==> 33333\r\nKeterangan : <NULL> ==> sadasd\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803024,'2015-10-12 19:17:48','m04cmainrequest',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:17:48\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803025,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444798,'Id : 0 ==> 635802742688444798\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803026,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444797,'Id : 0 ==> 635802742688444797\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803027,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444796,'Id : 0 ==> 635802742688444796\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803028,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444795,'Id : 0 ==> 635802742688444795\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803029,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444794,'Id : 0 ==> 635802742688444794\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803030,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444793,'Id : 0 ==> 635802742688444793\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803031,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444792,'Id : 0 ==> 635802742688444792\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803032,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444791,'Id : 0 ==> 635802742688444791\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803033,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444790,'Id : 0 ==> 635802742688444790\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803034,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444789,'Id : 0 ==> 635802742688444789\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803035,'2015-10-12 19:17:57','m04ddetailrequest',635802742688444788,'Id : 0 ==> 635802742688444788\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(1)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 1\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803036,'2015-10-12 19:17:57','m04cmainrequest',0,'Kode : <NULL> ==> JKT-PB15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:17:48\r\nJenis : PermintaanMutasi ==> PermintaanPembelian\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nDivisi : <NULL> ==> Nusoft.Persistent.Modules.m00.Divisi(2)\r\nCatatan : <NULL> ==> asdsd\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\nUrutan : 0 ==> 1\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803037,'2015-10-12 19:18:07','m04cmainrequest',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:18:07\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803038,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605332,'Id : 0 ==> 635802742872605332\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803039,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605331,'Id : 0 ==> 635802742872605331\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803040,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605330,'Id : 0 ==> 635802742872605330\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803041,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605329,'Id : 0 ==> 635802742872605329\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803042,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605328,'Id : 0 ==> 635802742872605328\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803043,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605327,'Id : 0 ==> 635802742872605327\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803044,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605326,'Id : 0 ==> 635802742872605326\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803045,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605325,'Id : 0 ==> 635802742872605325\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803046,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605324,'Id : 0 ==> 635802742872605324\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803047,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605322,'Id : 0 ==> 635802742872605322\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 1\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803048,'2015-10-12 19:18:18','m04ddetailrequest',635802742872605323,'Id : 0 ==> 635802742872605323\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nQty : 0 ==> 2\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803049,'2015-10-12 19:18:18','m04cmainrequest',0,'Kode : <NULL> ==> JKT-PB15100002\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:18:07\r\nJenis : PermintaanMutasi ==> PermintaanPembelian\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nDivisi : <NULL> ==> Nusoft.Persistent.Modules.m00.Divisi(2)\r\nCatatan : <NULL> ==> asdasd\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(43)\r\nUrutan : 0 ==> 2\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803063,'2015-10-12 19:22:48','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:22:48\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803064,'2015-10-12 19:23:01','m05ddetailorder',635802745746679709,'Id : 0 ==> 635802745746679709\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(1)\r\nQty : 0 ==> 1\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803065,'2015-10-12 19:23:01','m05cmainorder',0,'Kode : <NULL> ==> JKT-PO15100001\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:22:48\r\nVendor : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(787)\r\nKontakPerson : <NULL> ==> \r\nTermin : <NULL> ==> Nusoft.Persistent.Modules.m00.Termin(1)\r\nUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nPajak : TanpaPajak ==> HargaBelumTermasuk\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nNoPermintaan : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(6)\r\nUraian : <NULL> ==> adsad\r\nReffNo : <NULL> ==> \r\nLeadTime : <NULL> ==> \r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\nUrutan : 0 ==> 1\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803066,'2015-10-12 19:23:08','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:23:08\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803067,'2015-10-12 19:23:14','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:23:14\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803068,'2015-10-12 19:23:27','m05ddetailorder',635802745996123976,'Id : 0 ==> 635802745996123976\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 1\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803069,'2015-10-12 19:23:27','m05ddetailorder',635802745996123977,'Id : 0 ==> 635802745996123977\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 2\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24236897735803070,'2015-10-12 19:23:27','m05cmainorder',0,'Kode : <NULL> ==> JKT-PO15100002\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 12/10/2015 19:23:14\r\nVendor : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nKontakPerson : <NULL> ==> \r\nTermin : <NULL> ==> Nusoft.Persistent.Modules.m00.Termin(1)\r\nUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nPajak : TanpaPajak ==> HargaBelumTermasuk\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nNoPermintaan : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(7)\r\nUraian : <NULL> ==> asdasd\r\nReffNo : <NULL> ==> \r\nLeadTime : <NULL> ==> \r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\nUrutan : 0 ==> 2\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237839994585089,'2015-10-13 05:14:13','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 13/10/2015 5:14:12\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237839994585090,'2015-10-13 05:14:25','m05ddetailorder',635803100586794744,'Id : 0 ==> 635803100586794744\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 1\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237839994585091,'2015-10-13 05:14:25','m05ddetailorder',635803100586824747,'Id : 0 ==> 635803100586824747\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 2\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\nMain : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237839994585092,'2015-10-13 05:14:25','m05cmainorder',0,'Kode : <NULL> ==> JKT-PO15100003\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 13/10/2015 5:14:12\r\nVendor : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(787)\r\nKontakPerson : <NULL> ==> \r\nTermin : <NULL> ==> Nusoft.Persistent.Modules.m00.Termin(1)\r\nUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nPajak : TanpaPajak ==> HargaBelumTermasuk\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nNoPermintaan : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(7)\r\nUraian : <NULL> ==> asdasd\r\nReffNo : <NULL> ==> \r\nLeadTime : <NULL> ==> \r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\nUrutan : 0 ==> 3\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902595,'2015-10-13 08:36:29','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 13/10/2015 8:36:29\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902596,'2015-10-13 08:36:40','m05cmainorder',0,'Pajak : TanpaPajak ==> HargaBelumTermasuk\r\nKode : <NULL> ==> JKT-PO15100004\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 13/10/2015 8:36:29\r\nVendor : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(787)\r\nKontakPerson : <NULL> ==> \r\nTermin : <NULL> ==> Nusoft.Persistent.Modules.m00.Termin(1)\r\nUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nPajak : HargaBelumTermasuk ==> TanpaPajak\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nNoPermintaan : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(7)\r\nUraian : <NULL> ==> asdasd\r\nReffNo : <NULL> ==> \r\nLeadTime : <NULL> ==> \r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\nUrutan : 0 ==> 4\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902597,'2015-10-13 08:36:40','m05ddetailorder',635803221921477828,'Main : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\nId : 0 ==> 635803221921477828\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 1\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902598,'2015-10-13 08:36:40','m05ddetailorder',635803221921507831,'Main : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\nId : 0 ==> 635803221921507831\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 2\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902599,'2015-10-13 08:37:04','m05cmainorder',0,'Regional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 13/10/2015 8:37:04\r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\n','nusoft - Nusoft Administrator',2,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902600,'2015-10-13 08:37:17','m05cmainorder',0,'Pajak : TanpaPajak ==> HargaBelumTermasuk\r\nKode : <NULL> ==> JKT-PO15100005\r\nRegional : <NULL> ==> Nusoft.Persistent.Modules.m00.Regional(1)\r\nTanggal : 01/01/0001 0:00:00 ==> 13/10/2015 8:37:04\r\nVendor : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nKontakPerson : <NULL> ==> \r\nTermin : <NULL> ==> Nusoft.Persistent.Modules.m00.Termin(1)\r\nUang : <NULL> ==> Nusoft.Persistent.Modules.m00.MataUang(3)\r\nKaryawan : <NULL> ==> Nusoft.Persistent.Modules.m00.Kontak(786)\r\nGudang : <NULL> ==> Nusoft.Persistent.Modules.m00.Gudang(1)\r\nNoPermintaan : <NULL> ==> Nusoft.Persistent.Modules.m05.PermintaanStock(7)\r\nUraian : <NULL> ==> asdasdasd\r\nReffNo : <NULL> ==> \r\nLeadTime : <NULL> ==> \r\nCatatan : <NULL> ==> \r\nSumber : <NULL> ==> Nusoft.Persistent.Modules.m00.SumberData(20)\r\nUrutan : 0 ==> 5\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902601,'2015-10-13 08:37:17','m05ddetailorder',635803222286610657,'Main : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\nId : 0 ==> 635803222286610657\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 1\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1'),(24237966561902602,'2015-10-13 08:37:17','m05ddetailorder',635803222286610658,'Main : <NULL> ==> Nusoft.Persistent.Modules.m05.OrderPembelian(0)\r\nId : 0 ==> 635803222286610658\r\nBarang : <NULL> ==> Nusoft.Persistent.Modules.m00.Barang(265)\r\nQty : 0 ==> 2\r\nSatuan : <NULL> ==> Nusoft.Persistent.Modules.m00.Satuan(3)\r\nHarga : 0 ==> 100000\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(2)\r\nPPN : <NULL> ==> Nusoft.Persistent.Modules.m00.Pajak(1)\r\nPPNp : 0 ==> 10\r\n','nusoft - Nusoft Administrator',0,'Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36','::1','::1');
/*!40000 ALTER TABLE `npolog` ENABLE KEYS */;
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
-- Dumping routines for database 'nusoft_x01'
--
/*!50003 DROP FUNCTION IF EXISTS `f01_getsaldostatistik` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f01_getsaldostatistik`(Tipe TinyInt(4), DT_DATE Date) RETURNS decimal(10,0)
    NO SQL
begin
DECLARE SALDO      DOUBLE DEFAULT 0;
    CASE TIPE
      WHEN 0 THEN   
         SELECT COALESCE(SUM(d_debit-d_credit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level2=0;
      WHEN 1 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level2=1;   
      WHEN 2 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level2=2;  
      WHEN 3 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level1=1;
         
       WHEN 7 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where month(tr1.d_date) <= month(DT_DATE) and d_level2=3;        
       WHEN 8 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where month(tr1.d_date) <= month(DT_DATE) and d_level2=4;   
       WHEN 9 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where month(tr1.d_date) <= month(DT_DATE) and d_level1=1;                       
      ELSE
         set saldo=0;     
    END CASE;



  RETURN SALDO;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f02_getbeginningbalance` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f02_getbeginningbalance`(CoaID Integer(11), DT_DATE Date) RETURNS double
    NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f02_getbeginningbalanceproject` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f02_getbeginningbalanceproject`(CoaID Integer(11), DT_DATE Date, Project Integer(11)) RETURNS double
    NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit*tr2.d_rate),0),COALESCE(SUM(d_credit*tr2.d_rate),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE and tr2.f_proyek=Project;
       ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f02_getbeginningbalancevalas` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f02_getbeginningbalancevalas`(CoaID Integer(11), DT_DATE Date) RETURNS double
    NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debitvalas),0),COALESCE(SUM(d_creditvalas),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debitvalas),0),COALESCE(SUM(d_creditvalas),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debitvalas),0),COALESCE(SUM(d_creditvalas),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;

         SELECT COALESCE(SUM(d_creditvalas),0)-COALESCE(SUM(d_debitvalas),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_creditvalas),0)-COALESCE(SUM(d_debitvalas),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f02_getbookvalueasset` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f02_getbookvalueasset`(p_id Integer(11)) RETURNS decimal(18,4)
    NO SQL
begin
DECLARE SALDO      DOUBLE DEFAULT 0;

  SELECT coalesce(sum((d_qty*d_valuein)-(d_qty*d_valueout)),0)  
  INTO SALDO
  FROM m02dtransactiondetail 
  WHERE f_asset=p_id;  
  RETURN SALDO;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f02_getmutation` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f02_getmutation`(CoaID Integer(11), DT_DATE Date, TipeSaldo Integer(1)) RETURNS double
    NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_SALDO       DOUBLE DEFAULT 0;
DECLARE DBL_LABA      DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;


  SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
  INTO DBL_DEBIT,DBL_CREDIT
  FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
  where tr2.f_coa=CoaID AND tr1.u_month=month(DT_DATE) and tr1.u_year=year(DT_DATE);
 
   CASE     
      WHEN TipeSaldo = 0 THEN               
         SET DBL_SALDO = DBL_DEBIT;
      WHEN TipeSaldo = 1 THEN               
         SET DBL_SALDO = DBL_CREDIT; 
      WHEN TipeSaldo = 2 THEN               
         IF DC = 0 THEN
            SET DBL_SALDO=(DBL_DEBIT - DBL_CREDIT);
         ELSE
            SET DBL_SALDO= (DBL_CREDIT - DBL_DEBIT);
         END IF;    
      ELSE
         SET DBL_SALDO  = 0;
   END CASE;

  return DBL_SALDO;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f02_getsaldo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f02_getsaldo`(CoaID Integer(11), DT_DATE Date) RETURNS double
    NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE;       

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)   
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f04_getbeginningbalance` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f04_getbeginningbalance`(Tipe TinyInt(4), ItemID Integer(11), DT_DATE Date, Gudang Integer) RETURNS decimal(10,0)
    NO SQL
BEGIN
DECLARE SALDOQTY      DECIMAL DEFAULT 0;
DECLARE SALDONILAI    DECIMAL DEFAULT 0;

SELECT
  sum(tr1.d_qtyin-tr1.d_qtyout),
  sum((tr1.d_qtyin * tr1.d_price) - f04_hppvalue(tr1.primary_main))
INTO
  SALDOQTY,SALDONILAI  
FROM
  m04dstockdetail tr1
  LEFT JOIN m04cstockmain tr2 ON tr1.p_id = tr2.p_id 

WHERE
  tr1.f_item = ItemId AND
  tr2.d_date <  DT_DATE and
  tr1.f_warehouse=Gudang ;
  
  IF Tipe = 0 THEN
     RETURN SALDOQTY;
  ELSE
     RETURN SALDONILAI;
  END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f04_hppgetavailable` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f04_hppgetavailable`(StockDetailId BigInt(20)) RETURNS decimal(18,4)
    NO SQL
BEGIN
  DECLARE result DECIMAL(18,4);
  DECLARE used   DECIMAL(18,4);
  
  set used := f04_hppgetused(StockDetailId);
  SELECT d_qtyin-used INTO result FROM m04dstockdetail where primary_main=StockDetailId;
  Return result;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f04_hppgetused` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f04_hppgetused`(StockDetailId BigInt(20)) RETURNS decimal(18,4)
    NO SQL
BEGIN
  DECLARE result DECIMAL(18,4);
 
  SELECT coalesce(sum(d_qty),0) INTO result FROM m04estockhpp where f_idin=StockDetailId;
  Return result;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `f04_hppvalue` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f04_hppvalue`(ID Integer(11)) RETURNS double
    NO SQL
begin
DECLARE SALDO      DOUBLE DEFAULT 0.0;
  SELECT coalesce(Sum(m04estockhpp.d_qty * m04dstockdetail.d_price),0)
  INTO SALDO
  FROM m04estockhpp LEFT JOIN m04dstockdetail ON m04estockhpp.f_idin = m04dstockdetail.primary_main 
  WHERE m04estockhpp.f_idout = ID;

  RETURN SALDO;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `m05prinvoice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `m05prinvoice`(Tanggal Date)
    NO SQL
begin
  select 
    `tr1`.`p_id` AS `NoInvoice`,
     coalesce((select sum(`tr2`.`d_amount`) from (`nusoft_x01`.`m05ddetailpayment` `tr2` left join `nusoft_x01`.`m05cmainpayment` `tr3` on `tr2`.`p_id`=`tr3`.`p_id`) where (`tr2`.`p_idinvoice` = `tr1`.`p_id`) and `tr3`.`d_date`<=Tanggal),0) AS `Terbayar` 
  from 
    `nusoft_x01`.`m05cmaininvoicereceipt` `tr1`
  Where    
    `tr1`.`d_date`<=Tanggal;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `p04_hppavailable` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `p04_hppavailable`(f_itemx Integer(11), f_warehousex Integer(11))
    NO SQL
begin
  SELECT
  m04dstockdetail.primary_main AS id,
  m04dstockdetail.d_qtyin AS d_qtyin,
  m04dstockdetail.d_qtyout AS d_qtyout,
  GetUsedHPP(m04dstockdetail.primary_main) AS d_used,
  GetAvailableHPP(m04dstockdetail.primary_main) AS d_available
FROM
  m04dstockdetail
          WHERE
  m04dstockdetail.d_qtyin > 0 and f_item=f_itemx and f_warehouse=f_warehousex 
          ;  
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `m01varap`
--

/*!50001 DROP VIEW IF EXISTS `m01varap`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m01varap` AS select max(`m01dmaindetail`.`primary_main`) AS `id`,`m01dmaindetail`.`f_coa` AS `f_coa`,`m01dmaindetail`.`f_currency` AS `f_currency`,`m01cmaingl`.`f_contact` AS `f_contact`,sum(if((`m01acoalevel`.`d_dc` = 0),`m01dmaindetail`.`d_debit`,`m01dmaindetail`.`d_credit`)) AS `jumlah`,sum(if((`m01acoalevel`.`d_dc` = 0),`m01dmaindetail`.`d_credit`,`m01dmaindetail`.`d_debit`)) AS `bayar`,sum(if((`m01acoalevel`.`d_dc` = 0),`m01dmaindetail`.`d_debitvalas`,`m01dmaindetail`.`d_creditvalas`)) AS `jumlahvalas`,sum(if((`m01acoalevel`.`d_dc` = 0),`m01dmaindetail`.`d_creditvalas`,`m01dmaindetail`.`d_debitvalas`)) AS `bayarvalas`,sum(if((`m01acoalevel`.`d_dc` = 0),(`m01dmaindetail`.`d_debit` - `m01dmaindetail`.`d_credit`),(`m01dmaindetail`.`d_credit` - `m01dmaindetail`.`d_debit`))) AS `saldo`,sum(if((`m01acoalevel`.`d_dc` = 0),(`m01dmaindetail`.`d_debitvalas` - `m01dmaindetail`.`d_creditvalas`),(`m01dmaindetail`.`d_creditvalas` - `m01dmaindetail`.`d_debitvalas`))) AS `saldovalas` from (((`m01dmaindetail` left join `m01cmaingl` on((`m01dmaindetail`.`p_id` = `m01cmaingl`.`p_id`))) left join `m01bcoa` on((`m01dmaindetail`.`f_coa` = `m01bcoa`.`p_id`))) left join `m01acoalevel` on((`m01bcoa`.`f_type` = `m01acoalevel`.`p_id`))) where (`m01acoalevel`.`p_id` in (3,8,9,10)) group by `m01dmaindetail`.`f_coa`,`m01cmaingl`.`f_contact` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m01vwcashadvanceremain`
--

/*!50001 DROP VIEW IF EXISTS `m01vwcashadvanceremain`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m01vwcashadvanceremain` AS select `m01cmaingl`.`p_id` AS `p_id`,`m01cmaingl`.`u_code` AS `u_code`,`m01cmaingl`.`d_date` AS `d_date`,`m01cmaingl`.`d_contact` AS `d_contact` from `m01cmaingl` where ((`m01cmaingl`.`f_source` in (2,4)) and (`m01cmaingl`.`d_type` = 1) and (not(`m01cmaingl`.`p_id` in (select `m01cmaingl`.`fk_cashadvance` from `m01cmaingl` where (`m01cmaingl`.`fk_cashadvance` is not null))))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m01vwcustomreport`
--

/*!50001 DROP VIEW IF EXISTS `m01vwcustomreport`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m01vwcustomreport` AS select cast(concat(`m`.`p_id`,coalesce(`d`.`f_coa`,0)) as unsigned) AS `Id`,`m`.`p_id` AS `MainId`,`m`.`u_kind` AS `Tipe`,`m`.`d_order` AS `Urutan`,concat(repeat(' ',(`m`.`d_space` * 5)),`m`.`d_name`) AS `Nama`,`m`.`d_level` AS `Level`,`m`.`d_sign` AS `Tanda`,`d`.`f_coa` AS `Akun`,0.00 AS `Saldo` from (`m01zcustomreport` `m` left join `m01zcustomreportdetail` `d` on(((`m`.`p_id` = `d`.`f_main`) and (`m`.`d_level` in (1,4,5,6))))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m01vwgiro`
--

/*!50001 DROP VIEW IF EXISTS `m01vwgiro`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m01vwgiro` AS select `m01dmaingiro`.`primary_main` AS `Id`,`m01dmaingiro`.`p_id` AS `NoBukti`,`m01dmaingiro`.`f_idsetlement` AS `NoBuktiCair`,`m01dmaingiro`.`f_coagiro` AS `CoaGiro`,`m01dmaingiro`.`f_currency` AS `Uang`,`m01dmaingiro`.`d_girono` AS `NoGiro`,`m01dmaingiro`.`d_bank` AS `Bank`,`m01dmaingiro`.`d_bankacno` AS `NoACBank`,`m01dmaingiro`.`d_duedate` AS `TglJatuhTempo`,`m01dmaingiro`.`d_value` AS `Nilai`,`m01dmaingiro`.`d_kurs` AS `Kurs`,`m01dmaingiro`.`d_status` AS `Status`,`m01dmaingiro`.`d_type` AS `Tipe`,(to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) AS `SelisihHari`,(case when ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) < 0) then '< 0 Hari' when ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) = 0) then '0 Hari' when (((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) > 0) and ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) < 8)) then '1-7 Hari' when (((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) > 7) and ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) < 15)) then '8-14 Hari' when (((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) > 14) and ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) < 22)) then '15-21 Hari' when (((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) > 21) and ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) < 31)) then '21-30 Hari' when ((to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate())) > 30) then '>30 Hari' end) AS `SelisihHariNama` from `m01dmaingiro` order by `m01dmaingiro`.`d_duedate` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m01vwgl`
--

/*!50001 DROP VIEW IF EXISTS `m01vwgl`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m01vwgl` AS select `tr2`.`primary_main` AS `Id`,`tr1`.`f_source` AS `SumberData`,year(`tr1`.`d_date`) AS `Tahun`,month(`tr1`.`d_date`) AS `Bulan`,`tr1`.`d_date` AS `Tanggal`,`tr1`.`f_contact` AS `Kontak`,`tr1`.`u_code` AS `NoBukti`,`tr1`.`f_coa` AS `AkunMain`,`tr2`.`f_coa` AS `AkunDetail`,`tr2`.`p_order` AS `Urutan`,0.00 AS `SaldoAwal`,`tr2`.`d_debit` AS `Debit`,`tr2`.`d_credit` AS `Kredit`,0.00 AS `SaldoAwalValas`,`tr2`.`d_debitvalas` AS `DebitValas`,`tr2`.`d_creditvalas` AS `KreditValas`,`tr1`.`d_description` AS `Keterangan`,`tr2`.`f_proyek` AS `Proyek`,0 AS `ProyekSub`,`tr2`.`f_division` AS `Divisi`,`tr2`.`d_rate` AS `Kurs` from (`m01dmaindetail` `tr2` left join `m01cmaingl` `tr1` on((`tr2`.`p_id` = `tr1`.`p_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m01vwsaldo`
--

/*!50001 DROP VIEW IF EXISTS `m01vwsaldo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m01vwsaldo` AS select `m01bcoa`.`p_id` AS `id`,`m01bcoa`.`f_type` AS `tipe`,`m01bcoa`.`u_code` AS `kode`,`m01bcoa`.`d_name` AS `nama`,`m01bcoa`.`d_parent` AS `induk`,`m01bcoa`.`f_coa1` AS `level1`,`m01bcoa`.`f_coa2` AS `level2`,`m01bcoa`.`f_coa3` AS `level3`,`m01bcoa`.`f_coa4` AS `level4`,`m01bcoa`.`fk_currency` AS `uang`,0.00 AS `saldoawal`,0.00 AS `mutasidebit`,0.00 AS `mutasikredit`,0.00 AS `saldoakhir` from `m01bcoa` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m02vwasset`
--

/*!50001 DROP VIEW IF EXISTS `m02vwasset`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m02vwasset` AS select `m02bassetview`.`p_id` AS `p_id`,`m02bassetview`.`p_id` AS `f_asset`,`m02bassetview`.`d_price` AS `d_price`,`m02bassetview`.`d_residuvalue` AS `d_residuvalue`,if((`m02bassetview`.`d_purchase` = 0),0,((`m02bassetview`.`d_qtyin` * (`m02bassetview`.`d_price` - `m02bassetview`.`d_residuvalue`)) - `f02_getbookvalueasset`(`m02bassetview`.`p_id`))) AS `d_amortization`,`f02_getbookvalueasset`(`m02bassetview`.`p_id`) AS `d_bookvalue` from `m02bassetview` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m04vwhpp`
--

/*!50001 DROP VIEW IF EXISTS `m04vwhpp`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m04vwhpp` AS select `m04dstockdetail`.`primary_main` AS `primary_main`,`m04dstockdetail`.`f_item` AS `f_item`,`m04dstockdetail`.`d_qtyin` AS `d_qtyin`,(select coalesce(sum(`m04estockhpp`.`d_qty`),0) from `m04estockhpp` where (`m04estockhpp`.`f_idin` = `m04dstockdetail`.`primary_main`)) AS `d_qtyout` from `m04dstockdetail` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m04vwhppavailable`
--

/*!50001 DROP VIEW IF EXISTS `m04vwhppavailable`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m04vwhppavailable` AS select `m04dstockdetail`.`primary_main` AS `id`,`m04dstockdetail`.`f_item` AS `f_item`,`m04dstockdetail`.`f_warehouse` AS `f_warehouse`,`m04dstockdetail`.`f_location` AS `f_location`,`m04dstockdetail`.`d_qtyin` AS `d_qtyin`,`m04dstockdetail`.`d_qtyout` AS `d_qtyout`,`f04_hppgetused`(`m04dstockdetail`.`primary_main`) AS `d_used`,`f04_hppgetavailable`(`m04dstockdetail`.`primary_main`) AS `d_available` from `m04dstockdetail` where (`m04dstockdetail`.`d_qtyin` > 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m04vwitem`
--

/*!50001 DROP VIEW IF EXISTS `m04vwitem`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m04vwitem` AS select `tr1`.`p_id` AS `id`,`tr1`.`p_id` AS `barang`,`tr1`.`u_code` AS `kode`,`tr1`.`d_name` AS `nama`,0.0 AS `saldoawal`,0.0 AS `stockin`,0.0 AS `stockout`,0.0 AS `saldoakhir`,0.0 AS `stock1`,0.0 AS `stock2` from `m04bitem` `tr1` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m04vwkartustock`
--

/*!50001 DROP VIEW IF EXISTS `m04vwkartustock`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m04vwkartustock` AS select `tr1`.`primary_main` AS `Id`,0.00 AS `SaldoAwal`,0.00 AS `SaldoAwalNilai`,`tr1`.`d_qtyin` AS `Masuk`,`tr1`.`d_qtyout` AS `Keluar`,`tr1`.`d_price` AS `Harga`,`f04_hppvalue`(`tr1`.`primary_main`) AS `HPP`,`tr2`.`u_code` AS `NoBukti`,`tr2`.`d_date` AS `Tanggal`,`tr1`.`f_item` AS `Barang`,`tr2`.`d_remarks` AS `Uraian`,`tr1`.`f_warehouse` AS `Gudang` from (`m04dstockdetail` `tr1` left join `m04cstockmain` `tr2` on((`tr1`.`p_id` = `tr2`.`p_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m04vwsaldo`
--

/*!50001 DROP VIEW IF EXISTS `m04vwsaldo`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m04vwsaldo` AS select `tr1`.`p_id` AS `Id`,`tr1`.`u_code` AS `Kode`,`tr1`.`d_name` AS `Nama`,`tr1`.`f_uom` AS `Satuan`,`tr1`.`f_kategori` AS `Kategori`,`tr1`.`f_subkategori` AS `SubKategori`,`tr1`.`f_merk` AS `Merk`,0.0 AS `SaldoAwal`,0.0 AS `QtyIn`,0.0 AS `QtyOut`,0.0 AS `SaldoAwalNilai`,0.0 AS `QtyInNilai`,0.0 AS `QtyOutNilai` from `m04bitem` `tr1` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m05vwaginginvoice`
--

/*!50001 DROP VIEW IF EXISTS `m05vwaginginvoice`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m05vwaginginvoice` AS select `m05cmaininvoicereceipt`.`p_id` AS `p_id`,`m05cmaininvoicereceipt`.`p_id` AS `NoInvoice`,coalesce((select sum(`m05ddetailpayment`.`d_amount`) from `m05ddetailpayment` where (`m05ddetailpayment`.`p_idinvoice` = `m05cmaininvoicereceipt`.`p_id`)),0) AS `d_payment`,(to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) AS `d_different`,(case when ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) < 0) then '< 0 Hari' when ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) = 0) then '0 Hari' when (((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) > 0) and ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) < 8)) then '1-7 Hari' when (((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) > 7) and ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) < 15)) then '8-14 Hari' when (((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) > 14) and ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) < 22)) then '15-21 Hari' when (((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) > 21) and ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) < 31)) then '21-30 Hari' when ((to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate())) > 30) then '>30 Hari' end) AS `d_differentdays` from `m05cmaininvoicereceipt` where (`m05cmaininvoicereceipt`.`d_duedate` is not null) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m05vwinvoice`
--

/*!50001 DROP VIEW IF EXISTS `m05vwinvoice`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m05vwinvoice` AS select 0 AS `Urutan`,`m05cmaininvoicereceipt`.`p_id` AS `NoInvoice`,coalesce((select sum(`m05ddetailpayment`.`d_amount`) from `m05ddetailpayment` where (`m05ddetailpayment`.`p_idinvoice` = `m05cmaininvoicereceipt`.`p_id`)),0) AS `Terbayar`,0 AS `NilaiBayarCash`,1 AS `OK`,1 AS `Kurs`,'' AS `Catatan`,NULL AS `Pembayaran` from `m05cmaininvoicereceipt` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m06vwaginginvoice`
--

/*!50001 DROP VIEW IF EXISTS `m06vwaginginvoice`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m06vwaginginvoice` AS select `tr`.`p_id` AS `p_id`,`tr`.`p_id` AS `NoInvoice`,coalesce((select sum(`m06gdetailpayment`.`d_amount`) from `m06gdetailpayment` where (`m06gdetailpayment`.`p_idinvoice` = `tr`.`p_id`)),0) AS `d_payment`,(to_days(`tr`.`d_duedate`) - to_days(curdate())) AS `d_different`,(case when ((to_days(`tr`.`d_duedate`) - to_days(curdate())) < 0) then '< 0 Hari' when ((to_days(`tr`.`d_duedate`) - to_days(curdate())) = 0) then '0 Hari' when (((to_days(`tr`.`d_duedate`) - to_days(curdate())) > 0) and ((to_days(`tr`.`d_duedate`) - to_days(curdate())) < 8)) then '1-7 Hari' when (((to_days(`tr`.`d_duedate`) - to_days(curdate())) > 7) and ((to_days(`tr`.`d_duedate`) - to_days(curdate())) < 15)) then '8-14 Hari' when (((to_days(`tr`.`d_duedate`) - to_days(curdate())) > 14) and ((to_days(`tr`.`d_duedate`) - to_days(curdate())) < 22)) then '15-21 Hari' when (((to_days(`tr`.`d_duedate`) - to_days(curdate())) > 21) and ((to_days(`tr`.`d_duedate`) - to_days(curdate())) < 31)) then '21-30 Hari' when ((to_days(`tr`.`d_duedate`) - to_days(curdate())) > 30) then '>30 Hari' end) AS `d_differentdays` from `m06emaininvoice` `tr` where (`tr`.`d_duedate` is not null) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `m06vwinvoice`
--

/*!50001 DROP VIEW IF EXISTS `m06vwinvoice`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `m06vwinvoice` AS select 0 AS `Urutan`,`tr1`.`p_id` AS `NoInvoice`,coalesce((select sum(`tr2`.`d_amount`) from `m06gdetailpayment` `tr2` where (`tr2`.`p_idinvoice` = `tr1`.`p_id`)),0) AS `Terbayar`,0 AS `NilaiBayarCash`,1 AS `OK`,1 AS `Kurs`,'' AS `Catatan`,NULL AS `Pembayaran` from `m06emaininvoice` `tr1` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-02-20 16:51:56
