// -> PROMISE
// Promessa de resultado, podendo ser resolve ou reject

const myPromise = new Promise((resolve, reject) => {
    window.setTimeout(() => {
        resolve(console.log('Resolvida!'));
    }, 2000);
});

console.log(myPromise);
// Após 2 segundos retorna no log 'Resolvida!'

// Manipulando o Promise com AWAIT
const myPromise2 = new Promise((resolve, reject) => {
    window.setTimeout(() => {
        resolve('Resolvida');
    }, 2000);
});

await myPromise2
        .then((result) => result + ' passando pelo then')
        .then((result) => result + ' e agora acabou!')
        .catch((err) => console.log(err.message));
// Após 2 segundos, retornará o valor
// 'Resolvida passando pelo then e agora acabou!'

// -> ASYNC // AWAIT
// Funções assíncronas precisam dessas duas palavras chave

async function resolvePromise(){
    const myPromise3 = new Promise((resolve, reject) => {
        window.setTimeout(() => {
            resolve('Resolvida');
        }, 3000);
    });

    const resolved = await myPromise3
        .then((result) => result + ' passando pelo then')
        .then((result) => result + ' e agora acabou!')
        .catch((err) => console.log(err.message));
    
    return resolved;
}

resolvePromise();
// Promise {<pending>}
// [[Prototype]]: Promisecatch: ƒ catch()constructor: ƒ Promise()finally: ƒ finally()then: ƒ then()Symbol(Symbol.toStringTag): "Promise"[[Prototype]]: Object[[PromiseState]]: "pending"[[PromiseResult]]: undefined
await resolvePromise();
// 'Resolvida passando pelo then e agora acabou!'