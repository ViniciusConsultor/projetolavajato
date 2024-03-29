USE [Lavajato]
GO
/****** Object:  StoredProcedure [dbo].[FechamentoDeCaixa]    Script Date: 02/23/2011 20:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[FechamentoDeCaixa] 
	@data varchar(11), @idUsuario  int
As
Select 
	ISNULL(min( tt.[O.S. Inicial]), 0)[O.S. Inicial], 
	ISNULL(max(tt.[O.S. Final]), 0) [O.S. Final], 
	ISNULL(sum(tt.[O.S. Cancelado]), 0)[O.S. Cancelado], 
	ISNULL(sum(tt.Total), 0) [Total], 
	ISNULL(sum(tt.Desconto), 0) [Desconto], 
	ISNULL(sum(tt.Dinheiro), 0) [Dinheiro],
	ISNULL(sum(tt.[Visa Debito]), 0) [Visa Debito],
	ISNULL(sum(tt.[Visa Credito]), 0) [Visa Credito],
	ISNULL(sum(tt.[Master Debito]), 0) [Master Debito],
	ISNULL(sum(tt.[Master Credito]), 0) [Master Credito],
	ISNULL(tt.Entrada, 0) [Entrada],
	ISNULL(tt.Saida, 0) [Saida],
	ISNULL(tt.teste,0) [SomaTotal]

from (
	Select 
	ISNULL(max(Servico.OrdemServico), 0) [O.S. Inicial], 
	ISNULL(min(Servico.OrdemServico), 0) [O.S. Final], 
	ISNULL(sum(Servico.Cancelado), 0) as [O.S. Cancelado],
	ISNULL(sum(Servico.Total), 0) as Total,
	sum(Desconto) as Desconto,
		case when  Servico.FormaPagamentoID = 1 then SUM(Servico.Total) else 0 end as [Dinheiro],
		case when  Servico.FormaPagamentoID = 2 then SUM(Servico.Total) else 0 end as [Visa Debito],
		case when  Servico.FormaPagamentoID = 3 then SUM(Servico.Total) else 0 end as [Visa Credito],
		case when  Servico.FormaPagamentoID = 4 then SUM(Servico.Total) else 0 end as [Master Debito],
		case when  Servico.FormaPagamentoID = 5 then SUM(Servico.Total) else 0 end as [Master Credito],
		
		(select SUM(valor) from Retirada where Retirada.usuarioid = @idUsuario
		and convert(varchar, Retirada.Data, 103) = @data) as [Saida],
		
		(select SUM(valor) from Suprimentos where Suprimentos.usuarioid = 26
		and convert(varchar, Suprimentos.Data, 103) = @data) as [Entrada],
		
		((select SUM(valor) from Suprimentos where Suprimentos.usuarioid = @idUsuario 
		and convert(varchar, Suprimentos.Data, 103) = @data) + 
		(select SUM(Servico.Total) from Servico where Servico.usuarioid = @idUsuario and convert(varchar, Servico.Entrada, 103) = @data) - 
		((select SUM(valor) from Retirada where Retirada.usuarioid = @idUsuario
		and convert(varchar, Retirada.Data, 103) = @data ))) as teste
	from Servico
	Inner Join Usuarios u on u.UsuarioID = Servico.UsuarioID
	where Servico.UsuarioID = @idUsuario and convert(varchar, Servico.entrada, 103) = @data
	group by Servico.FormaPagamentoID
) as tt
group by tt.Entrada, tt.Saida,tt.teste


