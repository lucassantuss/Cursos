class heroiDeAventura {
    constructor(heroi) {
        this.nome = heroi.nome;
        this.idade = heroi.idade;
        this.tipo = heroi.tipo;
    }

    atacar(){
        switch(this.tipo){
            case "Mago":
                this.ataque = "magia"
                break
            case "Guerreiro":
                this.ataque = "espada"
                break
            case "Monge":
                this.ataque = "artes marciais"
                break
            case "Ninja":
                this.ataque = "shuriken"
                break
        }

        console.log(`O ${this.tipo} atacou usando ${this.ataque}`)
    }
}

let heroi = {
    nome: "Lucas",
    idade: 21,
    tipo: "Guerreiro"
}

let novoHeroi = new heroiDeAventura(heroi);
novoHeroi.atacar();