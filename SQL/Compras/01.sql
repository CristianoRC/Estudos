--Encontre o nome das pessoas que compraram produtos eletrônicos.

SELECT c.comprador
FROM compra c
INNER JOIN produto p
    ON c.produto = p.pnome
WHERE p.categoria = 'eletronicos'