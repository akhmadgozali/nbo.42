SELECT
  m04estockhpp.p_id,
  m04estockhpp.d_qty,
  CS.f_item,
  CSMain.u_code,
  BarangIN.d_price AS HargaBeli,
  BarangINu.u_code AS NomoBeli,
  m04bitem.u_code AS u_code1,
  m04bitem.d_name
FROM
  m04estockhpp
  INNER JOIN m04dstockdetail CS ON m04estockhpp.f_idout = CS.primary_main
  LEFT JOIN m04cstockmain CSMain ON CS.p_id = CSMain.p_id
  LEFT JOIN m04dstockdetail BarangIN ON m04estockhpp.f_idin = BarangIN.primary_main
  LEFT JOIN m04cstockmain BarangINu ON BarangIN.p_id = BarangINu.p_id
  LEFT JOIN m04bitem ON CS.f_item = m04bitem.p_id
WHERE
  CSMain.u_code = 'TA-CS22110001'