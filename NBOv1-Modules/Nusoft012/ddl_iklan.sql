CREATE TABLE `m12akelompokomzet` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Kode` varchar(30) NOT NULL,
  `TtdNama` varchar(100) NOT NULL,
  `TtdJabatan` varchar(100) NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12akelompokomzet_code` (`Kode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12bwilayah` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Regional` smallint unsigned NOT NULL,
  `KelompokOmzet` smallint unsigned NOT NULL,
  `Kode` varchar(3) NOT NULL,
  `Nama` varchar(30) NOT NULL,
  `JatuhTempo` smallint unsigned NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12bwilayah_code` (`Kode`),
  CONSTRAINT `fk_12bwilayah_kelompokomzet` FOREIGN KEY (`KelompokOmzet`) REFERENCES `m12akelompokomzet` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12bwilayah_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12asales` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
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
  `KomisiDefault` decimal(4,2) unsigned NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12asales_code` (`Kode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12apemasang` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
  `Kode` varchar(30) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(250) DEFAULT NULL,
  `NPWP` varchar(30) NOT NULL,
  `KodeFaktur` varchar(2) NOT NULL,
  `NIK` varchar(30) DEFAULT NULL,
  `NoTelpon` varchar(40) DEFAULT NULL,
  `NoFax` varchar(20) DEFAULT NULL,
  `NoHP1` varchar(20) DEFAULT NULL,
  `NoHP2` varchar(20) DEFAULT NULL,
  `Email` varchar(30) DEFAULT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT '1' COMMENT '0: NonAktif, 1: Aktif',
  `DiskonDefault` decimal(4,2) unsigned NOT NULL DEFAULT 0,
  `JatuhTempoDefault` smallint unsigned NOT NULL DEFAULT 0,
  `KontakPerson` varchar(100) DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12apemasang_code` (`Kode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12acarabayar` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
  `Akun` int unsigned NOT NULL,
  `Alias` varchar(50) NOT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT '1',
  `IsPPh23` tinyint(1) NOT NULL DEFAULT '0',
  `PPh23Persen` decimal(4,2) unsigned NOT NULL DEFAULT '0',
  `IsPPh21` tinyint(1) NOT NULL DEFAULT '0',
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12acarabayar_code` (`Akun`),
  CONSTRAINT `fk_12acarabayar_akun` FOREIGN KEY (`Akun`) REFERENCES `m01bcoa` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12atipeinvoice` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Kode` varchar(3) NOT NULL,
  `Nama` varchar(20) NOT NULL,
  `TipeIklan` tinyint unsigned NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `AkunPiutang` int unsigned DEFAULT NULL,
  `AkunPendapatan` int unsigned DEFAULT NULL,
  `AkunDiskon` int unsigned DEFAULT NULL,
  `AkunHutangKomisi` int unsigned DEFAULT NULL,
  `AkunBiayaKomisi` int unsigned DEFAULT NULL,
  `AkunHutangCashback` int unsigned DEFAULT NULL,
  `AkunBiayaCashback` int unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12atipeinvoice_code` (`Kode`),
  CONSTRAINT `fk_12atipeinvoice_akunpiutang` FOREIGN KEY (`AkunPiutang`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12atipeinvoice_akunpendapatan` FOREIGN KEY (`AkunPendapatan`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12atipeinvoice_akundiskon` FOREIGN KEY (`AkunDiskon`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12atipeinvoice_akunhutangkomisi` FOREIGN KEY (`AkunHutangKomisi`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12atipeinvoice_akunbiayakomisi` FOREIGN KEY (`AkunBiayaKomisi`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12atipeinvoice_akunhutangcashback` FOREIGN KEY (`AkunHutangCashback`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12atipeinvoice_akunbiayacashback` FOREIGN KEY (`AkunBiayaCashback`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12akurir` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Nama` varchar(50) NOT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT 1,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12akurir_code` (`Nama`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12atarifiklan` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Kode` varchar(10) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `TipeIklan` tinyint unsigned NOT NULL,
  `Tarif` decimal(18,4) unsigned NOT NULL DEFAULT 0,
  `Aktif` tinyint(1) NOT NULL DEFAULT 1,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12atarifiklan_code` (`Kode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12aproduk` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Kode` varchar(10) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12aproduk_code` (`Kode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12bmerk` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `Produk` smallint unsigned NOT NULL,
  `Kode` varchar(10) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12bmerk_code` (`Produk`,`Kode`),
  CONSTRAINT `fk_12bmerk_produk` FOREIGN KEY (`Produk`) REFERENCES `m12aproduk` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12cinvoice` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Wilayah` smallint unsigned NOT NULL,
  `TipeInvoice` smallint unsigned NOT NULL,
  `NoInvoice` varchar(30) NOT NULL,
  `NoOrder` varchar(30) NOT NULL,
  `Sales` int unsigned NOT NULL,
  `Pemasang` int unsigned DEFAULT NULL,
  `Kurir` smallint unsigned DEFAULT NULL,
  `SaldoAwal` tinyint(1) NOT NULL DEFAULT 0,
  `TanggalOmzet` date NOT NULL,
  `TanggalInvoice` date NOT NULL,
  `TanggalJatuhTempo` date NOT NULL,
  `InvoiceNama` varchar(100) NOT NULL,
  `InvoiceAlamat` varchar(255) NOT NULL,
  `InvoiceTtdNama` varchar(100) NOT NULL,
  `InvoiceTtdJabatan` varchar(100) NOT NULL,
  `InvoiceNPWP` varchar(30) NOT NULL,
  `InvoiceNIK` varchar(30) DEFAULT NULL,
  `InvoiceKeterangan` varchar(1255) DEFAULT NULL,
  `OrderTanggalBayar` date DEFAULT NULL,
  `OrderBayarVia` varchar(100) DEFAULT NULL,
  `OrderKontakPerson` varchar(100) DEFAULT NULL,
  `OrderDp` double NOT NULL DEFAULT 0,
  `OrderTtdNama` varchar(100) DEFAULT NULL,
  `OrderKeterangan` varchar(255) DEFAULT NULL,
  `WarnaBW` tinyint(1) NOT NULL DEFAULT 1,
  `Merk` smallint unsigned DEFAULT NULL,
  `TarifIklan` smallint unsigned DEFAULT NULL,
  `UkuranX` decimal(10,2) unsigned NOT NULL DEFAULT 0,
  `UkuranY` decimal(10,2) unsigned NOT NULL DEFAULT 0,
  `Halaman` tinyint(3) unsigned NOT NULL DEFAULT 0,
  `JudulIklan` varchar(1500) DEFAULT NULL,
  `MateriDeretLinear` text DEFAULT NULL,
  `MateriDeretBaris` text DEFAULT NULL,
  `JumlahBarisDeret` tinyint(3) unsigned NOT NULL DEFAULT 0,
  `HargaIklan` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `TanggalMulai` date DEFAULT NULL,
  `TanggalAkhir` date DEFAULT NULL,
  `HargaTermasukPajak` tinyint(1) NOT NULL DEFAULT 0,
  `Bruto` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `DiskonPersen` decimal(5,2) unsigned NOT NULL DEFAULT 0.00,
  `DiskonNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `Netto` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `PajakPersen` decimal(5,2) unsigned NOT NULL DEFAULT 0,
  `PajakNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `Total` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `CashbackPersen` decimal(4,2) unsigned NOT NULL DEFAULT 0.00,
  `CashbackNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `PotonganKomisiNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `KomisiPersen` decimal(4,2) unsigned NOT NULL DEFAULT 0.00,
  `KomisiNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `CetakKe` tinyint(3) unsigned NOT NULL DEFAULT 1,
  `Keterangan` varchar(255) DEFAULT NULL,
  `IndukInvoice` bigint unsigned DEFAULT NULL,
  `KoreksiInvoice` bigint unsigned DEFAULT NULL,
  `TaxId` bigint unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12cinvoice_noinvoce` (`NoInvoice`),
  UNIQUE KEY `m12cinvoice_noorder` (`NoOrder`),
  CONSTRAINT `fk_12cinvoice_tax` FOREIGN KEY (`TaxId`) REFERENCES `m07cppnkeluaran` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_induk` FOREIGN KEY (`IndukInvoice`) REFERENCES `m12cinvoice` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_koreksi` FOREIGN KEY (`KoreksiInvoice`) REFERENCES `m12cinvoice` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_kurir` FOREIGN KEY (`Kurir`) REFERENCES `m12akurir` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_pemasang` FOREIGN KEY (`Pemasang`) REFERENCES `m12apemasang` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_tipeinvoice` FOREIGN KEY (`TipeInvoice`) REFERENCES `m12atipeinvoice` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_sales` FOREIGN KEY (`Sales`) REFERENCES `m12asales` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_wilayah` FOREIGN KEY (`Wilayah`) REFERENCES `m12bwilayah` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_merk` FOREIGN KEY (`Merk`) REFERENCES `m12bmerk` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cinvoice_tarifiklan` FOREIGN KEY (`TarifIklan`) REFERENCES `m12atarifiklan` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12dinvoiceterbit` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Invoice` bigint unsigned NOT NULL,
  `TanggalTerbit` date NOT NULL,
  `Aktif` tinyint(1) NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12cinvoiceterbit_code` (`Invoice`,`TanggalTerbit`),
  CONSTRAINT `fk_12dinvoiceterbit_invoice` FOREIGN KEY (`Invoice`) REFERENCES `m12cinvoice` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12dinvoicekirim` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Invoice` bigint unsigned NOT NULL,
  `TanggalKirim` datetime NOT NULL,
  `Keterangan` varchar(255) NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_12dinvoicekirim_invoice` FOREIGN KEY (`Invoice`) REFERENCES `m12cinvoice` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12cpembayaraniklan` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Regional` smallint unsigned NOT NULL,
  `NoKwitansi` varchar(30) NOT NULL,
  `Tanggal` date NOT NULL,
  `CaraBayar` int unsigned NOT NULL,
  `Sales` int unsigned DEFAULT NULL,
  `Pemasang` varchar(100) NOT NULL,
  `Keterangan` varchar(255) NOT NULL,
  `GlId` bigint unsigned NOT NULL,
  `BatalBayarId` bigint unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12cpembayaraniklan_code` (`NoKwitansi`),
  CONSTRAINT `fk_12cpembayaraniklan_batalbayar` FOREIGN KEY (`BatalBayarId`) REFERENCES `m12cpembayaraniklan` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cpembayaraniklan_sales` FOREIGN KEY (`Sales`) REFERENCES `m12asales` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cpembayaraniklan_carabayar` FOREIGN KEY (`CaraBayar`) REFERENCES `m12acarabayar` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cpembayaraniklan_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12cpembayaraniklan_gl` FOREIGN KEY (`GlId`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12dpembayaraniklandetail` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Pembayaran` bigint unsigned NOT NULL,
  `Invoice` bigint unsigned NOT NULL,
  `NominalBayar` double NOT NULL DEFAULT 0,
  `Lunas` tinyint(1) NOT NULL DEFAULT 0,
  `CashbackPersen` decimal(4,2) unsigned NOT NULL DEFAULT 0.00,
  `CashbackNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `PotonganKomisiNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `KomisiPersen` decimal(4,2) unsigned NOT NULL DEFAULT 0.00,
  `KomisiNominal` decimal(18,4) unsigned NOT NULL DEFAULT 0.0000,
  `PPh23Id` bigint unsigned DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_12dpembayaraniklandetail_pembayaran` FOREIGN KEY (`Pembayaran`) REFERENCES `m12cpembayaraniklan` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpembayaraniklandetail_invoice` FOREIGN KEY (`Invoice`) REFERENCES `m12cinvoice` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpembayaraniklandetail_pph23` FOREIGN KEY (`PPh23Id`) REFERENCES `m07cpph23` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12dpencairankomisi` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Regional` smallint unsigned NOT NULL,
  `NoBukti` varchar(30) NOT NULL,
  `Tanggal` date NOT NULL,
  `CaraBayar` int unsigned NOT NULL,
  `Sales` int unsigned NOT NULL,
  `Keterangan` varchar(255) NOT NULL,
  `GlId` bigint unsigned NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12dpencairankomisi_code` (`NoBukti`),
  CONSTRAINT `fk_12dpencairankomisi_sales` FOREIGN KEY (`Sales`) REFERENCES `m12asales` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpencairankomisi_carabayar` FOREIGN KEY (`CaraBayar`) REFERENCES `m12acarabayar` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpencairankomisi_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpencairankomisi_gl` FOREIGN KEY (`GlId`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12epencairankomisidetail` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `PencairanKomisi` bigint unsigned NOT NULL,
  `Komisi` bigint unsigned NOT NULL,
  `NominalCair` double NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `PPh21KomisiId` bigint unsigned DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_12epencairankomisidetail_pencairankomisi` FOREIGN KEY (`PencairanKomisi`) REFERENCES `m12dpencairankomisi` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_12epencairankomisidetail_komisi` FOREIGN KEY (`Komisi`) REFERENCES `m12dpembayaraniklandetail` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpencairankomisidetail_pph21` FOREIGN KEY (`PPh21KomisiId`) REFERENCES `m07cpph21komisi` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12dpencairancashback` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Regional` smallint unsigned NOT NULL,
  `NoBukti` varchar(30) NOT NULL,
  `Tanggal` date NOT NULL,
  `CaraBayar` int unsigned NOT NULL,
  `Pemasang` varchar(100) NOT NULL,
  `Keterangan` varchar(255) NOT NULL,
  `GlId` bigint unsigned NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12dpencairancashback_code` (`NoBukti`),
  CONSTRAINT `fk_12dpencairancashback_carabayar` FOREIGN KEY (`CaraBayar`) REFERENCES `m12acarabayar` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpencairancashback_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12dpencairancashback_gl` FOREIGN KEY (`GlId`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12epencairancashbackdetail` (
  `Id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `PencairanCashback` bigint unsigned NOT NULL,
  `Cashback` bigint unsigned NOT NULL,
  `NominalCair` double NOT NULL DEFAULT 0,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_12epencairancashbackdetail_pencairancashback` FOREIGN KEY (`PencairanCashback`) REFERENCES `m12dpencairancashback` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_12epencairancashbackdetail_cashback` FOREIGN KEY (`Cashback`) REFERENCES `m12dpembayaraniklandetail` (`Id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE `m12zmapakun` (
  `Id` smallint unsigned NOT NULL AUTO_INCREMENT,
  `TipeIklan` tinyint unsigned NOT NULL,
  `Regional` smallint unsigned NOT NULL,
  `AkunPiutang` int unsigned DEFAULT NULL,
  `AkunPendapatan` int unsigned DEFAULT NULL,
  `AkunDiskon` int unsigned DEFAULT NULL,
  `Keterangan` varchar(255) DEFAULT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `m12zmapakun_code` (`TipeIklan`,`Regional`),
  CONSTRAINT `fk_12zmapakun_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_12zmapakun_akunpiutang` FOREIGN KEY (`AkunPiutang`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12zmapakun_akunpendapatan` FOREIGN KEY (`AkunPendapatan`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12zmapakun_akundiskon` FOREIGN KEY (`AkunDiskon`) REFERENCES `m01bcoa` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `m12zmapgl` (
  `Id` int unsigned NOT NULL AUTO_INCREMENT,
  `Tahun` year NOT NULL,
  `Bulan` tinyint(3) unsigned NOT NULL,
  `Regional` smallint unsigned DEFAULT NULL,
  `GlId` bigint unsigned NOT NULL,
  `created_date` datetime NOT NULL,
  `created_user` varchar(100) NOT NULL,
  `last_date` datetime NOT NULL,
  `last_modified` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`),
  CONSTRAINT `fk_12zmapgl_regional` FOREIGN KEY (`Regional`) REFERENCES `a_regional` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `fk_12zmapgl_gl` FOREIGN KEY (`GlId`) REFERENCES `m01cmaingl` (`p_id`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

DROP FUNCTION IF EXISTS f12_getinvnetto;
CREATE FUNCTION `f12_getinvnetto`(Id BigInt unsigned, Netto double, PerTanggal date) RETURNS double
    READS SQL DATA
BEGIN
  DECLARE Gabungan DOUBLE;
  SELECT coalesce(sum(Netto),0) INTO Gabungan FROM m12cinvoice where (IndukInvoice=Id or KoreksiInvoice=Id) and TanggalOmzet <= PerTanggal;
  RETURN Netto + Gabungan;
END;

DROP FUNCTION IF EXISTS f12_getinvomzet;
CREATE FUNCTION `f12_getinvomzet`(Id BigInt unsigned, Omzet double, PerTanggal date) RETURNS double
    READS SQL DATA
BEGIN
  DECLARE Gabungan DOUBLE;
  SELECT coalesce(sum(Total),0) INTO Gabungan FROM m12cinvoice where (IndukInvoice=Id or KoreksiInvoice=Id) and TanggalOmzet <= PerTanggal;
  RETURN Omzet + Gabungan;
END;

DROP FUNCTION IF EXISTS f12_getinvppn;
CREATE FUNCTION `f12_getinvppn`(Id BigInt unsigned, PajakNominal double, PerTanggal date) RETURNS double
    READS SQL DATA
BEGIN
  DECLARE Gabungan DOUBLE;
  SELECT coalesce(sum(PajakNominal),0) INTO Gabungan FROM m12cinvoice where (IndukInvoice=Id or KoreksiInvoice=Id) and TanggalOmzet <= PerTanggal;
  RETURN PajakNominal + Gabungan;
END;

DROP FUNCTION IF EXISTS f12_getinvpaid;
CREATE FUNCTION `f12_getinvpaid`(InvoiceId BigInt unsigned, PerTanggal date) RETURNS double
    READS SQL DATA
BEGIN
  DECLARE BAYAR DOUBLE;
  SELECT coalesce(sum(NominalBayar),0) INTO BAYAR 
  FROM m12dpembayaraniklandetail e LEFT JOIN m12cpembayaraniklan d on e.Pembayaran=d.Id
  where e.Invoice=InvoiceId and d.Tanggal <= PerTanggal;
  RETURN BAYAR;
END;

DROP FUNCTION IF EXISTS f12_getkomisipaid;
CREATE FUNCTION `f12_getkomisipaid`(KomisiId BigInt unsigned, PerTanggal date) RETURNS double
    READS SQL DATA
BEGIN
  DECLARE BAYAR DOUBLE;
  SELECT coalesce(sum(NominalCair),0) INTO BAYAR 
  FROM m12epencairankomisidetail e LEFT JOIN m12dpencairankomisi d on e.PencairanKomisi=d.Id
  where e.Komisi=KomisiId and d.Tanggal <= PerTanggal;
  RETURN BAYAR;
END;

DROP FUNCTION IF EXISTS f12_getcashbackpaid;
CREATE FUNCTION `f12_getcashbackpaid`(CashbackId BigInt unsigned, PerTanggal date) RETURNS double
    READS SQL DATA
BEGIN
  DECLARE BAYAR DOUBLE;
  SELECT coalesce(sum(NominalCair),0) INTO BAYAR 
  FROM m12epencairancashbackdetail e LEFT JOIN m12dpencairancashback d on e.PencairanCashback=d.Id
  where e.Cashback=CashbackId and d.Tanggal <= PerTanggal;
  RETURN BAYAR;
END;


insert into `modulelist`(`p_id`,`u_code`,`d_name`,`d_description`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12,'Nusoft012','Iklan Koran',null,'2020-08-14 23:32:03','NuSoft - NuSoft Administrator','2020-09-19 08:33:18','NuSoft - NuSoft Administrator');

insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12000,12,'12','Iklan',null,1,12,'2020-08-15 21:14:43','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12100,12,'1201','Transaksi',12000,1,1,'2020-09-11 15:03:51','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12101,12,'1201.01','Saldo Awal',12100,1,1,'2020-09-11 15:05:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12102,12,'1201.02','Iklan Kolom',12100,1,2,'2020-09-11 15:05:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12103,12,'1201.03','Iklan Deret',12100,1,3,'2020-09-11 15:05:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12104,12,'1201.04','Penagihan Iklan',12100,1,4,'2020-09-11 15:07:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12105,12,'1201.05','Gabung Iklan',12100,1,5,'2020-09-15 00:00:00','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12106,12,'1201.06','Koreksi Omzet',12100,1,6,'2020-09-11 15:07:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12107,12,'1201.07','Pembayaran Iklan',12100,1,7,'2020-09-11 15:07:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12108,12,'1201.08','Batal Bayar',12100,1,8,'2020-09-14 21:15:41','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12109,12,'1201.09','Pencairan Komisi',12100,1,9,'2020-09-14 21:15:41','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12110,12,'1201.10','Pencairan Cashback',12100,1,10,'2020-09-14 21:15:41','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12200,12,'1202','Utility',12000,1,2,'2020-09-11 15:07:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12201,12,'1202.01','Warning Terbit',12200,1,1,'2020-09-11 15:08:05','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12202,12,'1202.02','Edit Materi',12200,1,2,'2020-09-11 15:08:05','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12203,12,'1202.03','PraCetak',12200,1,3,'2020-09-11 15:08:05','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12204,12,'1202.04','Faktur Pajak',12200,1,4,'2020-10-04 07:59:18','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12300,12,'1203','Data Iklan',12000,1,3,'2020-09-11 15:07:04','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12301,12,'1203.01','Rekap Omzet',12300,1,1,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12302,12,'1203.02','Rincian Omzet',12300,1,2,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12303,12,'1203.03','Rekap Pembayaran',12300,1,3,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12304,12,'1203.04','Rincian Pembayaran',12300,1,4,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12305,12,'1203.05','Rekap Piutang',12300,1,5,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12306,12,'1203.06','Rincian Piutang',12300,1,6,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12307,12,'1203.07','Piutang Berjalan',12300,1,7,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12308,12,'1203.08','Piutang Jatuh Tempo',12300,1,8,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12309,12,'1203.09','Rekap Umur Piutang',12300,1,9,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12310,12,'1203.10','Rincian Umur Piutang',12300,1,10,'2020-09-11 15:11:45','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12400,12,'1204','Data Komisi',12000,1,4,'2020-09-14 21:23:08','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12401,12,'1204.01','Rekap Komisi',12400,1,1,'2020-09-14 21:25:21','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12402,12,'1204.02','Rincian Komisi',12400,1,2,'2020-09-14 21:25:21','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12403,12,'1204.03','Rekap Pencairan Komisi',12400,1,3,'2020-09-14 21:25:21','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12404,12,'1204.04','Rincian Pencairan Komisi',12400,1,4,'2020-09-14 21:25:21','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12405,12,'1204.05','Rekap Hutang Komisi',12400,1,5,'2020-09-14 21:25:21','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12406,12,'1204.06','Rincian Hutang Komisi',12400,1,6,'2020-09-14 21:25:21','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12500,12,'1205','Data Cashback',12000,1,5,'2020-09-14 21:23:08','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12501,12,'1205.01','Rekap Cashback',12500,1,1,'2020-09-14 21:27:35','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12502,12,'1205.02','Rincian Cashback',12500,1,2,'2020-09-14 21:27:35','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12503,12,'1205.03','Rekap Pencairan Cashback',12500,1,3,'2020-09-14 21:27:35','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12504,12,'1205.04','Rincian Pencairan Cashback',12500,1,4,'2020-09-14 21:27:35','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12505,12,'1205.05','Rekap Hutang Cashback',12500,1,5,'2020-09-14 21:27:35','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12506,12,'1205.06','Rincian Hutang Cashback',12500,1,6,'2020-09-14 21:27:35','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12970,12,'1298','Master Data',12000,1,98,'2020-08-15 21:17:19','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12971,12,'1298.01','Kelompok Omzet',12970,1,1,'2020-09-11 11:56:14','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12972,12,'1298.02','Wilayah',12970,1,2,'2020-09-11 11:56:14','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12973,12,'1298.03','Kontak',12970,1,3,'2020-09-11 11:58:46','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12974,12,'1298.04','Adm. Iklan',12970,1,4,'2020-09-11 11:58:46','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12975,12,'1298.05','Lain-Lain',12970,1,5,'2020-09-11 11:58:46','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12980,12,'1298.03.01','Sales',12973,1,1,'2020-09-11 12:03:58','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12981,12,'1298.03.02','Pemasang',12973,1,2,'2020-09-11 12:03:58','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12982,12,'1298.04.01','Tipe Invoice',12974,1,1,'2020-09-11 12:03:58','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12983,12,'1298.04.02','Cara Bayar',12974,1,2,'2020-09-11 12:03:58','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12984,12,'1298.04.03','Tarif Iklan',12974,1,3,'2020-09-11 12:03:58','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12985,12,'1298.05.01','Produk',12975,1,1,'2020-09-11 12:05:47','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12986,12,'1298.05.02','Merk',12975,1,2,'2020-09-11 12:05:47','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12987,12,'1298.05.03','Kurir',12975,1,3,'2020-09-11 12:05:47','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12990,12,'1299','Setting',12000,1,99,'2020-08-15 21:16:08','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12991,12,'1299.01','Konfigurasi',12990,1,1,'2020-08-15 21:16:44','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');
insert into `menulist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_active`,`d_order`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12992,12,'1299.02','Integrasi Keuangan',12990,1,2,'2020-08-31 12:13:15','NuSoft - NuSoft Administrator','2020-10-04 07:59:18','NuSoft - NuSoft Administrator');

insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12000,12,'12','Iklan',null,null,1,12,null,'2020-09-11 15:13:35','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12100,12,'1201','Transaksi',12000,null,1,1,null,'2020-09-11 15:15:25','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12101,12,'1201.01','Invoice Kolom',12100,'12TransaksiInvoiceKolom.repx',1,1,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12102,12,'1201.02','Invoice Deret',12100,'12TransaksiInvoiceDeret.repx',1,2,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12103,12,'1201.03','Invoice Gabungan',12100,'12TransaksiInvoiceGabungan.repx',1,3,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12104,12,'1201.04','Order Iklan',12100,'12TransaksiOrderIklan.repx',1,4,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12105,12,'1201.05','Tanda Terima',12100,'12TransaksiTandaTerima.repx',1,5,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12106,12,'1201.06','Kwitansi',12100,'12TransaksiKwitansi.repx',1,6,null,'2020-10-08 16:36:56','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12107,12,'1201.07','Surat Komisi',12100,'12TransaksiSuratKomisi.repx',1,7,null,'2020-10-08 16:36:56','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12108,12,'1201.08','Surat Cashback',12100,'12TransaksiSuratCashback.repx',1,8,null,'2020-10-08 16:36:56','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12109,12,'1201.09','Bukti Pencairan Komisi',12100,'12TransaksiPencairanKomisi.repx',1,9,null,'2020-10-08 16:36:56','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12110,12,'1201.10','Bukti Pencairan Cashback',12100,'12TransaksiPencairanCashback.repx',1,10,null,'2020-10-09 12:30:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12200,12,'1202','Piutang',12000,null,1,2,null,'2020-09-11 15:15:25','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12201,12,'1202.01','Iklan Termuat (Kolom)',12200,'12PiutangIklanTermuatKolom.repx',1,1,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:44','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12202,12,'1202.02','Iklan Termuat (Deret)',12200,'12PiutangIklanTermuatDeret.repx',1,2,null,'2020-09-11 15:25:42','NuSoft - NuSoft Administrator','2020-10-10 07:01:44','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12203,12,'1202.03','Penerimaan Pembayaran',12200,'12PiutangPenerimaanPembayaran.repx',1,3,null,'2020-09-11 15:31:41','NuSoft - NuSoft Administrator','2020-10-10 07:01:44','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12204,12,'1202.04','Rincian Pembayaran',12200,'12PiutangRincianPembayaran.repx',1,4,null,'2020-09-11 15:31:41','NuSoft - NuSoft Administrator','2020-10-10 07:01:44','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12205,12,'1202.05','Piutang Jatuh Tempo',12200,'12PiutangJatuhTempo.repx',1,5,null,'2020-09-11 15:31:41','NuSoft - NuSoft Administrator','2020-10-10 07:01:44','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12206,12,'1202.06','Konfirmasi Piutang',12200,'12PiutangKonfirmasiPiutang.repx',1,6,null,'2020-09-11 15:31:41','NuSoft - NuSoft Administrator','2020-10-10 07:01:44','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12300,12,'1203','Laporan Bulanan',12000,null,1,3,null,'2020-09-11 15:15:25','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12301,12,'1203.01','Rekap Omzet',12300,'12BulananRekapOmzet.repx',1,1,null,'2020-09-11 15:34:28','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12302,12,'1203.02','Rincian Omzet',12300,'12BulananRincianOmzet.repx',1,2,null,'2020-09-11 15:34:28','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12303,12,'1203.03','Rekap Pembayaran',12300,'12BulananRekapPembayaran.repx',1,3,null,'2020-09-11 15:34:28','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12304,12,'1203.04','Rincian Pembayaran',12300,'12BulananRincianPembayaran.repx',1,4,null,'2020-09-11 15:34:28','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12305,12,'1203.05','Rekap Piutang',12300,'12BulananRekapPiutang.repx',1,5,null,'2020-09-11 15:34:28','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12306,12,'1203.06','Rincian Piutang',12300,'12BulananRincianPiutang.repx',1,6,null,'2020-09-11 15:34:28','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12307,12,'1203.07','Rekap Hutang Komisi',12300,'12BulananRekapHutangKomisi.repx',1,7,null,'2020-10-10 06:16:34','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12308,12,'1203.08','Rincian Hutang Komisi',12300,'12BulananRincianHutangKomisi.repx',1,8,null,'2020-10-10 06:16:34','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12309,12,'1203.09','Rekap Hutang Cashback',12300,'12BulananRekapCashback.repx',1,9,null,'2020-10-10 06:16:34','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
insert into `reportlist`(`p_id`,`f_module`,`u_code`,`d_name`,`d_parent`,`d_filename`,`d_active`,`d_order`,`d_note`,`created_date`,`created_user`,`last_date`,`last_modified`) values (12310,12,'1203.10','Rincian Hutang Cashback',12300,'12BulananRincianCashback.repx',1,10,null,'2020-10-10 06:16:34','NuSoft - NuSoft Administrator','2020-10-10 07:01:45','NuSoft - NuSoft Administrator');
