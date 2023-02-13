function validaNum(num1, num2) {
    let retorno;
    const soma = num1 + num2;

    retorno = `Os números ${num1} e ${num2} `;
    
    num1 === num2 ? retorno += `são iguais. ` : retorno += `não são iguais. `;

    retorno += `Sua soma é ${soma}, `;

    soma > 10 ? retorno += `que é maior que 10 e ` : retorno += `que é menor que 10 e `;

    soma > 20 ? retorno += `maior que 20.` : retorno += `menor que 20.`;

    console.log(retorno);
}

validaNum(1, 2);