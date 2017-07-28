//ES5
/* function funcao(){

}

funcao()

const funcao2 = function(){

}

funcao2(); */
///////
//ES6

const soma = (num1, num2) => {
    return num1 + num2;
}

const multiplicar = (num1,num2) => num1 * num2;

console.log(soma(1,2));
console.log(multiplicar(2,2));