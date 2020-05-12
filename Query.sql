select M.Mem_ID, M.Mem_Name, M.Join_Date, C.Col_Date,C.Fee_Type, C.Bank_Name, C.Col_Amt,CT.Type_Details from tbl_member as M left outer join tbl_Collections as C on M.Mem_Id=C.Mem_ID left outer join tbl_collection_type as CT on C.Type_ID=CT.Type_ID  ;


select M.Bank_Name, count(M.Mem_ID) as 'Total Member', (select count(C.Mem_ID) from tbl_Collections as C where  year(C.Col_Date) =year('2016-12-26') group by M.Bank_Name) as PaidMember  from tbl_member as M where M.Join_date <='2018-12-26' group by  M.Bank_Name;


select M.Bank_Name, count(C.Mem_ID) from tbl_Collections as C inner join tbl_Member as M on M.Mem_Id=C.Mem_Id where M.Mem_Id=C.Mem_ID and year(C.Col_Date)=year('2016-12-26') group by  M.Bank_Name;


select count(C.Mem_ID) from tbl_Collections as C  group by  M.Bank_Name


select M.Bank_Name, count(M.Mem_ID) as 'Total Member'from tbl_member  as M where Year(M.Join_Date) <= year('2016-12-26') group by M.Bank_Name;

select M.Bank_Name, count(C.Mem_ID) as PaidMember from tbl_Collections as C inner join tbl_member as M on M.Mem_Id=C.Mem_ID where year(C.Col_Date) = year('2017-12-26') group by  M.Bank_Name;
