// -> Gerando exceção com THROW

function verificaPalindromo(string){
    if (!string) throw 'String inválida';

    return string === string.split('').reverse().join('');
}

verificaPalindromo('');
// Uncaught String inválida

// -> TRY.. catch
function tryCatchExemplo(string){
    try{
        verificaPalindromo(string);
    }
    catch(e){
        console.log(e);
    }
}

tryCatchExemplo('');
// String inválida

// -> FINALLY
// Executa independente de entrar no catch ou não - try.. catch.. FINALLY!!

function tryCatchExemplo(string){
    try{
        verificaPalindromo(string);
    }
    catch(e){
        throw e;
    }
    finally{
        console.log('A string enviada foi: ' + string);
    }
}

tryCatchExemplo('');
// A string enviada foi:
// Uncaught String inválida