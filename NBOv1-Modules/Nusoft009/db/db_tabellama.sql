/*******************************************************************************
 * Selected metadata objects
 * -------------------------
 * Extracted at 05/08/2023 04.48.22
 ******************************************************************************/

/*******************************************************************************
 * Tables
 * ------
 * Extracted at 05/08/2023 04.48.22
 ******************************************************************************/

CREATE TABLE m09_karyawan (
  created_date       DateTime,
  created_user       VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date          DateTime,
  last_modified      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id               BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode             VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama             VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_absensiid        Integer(11),
  f_divisi           BigInt(20),
  f_jabatan          BigInt(20),
  d_tanggallahir     DateTime,
  d_tanggaljoin      DateTime,
  d_gender           Integer(11),
  d_jenis            Integer(11),
  d_negara           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_statusnikah      Integer(11),
  d_jumlahanak       Integer(11),
  d_telp             VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nohp             VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_email            VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_telpemergency    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_agama            VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_tempatlahir      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_alamat           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bank             VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bankac           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_bankname         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikan       Integer(11),
  d_pendidikannama   VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikanstudi  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikandari   VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_pendidikansampai VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_noktp            VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nonpwp           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nobpjstk         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nobpjskesehatan  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_catatan          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_statuspajak      BigInt(20),
  d_alamatktp        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_namaibu          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_namaayah         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_office           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_groupproduksi    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_golongan         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_kehadiran        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_iurankop         Double,
  d_iuranserikat     Double,
  d_iuranserikatnama VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_management       Bit(1),
  d_password         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  f_promosi          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_mastercuti (
  created_date     DateTime,
  created_user     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date        DateTime,
  last_modified    VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id             BigInt(20) NOT NULL AUTO_INCREMENT,
  u_tahun          SmallInt(6),
  u_tipe           Integer(11),
  f_karyawan       BigInt(20),
  d_jumlah         Integer(11),
  d_aktif          Bit(1),
  d_tanggalexpired DateTime
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_masterdivisi (
  created_date      DateTime,
  created_user      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date         DateTime,
  last_modified     VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id              BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode            VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama            VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_shift           Bit(1),
  d_leader          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_supervisor      VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_manager         VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_managerasistent VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_aktif           Bit(1)
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_mastergolongan (
  created_date  DateTime,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id          BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_lembur      Bit(1)
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_masterijin (
  created_date  DateTime,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id          BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_lama        Integer(11)
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_masterjabatan (
  created_date           DateTime,
  created_user           VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date              DateTime,
  last_modified          VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id                   BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode                 VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama                 VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_gajipokok            Double,
  d_tunjanganjabatan     Double,
  d_tunjanganlain        Double,
  d_tunjangantenagakerja Double,
  d_tunjangangolongan    Double,
  d_tunjangankesehatan   Double,
  d_pottenagakerja       Double,
  d_potkesehatan         Double,
  d_potpensiun           Double,
  d_potlain              Double
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_masterkehadiran (
  created_date  DateTime,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id          BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nilai       Integer(11)
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_masterpajak (
  created_date  DateTime,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id          BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nama        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_nilaiptkp   Double
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
CREATE TABLE m09_mastershift (
  created_date  DateTime,
  created_user  VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  last_date     DateTime,
  last_modified VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  p_id          BigInt(20) NOT NULL AUTO_INCREMENT,
  u_kode        VarChar(100) CHARACTER SET latin1 COLLATE latin1_swedish_ci,
  d_jammasuk    Double,
  d_jampulang   Double
) ENGINE=InnoDB ROW_FORMAT=dynamic DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
/*******************************************************************************
 * Primary Key Constraints
 * -----------------------
 * Extracted at 05/08/2023 04.48.22
 ******************************************************************************/

ALTER TABLE m09_karyawan ADD PRIMARY KEY 
    (p_id);

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

/*******************************************************************************
 * Foreign Key Constraints
 * -----------------------
 * Extracted at 05/08/2023 04.48.22
 ******************************************************************************/

ALTER TABLE m09_karyawan ADD CONSTRAINT FK_m09_karyawan_f_divisi FOREIGN KEY (f_divisi)
  REFERENCES m09_masterdivisi (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_karyawan ADD CONSTRAINT FK_m09_karyawan_f_jabatan FOREIGN KEY (f_jabatan)
  REFERENCES m09_masterjabatan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_karyawan ADD CONSTRAINT FK_m09_karyawan_f_statuspajak FOREIGN KEY (f_statuspajak)
  REFERENCES m09_masterpajak (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

ALTER TABLE m09_mastercuti ADD CONSTRAINT FK_m09_mastercuti_f_karyawan FOREIGN KEY (f_karyawan)
  REFERENCES m09_karyawan (p_id)
  ON DELETE NO ACTION 
  ON UPDATE NO ACTION;

