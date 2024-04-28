-- Exibindo os dados da tabela (Todas as informações)
SELECT * FROM [TABELA DE PRODUTOS];

SELECT * FROM [TABELA DE CLIENTES];

-- Exibindo colunas específicas da tabela
SELECT [NOME], [ESTADO] FROM [TABELA DE CLIENTES];

-- Ordenando os registros
SELECT [NOME], [ESTADO] FROM [TABELA DE CLIENTES] ORDER BY [NOME];

-- Apelidando as colunas
SELECT 
    [NOME] AS [NOME DO CLIENTE],
    [CPF],
    [ESTADO] AS [UF]
FROM [TABELA DE CLIENTES]

-- Não exibindo valores repetidos (DISTINCT)
SELECT DISTINCT [SABOR] FROM [TABELA DE PRODUTOS];