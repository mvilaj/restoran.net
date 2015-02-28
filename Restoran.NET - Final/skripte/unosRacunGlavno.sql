CREATE PROCEDURE UnosRacunaGlavno
	@datum datetime,
	@zaposlenik int
	
	
AS
insert into Racun([Datum i vrijeme],Zaposlenik) values (@datum, @zaposlenik);

GO
