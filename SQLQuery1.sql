create database Assignments
use Assignments

create table EmpTb1(
  empId int  primary key identity(100,1),
  empName varchar(20),
  empSal float 
 );

  insert into EmpTb1 values('Sai',300000)
  insert into EmpTb1 values('Manisha',20000)
  insert into EmpTb1 values('Hema',450000)
  insert into EmpTb1 values('Lakshmi',150000)
  insert into EmpTb1 values('Bhanu',610000)

  select * from EmpTb1