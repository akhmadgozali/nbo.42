ALTER TABLE m01cmaingl CHANGE f_contact f_contact INT(10) UNSIGNED;

DROP TABLE IF EXISTS `dtaprovince`;
CREATE TABLE `dtaprovince` (
  `p_id` smallint(5) unsigned NOT NULL,
  `u_code` varchar(50) NOT NULL,
  `d_note` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`p_id`),
  UNIQUE KEY `dtaprovince_code` (`u_code`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
DROP TABLE IF EXISTS `dtbdistrict`;
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
  CONSTRAINT `fk_dtbdistrict_province` FOREIGN KEY (`f_province`) REFERENCES `dtaprovince` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data kabupaten';
DROP TABLE IF EXISTS `dtcsubdistrict`;
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
  KEY `fk_dtbdistict_province` (`f_district`),
  CONSTRAINT `fk_dtcsubdistrict_district` FOREIGN KEY (`f_district`) REFERENCES `dtbdistrict` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data kecamatan';
DROP TABLE IF EXISTS `dtdvillage`;
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
  KEY `fk_dtbdistict_province` (`f_subdistrict`),
  CONSTRAINT `fk_dtdvillage_subdistrict` FOREIGN KEY (`f_subdistrict`) REFERENCES `dtcsubdistrict` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk menyimpan data desa';


CREATE TABLE `m11acarabayar` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Akun` int(10) unsigned NOT NULL,
  `Alias` varchar(50) NOT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT '1',
  `Keterangan` varchar(255) DEFAULT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11acarabayar_code` (`Akun`),
  CONSTRAINT `fk_11acarabayar_akun` FOREIGN KEY (`Akun`) REFERENCES `m01bcoa` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata cara pembayaran';
CREATE TABLE `m11arute` (
  `Id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `Regional` smallint(5) unsigned NOT NULL,
  `Kode` varchar(30) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `AkunPiutang` int(10) unsigned DEFAULT NULL,
  `AkunPendapatan` int(10) unsigned DEFAULT NULL,
  `AkunRetur` int(10) unsigned DEFAULT NULL,
  `AkunDiskon` int(10) unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11arute_code` (`Kode`),
  KEY `fk_11arute_regional` (`Regional`),
  KEY `fk_11arute_akunpiutang` (`AkunPiutang`),
  KEY `fk_11arute_akunpendapatan` (`AkunPendapatan`),
  KEY `fk_11arute_akunretur` (`AkunRetur`),
  KEY `fk_11arute_akundiskon` (`AkunDiskon`),
  CONSTRAINT `fk_11arute_akundiskon` FOREIGN KEY (`AkunDiskon`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11arute_akunpendapatan` FOREIGN KEY (`AkunPendapatan`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11arute_akunpiutang` FOREIGN KEY (`AkunPiutang`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11arute_akunretur` FOREIGN KEY (`AkunRetur`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11arute_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata route mobil';
CREATE TABLE `m11bagen` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Rute` smallint(5) unsigned NOT NULL,
  `Kode` varchar(30) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(250) DEFAULT NULL,
  `NPWP` varchar(30) NOT NULL,
  `NIK` varchar(30) DEFAULT NULL,
  `NoTelpon` varchar(40) DEFAULT NULL,
  `NoFax` varchar(20) DEFAULT NULL,
  `NoHP1` varchar(20) DEFAULT NULL,
  `NoHP2` varchar(20) DEFAULT NULL,
  `Email` varchar(30) DEFAULT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT '1' COMMENT '0: NonAktif, 1: Aktif',
  `HargaJatah` double NOT NULL DEFAULT '0',
  `HargaKonsi` double NOT NULL DEFAULT '0',
  `KodePelanggan` varchar(10) NOT NULL,
  `HargaLangganan` double unsigned NOT NULL DEFAULT '0',
  `OrderTetap` tinyint(1) NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `SaldoPiutangAwal` double NOT NULL DEFAULT '0',
  `KeteranganSaldoAwal` varchar(255) DEFAULT NULL,
  `last_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `last_modified` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11bagen_code` (`Kode`),
  KEY `fk_11bagen_rute` (`Rute`),
  CONSTRAINT `fk_11bagen_rute` FOREIGN KEY (`Rute`) REFERENCES `m11arute` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata data agen.';
CREATE TABLE `m11bagenorder` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Agen` int(10) unsigned NOT NULL,
  `IndexHari` smallint(5) unsigned NOT NULL,
  `Jatah` smallint(5) unsigned NOT NULL DEFAULT '0',
  `Konsi` smallint(5) unsigned NOT NULL DEFAULT '0',
  `Gratis` smallint(5) unsigned NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11bagenorder_code` (`Agen`,`IndexHari`),
  CONSTRAINT `fk_11bagenorder_agen` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m11corder` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Tanggal` date NOT NULL,
  `HariKhusus` tinyint(1) NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11corder_code` (`Tanggal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m11dorderdetail` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Main` bigint(20) unsigned NOT NULL,
  `Agen` int(10) unsigned NOT NULL,
  `Jatah` smallint(6) NOT NULL DEFAULT '0',
  `Konsi` smallint(6) NOT NULL DEFAULT '0',
  `Gratis` smallint(6) NOT NULL DEFAULT '0',
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_11dorderdetail_agen` (`Agen`),
  KEY `fk_11dorderdetail_main` (`Main`),
  CONSTRAINT `fk_11dorderdetail_agen` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11dorderdetail_main` FOREIGN KEY (`Main`) REFERENCES `m11corder` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m11cmutation` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Tanggal` date NOT NULL,
  `HariKhusus` tinyint(1) NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11cmutation_code` (`Tanggal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata sirkulasi harian koran';
CREATE TABLE `m11dmutationdetail` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Main` bigint(20) unsigned NOT NULL,
  `Agen` int(10) unsigned NOT NULL,
  `JatahOrder` smallint(5) unsigned NOT NULL DEFAULT '0',
  `JatahMutasi` smallint(6) NOT NULL DEFAULT '0',
  `KonsiOrder` smallint(5) unsigned NOT NULL DEFAULT '0',
  `KonsiMutasi` smallint(6) NOT NULL DEFAULT '0',
  `GratisOrder` smallint(5) unsigned NOT NULL DEFAULT '0',
  `GratisMutasi` smallint(6) NOT NULL DEFAULT '0',
  `HargaJatah` double unsigned NOT NULL DEFAULT '0',
  `HargaKonsi` double unsigned NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `Retur` smallint(5) unsigned NOT NULL DEFAULT '0',
  `KeteranganRetur` varchar(255) DEFAULT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11dmutationdetail_code` (`Main`,`Agen`),
  KEY `fk_11dmutationdetail_agent` (`Agen`),
  CONSTRAINT `fk_11dmutationdetail_agent` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11dmutationdetail_main` FOREIGN KEY (`Main`) REFERENCES `m11cmutation` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata sirkulasi harian koran agen';
CREATE TABLE `m11zmapgl` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Tahun` smallint(5) unsigned NOT NULL,
  `Bulan` tinyint(3) unsigned NOT NULL,
  `Regional` smallint(5) unsigned NOT NULL,
  `GLId` bigint(20) unsigned DEFAULT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11zmapgl_code` (`Tahun`,`Bulan`,`Regional`),
  KEY `fk_11zmapgl_regional` (`Regional`),
  KEY `fk_11zmapgl_gl` (`GLId`),
  CONSTRAINT `fk_11zmapgl_gl` FOREIGN KEY (`GLId`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11zmapgl_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata mapping gl';
CREATE TABLE `m11zmaptax` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Tahun` smallint unsigned NOT NULL,
  `Bulan` tinyint unsigned NOT NULL,
  `Agen` int unsigned DEFAULT NULL,
  `TaxId` bigint unsigned NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11zmaptax_code` (`Tahun`,`Bulan`,`Agen`),
  CONSTRAINT `fk_11zmaptax_agen` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11zmaptax_tax` FOREIGN KEY (`TaxId`) REFERENCES `m07cppnkeluaran` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata mapping tax';

CREATE TABLE `m11cbayarkoran` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Kode` varchar(30) NOT NULL,
  `Regional` smallint(5) unsigned NOT NULL,
  `Agen` int(10) unsigned NOT NULL,
  `CaraBayar` int(10) unsigned NOT NULL,
  `Tanggal` date NOT NULL,
  `TotalBayar` double NOT NULL DEFAULT '0',
  `Diskon` double NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) NOT NULL,
  `GLId` bigint(20) unsigned DEFAULT NULL,
  `BatalBayarId` bigint(20) unsigned DEFAULT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11cbayarkoran_code` (`Kode`),
  KEY `fk_11cbayarkoran_agen` (`Agen`),
  KEY `fk_11cbayarkoran_batalbayar` (`BatalBayarId`),
  KEY `fk_11cbayarkoran_carabayar` (`CaraBayar`),
  KEY `fk_11cbayarkoran_regional` (`Regional`),
  KEY `fk_11cbayarkoran_transaction` (`GLId`),
  CONSTRAINT `fk_11cbayarkoran_agen` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cbayarkoran_batalbayar` FOREIGN KEY (`BatalBayarId`) REFERENCES `m11cbayarkoran` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cbayarkoran_carabayar` FOREIGN KEY (`CaraBayar`) REFERENCES `m11acarabayar` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cbayarkoran_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cbayarkoran_transaction` FOREIGN KEY (`GLId`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata pembayaran';
CREATE TABLE `m11ceditharga` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Tahun` year(4) NOT NULL,
  `Bulan` smallint(5) unsigned NOT NULL,
  `JumlahHari` int(10) unsigned NOT NULL DEFAULT '1',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m11ceditharga_code` (`Tahun`,`Bulan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m11dedithargadetail` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Main` bigint(20) unsigned NOT NULL,
  `Agen` int(10) unsigned NOT NULL,
  `HargaJatahLama` double unsigned NOT NULL DEFAULT '0',
  `HargaKonsiLama` double unsigned NOT NULL DEFAULT '0',
  `HargaJatahBaru` double unsigned NOT NULL DEFAULT '0',
  `HargaKonsiBaru` double unsigned NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_11dedithargadetail_agen` (`Agen`),
  KEY `fk_11dedithargadetail_main` (`Main`),
  CONSTRAINT `fk_11dedithargadetail_agen` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11dedithargadetail_main` FOREIGN KEY (`Main`) REFERENCES `m11ceditharga` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m11cpelanggan` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Agen` int(10) unsigned NOT NULL,
  `Kode` varchar(30) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(200) DEFAULT NULL,
  `Propinsi` smallint(5) unsigned DEFAULT NULL,
  `Kabupaten` smallint(5) unsigned DEFAULT NULL,
  `Kecamatan` int(10) unsigned DEFAULT NULL,
  `Kelurahan` int(10) unsigned DEFAULT NULL,
  `NIK` varchar(30) DEFAULT NULL,
  `TempatLahir` varchar(30) DEFAULT NULL,
  `TanggalLahir` date DEFAULT NULL,
  `Pekerjaan` varchar(50) DEFAULT NULL,
  `NoTelpRumah` varchar(50) DEFAULT NULL,
  `NoTelpKantor` varchar(50) DEFAULT NULL,
  `NoHP` varchar(50) DEFAULT NULL,
  `Email` varchar(30) DEFAULT NULL,
  `Harga` double NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `KoordinatX` decimal(16,8) NOT NULL DEFAULT '0.00000000',
  `KoordinatY` decimal(16,8) NOT NULL DEFAULT '0.00000000',
  `TanggalMulaiLangganan` datetime NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_11cpelanggan_agen` (`Agen`),
  KEY `fk_11cpelanggan_kabupaten` (`Kabupaten`),
  KEY `fk_11cpelanggan_kecamatan` (`Kecamatan`),
  KEY `fk_11cpelanggan_kelurahan` (`Kelurahan`),
  KEY `fk_11cpelanggan_propinsi` (`Propinsi`),
  CONSTRAINT `fk_11cpelanggan_agen` FOREIGN KEY (`Agen`) REFERENCES `m11bagen` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cpelanggan_kabupaten` FOREIGN KEY (`Kabupaten`) REFERENCES `dtbdistrict` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cpelanggan_kecamatan` FOREIGN KEY (`Kecamatan`) REFERENCES `dtcsubdistrict` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cpelanggan_kelurahan` FOREIGN KEY (`Kelurahan`) REFERENCES `dtdvillage` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_11cpelanggan_propinsi` FOREIGN KEY (`Propinsi`) REFERENCES `dtaprovince` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabel untuk mendata pelanggan koran';
CREATE TABLE `m11dpelangganhistory` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Pelanggan` bigint(20) unsigned NOT NULL,
  `Tanggal` date NOT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT '0',
  `JumlahExp` int(10) unsigned NOT NULL DEFAULT '1',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_m11dpelangganhistory_pelanggan` (`Pelanggan`),
  CONSTRAINT `fk_m11dpelangganhistory_pelanggan` FOREIGN KEY (`Pelanggan`) REFERENCES `m11cpelanggan` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m11dpelanggankomplain` (
  `Id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Pelanggan` bigint(20) unsigned NOT NULL,
  `Tanggal` date NOT NULL,
  `Penerima` varchar(50) NOT NULL,
  `Keluhan` varchar(255) NOT NULL,
  `Solusi` varchar(255) DEFAULT NULL,
  `BatasWaktu` date DEFAULT NULL,
  `Selesai` tinyint(1) NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_11dpelanggankomplain_pelanggan` (`Pelanggan`),
  CONSTRAINT `fk_11dpelanggankomplain_pelanggan` FOREIGN KEY (`Pelanggan`) REFERENCES `m11cpelanggan` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE OR REPLACE VIEW `m11vwsirkulasiagen` AS 
select 
	cast(concat(date_format(`c`.`Tanggal`,'%Y%m'),lpad(`d`.`Agen`,4,0)) as unsigned) AS `Id`,
	cast(concat(year(`c`.`Tanggal`),'-',month(`c`.`Tanggal`),'-01') as date) AS `Tanggal`,
	`d`.`Agen` AS `Agen`,
	sum(`d`.`JatahOrder` + `d`.`JatahMutasi`) AS `Jatah`,
	sum(`d`.`KonsiOrder` + `d`.`KonsiMutasi`) AS `Konsi`,
	sum(`d`.`GratisOrder` + `d`.`GratisMutasi`) AS `Gratis`,
	sum(`d`.`Retur`) AS `Retur`,
	sum((`d`.`JatahOrder` + `d`.`JatahMutasi`) * `d`.`HargaJatah`) AS `OmzetJatah`,
	sum((`d`.`KonsiOrder` + `d`.`KonsiMutasi`) * `d`.`HargaKonsi`) AS `OmzetKonsi`,
	sum(`d`.`Retur` * `d`.`HargaKonsi`) AS `OmzetRetur` 
from (`m11dmutationdetail` `d` left join `m11cmutation` `c` on(`d`.`Main` = `c`.`Id`)) 
group by concat(year(`c`.`Tanggal`),'-',month(`c`.`Tanggal`),'-01'),`d`.`Agen`;

CREATE  OR REPLACE VIEW `m11vwrekap` AS
select 
  uuid_short() as Id,
  0 as IsBayar, 
  0 as IsSaldoAwal,
  c.Tanggal as Tanggal,
  agen.Kode as AgenKode,
  agen.Nama as AgenNama,
  agen.Aktif as AgenAktif,
  rute.Kode as RuteKode,
  rute.Nama as RuteNama,
  concat(rute.Kode,' - ',rute.Nama) as RuteKodeNama,
  regional.p_id as RegionalId,
  regional.d_name as RegionalNama,
  cast((d.JatahOrder + d.JatahMutasi) as signed) as Jatah,
  cast((d.KonsiOrder + d.KonsiMutasi) as signed) as Konsi,
  cast((d.GratisOrder + d.GratisMutasi) as signed) as Gratis,
  cast(d.Retur as signed) as Retur,
  cast((d.JatahOrder + d.JatahMutasi) * d.HargaJatah as signed) as OmzetJatah,
  cast((d.KonsiOrder + d.KonsiMutasi) * d.HargaKonsi as signed) as OmzetKonsi,
  cast(d.Retur * d.HargaKonsi as signed) as OmzetRetur,
  0 as Pembayaran,
  0 as Diskon
from m11dmutationdetail d 
left join m11cmutation c on d.Main=c.Id
left join m11bagen agen on d.Agen=agen.Id
left join m11arute rute on agen.Rute=rute.Id
left join a_regional regional on rute.Regional=regional.p_id
union 
select
  uuid_short() as Id,
  1 as IsBayar, 
  0 as IsSaldoAwal,
  c.Tanggal as Tanggal,
  agen.Kode as AgenKode,
  agen.Nama as AgenNama,
  agen.Aktif as AgenAktif,
  rute.Kode as RuteKode,
  rute.Nama as RuteNama,
  concat(rute.Kode,' - ',rute.Nama) as RuteKodeNama,
  regional.p_id as RegionalId,
  regional.d_name as RegionalNama,
  0 as Jatah,
  0 as Konsi,
  0 as Gratis,
  0 as Retur,
  0 as OmzetJatah,
  0 as OmzetKonsi,
  0 as OmzetRetur,
  c.TotalBayar as Pembayaran,
  c.Diskon as Diskon
from m11cbayarkoran c 
left join m11bagen agen on c.Agen=agen.Id
left join m11arute rute on agen.Rute=rute.Id
left join a_regional regional on rute.Regional=regional.p_id
union 
select
	agen.Id as Id,
	0 as IsBayar, 
	1 as IsSaldoAwal,
	cast((select d_value from a_setting where u_module=11 and u_code='TanggalAwalPiutang') as Date) as Tanggal,
	agen.Kode as AgenKode,
	agen.Nama as AgenNama,
	agen.Aktif as AgenAktif,
	rute.Kode as RuteKode,
	rute.Nama as RuteNama,
	concat(rute.Kode,' - ',rute.Nama) as RuteKodeNama,
	regional.p_id as RegionalId,
	regional.d_name as RegionalNama,
	0 as Jatah,
	0 as Konsi,
	0 as Gratis,
	0 as Retur,
	agen.SaldoPiutangAwal as OmzetJatah,
	0 as OmzetKonsi,
	0 as OmzetRetur,
	0 as Pembayaran,
    0 as Diskon
from m11bagen agen
left join m11arute rute on agen.Rute=rute.Id
left join a_regional regional on rute.Regional=regional.p_id
where agen.SaldoPiutangAwal <> 0;


insert into `modulelist`(`p_id`,`u_code`,`d_name`,`d_description`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11,'Nusoft011','Sirkulasi & Pemasaran Koran',null,'2020-08-14 23:32:03','NuSoft - NuSoft Administrator','2020-08-16 16:04:43','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11000,11,'11','Sirkulasi & Pemasaran Koran',null,1,11,'2020-08-15 21:14:43','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11100,11,'1101','Sirkulasi',11000,1,1,'2020-08-15 21:23:45','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11101,11,'1101.01','Saldo Awal Piutang Agen',11100,1,1,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11102,11,'1101.02','Order Koran',11100,1,2,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11103,11,'1101.03','Sirkulasi Harian',11100,1,3,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11104,11,'1101.04','Retur Koran',11100,1,4,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11105,11,'1101.05','Pembayaran Koran',11100,1,5,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11106,11,'1101.06','Batal Bayar',11100,1,6,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11199,11,'1101.99','Edit Harga',11100,1,99,'2020-08-15 21:27:04','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11200,11,'1102','Pemasaran',11000,1,2,'2020-08-15 21:23:45','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11201,11,'1102.01','Pelanggan Aktif',11200,1,1,'2020-08-15 21:29:22','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11202,11,'1102.02','Pelanggan Non Aktif',11200,1,2,'2020-08-15 21:29:22','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11203,11,'1102.03','Pengingat Ultah',11200,1,3,'2020-08-15 21:29:22','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11204,11,'1102.04','Komplain',11200,1,4,'2020-08-15 21:29:22','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11300,11,'1103','Data-Data',11000,1,3,'2020-08-15 21:23:45','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11301,11,'1103.01','Rekap Oplah',11300,1,1,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11302,11,'1103.02','Rincian Oplah',11300,1,2,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11303,11,'1103.03','Rekap Omzet',11300,1,3,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11304,11,'1103.04','Rincian Omzet',11300,1,4,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11305,11,'1103.05','Rekap Pembayaran',11300,1,5,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11306,11,'1103.06','Rincian Pembayaran',11300,1,6,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11307,11,'1103.07','Rekap Piutang',11300,1,7,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11308,11,'1103.08','Rincian Piutang',11300,1,8,'2020-08-15 21:33:37','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11980,11,'1198','Master Data',11000,1,98,'2020-08-15 21:17:19','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11981,11,'1198.01','Rute',11980,1,1,'2020-08-15 21:21:16','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11982,11,'1198.02','Agen',11980,1,2,'2020-08-15 21:21:16','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11983,11,'1198.03','Cara Bayar',11980,1,3,'2020-08-15 21:21:16','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11990,11,'1199','Setting',11000,1,99,'2020-08-15 21:16:08','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11991,11,'1199.01','Konfigurasi',11990,1,1,'2020-08-15 21:16:08','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11992,11,'1199.02','Integrasi Keuangan',11990,1,2,'2020-08-31 12:12:43','NuSoft - NuSoft Administrator','2020-09-11 15:11:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11000,11,'11','Sirkulasi & Pemasaran Koran',null,null,1,11,null,'2020-08-15 21:35:11','NuSoft - NuSoft Administrator','2020-09-11 15:34:28','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11100,11,'1101','Order Cetak',11000,null,1,1,null,'2020-08-15 21:35:49','NuSoft - NuSoft Administrator','2020-09-11 15:34:28','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11101,11,'1101.01','Sampul',11100,'11OrderSampul.repx',1,1,null,'2020-08-15 21:36:21','NuSoft - NuSoft Administrator','2020-09-11 15:34:28','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11102,11,'1101.02','Rekap Order',11100,'11OrderRekap.repx',1,2,null,'2020-08-15 21:37:49','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11103,11,'1101.03','Rincian Order',11100,'11OrderRincian.repx',1,3,null,'2020-08-15 21:37:49','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11104,11,'1101.04','Label Expedisi',11100,'11OrderLabel.repx',1,4,null,'2020-08-15 21:37:49','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11200,11,'1102','Sirkulasi',11000,null,1,2,null,'2020-08-15 21:38:28','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11201,11,'1102.01','Rekap Sirkulasi Harian',11200,'11SirkulasiRekapHarian.repx',1,1,null,'2020-08-15 21:40:51','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11202,11,'1102.02','Rincian Sirkulasi Harian',11200,'11SirkulasiRincianHarian.repx',1,2,null,'2020-08-15 21:40:51','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11203,11,'1102.03','Rekap Sirkulasi Bulanan',11200,'11SirkulasiRekapBulanan.repx',1,3,null,'2020-08-15 21:40:51','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11204,11,'1102.04','Rincian Sirkulasi Bulanan',11200,'11SirkulasiRincianBulanan.repx',1,4,null,'2020-08-15 21:40:51','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11300,11,'1103','Agen',11000,null,1,3,null,'2020-08-15 21:45:45','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11301,11,'1103.01','Tagihan Bulanan',11300,'11AgenTagihan.repx',1,1,null,'2020-08-15 21:47:05','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11302,11,'1103.02','Label Tagihan',11300,'11AgenLabel.repx',1,2,null,'2020-08-15 21:47:05','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11303,11,'1103.03','Kwitansi Pembayaran',11300,'11AgenKwitansi.repx',1,3,null,'2020-08-15 21:47:05','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11304,11,'1103.04','Rekap Pembayaran Harian',11300,'11AgenPembayaranRekapHarian.repx',1,4,null,'2020-09-10 02:35:29','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11400,11,'1104','Pelanggan',11000,null,1,4,null,'2020-08-15 21:45:45','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11401,11,'1104.01','Kwitansi Pelanggan',11400,'11PelangganKwitansi.repx',1,1,null,'2020-08-15 21:48:22','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11402,11,'1104.02','Daftar Pelanggan',11400,'11PelangganDaftar.repx',1,2,null,'2020-09-10 04:01:11','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11500,11,'1105','Laporan Bulanan',11000,null,1,5,null,'2020-08-15 21:45:45','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11501,11,'1105.01','Rekap Omzet Per Tanggal',11500,'11BulananRekapOmzetTanggal.repx',1,1,null,'2020-08-15 22:06:19','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11502,11,'1105.02','Rekap Omzet Per Rute',11500,'11BulananRekapOmzetRute.repx',1,2,null,'2020-08-15 22:06:19','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11503,11,'1105.03','Rincian Omzet Per Rute',11500,'11BulananRincianOmzetRute.repx',1,3,null,'2020-08-15 22:06:19','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11504,11,'1105.04','Rekap Pembayaran',11500,'11BulananRekapPembayaran.repx',1,4,null,'2020-08-15 22:07:34','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11505,11,'1105.05','Rincian Pembayaran',11500,'11BulananRincianPembayaran.repx',1,5,null,'2020-08-15 22:07:34','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11506,11,'1105.06','Rekap Piutang',11500,'11BulananRekapPiutang.repx',1,6,null,'2020-08-15 22:08:21','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (11507,11,'1105.07','Rincian Piutang',11500,'11BulananRincianPiutang.repx',1,7,null,'2020-08-15 22:08:21','NuSoft - NuSoft Administrator','2020-09-11 15:34:29','NuSoft - NuSoft Administrator');
