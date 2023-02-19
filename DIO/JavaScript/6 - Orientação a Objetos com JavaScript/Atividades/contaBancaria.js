// Atividade: Conta Bancária

// Nesta atividade, vamos testar os conceitos de Orientação a Objetos simulando a criação de diversos tipos de contas bancárias e operações disponíveis em cada uma.

// -> Crie a classe ContaBancaria, que possui os parâmetros agencia, numero, tipo e saldo;
// -> Dentro de ContaBancaria, construa o getter e o setter de saldo;
// -> Dentro de ContaBancaria, crie os métodos sacar e depositar;
// -> Crie uma classe-filha chamada ContaCorrente que herda todos esses parâmetros e ainda possua o parâmetro cartaoCredito;
// -> Ainda em ContaCorrente, construa o getter e o setter de cartaoCredito;
// -> Ainda em ContaCorrente, faça com que o tipo seja 'conta corrente' por padrão;
// -> Crie uma classe-filha chamada ContaPoupanca que herda todos os parâmetros de ContaBancaria;
// -> Crie uma classe-filha chamada ContaUniversitaria que herda todos os parâmetros de ContaBancaria;
// -> Faça com que o método saque de ContaUniversitaria apenas seja capaz de sacar valores menores que 500 reais.

class contaBancaria {
    constructor(agencia, numero, tipo){
        this.agencia = agencia;
        this.numero = numero;
        this.tipo = tipo;
        this._saldo = 0;
    }

    get saldo(){
        return this._saldo;
    }

    set saldo(valor){
        this._saldo = valor;
    }

    sacar(valor){
        if(valor > this._saldo) return 'Operação negada!';

        this._saldo = this._saldo - valor;

        return this._saldo;
    }

    depositar(valor){
        this._saldo = this._saldo + valor;

        return this._saldo;
    }
}

class contaCorrente extends contaBancaria {
    constructor(agencia, numero, cartaoCredito){
        super(agencia, numero);
        this.tipo = 'corrente';
        this._cartaoCredito = cartaoCredito;
    }

    get cartaoCredito(){
        return this._cartaoCredito;
    }

    set cartaoCredito(valor){
        this._cartaoCredito = valor;
    }
}

class contaPoupanca extends contaBancaria {
    constructor(agencia, numero){
        super(agencia, numero);
        this.tipo = 'poupança';
    }
}

class contaUniversitaria extends contaBancaria {
    constructor(agencia, numero){
        super(agencia, numero);
        this.tipo = 'universitária';
    }

    sacar(valor){
        if(valor > 500) return 'Operação negada!';

        this._saldo = this._saldo - valor;
    }
}

// -> TESTES NO CONSOLE DO NAVEGADOR
const minhaConta = new contaCorrente(1, 234, true)
// undefined
minhaConta
// contaCorrente {agencia: 1, numero: 234, tipo: 'corrente', _saldo: 0, _cartaoCredito: true}
minhaConta.saldo
// 0
minhaConta.depositar(1000)
// 1000
minhaConta.sacar(500)
// 500
minhaConta.saldo
// 500
minhaConta.sacar(600)
// 'Operação negada!'

const contaPoup = new contaPoupanca(1, 22)
// undefined
const contaUni = new contaUniversitaria(1, 22)
// undefined
contaUni.depositar(1000)
// 1000
contaUni.sacar(550)
// 'Operação negada!'