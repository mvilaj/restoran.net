CREATE PROCEDURE UnosStavkeRacuna
	@racun int,
	@artikl int,
	@kolicina int,
	@pripremljen bit
	
	
AS
insert into [Stavka racuna](Racun,Artikl,Kolicina,Pripremljen) values (@racun, @artikl, @kolicina,@pripremljen);

GO
