/*Encontre o nome e a cidade onde moram as pessoas que são as únicas moradoras desta cidade cadastradas no sistema*/

select t.nomepess
from pessoa t
inner join (
    select p.cidade,
           count(*) as num_moradores
    from pessoa p
    group by p.cidade
    having count(*) = 1
) x
on x.cidade = t.cidade