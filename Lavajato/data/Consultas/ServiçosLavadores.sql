Create Procedure procServicoPorLavador
@dataInicial as varchar(10),
@dataFinal as varchar(10)
AS
SELECT
	U.NOME,
	P.DESCRICAO,
	COUNT(SF.ProdutoID) TOTALSERVICOS
FROM SERVICO S
	INNER JOIN ServicoFuncionario SF ON S.ServicoID = SF.ServicoID
	INNER JOIN Produto P ON SF.ProdutoID = P.ProdutoID
	INNER JOIN Usuarios u on u.UsuarioID = SF.LavadorID
WHERE sf.LavadorID = 26
	AND CONVERT(VARCHAR, S.ENTRADA, 103) >= @dataInicial AND CONVERT(VARCHAR, S.ENTRADA, 103) <= @dataFinal
	GROUP BY U.NOME,  P.DESCRICAO, S.ServicoID,SF.ServicoID
	order by SF.ServicoID