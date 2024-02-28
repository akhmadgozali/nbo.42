SELECT
  dempyousn.primary_main,
  dempyousn.p_id,
  dempyouu.u_code,
  dempyousn.d_serial,
  dempyousn.d_snlength,
  dempyousn.d_length,
  (
SELECT coalesce(Sum(a.d_length_out),0) AS x
FROM
  m04estockdetailserial a
  LEFT JOIN m04dstockdetail b ON a.p_id = b.primary_main
  LEFT JOIN m04cstockmain c ON b.p_id = c.p_id
WHERE a.d_serial = dempyousn.d_serial AND c.f_iddempyou = dempyousn.p_id  
  ) as Produksi
FROM
  m04dorderproduksibaku dempyousn
  LEFT JOIN m04corderproduksi dempyouu ON dempyousn.p_id = dempyouu.p_id
