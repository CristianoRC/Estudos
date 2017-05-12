--Encontre o nome das pessoas que compraram produtos japoneses e vivem em Curitiba.
SELECT c.comprador
FROM pessoa p
INNER JOIN compra c
    ON c.comprador = p.nomepess
INNER JOIN produto pr
    ON pr.pnome = c.produto
INNER JOIN companhia co
    ON co.cnome = pr.fabricante
WHERE co.pais = 'Japao'
        AND p.cidade = 'Curitiba'