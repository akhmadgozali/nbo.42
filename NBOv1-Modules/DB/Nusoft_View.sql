/*******************************************************************************
 * Selected metadata objects
 * -------------------------
 * Extracted at 17/01/2024 09.03.33
 ******************************************************************************/

/*******************************************************************************
 * Views
 * -----
 * Extracted at 17/01/2024 09.03.33
 ******************************************************************************/

CREATE VIEW m06vwinvoice
(
 Urutan,
 NoInvoice,
 Terbayar,
 NilaiBayarCash,
 OK,
 Kurs,
 Catatan,
 Pembayaran
) AS
select 0 AS `Urutan`,`tr1`.`p_id` AS `NoInvoice`,coalesce((select sum(`tr2`.`d_amount`) from `m06gdetailpayment` `tr2` where `tr2`.`p_idinvoice` = `tr1`.`p_id`),0) AS `Terbayar`,0 AS `NilaiBayarCash`,1 AS `OK`,1 AS `Kurs`,'' AS `Catatan`,NULL AS `Pembayaran` from `m06emaininvoice` `tr1`;
CREATE VIEW m06vwaginginvoice
(
 p_id,
 NoInvoice,
 d_payment,
 d_different,
 d_differentdays
) AS
select `tr`.`p_id` AS `p_id`,`tr`.`p_id` AS `NoInvoice`,coalesce((select sum(`m06gdetailpayment`.`d_amount`) from `m06gdetailpayment` where `m06gdetailpayment`.`p_idinvoice` = `tr`.`p_id`),0) AS `d_payment`,to_days(`tr`.`d_duedate`) - to_days(curdate()) AS `d_different`,case when to_days(`tr`.`d_duedate`) - to_days(curdate()) < 0 then '< 0 Hari' when to_days(`tr`.`d_duedate`) - to_days(curdate()) = 0 then '0 Hari' when to_days(`tr`.`d_duedate`) - to_days(curdate()) > 0 and to_days(`tr`.`d_duedate`) - to_days(curdate()) < 8 then '1-7 Hari' when to_days(`tr`.`d_duedate`) - to_days(curdate()) > 7 and to_days(`tr`.`d_duedate`) - to_days(curdate()) < 15 then '8-14 Hari' when to_days(`tr`.`d_duedate`) - to_days(curdate()) > 14 and to_days(`tr`.`d_duedate`) - to_days(curdate()) < 22 then '15-21 Hari' when to_days(`tr`.`d_duedate`) - to_days(curdate()) > 21 and to_days(`tr`.`d_duedate`) - to_days(curdate()) < 31 then '21-30 Hari' when to_days(`tr`.`d_duedate`) - to_days(curdate()) > 30 then '>30 Hari' end AS `d_differentdays` from `m06emaininvoice` `tr` where `tr`.`d_duedate` is not null;
CREATE VIEW m05vwinvoice
(
 Urutan,
 NoInvoice,
 Terbayar,
 NilaiBayarCash,
 OK,
 Kurs,
 Catatan,
 Pembayaran
) AS
select 0 AS `Urutan`,`m05cmaininvoicereceipt`.`p_id` AS `NoInvoice`,coalesce((select sum(`m05ddetailpayment`.`d_amount`) from `m05ddetailpayment` where `m05ddetailpayment`.`p_idinvoice` = `m05cmaininvoicereceipt`.`p_id`),0) AS `Terbayar`,0 AS `NilaiBayarCash`,1 AS `OK`,1 AS `Kurs`,'' AS `Catatan`,NULL AS `Pembayaran` from `m05cmaininvoicereceipt`;
CREATE VIEW m05vwaginginvoice
(
 p_id,
 NoInvoice,
 d_payment,
 d_different,
 d_differentdays
) AS
select `m05cmaininvoicereceipt`.`p_id` AS `p_id`,`m05cmaininvoicereceipt`.`p_id` AS `NoInvoice`,coalesce((select sum(`m05ddetailpayment`.`d_amount`) from `m05ddetailpayment` where `m05ddetailpayment`.`p_idinvoice` = `m05cmaininvoicereceipt`.`p_id`),0) AS `d_payment`,to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) AS `d_different`,case when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) < 0 then '< 0 Hari' when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) = 0 then '0 Hari' when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) > 0 and to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) < 8 then '1-7 Hari' when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) > 7 and to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) < 15 then '8-14 Hari' when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) > 14 and to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) < 22 then '15-21 Hari' when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) > 21 and to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) < 31 then '21-30 Hari' when to_days(`m05cmaininvoicereceipt`.`d_duedate`) - to_days(curdate()) > 30 then '>30 Hari' end AS `d_differentdays` from `m05cmaininvoicereceipt` where `m05cmaininvoicereceipt`.`d_duedate` is not null;
CREATE VIEW m04vwsaldo
(
 Id,
 Kode,
 Nama,
 Satuan,
 Kategori,
 SubKategori,
 Merk,
 SaldoAwal,
 QtyIn,
 QtyOut,
 SaldoAwalNilai,
 QtyInNilai,
 QtyOutNilai
) AS
select `tr1`.`p_id` AS `Id`,`tr1`.`u_code` AS `Kode`,`tr1`.`d_name` AS `Nama`,`tr1`.`f_uom` AS `Satuan`,`tr1`.`f_kategori` AS `Kategori`,`tr1`.`f_subkategori` AS `SubKategori`,`tr1`.`f_merk` AS `Merk`,0.0 AS `SaldoAwal`,0.0 AS `QtyIn`,0.0 AS `QtyOut`,0.0 AS `SaldoAwalNilai`,0.0 AS `QtyInNilai`,0.0 AS `QtyOutNilai` from `m04bitem` `tr1`;
CREATE VIEW m04vwkartustock
(
 Id,
 SaldoAwal,
 SaldoAwalNilai,
 Masuk,
 Keluar,
 Harga,
 HPP,
 NoBukti,
 Tanggal,
 Barang,
 Uraian,
 Gudang
) AS
select `tr1`.`primary_main` AS `Id`,0.00 AS `SaldoAwal`,0.00 AS `SaldoAwalNilai`,`tr1`.`d_qtyin` AS `Masuk`,`tr1`.`d_qtyout` AS `Keluar`,`tr1`.`d_price` AS `Harga`,`f04_hppvalue`(`tr1`.`primary_main`) AS `HPP`,`tr2`.`u_code` AS `NoBukti`,`tr2`.`d_date` AS `Tanggal`,`tr1`.`f_item` AS `Barang`,`tr2`.`d_remarks` AS `Uraian`,`tr1`.`f_warehouse` AS `Gudang` from (`m04dstockdetail` `tr1` left join `m04cstockmain` `tr2` on(`tr1`.`p_id` = `tr2`.`p_id`));
CREATE VIEW m04vwitem
(
 id,
 barang,
 kode,
 nama,
 saldoawal,
 stockin,
 stockout,
 saldoakhir,
 stock1,
 stock2
) AS
select `tr1`.`p_id` AS `id`,`tr1`.`p_id` AS `barang`,`tr1`.`u_code` AS `kode`,`tr1`.`d_name` AS `nama`,0.0 AS `saldoawal`,0.0 AS `stockin`,0.0 AS `stockout`,0.0 AS `saldoakhir`,0.0 AS `stock1`,0.0 AS `stock2` from `m04bitem` `tr1`;
CREATE VIEW m04vwhppavailable
(
 id,
 f_item,
 f_warehouse,
 f_location,
 d_qtyin,
 d_qtyout,
 d_used,
 d_available
) AS
select `m04dstockdetail`.`primary_main` AS `id`,`m04dstockdetail`.`f_item` AS `f_item`,`m04dstockdetail`.`f_warehouse` AS `f_warehouse`,`m04dstockdetail`.`f_location` AS `f_location`,`m04dstockdetail`.`d_qtyin` AS `d_qtyin`,`m04dstockdetail`.`d_qtyout` AS `d_qtyout`,`f04_hppgetused`(`m04dstockdetail`.`primary_main`) AS `d_used`,`f04_hppgetavailable`(`m04dstockdetail`.`primary_main`) AS `d_available` from `m04dstockdetail` where `m04dstockdetail`.`d_qtyin` > 0;
CREATE VIEW m04vwhpp
(
 primary_main,
 f_item,
 d_qtyin,
 d_qtyout
) AS
select `m04dstockdetail`.`primary_main` AS `primary_main`,`m04dstockdetail`.`f_item` AS `f_item`,`m04dstockdetail`.`d_qtyin` AS `d_qtyin`,(select coalesce(sum(`m04estockhpp`.`d_qty`),0) from `m04estockhpp` where `m04estockhpp`.`f_idin` = `m04dstockdetail`.`primary_main`) AS `d_qtyout` from `m04dstockdetail`;
CREATE VIEW m02vwasset
(
 p_id,
 f_asset,
 d_price,
 d_residuvalue,
 d_amortization,
 d_bookvalue
) AS
select `m02bassetview`.`p_id` AS `p_id`,`m02bassetview`.`p_id` AS `f_asset`,`m02bassetview`.`d_price` AS `d_price`,`m02bassetview`.`d_residuvalue` AS `d_residuvalue`,if(`m02bassetview`.`d_purchase` = 0,0,`m02bassetview`.`d_qtyin` * (`m02bassetview`.`d_price` - `m02bassetview`.`d_residuvalue`) - `f02_getbookvalueasset`(`m02bassetview`.`p_id`)) AS `d_amortization`,`f02_getbookvalueasset`(`m02bassetview`.`p_id`) AS `d_bookvalue` from `m02bassetview`;
CREATE VIEW m01vwzcashflowreportdetail
(
 id,
 Tipe,
 Urutan,
 Nama,
 Asign,
 COA,
 Debit,
 Kredit,
 NoTransaksi,
 Tanggal,
 Divisi,
 Project,
 ProjectSub,
 Level1,
 Level2,
 Level3,
 Level4,
 Level,
 m1,
 m2,
 m3,
 m4,
 m5,
 m6,
 m7,
 m8,
 m9,
 m10,
 m11,
 m12,
 Keterangan,
 Uraian
) AS
select `m01zcustomreportdetail`.`p_id` AS `id`,`m01zcustomreport`.`u_kind` AS `Tipe`,`m01zcustomreport`.`d_order` AS `Urutan`,`m01zcustomreport`.`d_name` AS `Nama`,`m01zcustomreport`.`d_sign` AS `Asign`,`m01zcustomreportdetail`.`f_coa` AS `COA`,0.0 AS `Debit`,0.0 AS `Kredit`,NULL AS `NoTransaksi`,NULL AS `Tanggal`,NULL AS `Divisi`,NULL AS `Project`,NULL AS `ProjectSub`,`m01bcoa`.`f_coa1` AS `Level1`,`m01bcoa`.`f_coa2` AS `Level2`,`m01bcoa`.`f_coa3` AS `Level3`,`m01bcoa`.`f_coa4` AS `Level4`,`m01bcoa`.`d_level` AS `Level`,0.00 AS `m1`,0.00 AS `m2`,0.00 AS `m3`,0.00 AS `m4`,0.00 AS `m5`,0.00 AS `m6`,0.00 AS `m7`,0.00 AS `m8`,0.00 AS `m9`,0.00 AS `m10`,0.00 AS `m11`,0.00 AS `m12`,'' AS `Keterangan`,'' AS `Uraian` from ((`m01zcustomreportdetail` left join `m01zcustomreport` on(`m01zcustomreportdetail`.`f_main` = `m01zcustomreport`.`p_id`)) left join `m01bcoa` on(`m01zcustomreportdetail`.`f_coa` = `m01bcoa`.`p_id`)) order by `m01zcustomreport`.`d_order`;
CREATE VIEW m01vwzcashflowreport
(
 id,
 Tipe,
 Kode,
 Urutan,
 Nama,
 Asign,
 Saldo
) AS
select `m01zcustomreport`.`p_id` AS `id`,`m01zcustomreport`.`u_kind` AS `Tipe`,`m01zcustomreport`.`u_code` AS `Kode`,`m01zcustomreport`.`d_order` AS `Urutan`,`m01zcustomreport`.`d_name` AS `Nama`,`m01zcustomreport`.`d_sign` AS `Asign`,0.0 AS `Saldo` from `m01zcustomreport`;
CREATE VIEW m01vwzcashflow
(
 id,
 main,
 coakasbank,
 debit,
 credit,
 `type`,
 coalawan,
 Tanggal,
 NoTransaksi,
 Bulan,
 Divisi,
 Proyek,
 ProyekSub,
 JmlDebit,
 JmlKredit,
 JmlKredit2,
 Keterangan,
 Uraian
) AS
select `m01dmaindetail`.`primary_main` AS `id`,`m01dmaindetail`.`p_id` AS `main`,`m01dmaindetail`.`f_coa` AS `coakasbank`,`m01dmaindetail`.`d_debit` AS `debit`,`m01dmaindetail`.`d_credit` AS `credit`,if(`m01dmaindetail`.`d_debit` > 0,'+','-') AS `type`,`f_getcashflow`(`m01dmaindetail`.`p_id`,`m01dmaindetail`.`d_debit`,`m01dmaindetail`.`d_credit`) AS `coalawan`,`m01cmaingl`.`d_date` AS `Tanggal`,`m01cmaingl`.`u_code` AS `NoTransaksi`,month(`m01cmaingl`.`d_date`) AS `Bulan`,`m01dmaindetail`.`f_division` AS `Divisi`,`m01dmaindetail`.`f_proyek` AS `Proyek`,NULL AS `ProyekSub`,(select count(`xx`.`primary_main`) from `m01dmaindetail` `xx` where `xx`.`p_id` = `m01dmaindetail`.`p_id` and `xx`.`d_debit` > 0) AS `JmlDebit`,(select count(`xx`.`primary_main`) from `m01dmaindetail` `xx` where `xx`.`p_id` = `m01dmaindetail`.`p_id` and `xx`.`d_credit` > 0) AS `JmlKredit`,(select count(`xx`.`primary_main`) from (`m01dmaindetail` `xx` left join `m01bcoa` `yy` on(`xx`.`f_coa` = `yy`.`p_id`)) where `xx`.`p_id` = `m01dmaindetail`.`p_id` and `xx`.`d_credit` > 0 and `yy`.`f_type` > 2) AS `JmlKredit2`,' ' AS `Keterangan`,`m01dmaindetail`.`d_note` AS `Uraian` from ((`m01dmaindetail` left join `m01bcoa` on(`m01dmaindetail`.`f_coa` = `m01bcoa`.`p_id`)) left join `m01cmaingl` on(`m01dmaindetail`.`p_id` = `m01cmaingl`.`p_id`)) where `m01bcoa`.`f_type` = 1 or `m01bcoa`.`f_type` = 2;
CREATE VIEW m01vwsaldo
(
 id,
 tipe,
 kode,
 nama,
 induk,
 level,
 level1,
 level2,
 level3,
 level4,
 uang,
 saldoawal,
 mutasidebit,
 mutasikredit,
 saldoakhir,
 m1,
 m2,
 m3,
 m4,
 m5,
 m6,
 m7,
 m8,
 m9,
 m10,
 m11,
 m12
) AS
select `m01bcoa`.`p_id` AS `id`,`m01bcoa`.`f_type` AS `tipe`,`m01bcoa`.`u_code` AS `kode`,`m01bcoa`.`d_name` AS `nama`,`m01bcoa`.`d_parent` AS `induk`,`m01bcoa`.`d_level` AS `level`,`m01bcoa`.`f_coa1` AS `level1`,`m01bcoa`.`f_coa2` AS `level2`,`m01bcoa`.`f_coa3` AS `level3`,`m01bcoa`.`f_coa4` AS `level4`,`m01bcoa`.`fk_currency` AS `uang`,0.00 AS `saldoawal`,0.00 AS `mutasidebit`,0.00 AS `mutasikredit`,0.00 AS `saldoakhir`,0.00 AS `m1`,0.00 AS `m2`,0.00 AS `m3`,0.00 AS `m4`,0.00 AS `m5`,0.00 AS `m6`,0.00 AS `m7`,0.00 AS `m8`,0.00 AS `m9`,0.00 AS `m10`,0.00 AS `m11`,0.00 AS `m12` from `m01bcoa`;
CREATE VIEW m01vwglwoojin
(
 Id,
 SumberData,
 Tahun,
 Bulan,
 Tanggal,
 Kontak,
 NoBukti,
 AkunMain,
 AkunDetail,
 Urutan,
 SaldoAwal,
 Debit,
 Kredit,
 SaldoAwalValas,
 DebitValas,
 KreditValas,
 Keterangan,
 Catatan,
 Proyek,
 ProyekSub,
 Divisi,
 Kurs,
 Tipe
) AS
select `tr2`.`primary_main` AS `Id`,`tr1`.`f_source` AS `SumberData`,year(`tr1`.`d_date`) AS `Tahun`,month(`tr1`.`d_date`) AS `Bulan`,`tr1`.`d_date` AS `Tanggal`,`tr1`.`f_contact` AS `Kontak`,`tr1`.`u_code` AS `NoBukti`,`tr1`.`f_coa` AS `AkunMain`,`tr2`.`f_coa` AS `AkunDetail`,`tr2`.`p_order` AS `Urutan`,0.00 AS `SaldoAwal`,`tr2`.`d_debit` AS `Debit`,`tr2`.`d_credit` AS `Kredit`,0.00 AS `SaldoAwalValas`,`tr2`.`d_debitvalas` AS `DebitValas`,`tr2`.`d_creditvalas` AS `KreditValas`,`tr1`.`d_description` AS `Keterangan`,`tr2`.`d_note` AS `Catatan`,`tr2`.`f_proyek` AS `Proyek`,`tr2`.`f_proyeksub` AS `ProyekSub`,`tr2`.`f_division` AS `Divisi`,`tr2`.`d_rate` AS `Kurs`,'1. Saldo KasBank' AS `Tipe` from (`m01dmaindetail` `tr2` left join `m01cmaingl` `tr1` on(`tr2`.`p_id` = `tr1`.`p_id`));
CREATE VIEW m01vwgl
(
 Id,
 SumberData,
 Tahun,
 Bulan,
 Tanggal,
 Kontak,
 NoBukti,
 AkunMain,
 AkunDetail,
 Urutan,
 SaldoAwal,
 Debit,
 Kredit,
 SaldoAwalValas,
 DebitValas,
 KreditValas,
 Keterangan,
 Proyek,
 ProyekSub,
 Divisi,
 Kurs,
 Regional,
 Catatan
) AS
select `tr2`.`primary_main` AS `Id`,`tr1`.`f_source` AS `SumberData`,year(`tr1`.`d_date`) AS `Tahun`,month(`tr1`.`d_date`) AS `Bulan`,`tr1`.`d_date` AS `Tanggal`,`tr1`.`f_contact` AS `Kontak`,`tr1`.`u_code` AS `NoBukti`,`tr1`.`f_coa` AS `AkunMain`,`tr2`.`f_coa` AS `AkunDetail`,`tr2`.`p_order` AS `Urutan`,0.00 AS `SaldoAwal`,`tr2`.`d_debit` AS `Debit`,`tr2`.`d_credit` AS `Kredit`,0.00 AS `SaldoAwalValas`,`tr2`.`d_debitvalas` AS `DebitValas`,`tr2`.`d_creditvalas` AS `KreditValas`,`tr1`.`d_description` AS `Keterangan`,`tr2`.`f_proyek` AS `Proyek`,0 AS `ProyekSub`,`tr2`.`f_division` AS `Divisi`,`tr2`.`d_rate` AS `Kurs`,`tr1`.`u_regional` AS `Regional`,`tr2`.`d_note` AS `Catatan` from (`m01dmaindetail` `tr2` left join `m01cmaingl` `tr1` on(`tr2`.`p_id` = `tr1`.`p_id`));
CREATE VIEW m01vwgiro
(
 Id,
 NoBukti,
 NoBuktiCair,
 CoaGiro,
 Uang,
 NoGiro,
 Bank,
 NoACBank,
 TglJatuhTempo,
 Nilai,
 Kurs,
 Status,
 Tipe,
 SelisihHari,
 SelisihHariNama
) AS
select `m01dmaingiro`.`primary_main` AS `Id`,`m01dmaingiro`.`p_id` AS `NoBukti`,`m01dmaingiro`.`f_idsetlement` AS `NoBuktiCair`,`m01dmaingiro`.`f_coagiro` AS `CoaGiro`,`m01dmaingiro`.`f_currency` AS `Uang`,`m01dmaingiro`.`d_girono` AS `NoGiro`,`m01dmaingiro`.`d_bank` AS `Bank`,`m01dmaingiro`.`d_bankacno` AS `NoACBank`,`m01dmaingiro`.`d_duedate` AS `TglJatuhTempo`,`m01dmaingiro`.`d_value` AS `Nilai`,`m01dmaingiro`.`d_kurs` AS `Kurs`,`m01dmaingiro`.`d_status` AS `Status`,`m01dmaingiro`.`d_type` AS `Tipe`,to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) AS `SelisihHari`,case when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) < 0 then '< 0 Hari' when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) = 0 then '0 Hari' when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) > 0 and to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) < 8 then '1-7 Hari' when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) > 7 and to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) < 15 then '8-14 Hari' when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) > 14 and to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) < 22 then '15-21 Hari' when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) > 21 and to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) < 31 then '21-30 Hari' when to_days(`m01dmaingiro`.`d_duedate`) - to_days(curdate()) > 30 then '>30 Hari' end AS `SelisihHariNama` from `m01dmaingiro` order by `m01dmaingiro`.`d_duedate`;
CREATE VIEW m01vwcustomreport
(
 Id,
 MainId,
 Tipe,
 Urutan,
 Nama,
 Level,
 Tanda,
 Akun,
 Saldo
) AS
select cast(concat(`m`.`p_id`,coalesce(`d`.`f_coa`,0)) as unsigned) AS `Id`,`m`.`p_id` AS `MainId`,`m`.`u_kind` AS `Tipe`,`m`.`d_order` AS `Urutan`,concat(repeat(' ',`m`.`d_space` * 5),`m`.`d_name`) AS `Nama`,`m`.`d_level` AS `Level`,`m`.`d_sign` AS `Tanda`,`d`.`f_coa` AS `Akun`,0.00 AS `Saldo` from (`m01zcustomreport` `m` left join `m01zcustomreportdetail` `d` on(`m`.`p_id` = `d`.`f_main` and `m`.`d_level` in (1,4,5,6)));
CREATE VIEW m01vwcoa
(
 id,
 Tipe,
 Kode,
 Nama,
 NamaCashFlowTambah,
 NamaCashFlowMinus,
 Induk,
 Aktif,
 GabungCashFlow,
 Keterangan,
 Format,
 AkunIntegrasi,
 MataUang,
 Bank,
 Divisi,
 GeneralDetail,
 Level1,
 Level2,
 Level3,
 Level4,
 Level,
 KodeX,
 f_cashflowin,
 f_cashflowout
) AS
select `m01bcoa`.`p_id` AS `id`,`m01bcoa`.`f_type` AS `Tipe`,`m01bcoa`.`u_code` AS `Kode`,`m01bcoa`.`d_name` AS `Nama`,`m01bcoa`.`d_cfp` AS `NamaCashFlowTambah`,`m01bcoa`.`d_cfm` AS `NamaCashFlowMinus`,`m01bcoa`.`d_parent` AS `Induk`,`m01bcoa`.`d_active` AS `Aktif`,`m01bcoa`.`d_cfmerge` AS `GabungCashFlow`,`m01bcoa`.`d_note` AS `Keterangan`,`m01bcoa`.`d_format` AS `Format`,`m01bcoa`.`d_linkaccount` AS `AkunIntegrasi`,`m01bcoa`.`fk_currency` AS `MataUang`,`m01bcoa`.`fk_bank` AS `Bank`,`m01bcoa`.`fk_division` AS `Divisi`,`m01bcoa`.`d_gd` AS `GeneralDetail`,`m01bcoa`.`f_coa1` AS `Level1`,`m01bcoa`.`f_coa2` AS `Level2`,`m01bcoa`.`f_coa3` AS `Level3`,`m01bcoa`.`f_coa4` AS `Level4`,`m01bcoa`.`d_level` AS `Level`,concat(repeat('    ',`m01bcoa`.`d_level`),`m01bcoa`.`u_code`) AS `KodeX`,`m01bcoa`.`f_cashflowin` AS `f_cashflowin`,`m01bcoa`.`f_cashflowout` AS `f_cashflowout` from `m01bcoa`;
CREATE VIEW m01vwcashadvanceremain
(
 p_id,
 u_code,
 d_date,
 d_contact
) AS
select `m01cmaingl`.`p_id` AS `p_id`,`m01cmaingl`.`u_code` AS `u_code`,`m01cmaingl`.`d_date` AS `d_date`,`m01cmaingl`.`d_contact` AS `d_contact` from `m01cmaingl` where `m01cmaingl`.`f_source` in (2,4) and `m01cmaingl`.`d_type` = 1 and !(`m01cmaingl`.`p_id` in (select `m01cmaingl`.`fk_cashadvance` from `m01cmaingl` where `m01cmaingl`.`fk_cashadvance` is not null));
CREATE VIEW m01varap
(
 id,
 f_coa,
 f_currency,
 f_contact,
 jumlah,
 bayar,
 jumlahvalas,
 bayarvalas,
 saldo,
 saldovalas
) AS
select max(`m01dmaindetail`.`primary_main`) AS `id`,`m01dmaindetail`.`f_coa` AS `f_coa`,`m01dmaindetail`.`f_currency` AS `f_currency`,`m01cmaingl`.`f_contact` AS `f_contact`,sum(if(`m01acoalevel`.`d_dc` = 0,`m01dmaindetail`.`d_debit`,`m01dmaindetail`.`d_credit`)) AS `jumlah`,sum(if(`m01acoalevel`.`d_dc` = 0,`m01dmaindetail`.`d_credit`,`m01dmaindetail`.`d_debit`)) AS `bayar`,sum(if(`m01acoalevel`.`d_dc` = 0,`m01dmaindetail`.`d_debitvalas`,`m01dmaindetail`.`d_creditvalas`)) AS `jumlahvalas`,sum(if(`m01acoalevel`.`d_dc` = 0,`m01dmaindetail`.`d_creditvalas`,`m01dmaindetail`.`d_debitvalas`)) AS `bayarvalas`,sum(if(`m01acoalevel`.`d_dc` = 0,`m01dmaindetail`.`d_debit` - `m01dmaindetail`.`d_credit`,`m01dmaindetail`.`d_credit` - `m01dmaindetail`.`d_debit`)) AS `saldo`,sum(if(`m01acoalevel`.`d_dc` = 0,`m01dmaindetail`.`d_debitvalas` - `m01dmaindetail`.`d_creditvalas`,`m01dmaindetail`.`d_creditvalas` - `m01dmaindetail`.`d_debitvalas`)) AS `saldovalas` from (((`m01dmaindetail` left join `m01cmaingl` on(`m01dmaindetail`.`p_id` = `m01cmaingl`.`p_id`)) left join `m01bcoa` on(`m01dmaindetail`.`f_coa` = `m01bcoa`.`p_id`)) left join `m01acoalevel` on(`m01bcoa`.`f_type` = `m01acoalevel`.`p_id`)) where `m01acoalevel`.`p_id` in (3,8,9,10) group by `m01dmaindetail`.`f_coa`,`m01cmaingl`.`f_contact`;
