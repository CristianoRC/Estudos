/*Encontre o nome das pessoas que compraram produtos de "Pedro"
ou produtos fabricados por uma companhia com valor de ação maior que $50. */
SELECT c.comprador
FROM compra c
INNER JOIN produto p
    ON p.pnome = c.produto
INNER JOIN companhia co
    ON co.cnome = p.fabricante
WHERE c.vendedor = 'Pedro'
        OR co.valoracao >50