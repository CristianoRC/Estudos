-- Encontre o nome das pessoas que compraram E venderam alguma coisa.
SELECT c.comprador
FROM compra c
INNER JOIN compra v
    ON c.comprador = v.vendedor