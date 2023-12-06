let saldoVitorias = calcularSaldo(100, 25);

let nivel = verificarNivel(saldoVitorias);

console.log(`O Herói tem saldo de ${saldoVitorias} e está no nível ${nivel}`);

function calcularSaldo(qtdVitorias, qtdDerrotas) {
    return qtdVitorias - qtdDerrotas;
}

function verificarNivel(saldo) {
    if (saldo < 10)
        return "Ferro";
    else if (saldo > 10 && saldo <= 20)
        return "Bronze";
    else if (saldo > 20 && saldo <= 50)
        return "Prata";
    else if (saldo > 50 && saldo <= 80)
        return "Ouro";
    else if (saldo > 80 && saldo <= 90)
        return "Diamante";
    else if (saldo > 90 && saldo <= 100)
        return "Lendário";
    else if (saldo >= 101)
        return "Imortal";
    else
        return "";
}