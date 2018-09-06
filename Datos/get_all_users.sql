use erp;
drop procedure get_all_users;
go
create procedure get_all_users

as 
begin
	select * from mae_usuario
end
go