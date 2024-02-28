SELECT
  so.primary_main AS SOId,
  m04bitem.u_code AS KodeBarang,
  m04bitem.d_name AS NamaBarang,
  Coalesce(Sum(d.d_qtyin), 0) AS QtyMasuk,
  Coalesce(Sum(d.d_qtyout), 0) AS QtyKeluar,
  Coalesce(Sum(If(u.d_date < '2023-03-01', d.d_qtyin - d.d_qtyout, 0)), 0) AS QtySaldoAwal,
  Coalesce(Sum(If(u.d_date >= '2023-03-01', d.d_qtyin, 0)), 0) AS QtyMutasiIN,
  Coalesce(Sum(If(u.d_date >= '2023-03-01', d.d_qtyout, 0)), 0) AS QtyMutasiOut,
  Coalesce(Sum(d.d_qtyin - d.d_qtyout), 0) AS QtySaldoAkhir,
  Coalesce(Sum(d.d_qtyin * d.d_price * u.d_kurs), 0) AS AmountIN,
  Coalesce(Sum(d.d_hpp), 0) AS AmountOUT,
  Coalesce(Sum(If(u.d_date < '2023-03-01', ((d.d_qtyin * d.d_price * u.d_kurs) - d.d_hpp), 0)), 0) AS AmountSaldoAwal,
  Coalesce(Sum(If(u.d_date >= '2023-03-01', (d.d_qtyin * d.d_price * u.d_kurs), 0)), 0) AS AmountMutasiIN,
  Coalesce(Sum(If(u.d_date >= '2023-03-01', d.d_hpp, 0)), 0) AS AmountMutasiOut,
  Coalesce(Sum((d.d_qtyin * d.d_price * u.d_kurs) - d.d_hpp), 0) AS AmountSaldoAkhir,
  m04bitem.d_od,
  m04bitem.d_id,
  m04bitem.d_ticknes,
  m04bitem.d_length
FROM
  m04dstockdetail d
  LEFT JOIN m04cstockmain u ON d.p_id = u.p_id
  LEFT JOIN m06edetailorder so ON d.f_idsod = so.primary_main
  LEFT JOIN m04bitem ON so.f_item = m04bitem.p_id
WHERE
  d.f_item = 2183 AND
  u.d_date <= '2023-03-31'
GROUP BY
  so.primary_main,
  m04bitem.u_code,
  m04bitem.d_name,
  d.f_item,
  so.f_item,
  m04bitem.d_od,
  m04bitem.d_id,
  m04bitem.d_ticknes,
  m04bitem.d_length