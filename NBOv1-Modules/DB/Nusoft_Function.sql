/*******************************************************************************
 * Selected metadata objects
 * -------------------------
 * Extracted at 17/01/2024 09.04.51
 ******************************************************************************/

/*******************************************************************************
 * Stored Functions
 * ----------------
 * Extracted at 17/01/2024 09.04.51
 ******************************************************************************/

CREATE FUNCTION f01_getbeginningbalancedivisi(CoaID Integer(11), DT_DATE Date, Divisi SmallInt(6))
  RETURNS Double
  NO SQL
BEGIN



DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;

DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;

DECLARE DBL_LABA       DOUBLE DEFAULT 0;

DECLARE DC SMALLINT;

DECLARE TIPE INT;



SELECT sys.d_dc,coa.f_type

INTO DC,TIPE

FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id

where coa.p_id=CoaID;



    CASE

      WHEN TIPE BETWEEN 1 AND 11 THEN

           SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)

           INTO DBL_DEBIT,DBL_CREDIT

           FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id

           where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE and tr2.f_division=Divisi; 

      WHEN TIPE BETWEEN 12 AND 16 THEN

           SELECT COALESCE(SUM(d_debit*tr2.d_rate),0),COALESCE(SUM(d_credit*tr2.d_rate),0)

           INTO DBL_DEBIT,DBL_CREDIT

           FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id

           where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE and tr2.f_division=Divisi; 

       ELSE

         SET DBL_DEBIT  = 0;

         SET DBL_CREDIT = 0;

    END CASE;



  IF DC = 0 THEN

     RETURN (DBL_DEBIT - DBL_CREDIT);

  ELSE

     RETURN (DBL_CREDIT - DBL_DEBIT);

  END IF;

END
/
CREATE FUNCTION f01_getsaldoCFIN(COA Integer(11), PeriodeAwal Date, PeriodeAkhir Date, Divisi Integer(11), Proyek Integer(11), ProyekSub Integer(11))
  RETURNS Decimal(18, 4)
  NO SQL
begin

  DECLARE SALDO DECIMAL(18,4);

  

  if (Proyek=0 and Divisi=0) THEN

     

     select sum(debit+credit) 

     INTO SALDO

     from m01vwzcashflow where coalawan=COA and (Tanggal between PeriodeAwal and PeriodeAkhir) and debit>0;

  ELSE

     IF (PROYEK=0 and DIVISI>0) THEN 

        

         SET SALDO  = 0;

     ELSE

        IF (PROYEKSUB>0) THEN

           

           SET SALDO  = 0;

        ELSE

           

           SET SALDO  = 0;

        END IF;  

     END IF;

  END IF;



  RETURN SALDO;

end
/
CREATE FUNCTION f01_getsaldodivisi(CoaID Integer(11), Divisi SmallInt(6), DT_DATE Date)
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE and tr2.f_division=Divisi;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) and tr2.f_division=Divisi;
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE and tr2.f_division=Divisi;       

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)   
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE) and tr2.f_division=Divisi;

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) and tr2.f_division=Divisi;

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f01_getsaldoproyek(CoaID Integer(11), Proyek Integer(11), DT_DATE Date)
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE and tr2.f_proyek=Proyek;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) and tr2.f_proyek=Proyek;
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE and tr2.f_proyek=Proyek;       

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)   
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE) and tr2.f_proyek=Proyek;

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) and tr2.f_proyek=Proyek;

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f01_getsaldoregional(CoaID Integer(11), Regional Integer(11), DT_DATE Date)
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;
    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE and tr1.u_regional=Regional;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) and tr1.u_regional=Regional;
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE and tr1.u_regional=Regional;       

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)   
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE) and tr1.u_regional=Regional;

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) and tr1.u_regional=Regional;

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f01_getsaldostatistik(Tipe TinyInt(4), DT_DATE Date)
  RETURNS Decimal(10, 0)
  NO SQL
begin
DECLARE SALDO      DOUBLE DEFAULT 0;
    CASE TIPE
      WHEN 0 THEN   
         SELECT COALESCE(SUM(d_debit-d_credit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level2=0;
      WHEN 1 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level2=1;   
      WHEN 2 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level2=2;  
      WHEN 3 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where tr1.d_date <= DT_DATE and d_level1=1;
         
       WHEN 7 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where month(tr1.d_date) <= month(DT_DATE) and d_level2=3;        
       WHEN 8 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where month(tr1.d_date) <= month(DT_DATE) and d_level2=4;   
       WHEN 9 THEN   
         SELECT COALESCE(SUM(d_credit-d_debit),0)
         INTO SALDO
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id 
         left join m01bcoa c on tr2.f_coa=c.p_id left join m01acoalevel d on c.f_type=d.p_id
         where month(tr1.d_date) <= month(DT_DATE) and d_level1=1;                       
      ELSE
         set saldo=0;     
    END CASE;



  RETURN SALDO;
end
/
CREATE FUNCTION f01_xgetsaldocashflow(TIPE VarChar(15), TGLAWAL Date, TGLAKHIR Date, COA Integer(11))
  RETURNS Decimal(18, 4)
  NO SQL
begin

  DECLARE DEBIT      DECIMAL(18,4) DEFAULT 0;

  DECLARE KREDIT      DECIMAL(18,4) DEFAULT 0;

  DECLARE SALDO      DECIMAL(18,4) DEFAULT 0;

  

  SELECT COALESCE(SUM(debit),0),COALESCE(SUM(credit),0)

  INTO DEBIT,KREDIT

  FROM m01vwzcashflow tr1 

  where tr1.type=TIPE;

  

  IF TIPE = 'Penerimaan' THEN

     RETURN (DEBIT - KREDIT);

  ELSE

     RETURN (DEBIT - KREDIT);

  END IF;

end
/
CREATE FUNCTION f02_getbeginningbalance(CoaID Integer(11), DT_DATE Date)
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f02_getbeginningbalanceproject(CoaID Integer(11), DT_DATE Date, Project Integer(11))
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit*tr2.d_rate),0),COALESCE(SUM(d_credit*tr2.d_rate),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE and tr2.f_proyek=Project;
       ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f02_getbeginningbalancevalas(CoaID Integer(11), DT_DATE Date)
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debitvalas),0),COALESCE(SUM(d_creditvalas),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debitvalas),0),COALESCE(SUM(d_creditvalas),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debitvalas),0),COALESCE(SUM(d_creditvalas),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date < DT_DATE;

         SELECT COALESCE(SUM(d_creditvalas),0)-COALESCE(SUM(d_debitvalas),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_creditvalas),0)-COALESCE(SUM(d_debitvalas),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f02_getbookvalueasset(p_id Integer(11))
  RETURNS Decimal(18, 4)
  NO SQL
begin
DECLARE SALDO      DOUBLE DEFAULT 0;

  SELECT coalesce(sum((d_qty*d_valuein)-(d_qty*d_valueout)),0)  
  INTO SALDO
  FROM m02dtransactiondetail 
  WHERE f_asset=p_id;  
  RETURN SALDO;
end
/
CREATE FUNCTION f02_getmutation(CoaID Integer(11), DT_DATE Date, TipeSaldo Integer(1))
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_SALDO       DOUBLE DEFAULT 0;
DECLARE DBL_LABA      DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;


  SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
  INTO DBL_DEBIT,DBL_CREDIT
  FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
  where tr2.f_coa=CoaID AND tr1.u_month=month(DT_DATE) and tr1.u_year=year(DT_DATE);
 
   CASE     
      WHEN TipeSaldo = 0 THEN               
         SET DBL_SALDO = DBL_DEBIT;
      WHEN TipeSaldo = 1 THEN               
         SET DBL_SALDO = DBL_CREDIT; 
      WHEN TipeSaldo = 2 THEN               
         IF DC = 0 THEN
            SET DBL_SALDO=(DBL_DEBIT - DBL_CREDIT);
         ELSE
            SET DBL_SALDO= (DBL_CREDIT - DBL_DEBIT);
         END IF;    
      ELSE
         SET DBL_SALDO  = 0;
   END CASE;

  return DBL_SALDO;
END
/
CREATE FUNCTION f02_getsaldo(CoaID Integer(11), DT_DATE Date)
  RETURNS Double
  NO SQL
BEGIN

DECLARE DBL_DEBIT      DOUBLE DEFAULT 0;
DECLARE DBL_CREDIT     DOUBLE DEFAULT 0;
DECLARE DBL_LABA       DOUBLE DEFAULT 0;
DECLARE DC SMALLINT;
DECLARE TIPE INT;

SELECT sys.d_dc,coa.f_type
INTO DC,TIPE
FROM m01bcoa coa LEFT JOIN m01acoalevel sys ON coa.f_type=sys.p_id
where coa.p_id=CoaID;

    CASE
      WHEN TIPE BETWEEN 1 AND 11 THEN   
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE;
      WHEN TIPE BETWEEN 12 AND 16 THEN  
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE) AND MONTH(tr1.d_date)=MONTH(DT_DATE);
      WHEN TIPE = 17 THEN               
         SELECT COALESCE(SUM(d_debit),0),COALESCE(SUM(d_credit),0)
         INTO DBL_DEBIT,DBL_CREDIT
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         where tr2.f_coa=CoaID AND tr1.d_date <= DT_DATE;       

         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)   
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date < cast(concat(year(DT_DATE),'-01-01') as DATE);

         SET DBL_CREDIT = DBL_CREDIT + DBL_LABA;
      WHEN TIPE = 18 THEN               
         SELECT COALESCE(SUM(d_credit),0)-COALESCE(SUM(d_debit),0)
         INTO DBL_LABA
         FROM m01dmaindetail tr2 LEFT JOIN m01cmaingl tr1 ON tr2.p_id=tr1.p_id
         LEFT JOIN m01bcoa b ON tr2.f_coa=b.p_id
         LEFT JOIN m01acoalevel a ON b.f_type=a.p_id
         where a.d_level1=1 AND tr1.d_date <= DT_DATE AND YEAR(tr1.d_date)=YEAR(DT_DATE);

         SET DBL_CREDIT =  DBL_LABA;   
      ELSE
         SET DBL_DEBIT  = 0;
         SET DBL_CREDIT = 0;
    END CASE;

  IF DC = 0 THEN
     RETURN (DBL_DEBIT - DBL_CREDIT);
  ELSE
     RETURN (DBL_CREDIT - DBL_DEBIT);
  END IF;
END
/
CREATE FUNCTION f04_getbeginningbalance(Tipe TinyInt(4), ItemID Integer(11), DT_DATE Date, Gudang Integer(11))
  RETURNS Decimal(10, 0)
  NO SQL
BEGIN
DECLARE SALDOQTY      DECIMAL DEFAULT 0;
DECLARE SALDONILAI    DECIMAL DEFAULT 0;

SELECT
  sum(tr1.d_qtyin-tr1.d_qtyout),
  sum((tr1.d_qtyin * tr1.d_price) - f04_hppvalue(tr1.primary_main))
INTO
  SALDOQTY,SALDONILAI  
FROM
  m04dstockdetail tr1
  LEFT JOIN m04cstockmain tr2 ON tr1.p_id = tr2.p_id 

WHERE
  tr1.f_item = ItemId AND
  tr2.d_date <  DT_DATE and
  tr1.f_warehouse=Gudang ;
  
  IF Tipe = 0 THEN
     RETURN SALDOQTY;
  ELSE
     RETURN SALDONILAI;
  END IF;
END
/
CREATE FUNCTION f04_hppgetavailable(StockDetailId BigInt(20))
  RETURNS Decimal(18, 4)
  NO SQL
BEGIN
  DECLARE result DECIMAL(18,4);
  DECLARE used   DECIMAL(18,4);
  
  set used := f04_hppgetused(StockDetailId);
  SELECT d_qtyin-used INTO result FROM m04dstockdetail where primary_main=StockDetailId;
  Return result;
END
/
CREATE FUNCTION f04_hppgetused(StockDetailId BigInt(20))
  RETURNS Decimal(18, 4)
  NO SQL
BEGIN
  DECLARE result DECIMAL(18,4);
 
  SELECT coalesce(sum(d_qty),0) INTO result FROM m04estockhpp where f_idin=StockDetailId;
  Return result;
END
/
CREATE FUNCTION f04_hppvalue(ID Integer(11))
  RETURNS Double
  NO SQL
begin
DECLARE SALDO      DOUBLE DEFAULT 0.0;
  SELECT coalesce(Sum(m04estockhpp.d_qty * m04dstockdetail.d_price),0)
  INTO SALDO
  FROM m04estockhpp LEFT JOIN m04dstockdetail ON m04estockhpp.f_idin = m04dstockdetail.primary_main 
  WHERE m04estockhpp.f_idout = ID;

  RETURN SALDO;
end
/
CREATE FUNCTION f_getcashflow(id Integer(11), debit Decimal(18, 4), kredit Decimal(18, 4))
  RETURNS Integer(11)
  NO SQL
begin
  DECLARE FCOA INTEGER;
  
  IF debit= 0 THEN
     select f_coa 
     INTO FCOA
     from m01dmaindetail where p_id=id and d_debit>0 limit 0,1;
  ELSE
     select f_coa 
     INTO FCOA
     from m01dmaindetail where p_id=id and d_credit>0 limit 0,1;
  END IF;
  
  return  FCOA;  
end
/
