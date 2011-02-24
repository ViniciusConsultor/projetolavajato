select distinct min(s.servicoid) as [O.S. Inicial], max(s.servicoid) as [O.S. Final],
(select count(servico.cancelado) 
from servico where  servico.cancelado = 1 and s.servicoid = servico.servicoid) as [O.S. Cancelado],
sum(s.Total) as [Total Vendas], 
sum(s.Desconto) as [Total Desconto],
isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 1 and s.servicoid = servico.servicoid),0) as [Dinheiro],
isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 2 and s.servicoid = servico.servicoid),0)  as [Visa Debito],
isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 3 and s.servicoid = servico.servicoid),0)  as [Visa Credito],
isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 4 and s.servicoid = servico.servicoid),0) as [Master Debito],
isnull((select sum(servico.total) from servico inner join formapagamento fp on fp.formapagamentoid = servico.formapagamentoid where servico.formapagamentoid = 5 and s.servicoid = servico.servicoid),0)  as [Master Debito]
from servico s
--where s.entrada >= '2010-06-01 00:00:00.000' and s.entrada <= '2010-10-15 23:59:59.999'
group by s.ServicoID
	
select * from FormaPagamento
