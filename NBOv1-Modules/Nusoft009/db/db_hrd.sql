/*******************************************************************************
 * Database character set: latin1
 * Server version: 5.5
 * Server version build: 5.5.5-10.6.11-MariaDB
 ******************************************************************************/

/*******************************************************************************
 * Selected metadata objects
 * -------------------------
 * Extracted at 29/07/2023 05.20.01
 ******************************************************************************/

/*******************************************************************************
 * Tables
 * ------
 * Extracted at 29/07/2023 05.20.01
 ******************************************************************************/

CREATE TABLE a_blob (
  p_id          Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  d_filename    VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_size        MediumInt(8) UNSIGNED NOT NULL DEFAULT 0,
  d_blob        MediumBLOB NOT NULL,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE a_blob COMMENT = 'Tabel untuk menyimpan gambar dari semua module';
CREATE TABLE a_division (
  p_id          SmallInt(5) UNSIGNED NOT NULL,
  u_code        VarChar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_name        VarChar(150) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE a_division COMMENT = 'Tabel untuk mendata data divisi.';
CREATE TABLE a_regional (
  p_id          SmallInt(5) UNSIGNED NOT NULL,
  u_code        VarChar(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_name        VarChar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_address     VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_city        VarChar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_province    VarChar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_postal      VarChar(10) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_note        VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_coaar       Integer(10) UNSIGNED,
  d_coaap       Integer(10) UNSIGNED
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE a_regional COMMENT = 'Tabel untuk mendata wilayah kerja';
CREATE TABLE a_setting (
  p_id          Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  u_module      SmallInt(6) NOT NULL,
  u_code        VarChar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_value       VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_note        VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=152 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE a_setting COMMENT = 'Tabel system untuk menyimpan setting aplikasi dari modul.';
CREATE TABLE a_source (
  p_id     SmallInt(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  u_code   VarChar(3) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_note   VarChar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_link   TinyInt(1),
  x_module Integer(11)
) ENGINE=InnoDB AUTO_INCREMENT=103 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE a_source COMMENT = '';
CREATE TABLE datalog_amain (
  p_id              BigInt(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  d_date            DateTime NOT NULL,
  d_user            VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_kind            TinyInt(1) UNSIGNED NOT NULL,
  d_activity        VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_useragent       VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_userhostaddress VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_userhostname    VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_tablename       VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_rowid           VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_uniquedata      VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  UniqueId          VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE datalog_amain COMMENT = '';
CREATE TABLE datalog_bdetail (
  p_id          BigInt(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  f_main        BigInt(20) UNSIGNED NOT NULL,
  property_name VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  value_old     Text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  value_new     Text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=129437 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE datalog_bdetail COMMENT = '';
CREATE TABLE dtaprovince (
  p_id          SmallInt(5) UNSIGNED,
  u_code        VarChar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  d_note        VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  last_date     DateTime,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE dtaprovince COMMENT = '';
CREATE TABLE dtbdistrict (
  p_id          SmallInt(5) UNSIGNED NOT NULL,
  f_province    SmallInt(5) UNSIGNED NOT NULL,
  u_code        VarChar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_note        VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE dtbdistrict COMMENT = 'Tabel untuk menyimpan data kabupaten';
CREATE TABLE dtcsubdistrict (
  p_id          Integer(10) UNSIGNED NOT NULL,
  f_district    SmallInt(5) UNSIGNED NOT NULL,
  u_code        VarChar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_note        VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE dtcsubdistrict COMMENT = 'Tabel untuk menyimpan data kecamatan';
CREATE TABLE dtdvillage (
  p_id          Integer(10) UNSIGNED NOT NULL,
  f_subdistrict Integer(10) UNSIGNED NOT NULL,
  u_code        VarChar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  d_note        VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE dtdvillage COMMENT = 'Tabel untuk menyimpan data desa';
CREATE TABLE keypages (
  unique_form VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  unique_rgnl VarChar(3) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE keypages COMMENT = '';
CREATE TABLE m09_absensi (
  p_id              Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  f_karyawan        Integer(11) NOT NULL,
  u_tanggal         Date NOT NULL,
  d_jammasuk        Time,
  d_jampulang       Time,
  f_status          SmallInt(6) DEFAULT 0,
  d_catatan         VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_divisi          SmallInt(6),
  f_shift           SmallInt(5) UNSIGNED,
  d_hk              SmallInt(6),
  d_lembur          SmallInt(6),
  d_lemburpengganti SmallInt(6),
  d_liburnasional   SmallInt(6),
  d_cutibesar       SmallInt(6),
  f_jadwalproduksi  Integer(11),
  d_lupaabsen       SmallInt(6),
  d_reimbusmakan    SmallInt(6),
  d_jamkerjamasuk   Time,
  d_jamkerjapulang  Time,
  created_user      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date      DateTime,
  last_modified     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date         DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_absensi COMMENT = '';
CREATE TABLE m09_absensilupa (
  p_id          Integer(11) NOT NULL AUTO_INCREMENT,
  f_karyawan    Integer(11) NOT NULL,
  d_tanggal     Date NOT NULL,
  d_jammasuk    Time,
  d_jamkeluar   Time,
  d_keterangan  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime,
  d_approve     SmallInt DEFAULT 0
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_absensilupa COMMENT = '';
CREATE TABLE m09_absensitipe (
  p_id          SmallInt(6) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_absensitipe COMMENT = '';
CREATE TABLE m09_dayoff (
  p_id          Integer(11) NOT NULL AUTO_INCREMENT,
  u_tanggal     Date NOT NULL,
  d_keterangan  VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_lebaran     SmallInt(6) NOT NULL,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_dayoff COMMENT = '';
CREATE TABLE m09_ijin (
  p_id             Integer(11) NOT NULL AUTO_INCREMENT,
  u_year           SmallInt(6),
  u_month          SmallInt(6),
  u_source         SmallInt(6),
  u_sequence       SmallInt(6),
  u_code           VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  d_date           Date NOT NULL,
  f_karyawan       Integer(11) NOT NULL,
  d_jenis          SmallInt(6) NOT NULL,
  d_cutimendadak   SmallInt(6) DEFAULT 0,
  f_cutimaster     Integer(10) UNSIGNED,
  d_cutibesar      SmallInt(6) DEFAULT 0,
  d_cutikompensasi SmallInt(6) DEFAULT 0,
  f_cutipengajuan  Integer(11),
  d_tanggalawal    Date,
  d_tanggalakhir   Date,
  d_keterangan     VarChar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_jamawal        Time,
  d_jamakhir       Time,
  d_jumlahhari     SmallInt(6) DEFAULT 0,
  d_reimbusmakan   SmallInt(6) DEFAULT 0,
  created_user     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date     DateTime,
  last_modified    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date        DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_ijin COMMENT = '';
CREATE TABLE m09_ijindetail (
  primary_main       Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  p_id               Integer(11) NOT NULL,
  d_tanggal          Date,
  f_absesitipe       SmallInt(6),
  d_tanggalpengganti Date,
  f_cutimaster       Integer(10) UNSIGNED,
  d_cutikompensasi   SmallInt(6),
  d_reimbusmakan     SmallInt(6),
  created_user       VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date       DateTime,
  last_modified      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date          DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_ijindetail COMMENT = '';
CREATE TABLE m09_jadwalproduksi (
  p_id           Integer(11) NOT NULL AUTO_INCREMENT,
  d_jenis        SmallInt(6),
  d_tahun        SmallInt(6),
  d_tanggalawal  Date,
  d_tanggalakhir Date,
  f_divisi       SmallInt(5) UNSIGNED,
  d_status       SmallInt(5) UNSIGNED,
  d_p1           SmallInt(5) UNSIGNED,
  d_p2           SmallInt(5) UNSIGNED,
  d_p3           SmallInt(5) UNSIGNED,
  d_p4           SmallInt(5) UNSIGNED,
  d_p5           SmallInt(5) UNSIGNED,
  d_p6           SmallInt(5) UNSIGNED,
  d_p7           SmallInt(5) UNSIGNED,
  d_p8           SmallInt(5) UNSIGNED,
  d_p9           SmallInt(5) UNSIGNED,
  d_p10          SmallInt(5) UNSIGNED,
  d_p11          SmallInt(5) UNSIGNED,
  d_p12          SmallInt(5) UNSIGNED,
  d_p13          SmallInt(5) UNSIGNED,
  d_p14          SmallInt(5) UNSIGNED,
  created_user   VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date   DateTime,
  last_modified  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date      DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_jadwalproduksi COMMENT = '';
CREATE TABLE m09_karyawan (
  p_id               Integer(11) NOT NULL AUTO_INCREMENT,
  u_kode             VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  d_nama             VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_absensiid        Integer(11),
  f_divisi           SmallInt(6),
  f_jabatan          SmallInt(6),
  d_tanggallahir     Date,
  d_tanggaljoin      Date,
  d_gender           SmallInt(6),
  d_jenis            SmallInt(6),
  d_negara           VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_statusnikah      SmallInt(6),
  d_jumlahanak       SmallInt(6),
  d_telp             VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nohp             VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_email            VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_telpemergency    VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_agama            SmallInt(6),
  d_tempatlahir      VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_alamat           VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bank             VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bankac           VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bankname         VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikan       VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikannama   VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikanstudi  VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikandari   VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikansampai VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_noktp            VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nonpwp           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nobpjstk         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nobpjskesehatan  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_catatan          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_statuspajak      SmallInt(1) UNSIGNED,
  d_alamatktp        VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_namaibu          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_namaayah         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_office           SmallInt(6),
  d_groupproduksi    SmallInt(6),
  f_golongan         SmallInt(6),
  f_kehadiran        SmallInt(6),
  d_iurankop         Double,
  d_iuranserikat     Double,
  d_iuranserikatnama VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_management       SmallInt(6),
  d_password         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_promosi          Integer(10) UNSIGNED,
  created_user       VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date       DateTime,
  last_modified      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date          DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_karyawan COMMENT = '';
CREATE TABLE m09_karyawankeluarga (
  p_id           BigInt(20) NOT NULL AUTO_INCREMENT,
  f_karyawan     Integer(11) NOT NULL,
  d_jenis        SmallInt(6),
  d_nama         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_tanggallahir Date,
  created_user   VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date   DateTime,
  last_modified  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date      DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_karyawankeluarga COMMENT = '';
CREATE TABLE m09_karyawanlembur (
  p_id                Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  f_karyawan          Integer(11),
  f_golongan          SmallInt(6),
  f_divisi            SmallInt(6),
  f_pengajuanlembur   Integer(10) UNSIGNED,
  d_tanggal           Date,
  f_absensi           Integer(10) UNSIGNED,
  d_jammulai          Time,
  d_jamselesai        Time,
  d_catatan           VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_gajipokok         Double DEFAULT 0,
  d_nilai             Double DEFAULT 0,
  d_nilailembur       Double DEFAULT 0,
  d_jumlahjam         Double DEFAULT 0,
  d_jumlahistirahat   Double DEFAULT 0,
  d_lembur1           Double DEFAULT 0,
  d_lembur2           Double DEFAULT 0,
  d_lembur3           Double DEFAULT 0,
  d_lembur4           Double DEFAULT 0,
  d_jenis             SmallInt(6) DEFAULT 0,
  d_overlembur        SmallInt(6) DEFAULT 0,
  d_nilai7a           Double DEFAULT 0,
  d_tunjanganshift    Double DEFAULT 0,
  d_transport         SmallInt(6) DEFAULT 0,
  d_tunjanganshift2   SmallInt(6) DEFAULT 0,
  d_tunjanganshift3   SmallInt(6) DEFAULT 0,
  d_nilailemburmanual Double DEFAULT 0,
  d_jagamesin         SmallInt(6) DEFAULT 0,
  created_user        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date        DateTime,
  last_modified       VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date           DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_karyawanlembur COMMENT = '';
CREATE TABLE m09_karyawanpindahdivisi (
  primary_main     Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  f_karyawan       Integer(11) NOT NULL,
  d_tanggal        Date NOT NULL,
  f_divisi         SmallInt(6) NOT NULL,
  d_catatan        VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_jadwalproduksi Integer(11),
  created_user     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date     DateTime,
  last_modified    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date        DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_karyawanpindahdivisi COMMENT = '';
CREATE TABLE m09_mastercuti (
  p_id             Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  u_tahun          SmallInt(6) NOT NULL,
  u_tipe           SmallInt(6) NOT NULL DEFAULT 0,
  f_karyawan       Integer(11) NOT NULL,
  d_jumlah         SmallInt(6) DEFAULT 0,
  d_aktif          SmallInt(6) DEFAULT 0,
  d_tanggalexpired Date,
  created_user     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date     DateTime,
  last_modified    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date        DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_mastercuti COMMENT = '';
CREATE TABLE m09_masterdivisi (
  p_id              SmallInt(6) NOT NULL AUTO_INCREMENT,
  u_kode            VarChar(25) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  d_nama            VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_shift           SmallInt(6),
  d_leader          VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_supervisor      VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_manager         VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_managerasistent VarChar(150) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_aktif           SmallInt(6) DEFAULT 0,
  created_user      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date      DateTime,
  last_modified     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date         DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_masterdivisi COMMENT = '';
CREATE TABLE m09_mastergolongan (
  p_id          SmallInt(6) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_lembur      SmallInt(6),
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_mastergolongan COMMENT = '';
CREATE TABLE m09_masterijin (
  p_id          SmallInt(6) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama        VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_lama        SmallInt(6) DEFAULT 0,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_masterijin COMMENT = '';
CREATE TABLE m09_masterjabatan (
  p_id                   SmallInt(6) NOT NULL AUTO_INCREMENT,
  u_kode                 VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama                 VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_gajipokok            Double DEFAULT 0,
  d_tunjanganjabatan     Double DEFAULT 0,
  d_tunjanganlain        Double DEFAULT 0,
  d_tunjangantenagakerja Double DEFAULT 0,
  d_tunjangangolongan    Double DEFAULT 0,
  d_tunjangankesehatan   Double DEFAULT 0,
  d_pottenagakerja       Double DEFAULT 0,
  d_potkesehatan         Double DEFAULT 0,
  d_potpensiun           Double DEFAULT 0,
  d_potlain              Double DEFAULT 0,
  created_user           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date           DateTime,
  last_modified          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date              DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_masterjabatan COMMENT = '';
CREATE TABLE m09_masterkehadiran (
  p_id          SmallInt(6) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(5) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nilai       Double DEFAULT 0,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_masterkehadiran COMMENT = '';
CREATE TABLE m09_masterpajak (
  p_id          SmallInt(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(10) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama        VarChar(50) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nilaiptkp   Double DEFAULT 0,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_masterpajak COMMENT = '';
CREATE TABLE m09_mastershift (
  p_id          SmallInt(5) UNSIGNED NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(15) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_jammasuk    Time,
  d_jampulang   Time,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=5 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_mastershift COMMENT = '';
CREATE TABLE m09_pengajuancuti (
  p_id            Integer(11) NOT NULL AUTO_INCREMENT,
  u_source        SmallInt(6),
  u_year          SmallInt(6),
  u_month         SmallInt(6),
  u_sequence      SmallInt(6),
  u_code          VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_date          Date,
  f_karyawan      Integer(11),
  d_tanggalawal   Date,
  d_tanggalakhir  Date,
  d_keterangan    VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_cutibesar     SmallInt(6) DEFAULT 0,
  d_jumlahhari    SmallInt(6) DEFAULT 0,
  d_cutidadakan   SmallInt(6) DEFAULT 0,
  d_status        SmallInt(6) DEFAULT 0,
  d_keteranganapp VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_mastercuti    Integer(10) UNSIGNED,
  created_user    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date    DateTime,
  last_modified   VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date       DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_pengajuancuti COMMENT = '';
CREATE TABLE m09_pengajuancuti_tanggal (
  primary_main  Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  p_id          Integer(11) NOT NULL,
  d_tanggal     Date,
  d_absensi     Integer(10) UNSIGNED,
  f_statusabsen SmallInt(6),
  f_mastercuti  Integer(10) UNSIGNED,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_pengajuancuti_tanggal COMMENT = '';
CREATE TABLE m09_pengajuanlembur (
  p_id            Integer(11) NOT NULL AUTO_INCREMENT,
  u_year          SmallInt(6),
  u_month         SmallInt(6),
  u_sequence      SmallInt(6),
  u_code          VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_date          Date,
  f_divisi        SmallInt(6),
  d_tanggallembur Date,
  d_keterangan    VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_tanggalapp1   Date,
  d_tanggalapp2   Date,
  d_status        SmallInt(6) DEFAULT 0,
  created_user    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date    DateTime,
  last_modified   VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date       DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_pengajuanlembur COMMENT = '';
CREATE TABLE m09_pengajuanlembur_detail (
  primary_main        Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  p_id                Integer(11) NOT NULL,
  f_karyawan          Integer(11) NOT NULL,
  d_jamawal           Time,
  d_jamakhir          Time,
  d_pekerjaan         VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bersedia          SmallInt(6) DEFAULT 0,
  d_karyawanrealisasi Integer(11),
  d_jamawalrealisasi  Time,
  d_jamakhirrealisasi Time,
  d_keterangan        VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_status            SmallInt(6) DEFAULT 0,
  d_tukarcuti         SmallInt(6) DEFAULT 0,
  d_lemburwajib       SmallInt(6) DEFAULT 0,
  d_liburpengganti    SmallInt(6) DEFAULT 0,
  d_uangmakan         SmallInt(6) DEFAULT 0,
  d_shift2            SmallInt(6) DEFAULT 0,
  d_shift3            SmallInt(6) DEFAULT 0,
  d_potongan          Integer(11) DEFAULT 0,
  d_jagamesin         SmallInt(6) DEFAULT 0,
  f_absensi           Integer(10) UNSIGNED NOT NULL,
  created_user        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date        DateTime,
  last_modified       VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date           DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_pengajuanlembur_detail COMMENT = '';
CREATE TABLE m09_pinjaman (
  p_id                  Integer(11) NOT NULL AUTO_INCREMENT,
  u_year                SmallInt(6),
  u_month               SmallInt(6),
  u_source              SmallInt(6),
  u_sequence            SmallInt(6),
  u_code                VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_karyawan            Integer(11),
  d_jenis               SmallInt(6),
  d_nilai               Double DEFAULT 0,
  d_lama                SmallInt(6) DEFAULT 0,
  d_status              SmallInt(6) DEFAULT 0,
  d_tanggalpencairan    Date,
  d_tanggalapprove      Date,
  d_tanggalpotonganawal Date,
  d_keterangan          VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_user          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date          DateTime,
  last_modified         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date             DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_pinjaman COMMENT = '';
CREATE TABLE m09_pinjaman_detail (
  primary_main  BigInt(20) NOT NULL AUTO_INCREMENT,
  p_id          Integer(11) NOT NULL,
  d_tanggal     Date,
  d_nilai       Double,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_pinjaman_detail COMMENT = '';
CREATE TABLE m09_promosikaryawan (
  p_id             Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  f_karyawan       Integer(11) NOT NULL,
  d_tanggal        Date NOT NULL,
  d_catatan        VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_jabatan        SmallInt(6) DEFAULT 0,
  d_gajipokok      Double DEFAULT 0,
  d_tunjabatan     Double DEFAULT 0,
  d_tunlain        Double DEFAULT 0,
  d_tuntenagakerja Double DEFAULT 0,
  d_tungolongan    Double DEFAULT 0,
  d_pokesehatan    Double DEFAULT 0,
  d_potpensiun     Double DEFAULT 0,
  d_potlain        Double DEFAULT 0,
  d_premikehadiran Double DEFAULT 0,
  d_jenis          SmallInt(6),
  created_user     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date     DateTime,
  last_modified    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date        DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_promosikaryawan COMMENT = '';
CREATE TABLE m09_resign (
  p_id          Integer(11) NOT NULL AUTO_INCREMENT,
  u_year        SmallInt(6),
  u_month       SmallInt(6),
  u_source      SmallInt(6),
  u_sequence    SmallInt(6),
  u_code        VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_date        Date,
  f_karyawan    Integer(11),
  d_catatan     VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_tipe        SmallInt(6),
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_resign COMMENT = '';
CREATE TABLE m09_suratperingatan (
  p_id          Integer(11) NOT NULL AUTO_INCREMENT,
  u_year        SmallInt(6),
  u_month       SmallInt(6),
  u_source      SmallInt(6),
  u_sequence    SmallInt(6),
  u_code        VarChar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_date        Date,
  f_karyawan    Integer(11),
  d_jenis       SmallInt(6),
  d_expired     Date,
  d_keterangan  VarChar(250) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  created_date  DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
ALTER TABLE m09_suratperingatan COMMENT = '';
CREATE TABLE npolog (
  Id          BigInt(20) UNSIGNED NOT NULL,
  ServerDate  DateTime NOT NULL,
  TableName   VarChar(64) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  RowId       BigInt(20) UNSIGNED,
  Changes     Text CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  User        VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  Action      TinyInt(2) NOT NULL,
  UIAgent     VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  HostAddress VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  HostName    VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE npolog COMMENT = '';
CREATE TABLE setting (
  Id            Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  Code          VarChar(30) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  Value         VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  created_date  DateTime NOT NULL,
  created_user  VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  last_date     DateTime NOT NULL,
  last_modified VarChar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE setting COMMENT = '';
CREATE TABLE xpobjecttype (
  OID          Integer(10) UNSIGNED NOT NULL AUTO_INCREMENT,
  TypeName     VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  AssemblyName VarChar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE xpobjecttype COMMENT = '';
CREATE TABLE xtempsa (
  pid      Integer(11) NOT NULL AUTO_INCREMENT,
  pcoa     VarChar(150) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  idcoa    Integer(11),
  idkontak Integer(11),
  nilai    Decimal(18, 4),
  dc       VarChar(2) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci,
  kontak   VarChar(150) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci;
ALTER TABLE xtempsa COMMENT = '';
CREATE TABLE m09_jadwalproduksi_detail (
  primary_main BigInt NOT NULL AUTO_INCREMENT,
  p_id         Integer NOT NULL,
  d_tanggal    Date NOT NULL,
  d_shift      SmallInt UNSIGNED
) ;
ALTER TABLE m09_jadwalproduksi_detail COMMENT = '';
/*******************************************************************************
 * Primary Key Constraints
 * -----------------------
 * Extracted at 29/07/2023 05.20.02
 ******************************************************************************/

ALTER TABLE a_blob ADD PRIMARY KEY 
    (p_id);

ALTER TABLE a_division ADD PRIMARY KEY 
    (p_id);

ALTER TABLE a_regional ADD PRIMARY KEY 
    (p_id);

ALTER TABLE a_setting ADD PRIMARY KEY 
    (p_id);

ALTER TABLE a_source ADD PRIMARY KEY 
    (p_id);

ALTER TABLE datalog_amain ADD PRIMARY KEY 
    (p_id);

ALTER TABLE datalog_bdetail ADD PRIMARY KEY 
    (p_id);

ALTER TABLE dtbdistrict ADD PRIMARY KEY 
    (p_id);

ALTER TABLE dtcsubdistrict ADD PRIMARY KEY 
    (p_id);

ALTER TABLE dtdvillage ADD PRIMARY KEY 
    (p_id);

ALTER TABLE keypages ADD PRIMARY KEY 
    (unique_form);

ALTER TABLE m09_absensi ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_absensilupa ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_absensitipe ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_dayoff ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_ijin ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_ijindetail ADD PRIMARY KEY 
    (primary_main);

ALTER TABLE m09_jadwalproduksi ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_karyawan ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_karyawankeluarga ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_karyawanlembur ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_karyawanpindahdivisi ADD PRIMARY KEY 
    (primary_main);

ALTER TABLE m09_mastercuti ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_masterdivisi ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_mastergolongan ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_masterijin ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_masterjabatan ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_masterkehadiran ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_masterpajak ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_mastershift ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_pengajuancuti ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_pengajuancuti_tanggal ADD PRIMARY KEY 
    (primary_main);

ALTER TABLE m09_pengajuanlembur ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_pengajuanlembur_detail ADD PRIMARY KEY 
    (primary_main);

ALTER TABLE m09_pinjaman ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_pinjaman_detail ADD PRIMARY KEY 
    (primary_main);

ALTER TABLE m09_promosikaryawan ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_resign ADD PRIMARY KEY 
    (p_id);

ALTER TABLE m09_suratperingatan ADD PRIMARY KEY 
    (p_id);

ALTER TABLE npolog ADD PRIMARY KEY 
    (Id);

ALTER TABLE setting ADD PRIMARY KEY 
    (Id);

ALTER TABLE xpobjecttype ADD PRIMARY KEY 
    (OID);

ALTER TABLE xtempsa ADD PRIMARY KEY 
    (pid);

ALTER TABLE m09_jadwalproduksi_detail ADD PRIMARY KEY 
    (primary_main);

/*******************************************************************************
 * Unique Constraints
 * ------------------
 * Extracted at 29/07/2023 05.20.02
 ******************************************************************************/

ALTER TABLE a_division ADD CONSTRAINT code UNIQUE 
    (u_code);

ALTER TABLE a_regional ADD CONSTRAINT code UNIQUE 
    (u_code);

ALTER TABLE a_setting ADD CONSTRAINT code UNIQUE 
    (u_module, u_code);

ALTER TABLE a_source ADD CONSTRAINT code_asource UNIQUE 
    (u_code, x_module);

ALTER TABLE dtbdistrict ADD CONSTRAINT code UNIQUE 
    (f_province, u_code);

ALTER TABLE dtcsubdistrict ADD CONSTRAINT code UNIQUE 
    (f_district, u_code);

ALTER TABLE dtdvillage ADD CONSTRAINT code UNIQUE 
    (f_subdistrict, u_code);

ALTER TABLE m09_absensi ADD CONSTRAINT u_m09_absensi UNIQUE 
    (f_karyawan, u_tanggal);

ALTER TABLE m09_dayoff ADD CONSTRAINT u_m09_dayoff UNIQUE 
    (u_tanggal);

ALTER TABLE m09_ijin ADD CONSTRAINT u_m09_ijin UNIQUE 
    (u_code);

ALTER TABLE m09_ijindetail ADD CONSTRAINT u_m09_ijindetail UNIQUE 
    (p_id, d_tanggal);

ALTER TABLE m09_karyawan ADD CONSTRAINT u_m09_karyawan UNIQUE 
    (u_kode);

ALTER TABLE m09_karyawanlembur ADD CONSTRAINT u_m09_karyawanlembur UNIQUE 
    (f_karyawan, d_tanggal, f_pengajuanlembur);

ALTER TABLE m09_mastercuti ADD CONSTRAINT u_m09_mastercuti UNIQUE 
    (u_tahun, u_tipe, f_karyawan);

ALTER TABLE m09_masterdivisi ADD CONSTRAINT u_m09_divisi UNIQUE 
    (u_kode);

ALTER TABLE m09_masterijin ADD CONSTRAINT u_m09_masterijin UNIQUE 
    (u_kode);

ALTER TABLE m09_masterjabatan ADD CONSTRAINT u_m09_jabatan UNIQUE 
    (u_kode);

ALTER TABLE m09_masterkehadiran ADD CONSTRAINT u_m09_masterkehadiran UNIQUE 
    (u_kode);

ALTER TABLE m09_mastershift ADD CONSTRAINT u_m09_mastershift UNIQUE 
    (u_kode);

ALTER TABLE m09_pengajuancuti ADD CONSTRAINT u_m09_pengajuancuti UNIQUE 
    (u_code);

ALTER TABLE m09_pengajuancuti_tanggal ADD CONSTRAINT u_m09_pengajuancuti_tanggal UNIQUE 
    (p_id, d_tanggal);

ALTER TABLE m09_pengajuanlembur ADD CONSTRAINT u_m09_pengajuanlembur UNIQUE 
    (u_code);

ALTER TABLE m09_pinjaman ADD CONSTRAINT u_m09_pinjaman UNIQUE 
    (u_code);

ALTER TABLE m09_pinjaman_detail ADD CONSTRAINT u_m09_pinjaman_detail UNIQUE 
    (p_id, d_tanggal);

ALTER TABLE m09_resign ADD CONSTRAINT u_m09_resign UNIQUE 
    (u_code);

ALTER TABLE m09_suratperingatan ADD CONSTRAINT u_m09_suratperingatan UNIQUE 
    (u_code);

ALTER TABLE m09_jadwalproduksi_detail ADD CONSTRAINT u_m09_jadwalproduksi_detail UNIQUE 
    (p_id, d_tanggal);

/*******************************************************************************
 * Foreign Key Constraints
 * -----------------------
 * Extracted at 29/07/2023 05.20.02
 ******************************************************************************/

ALTER TABLE m09_absensi ADD CONSTRAINT fk_m09_absensi_m09_absensitipe FOREIGN KEY (f_status)
  REFERENCES m09_absensitipe (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_absensi ADD CONSTRAINT fk_m09_absensi_m09_divisi FOREIGN KEY (f_divisi)
  REFERENCES m09_masterdivisi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_absensi ADD CONSTRAINT FK_m09_absensi_m09_jadwalproduksi FOREIGN KEY (f_jadwalproduksi)
  REFERENCES m09_jadwalproduksi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_absensi ADD CONSTRAINT fk_m09_absensi_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_absensi ADD CONSTRAINT FK_m09_absensi_m09_mastershift FOREIGN KEY (f_shift)
  REFERENCES m09_mastershift (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_ijin ADD CONSTRAINT fk_m09_ijin_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_ijin ADD CONSTRAINT fk_m09_ijin_m09_mastercuti FOREIGN KEY (f_cutimaster)
  REFERENCES m09_mastercuti (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_ijin ADD CONSTRAINT fk_m09_ijin_m09_pengajuancuti FOREIGN KEY (f_cutipengajuan)
  REFERENCES m09_pengajuancuti (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_ijindetail ADD CONSTRAINT fk_m09_ijindetail_m09_absensitipe FOREIGN KEY (f_absesitipe)
  REFERENCES m09_absensitipe (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_ijindetail ADD CONSTRAINT fk_m09_ijindetail_m09_ijin FOREIGN KEY (p_id)
  REFERENCES m09_ijin (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

ALTER TABLE m09_ijindetail ADD CONSTRAINT fk_m09_ijindetail_m09_mastercuti FOREIGN KEY (f_cutimaster)
  REFERENCES m09_mastercuti (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawan ADD CONSTRAINT fk_m09_karyawan_m09_divisi FOREIGN KEY (f_divisi)
  REFERENCES m09_masterdivisi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawan ADD CONSTRAINT fk_m09_karyawan_m09_golongan FOREIGN KEY (f_golongan)
  REFERENCES m09_mastergolongan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_karyawan ADD CONSTRAINT fk_m09_karyawan_m09_jabatan FOREIGN KEY (f_jabatan)
  REFERENCES m09_masterjabatan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawan ADD CONSTRAINT fk_m09_karyawan_m09_masterkehadiran FOREIGN KEY (f_kehadiran)
  REFERENCES m09_masterkehadiran (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawan ADD CONSTRAINT fk_m09_karyawan_m09_masterpajak FOREIGN KEY (f_statuspajak)
  REFERENCES m09_masterpajak (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawan ADD CONSTRAINT fk_m09_karyawan_m09_promosikaryawan FOREIGN KEY (f_promosi)
  REFERENCES m09_promosikaryawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawankeluarga ADD CONSTRAINT fk_m09_karyawankeluarga_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanlembur ADD CONSTRAINT fk_m09_karyawanlembur_m09_absensi FOREIGN KEY (f_absensi)
  REFERENCES m09_absensi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanlembur ADD CONSTRAINT fk_m09_karyawanlembur_m09_divisi FOREIGN KEY (f_divisi)
  REFERENCES m09_masterdivisi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanlembur ADD CONSTRAINT fk_m09_karyawanlembur_m09_golongan FOREIGN KEY (f_golongan)
  REFERENCES m09_mastergolongan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanlembur ADD CONSTRAINT fk_m09_karyawanlembur_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanlembur ADD CONSTRAINT fk_m09_karyawanlembur_m09_pengajuanlembur_detail FOREIGN KEY (f_pengajuanlembur)
  REFERENCES m09_pengajuanlembur_detail (primary_main)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_karyawanpindahdivisi ADD CONSTRAINT fk_m09_karyawanpindahdivisi_m09_divisi FOREIGN KEY (f_divisi)
  REFERENCES m09_masterdivisi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanpindahdivisi ADD CONSTRAINT fk_m09_karyawanpindahdivisi_m09_jadwalproduksi FOREIGN KEY (f_jadwalproduksi)
  REFERENCES m09_jadwalproduksi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_karyawanpindahdivisi ADD CONSTRAINT fk_m09_karyawanpindahdivisi_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

ALTER TABLE m09_pengajuancuti ADD CONSTRAINT fk_m09_pengajuancuti_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_pengajuancuti ADD CONSTRAINT fk_m09_pengajuancuti_m09_mastercuti FOREIGN KEY (f_mastercuti)
  REFERENCES m09_mastercuti (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_pengajuancuti_tanggal ADD CONSTRAINT fk_m09_pengajuancuti_tanggal_m09_absensitipe FOREIGN KEY (f_statusabsen)
  REFERENCES m09_absensitipe (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_pengajuancuti_tanggal ADD CONSTRAINT fk_m09_pengajuancuti_tanggal_m09_mastercuti FOREIGN KEY (f_mastercuti)
  REFERENCES m09_mastercuti (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_pengajuanlembur ADD CONSTRAINT fk_m09_pengajuanlembur_m09_divisi FOREIGN KEY (f_divisi)
  REFERENCES m09_masterdivisi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_pengajuanlembur_detail ADD CONSTRAINT fk_m09_pengajuanlembur_detail_m09_absensi FOREIGN KEY (f_absensi)
  REFERENCES m09_absensi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_pengajuanlembur_detail ADD CONSTRAINT fk_m09_pengajuanlembur_detail_m09_pengajuanlembur FOREIGN KEY (p_id)
  REFERENCES m09_pengajuanlembur (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

ALTER TABLE m09_pinjaman ADD CONSTRAINT fk_m09_pinjaman_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_pinjaman_detail ADD CONSTRAINT fk_m09_pinjaman_detail_m09_pinjaman FOREIGN KEY (p_id)
  REFERENCES m09_pinjaman (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

ALTER TABLE m09_promosikaryawan ADD CONSTRAINT fk_m09_promosikaryawan_m09_jabatan FOREIGN KEY (f_jabatan)
  REFERENCES m09_masterjabatan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_promosikaryawan ADD CONSTRAINT fk_m09_promosikaryawan_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_resign ADD CONSTRAINT fk_m09_resign_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_suratperingatan ADD CONSTRAINT fk_m09_suratperingatan_m09_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE CASCADE;

ALTER TABLE m09_jadwalproduksi_detail ADD CONSTRAINT fk_m09_jadwalproduksi_detail_m09_jadwalproduksi FOREIGN KEY (p_id)
  REFERENCES m09_jadwalproduksi (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

