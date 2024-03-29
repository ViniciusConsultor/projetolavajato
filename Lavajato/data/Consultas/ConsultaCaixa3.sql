Select 
	ISNULL(min( tt.[O.S. Inicial]), 0)[O.S. Inicial], 
	ISNULL(max(tt.[O.S. Final]), 0) [O.S. Final], 
	ISNULL(max(tt.[O.S. Final]), 0) - ISNULL(min( tt.[O.S. Inicial]), 0)  [QtdeOS],
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
	SELECT 
	ISNULL(min(S.OrdemServico), 0) [O.S. Inicial], 
	ISNULL(max(S.OrdemServico), 0) [O.S. Final], 
	ISNULL(sum(S.Cancelado), 0) as [O.S. Cancelado],
	ISNULL(sum(SPF.Total), 0) as Total,
	ISNULL(SUM(SPF.Desconto),0) AS Desconto,
	ISNULL(SUM(Dinheiro), 0)as [Dinheiro],
	case when  SPF.FormaPagamentoID = 2 then SUM(SPF.CartaoValor) else 0 end as [Visa Debito],
	case when  SPF.FormaPagamentoID = 3 then SUM(SPF.CartaoValor) else 0 end as [Visa Credito],
	case when  SPF.FormaPagamentoID = 4 then SUM(SPF.CartaoValor) else 0 end as [Master Debito],
	case when  SPF.FormaPagamentoID = 5 then SUM(SPF.CartaoValor) else 0 end as [Master Credito],
	
	(select SUM(valor) from Suprimentos where Suprimentos.usuarioid = 54
	and convert(varchar, Suprimentos.Data, 103) = '19/03/2011') as [Entrada],
		
	(select SUM(valor) from Retirada where Retirada.usuarioid = 54
	and convert(varchar, Retirada.Data, 103) = '19/03/2011') as [Saida],
	
	SUM(SPF.Total) +
	isnull((select SUM(valor) from Suprimentos where Suprimentos.usuarioid = 54
	and convert(varchar, Suprimentos.Data, 103) = '19/03/2011'),0) -
	isnull((select SUM(valor) from Retirada where Retirada.usuarioid = 54
	and convert(varchar, Retirada.Data, 103) = '19/03/2011'),0)as teste 
	
FROM ServicoFormaPagamento SPF
INNER JOIN Servico S ON S.ServicoID = SPF.ServicoID
Inner Join Usuarios u on u.UsuarioID = S.UsuarioID
where S.UsuarioID = 54 and convert(varchar, S.entrada, 103) = '19/03/2011'
group by SPF.FormaPagamentoID

) as tt
--group by tt.Entrada, tt.Saida,tt.teste


--exec [FechamentoDeCaixa] '23/02/2011', 26