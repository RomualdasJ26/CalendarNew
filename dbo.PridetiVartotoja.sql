CREATE PROC PridetiVartotoja
@vartotojoVardas nchar(35),
@slaptazodis nchar(35),
@slaptazodisPakartot nchar(35)
AS
    INSERT INTO Login(Username, Password)
    VALUES (@vartotojoVardas, @slaptazodis)