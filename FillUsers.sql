declare @Name nvarchar(50),@pd int,@as int,@no int, @sl int, @k int,
@Password nvarchar(50), @Age int,@i int,@RandomSymbol char(60),
@RandomSymbolAndNumber char(70), @index int,@iglobal int,@mark int,
@sex nvarchar(10),@stringNumber nvarchar(20),@numberPasport int,
@Data2 Datetime,@y nvarchar(3),@n nvarchar(2)
set @y='yes'
set @n='no'
set @RandomSymbol = 'qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM'
select @i=0,@index=0,@iglobal=0

while @iglobal < 100
begin
          set @i = 0;
	      set @Name='';
		  set @Password='';
		  set @Age = 0;
		  set @pd =  0;
		  set @as =  0;
		  set @no =  0;
		  set @sl =  0;
		  set @k =  0;
		  set @mark = 0;

		  if @iglobal%2 =0
		  begin
          set @sex='Man';
          end
          if @iglobal%2 !=0
          begin
          set @sex = 'Woman';
          end



      while @i < 15
	  begin
	      set @index=Rand()*60;
	      set @Name=@Name + substring(@RandomSymbol,@index, 1);
		  set @i= @i + 1;
	  end

	  set @i = 0;

	  while @i < 8
	  begin
	      set @index=Rand()*60;
	      set @Password=@Password + substring(@RandomSymbol,@index, 1);
		  set @i=@i+1;
	  end

	  set @Age = FLOOR(RAND()*(21-18)+18);
	  set @pd =  FLOOR(RAND()*(8-0)+0);
	  set @as =  FLOOR(RAND()*(8-0)+0);
	  set @no =  FLOOR(RAND()*(8-0)+0);
	  set @sl =  FLOOR(RAND()*(8-0)+0);
	  set @k =  FLOOR(RAND()*(8-0)+0);
	  set @mark =  FLOOR(RAND()*(50-0)+0);
	  

	  begin
	  insert into SecondTests(Mark)
	  values(@mark)
	  insert into Users(UserName, Gender, Age, Password, P_D, A_S, N_O, S_L, K, RoleId)
	  values(@Name, @sex, @Age, @Password, @pd, @as, @no, @sl, @k,1)
	  end
	  
	  set @iglobal = @iglobal + 1
end