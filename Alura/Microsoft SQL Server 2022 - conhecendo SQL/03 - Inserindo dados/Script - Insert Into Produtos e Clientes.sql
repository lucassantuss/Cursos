-- Inserindo Produtos
INSERT INTO [TABELA DE PRODUTOS] VALUES
('1040107', 'Light - 350 ml - Melância', 'Lata', '350 ml', 'Melancia', 4.56),
('1037797', 'Clean - 2 Litros - Laranja', 'PET', '2 Litros', 'Laranja', 16.01);

-- Inserindo Clientes
INSERT INTO [TABELA DE CLIENTES] VALUES
('00384393431', 'João da Silva', 'Rua Projetada A', 'Numero 233', 'Copacabana', 'RJ', '20000000',
'1965-03-21', 57, 'M', 200000, 3000.30, 1),
('00384393555', 'Maria Clara', 'Rua Projetada A', 'Numero 233', 'Copacabana', 'RJ', '20000000',
'1975-03-21', 47, 'F', 200000, 3000.30, 0);

-- Mudando ordem dos valores na inserção (Preço de Lista e Sabor invertidos)
INSERT INTO [TABELA DE PRODUTOS] 
([CODIGO DO PRODUTO], [NOME DO PRODUTO], [EMBALAGEM], [TAMANHO], [PRECO DE LISTA], [SABOR])
VALUES
('1040107', 'Light - 350 ml - Melância', 'Lata', '350 ml', 4.56, 'Melancia');