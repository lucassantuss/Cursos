// camelCase

var a = 1;
var b = 2;

if (a === 1){
    var a = 11; // the scope is global
    let b = 22; // the scope is inside if-block

    console.log(a); // 11
    console.log(b); // 22
}

console.log(a); // 11
console.log(b); // 2

// Hoisting -> Dar valor a uma variável, antes de declarar ela -> var

numberOne = 1;

console.log(numberOne + 2);

var numberOne;

// VAR e LET

var firstName = 'João';
let lastName = 'Souza'

if (firstName === 'João'){
    let lastName = 'Rodrigues';
    var firstName = 'Pedro';
    lastName = 'Silva';
    
    console.log(lastName);
}

console.log(firstName, lastName);