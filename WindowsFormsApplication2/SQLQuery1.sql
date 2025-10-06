create proc sp_login
@id varchar(50) , @pwd varchar(50)
As
select * from Table_users
 where id=@id And pwd=@pwd
