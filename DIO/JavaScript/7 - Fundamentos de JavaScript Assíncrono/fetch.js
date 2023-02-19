// -> FETCH
// Consumindo APIs

fetch(url, options)
    .then(response => response.json())
    .then(json => console.log(json))
// Retorna uma Promise

// Realizar operações no BANCO DE DADOS
// POST, GET, PUT, DELETE, etc

// Exemplo 1 - GET
fetch('https://endereco-api.com/', {
    method: 'GET',
    cache: 'no-cache',

})
    .then(response => response.json())
    .then(json => console.log(json))

// Exemplo 2 - POST - Manda dados para o banco
fetch('https://endereco-api.com/', {
    method: 'POST',
    cache: 'no-cache',
    body: JSON.stringify(data) // Converte de JSON para uma string
})
    .then(response => response.json())
    .then(json => console.log(json))