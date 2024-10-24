-- Junção entre tabelas com o LEFT JOIN
SELECT TE.NOME, TD.HOBBY 
FROM TABELA_ESQUERDA TE
LEFT JOIN 
TABELA_DIREITA TD
ON TE.IDENTIFICADOR = TD.IDENTIFICADOR;

-- Junção entre tabelas com o RIGHT JOIN
SELECT TE.NOME, TD.HOBBY 
FROM TABELA_ESQUERDA TE
RIGHT JOIN 
TABELA_DIREITA TD
ON TE.IDENTIFICADOR = TD.IDENTIFICADOR;

-- Junção entre tabelas com o FULL JOIN
SELECT TE.NOME, TD.HOBBY 
FROM TABELA_ESQUERDA TE
FULL JOIN 
TABELA_DIREITA TD
ON TE.IDENTIFICADOR = TD.IDENTIFICADOR;

-- Junção entre tabelas com o CROSS JOIN
SELECT TE.NOME, TD.HOBBY 
FROM TABELA_ESQUERDA TE
CROSS JOIN 
TABELA_DIREITA TD