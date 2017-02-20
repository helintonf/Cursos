

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