CREATE TABLE `m07aregional` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `TtdNama` varchar(100) DEFAULT NULL,
  `TtdJabatan` varchar(100) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_07zregional_regional` FOREIGN KEY (`Id`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE `m07anomorseri` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
  `TanggalMulaiBerlaku` datetime NOT NULL,
  `NomorDari` varchar(16) NOT NULL,
  `NomorSampai` varchar(16) NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB;
CREATE TABLE `m07bnomorseridetail` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
  `Main` int unsigned NOT NULL,
  `NomorSeriFaktur` varchar(16) NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(255) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m07bnomorseridetail_code` (`NomorSeriFaktur`),
  CONSTRAINT `fk_07bnomorseridetail_main` FOREIGN KEY (`Main`) REFERENCES `m07anomorseri` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB;

CREATE TABLE `m07bppnexportcsv` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `LokasiFile` varchar(150) NOT NULL,
  `CSV` MEDIUMTEXT NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB;
CREATE TABLE `m07bppnapproval` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `LokasiFile` varchar(150) NOT NULL,
  `PDF` MEDIUMBLOB NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB;

CREATE TABLE `m07cppnkeluaran` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `KodeTransaksi` varchar(2) NOT NULL,
  `KodeStatus` varchar(1) NOT NULL,
  `NomorSeri` varchar(15) NOT NULL,
  `Tanggal` date NOT NULL,
  `NamaPerusahaan` varchar(100) NOT NULL,
  `AlamatPerusahaan` varchar(150) NOT NULL,
  `NPWPPerusahaan` varchar(30) NOT NULL,
  `TanggalPKPPerusahaan` date DEFAULT NULL,
  `NamaPelanggan` varchar(100) NOT NULL,
  `AlamatPelanggan` varchar(150) NOT NULL,
  `NPWPPelanggan` varchar(30) NOT NULL,
  `NIKPelanggan` varchar(30) DEFAULT NULL,
  `NomorInvoice` varchar(50) NOT NULL,
  `UangMuka` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `PPnPersen` decimal(4,2) NOT NULL DEFAULT 0,
  `PPnNominal` decimal(18,4) NOT NULL DEFAULT 0.0000,
  `Regional` smallint unsigned NOT NULL,
  `NamaRegional` varchar(30) NOT NULL,
  `TTdNama` varchar(100) NOT NULL,
  `TTdJabatan` varchar(50) NOT NULL,
  `ModuleId` int NOT NULL,
  `NomorSeriValid` int unsigned DEFAULT NULL,
  `ExportCSV` bigint unsigned DEFAULT NULL,
  `ApprovalPDF` bigint unsigned DEFAULT NULL,
  `StatusFaktur` tinyint(1) unsigned NOT NULL DEFAULT 1 COMMENT '1 : Edit\n2 : Valid\n3 : ExportCSV\n4 : Approval\n5 : FP Pengganti\n6 : FP Batal',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m07cppnkeluaran_code` (`KodeStatus`, `NomorSeri`),
  CONSTRAINT `fk_07cppnkeluaran_regional` FOREIGN KEY (`Regional`) REFERENCES `m07aregional` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_07cppnkeluaran_nomorserivalid` FOREIGN KEY (`NomorSeriValid`) REFERENCES `m07bnomorseridetail` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_07cppnkeluaran_exportcsv` FOREIGN KEY (`ExportCSV`) REFERENCES `m07bppnexportcsv` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_07cppnkeluaran_approvalpdf` FOREIGN KEY (`ApprovalPDF`) REFERENCES `m07bppnapproval` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB COMMENT='Tabel untuk mendata faktur pajak';
CREATE TABLE `m07dppnkeluarandetail` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Main` bigint unsigned NOT NULL,
  `Nama` varchar(1255) NOT NULL,
  `Qty` decimal(18,4) unsigned NOT NULL DEFAULT 1,
  `Harga` decimal(18,4) NOT NULL DEFAULT 0.0000,
  `Diskon` decimal(18,4) NOT NULL DEFAULT 0.0000,
  `Keterangan` varchar(255) DEFAULT NULL,
  `ReferensiId` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_07dppnkeluarandetail_main` FOREIGN KEY (`Main`) REFERENCES `m07cppnkeluaran` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB COMMENT='Table untuk mendata item faktur pajak';

CREATE TABLE `m07cppnmasukan` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `NomorFaktur` varchar(25) NOT NULL,
  `SupplierNama` varchar(100) NOT NULL,
  `SupplierNPWP` varchar(30) NOT NULL,
  `Tanggal` date NOT NULL,
  `MasaPajak` int unsigned NOT NULL,
  `TahunPajak` int unsigned NOT NULL,
  `IsKredit` tinyint(1) NOT NULL DEFAULT 1,
  `Dpp` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `PPn` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `PPnBM` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `ModuleId` int NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m07cppnmasukan_code` (`NomorFaktur`)
) ENGINE=InnoDB;

CREATE TABLE `m07bpphbuktipotong` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `LokasiFile` varchar(150) NOT NULL,
  `FileBlob` MEDIUMBLOB NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB;

CREATE TABLE `m07btarifpph17` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
  `Tarif` decimal(4,2) unsigned NOT NULL DEFAULT 0.00,
  `BatasBawah` decimal(10,0) unsigned NOT NULL DEFAULT 0,
  `BatasAtas` decimal(10,0) unsigned NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB;

CREATE TABLE `m07cpph21komisi` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `NoInvoice` varchar(50) NOT NULL,
  `NoKwitansi` varchar(50) NOT NULL,
  `TanggalInvoice` date NOT NULL,
  `TanggalKwitansi` date NOT NULL,
  `Wilayah` varchar(50) NOT NULL,
  `KeteranganInvoice` varchar(555) NOT NULL,
  `Penerima` varchar(150) NOT NULL,
  `NPWPPenerima` varchar(30) NOT NULL,
  `DppKomisi` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `KomisiPersen` decimal(4,2) unsigned NOT NULL DEFAULT 0,
  `KomisiNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `TarifPPh21` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `Pph21` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `ModuleId` int NOT NULL,
  `BuktiPotong` bigint unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m07cpph21komisi_code` (`NoInvoice`),
  CONSTRAINT `fk_07cpph21komisi_buktipotong` FOREIGN KEY (`BuktiPotong`) REFERENCES `m07bpphbuktipotong` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB;
CREATE TABLE `m07cpph23` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `NoInvoice` varchar(50) NOT NULL,
  `NoKwitansi` varchar(50) NOT NULL,
  `TanggalInvoice` date NOT NULL,
  `TanggalKwitansi` date NOT NULL,
  `Wilayah` varchar(50) NOT NULL,
  `KeteranganInvoice` varchar(555) NOT NULL,
  `Pemasang` varchar(150) NOT NULL,
  `DppPPh23` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `PPh23Persen` decimal(4,2) unsigned NOT NULL DEFAULT 0,
  `PPh23Nominal` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `ModuleId` int NOT NULL,
  `BuktiPotong` bigint unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m07cpph23_code` (`NoInvoice`),
  CONSTRAINT `fk_07cpph23_buktipotong` FOREIGN KEY (`BuktiPotong`) REFERENCES `m07bpphbuktipotong` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB;


insert into `modulelist`(`p_id`,`u_code`,`d_name`,`d_description`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7,'Nusoft007','Pajak',null,'2020-09-19 08:33:18','NuSoft - NuSoft Administrator','2020-09-19 08:33:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7000,7,'7','Pajak',null,1,7,'2020-09-19 08:34:18','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7100,7,'0701','PPn',7000,1,1,'2020-09-19 08:34:18','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7101,7,'0701.01','Nomor Seri Faktur',7100,1,1,'2020-09-19 08:41:24','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7102,7,'0701.02','Daftar PPn',7100,1,2,'2020-09-19 08:41:24','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7103,7,'0701.03','PPn Keluaran',7100,1,3,'2020-09-21 11:01:22','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7106,7,'0701.06','PPn Masukan',7100,1,6,'2020-09-19 08:41:24','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7200,7,'0702','PPh',7000,1,2,'2020-09-19 08:34:41','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7201,7,'0702.01','Tarif PPh Pasal 17',7200,1,1,'2020-09-19 08:35:51','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7202,7,'0702.02','PPh 21 Komisi',7200,1,2,'2020-09-19 08:35:51','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7203,7,'0702.03','PPh 23',7200,1,3,'2020-09-19 08:35:51','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7900,7,'0709','Setting',7000,1,9,'2020-09-19 08:43:54','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (7901,7,'0709.01','Konfigurasi',7900,1,1,'2020-09-19 08:44:15','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
