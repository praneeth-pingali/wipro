create database praneeth

use praneeth

create table Employee(Empid int,Empname varchar(25),city varchar(20));

Alter table Employee add dept varchar(10),salary decimal(8,2);

select * from Employee

select * from Employee where salary>45000 and dept='Coding'

select * from Employee

select * from Employee where empname like '%a' 

select * from Employee where empname like '%i_'

select * from Employee where empname like '%[ya]' 

select * from Employee where empname like '[sz]%'

select * from Employee where empname like '[s-z]%' 

select * from Employee where empname like '[^s-z]%' 

delete from Employee where empid=14

create table Product(Prodid int not null,proName varchar(30),price decimal(10,2),Qty int)

select proname,price,qty,price * qty as TotalPrice from Product

	
alter table Product add discount varchar(6)

select * from Product where discount like '10!%' escape '!'

alter table Product add discount varchar(6)

select * from Product where discount like '10!%' escape '!'

insert into product(prodid,proname,price,qty) values(113,'iPod',700,2)

alter table product add constraint UQ_Proname unique(proname)

delete from product where proname='ipod'

alter table product add primary key(prodid)