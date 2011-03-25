SELECT 
	ISNULL(min(S.OrdemServico), 0) [O.S. Inicial], 
	ISNULL(max(S.OrdemServico), 0) [O.S. Final], 
	ISNULL(sum(S.Cancelado), 0) as [O.S. Cancelado],
	ISNULL(sum(SPF.Total), 0) as Total,
	ISNULL(SUM(SPF.Desconto),0) AS Desconto,
	ISNULL(SUM(Dinheiro), 0)as [Dinheiro],
	
	 ISNULL(SUM(SPF.VisaDebito), 0)as[Visa Debito],
	 ISNULL(SUM(SPF.VisaCredito), 0)as[Visa Credito],
	 ISNULL(SUM(SPF.MasterDebito), 0)as[Master Debito],
	 ISNULL(SUM(SPF.MasterCredito), 0)as[Master Credito],
	
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
group by SPF.CartaoTipo