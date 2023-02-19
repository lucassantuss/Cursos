new Error(message, fileName, lineNumber)

// todos os parâmetros são opcionais

const meuErro = new Error('Mensagem inválida');

// Nome do erro
meuErro.name = 'InvalidMessage';

throw meuErro;
// Uncaught InvalidMessage: Mensagem inválida
//     at <anonymous>:1:17

meuErro.name
// 'InvalidMessage'
meuErro.stack
// 'InvalidMessage: Mensagem inválida\n    at <anonymous>:1:17'