/*Encontre o nome das pessoas que compraram produtos japoneses, mas que não compraram produtos brasileiros.*/
SELECT c.comprador
FROM compra c
INNER JOIN produto p
    ON p.pnome = c.produto
INNER JOIN companhia co
    ON co.cnome = p.fabricante
WHERE co.pais = 'Japao' exceptSELECT c.comprador
FROM compra c
INNER JOIN produto p
    ON p.pnome = c.produto
INNER JOIN companhia co
    ON co.cnome = p.fabricante
WHERE co.pais = 'Brasil'