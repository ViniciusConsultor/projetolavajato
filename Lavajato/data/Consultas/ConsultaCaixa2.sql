Select 
	ISNULL(MIN(Servico.OrdemServico), 0) [O.S. Inicial], 
	ISNULL(MAX(Servico.OrdemServico), 0) [O.S. Final], 
	ISNULL(SUM(Servico.Cancelado), 0) as [O.S. Cancelado],
	ISNULL(SUM(Servico.Total), 0) as Total,
	
	SUM(sp.Desconto) Desconto,
	
	SUM(sp.Dinheiro)  as [Dinheiro],
	CASE WHEN  sp.CartaoTipo = 2 THEN SUM(sp.CartaoValor) ELSE 0 END AS [Visa Debito],
	CASE WHEN  sp.CartaoTipo = 3 THEN SUM(sp.CartaoValor) ELSE 0 END AS [Visa Credito],
	CASE WHEN  sp.CartaoTipo = 4 THEN SUM(sp.CartaoValor) ELSE 0 END AS [Master Debito],
	CASE WHEN  sp.CartaoTipo = 5 THEN SUM(sp.CartaoValor) ELSE 0 END AS [Master Credito],
	
	ISNULL((SELECT SUM(valor) FROM Suprimentos WHERE Suprimentos.usuarioid = 26
	AND CONVERT(VARCHAR, Suprimentos.Data, 103) = '19/09/2011'),0) as [Entrada],
	
	ISNULL((SELECT SUM(valor) FROM Retirada WHERE Retirada.usuarioid = 54
	AND CONVERT(VARCHAR, Retirada.Data, 103) = '19/09/2011'),0) as [Saida],
	
	ISNULL((SELECT SUM(valor) FROM Retirada WHERE Retirada.usuarioid = 54
	AND CONVERT(VARCHAR, Retirada.Data, 103) = '19/09/2011'),0) as [Vale],
	
	(ISNULL(sp.Total,0) +
	ISNULL((SELECT SUM(valor) FROM Suprimentos WHERE Suprimentos.usuarioid = 54
	AND CONVERT(VARCHAR, Suprimentos.Data, 103) = '19/09/2011'),0)) -
	ISNULL((SELECT SUM(valor) FROM Retirada WHERE Retirada.usuarioid = 54
	AND CONVERT(VARCHAR, Retirada.Data, 103) = '19/09/2011'),0)as teste 
	
	FROM Servico
	INNER JOIN Usuarios u on u.UsuarioID = Servico.UsuarioID
	INNER JOIN ServicoFormaPagamento sp on Servico.ServicoID = sp.ServicoID
	WHERE Servico.UsuarioID = 54 
	AND CONVERT(VARCHAR, Servico.entrada, 103) = '19/03/2011'
	GROUP BY Servico.FormaPagamentoID, sp.CartaoTipo, sp.Total
	
	
	
	
	
	
	
	--( select SUM(Dinheiro) from ServicoFormaPagamento Where CartaoTipo = 1 
	--and ServicoFormaPagamento.ServicoID = Servico.ServicoID)  [Dinheiro],
	--( select SUM(CartaoValor) from ServicoFormaPagamento Where CartaoTipo = 2 
	--and ServicoFormaPagamento.ServicoID = Servico.ServicoID) [Visa Debito],
	--( select SUM(CartaoValor) from ServicoFormaPagamento Where CartaoTipo = 3 
	--and ServicoFormaPagamento.ServicoID = Servico.ServicoID) [Visa Credito],
	--( select SUM(CartaoValor) from ServicoFormaPagamento Where CartaoTipo = 4 
	--and ServicoFormaPagamento.ServicoID = Servico.ServicoID) [Master Debito],
	--( select SUM(CartaoValor) from ServicoFormaPagamento Where CartaoTipo = 5 
	--and ServicoFormaPagamento.ServicoID = Servico.ServicoID) [Master Credito],
	
	
	--select * from ServicoFormaPagamento
	--select * from Retirada