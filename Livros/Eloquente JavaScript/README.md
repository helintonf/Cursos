

#C01 - Valores, Tipos e Operadores

- Bits são descritos como 0 e 1.
- Dados são separados em valores.
- Valores tem tipos.
- Existem 6 tipos em JavaScript:
    + number - (números).
    + string - (Textos).
    + boolean - (boleanos).
    + object - (objetos).
    + function - (funções).
    + undefined - (indefinido).

##Number - Números

- São valores numéricos.
- São de 64 bits ou numeros abaixo de 18 quintilhões.
- Infinity é número especial para valores infinitos positivos.
- -Infinity é número especial para valores infinitos negativos.
- NaN significa "Not a Number" (não é um número) acontece quando a operação não produz um valor numérico.

#Strings

- para colocar um texto em multiplas linhas é só colocar `\n` no texto.


```javascript

var stA = "texto novo \n nova linha";
var stB = "texto novo \"\\n\"nova linha";
var stC = "con"+"ca"+"te"+"na"+"do";
```

#C02 - Estrutura do programa

- Um fragmento de código que `produz` um valor é chamado de `expressão`.
- Todo valor é uma expressão.
- Uma expressão entre parênteses também é uma expressão.
- Operadores aplicado a espressões também.
- Pode combinar expressões encadeadas.

Declaração:

- Vale por si só.
- Equivale a alguma coisa
- se ela afeta em algo.
- essas mudanças são chamdas efeitos colaterais.


Variaveis

- imaginar como tentaculos.

Função

- valores dados a função são chamados argumetos.
- As chaves, para declarações, são similares aos parênteses para as expressões.
- Agrupando e fazendo com que sejam tratadas como uma única declaração.
- Uma sequencia de declarações envolvidas por chaves é chamada de `bloco`.

```javascript

var theNumber = Number(prompt("Pick a number", ""));
if(!isNaN(theNumber))
    alert("Your number is the square root "+theNumber * theNumber);
else
    alert("Ei! cade o numero?");


var num = Number(prompt("Digite um número","0"));

if(num < 10)
    alert("Pequeno");
else if(num < 100)
    alert("Médio");
else
    alert("Grande");


```

While:

```javascript

var number = 0;

while (number <= 12){
    console.log(number);
    number += 1;
}


var result = 1;
var counter = 0;

while (counter < 10){
    result *=  2;
    counter += 1;
}
console.log(result);
```

do:

```javascript

do{
    var name = prompt("Who are you?");
}while(!name);
console.log(name);

```

for:

```javascript

for (var number = 0; number <=12; number = number +2){
    console.log(number);
}


```

break:

quebrar a execução de um loop.

```javascript

for(var current = 20; ;current++)
{
    if(current % 7 == 0){
        break;
    }
    console.log(current);
}

```

continue: interenpe a execução do loop pulando para a proxima interação.

##Atualizando variáveis sucintamente.

```javascript

soma += 1;

multiplica *= 1;

diminue -= 1;

//mais curtos

counter++

counter--

```

##switch

```javascript

switch(prompt('What is the weather like?')){
    case "chuva":
        console.log("It's rainy, Remenber to bring an umbrella.");
        break;
    case "sol":
        console.log("It's sunny, Dress lightly.");
        break;
    case "nublado":
        console.log("It's cloudy, Go outside.");
        break;
    default:
        console.log("Unknow weather type!");
        break;
}

/*nomes possiveis pra variaveis*/

var nomecompostovalor;

var nome_composto_valor;

var NomeCompostoValor; //funções com construtor

var nomeCompostoValor;

```

##Exercícios

###Triângulo com Loop

Escreva um programa que faça sete chamadasa console.log() para retornar o seguinte triângulo:

#
##
###
####
#####
######
#######


```javascript

var value = "#";
while(value.length < 7){
    console.log(value);
    value += "#";
}

//Solução livro

for(var line = "#"; line.length <= 7; line +="#")
    console.log(line);
```

###FizzBuzz

```javascript

for(var i = 0; i < 100; i++){

    var st = "";
    if(i % 3 == 0){
        st="Fizz";    
    }
    if(i % 5 == 0){
        st += "Buzz";
    }
    if(st != ""){
        console.log(st);    
    }else{
        console.log(i)        
    }
    
}

//solução livro

for (var n = 1; n <= 100; n++) {
  var output = "";
  if (n % 3 == 0)
    output += "Fizz";
  if (n % 5 == 0)
    output += "Buzz";
  console.log(output || n);
}

```

###Tabuleiro de Xadrez

```javascript

var size = 8;
var vl =""; 

for(var i = 0; i < size; i++){    
       
    for(var j = 0; j < size; j++){
        var tt = ((i+j) % 2);
        if(tt == 0){
            vl += "#";
        }else {
            vl += " ";
        }
    }
    vl +="\n";
}

console.log(vl);

```

#C03 - Funções

##Definindo uma função

```javascript

var square = function(x){
    return x*x;
};

console.log(square(12));

```

nenhum parametro:

```javascript

var makeNoise = function(){
    console.log("Pling!");
};

```

Varios parametros:

```javascript

var power = function(base,exponent){
    var result = 1;
    for(var count = 0; count < exponent; count++){
        result *= base;        
    }
    return result;
};

console.log(power(2,10));

```

##Parâmetros e Escopos

```javascript

var x = "outside";

var f1 = function(){
    var x = "inside f1";
};
f1();
console.log(x);
// ouside

var f2 = function(){
    x = "inside f2";
};
f2();
console.log(x);
//inside

```