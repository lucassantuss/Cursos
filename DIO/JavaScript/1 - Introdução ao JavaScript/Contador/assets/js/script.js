/*
-> Exercicios Extra
-> Tente implementar os eventos usando o método addEventListener.
-> Mude a cor do texto em CURRENT_NUMBER para vermelho quando o número for negativo.
*/

var currentNumberWrapper = document.getElementById("currentNumber");
var currentNumber = 0;

function increment() {
    currentNumber = currentNumber + 1;
    currentNumberWrapper.innerHTML = currentNumber;
    textoColorido();
}

function decrement() {
    currentNumber = currentNumber - 1;
    currentNumberWrapper.innerHTML = currentNumber;
    textoColorido();
}

function textoColorido() {
    if (currentNumber < 0){
        document.getElementById("currentNumber").style.color = 'red';
    }
    else{
        document.getElementById("currentNumber").style.color = 'black';
    }
}

document.getElementById("adicionar").addEventListener("click", increment);
document.getElementById("subtrair").addEventListener("click", decrement);