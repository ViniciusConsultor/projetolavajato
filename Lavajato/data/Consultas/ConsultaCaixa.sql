select 
	min( tt.[O.S. Inicial])[O.S. Inicial], 
	max(tt.[O.S. Final]) [O.S. Final], 
	sum(tt.[O.S. Cancelado])[O.S. Cancelado], 
	sum(tt.Total) [Total], 
	sum(tt.Desconto) [Desconto], 
	sum(tt.Dinheiro) [Dinheiro],
	sum(tt.[Visa Debito]) [Visa Debito],
	sum(tt.[Visa Credito]) [Visa Credito],
	sum(tt.[Master Debito]) [Master Debito],
	sum(tt.[Master Credito]) [Master Credito]
from (
	Select 
	max(OrdemServico) [O.S. Inicial], 
	min(OrdemServico) [O.S. Final], 
	sum(Cancelado) as [O.S. Cancelado],
	sum(Total) as Total,
	sum(Desconto) as Desconto,
		case when  FormaPagamentoID = 1 then SUM(Total) else 0 end as [Dinheiro],
		case when  FormaPagamentoID = 2 then SUM(Total) else 0 end as [Visa Debito],
		case when  FormaPagamentoID = 3 then SUM(Total) else 0 end as [Visa Credito],
		case when  FormaPagamentoID = 4 then SUM(Total) else 0 end as [Master Debito],
		case when  FormaPagamentoID = 5 then SUM(Total) else 0 end as [Master Credito]
	from Servico
	group by FormaPagamentoID
) as tt


