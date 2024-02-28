/*******************************************************************************
 * Database character set: utf8mb4
 * Server version: 8.0
 * Server version build: 8.0.14
 ******************************************************************************/

/*******************************************************************************
 * Selected metadata objects
 * -------------------------
 * Extracted at 5/10/2021 10:16:25 AM
 ******************************************************************************/

/*******************************************************************************
 * Tables
 * ------
 * Extracted at 5/10/2021 10:16:25 AM
 ******************************************************************************/

CREATE TABLE m04amesin (
  p_id          TinyInt(3) UNSIGNED NOT NULL AUTO_INCREMENT,
  u_code        NVarChar(25) COLLATE utf8_general_ci NOT NULL,
  d_name        NVarChar(50) COLLATE utf8_general_ci NOT NULL,
  created_user  NVarChar(100) COLLATE utf8_general_ci,
  created_date  DateTime,
  last_modified NVarChar(100) COLLATE utf8_general_ci,
  last_date     DateTime, 
  PRIMARY KEY (
      p_id
  )
) ENGINE=InnoDB AUTO_INCREMENT=8 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;


ALTER TABLE m04amesin COMMENT = '';
CREATE TABLE m04dorderproduksidaily (
  primary_main    BigInt(20) UNSIGNED NOT NULL AUTO_INCREMENT,
  p_id            BigInt(20) UNSIGNED NOT NULL,
  d_tanggal       Date,
  created_date    Timestamp,
  created_user    VarChar(100) COLLATE utf8_general_ci,
  last_date       Timestamp,
  last_modified   VarChar(100) COLLATE utf8_general_ci,
  d_remarks       VarChar(255) COLLATE utf8_general_ci,
  d_qtyp1         Decimal(18, 4),
  d_qtyp2         Decimal(18, 4),
  d_qtyp3         Decimal(18, 4),
  d_qtyp4         Decimal(18, 4),
  d_qtyp5         Decimal(18, 4),
  f_item          Integer(11),
  f_mesin         Integer(11),
  d_shift         VarChar(5)  COLLATE utf8_general_ci,
  d_jamkerja      VarChar(5) COLLATE utf8_general_ci,
  d_waktustopline VarChar(10) COLLATE utf8_general_ci, 
  PRIMARY KEY (
      primary_main
  )
) ENGINE=InnoDB AUTO_INCREMENT=1 ROW_FORMAT=DYNAMIC DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
ALTER TABLE m04dorderproduksidaily COMMENT = '';
/*******************************************************************************
 * Foreign Key Constraints
 * -----------------------
 * Extracted at 5/10/2021 10:16:25 AM
 ******************************************************************************/

ALTER TABLE m04dorderproduksidaily ADD CONSTRAINT fk_m04dorderproduksidaily_main FOREIGN KEY (p_id)
  REFERENCES m04corderproduksi (p_id)
  ON DELETE CASCADE 
  ON UPDATE CASCADE;

