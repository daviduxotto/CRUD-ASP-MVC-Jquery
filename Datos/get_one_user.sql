use erp;
drop procedure get_one_user;
go
create procedure get_one_user
   @parusuario varchar(15)
as 
begin
	select * from mae_usuario where cod_usuario=@parusuario;
end
go