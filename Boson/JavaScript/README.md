#Índice
* [A01 - Introdução](#a01---introdução)
  * [Javascript](#javascript)
* [A02 - Variáveis e Tipos de Dados](#a02---variáveis-e-tipos-de-dados)
  * [Tipos de Dados em Javascript](#tipos-de-dados-em-javascript)
    * [Tipos de Dados](#em-javascript-há-diversos-tipos-de-dados-disponíveis-tais-como)
    * [Tipo de dado Númerico](#tipos-de-dados-númerico)
    * [Tipo de dado String](#tipos-de-dados-strings)
    * [Tipo de dado Booleano](#tipos-de-dados-booleano)
  * [Criando Variáveis](#criando-variáveis-em-javascript)
  * [Palavras Reservadas](#nomes-de-variáveis-e-palavras-reservadas)
  * [Escopo Variáveis](#escopo-das-variáveis)
  	- [Declarando Variáveis](#declarando-variáveis)
  * [Operador typeof](#operador-typeof)
* [A03 - Operadores Aritméticos](#a03---operadores-aritméticos)
* [A04 - Constantes](#a04---constantes)
	- [Boas Práticas](#boa-prática)
* [A05 - Métodos Javascript](#a05---métodos-javascript)
	- [Método alert()](#método-alert)
	- [Método prompt()](#método-prompt)
	- [Método confirm()](#método-confirm)
	- [Método documentwrite()](#método-documentwrite)
* [A06 - Convertendo Tipos de Dados](#a06---convertendo-tipos-de-dados)
	- [Operador typeof](#operador-typeof-1)
	- [Converter para String](#converter-para-string)
	- [Converter para Number](#converter-para-number)
		+ [Converter para número inteiro](#converter-para-número-inteiro)
		+ [Converter para número de ponto flutuante](#converter-para-número-de-ponto-flutuante)
			* [Precisão de ponto flutuante](#precisão-de-ponto-flutuante)
			* [Comprimento de ponto flutuante](#comprimento-de-ponto-flutuante)
* [A07 - Operadores Relacionais](#a07---operadores-relacionais)
* [A08 - Operadores Lógicos](#a08---operadores-lógicos)
	- [AND lógico - &&](#and-lógico---)
		+ [Retornando operandos com &&](#retornando-operandos-com-)
	- [OR lógico - ||](#or-lógico---)
		+ [Retornando operandos com ||](#retornando-operandos-com--1)
	- [NOT lógico - !](#not-lógico---)
* [A09 - Estruturas de decisão Condicional IF](#a09---estruturas-de-decisão-condicional-if)	 
	- [Estrutura Condicional Composta - if / else](#estrutura-condicional-composta---if--else)
	- [Estrutura Condicional Aninhada ou Encadeado - else if](#estrutura-condicional-aninhada--ou-encadeado---else-if)
* [A10 - Estrutura Condicional Switch Case](#a10---estrutura-condicional-switch-case)	 	
* [A11 - Estrutura de Repetição FOR](#a11---estrutura-de-repetição-for)
* [A12 - Estrutra de Repetição While](#a12---estrutra-de-repetição-while)
* [A13 - Arrays Declaração e Atribuição](#a13---arrays-declaração-e-atribuição)
	- [Criando um Array literal](#criando-um-array-literal)
	- [Criando um Array com new](#criando-um-array-com-new)
	- [Lendo os elementos do Array](#lendo-os-elementos-do-array)
	- [Alterando um Array](#alterando-um-array)
* [A14 - Propriedades e Métodos de um Array](#a14---propriedades-e-métodos-de-um-array)	
	- [length](#length)
	- [push()](#push)
	- [pop()](#pop)
	- [join()](#join)
	- [shift()](#shift)
	- [delete](#delete)
	- [splice()](#splice)
		+ [Removendo Elementos com método splice()](#removendo-elementos-com-método-splice)
	- [concat()](#concat)


#A01 - Introdução

##JavaScript
- Linguagem `interpretada`, e não compilada, assim como PHP e Ruby.
- Não é uma versão "script" do Java, e não tem relação entre si.
- Disponibilizada primeiramente no navegador Netscape Navigator 2.
- Chamada inicialmente de `LiveScript`.
- No Internet Explorer 3 foi adicionado o JScript, "dialeto" MS do JavaScript.
- Padronizada em 1997 pela ECMA International, e renomeada para **ECMAScript**.
- Executada a partir de um navegador, ou ainda em um servidor Web ou dentro de arquivos específicos.
- Usada para interagir com usuários e criada inicialmente para validar entradas em formulários HTML.
- Atualmente tem aplicações amplas, como Google Maps, LibreOffice, Planilhas Google e muitas outras.

#A02 - Variáveis e Tipos de Dados

##Tipos de dados em JavaScript
- O JavaScript é uma linguaguem não tipada.
- Não especificamos os tipos dos dados representados - o JS os identifica.
- Os tipo de dados são dinâmicos, o que significa que a mesma variável pode ser usada com tipos diferentes.
- Mas é possivel converter tipos de dados usando funções específicas.

###Em JavaScript há diversos tipos de dados disponíveis, tais como:
- Número inteiro.
- Número de ponto flutuante.
- String.
- Booleano.
- Array.
- Objeto.

###Tipos de dados Númerico:
- São divididos em números inteiros e números de ponto flutuante (com casas decimais).
- Internamente, ambos o stipos são tratados como ponto flutuante.

###Tipos de dados Strings:
- Representam dados de texto, que devem ser representados entre aspas, simples ou duplas.

###Tipos de dados Booleano:
- É aquele que apresenta apenas valores TRUE (verdadeiro) ou FALSE (falso).

##Criando variáveis em JavaScript
- Nomes de variáveis podem começar com uma `letra`, um `underscore` (_) ou um `crifrão` ($).
- Os caracteres seguintes podem ser letras, númericos, underscores e o cifrão.
- Também é possivel usar letras acentuadas, caracteres escapados e outros caracteres Unicode, a partir da versão JavaScript 1.5.
- O nome de uma variável sempre deve passar uma boa ideia do que ela representa.
- Se um nome for composto (mais de uma palavra), recomendado usar a notação `camelCase` (por ex: nomeCliente).
- Os nomes de variáveis são `case-sensitive`.

##Nomes de variáveis e palavras reservadas
- Algumas paravras são parte da sintaxe da linguaguem e não podem ser usadas para dar nome a variáveis.
	http://www.w3schools.com/js/js_reserved.asp
![Palavras Reservadas](https://raw.githubusercontent.com/helintonf/Cursos/JAVASCRIPT/Boson/JavaScript/images/reservada1.PNG)

##Escopo das variáveis
- O escopo de uma variável é o local, trecho ou região do script no qual a variável é válida, assumindo o valor a ela passado.

###Os escopos podem ser:
- **Global**: 
	- Seu valor é reconhecido em qualquer parte do script.
	- É automaticamente declarada como uma `propriedade` do objeto global **window**.
- **Local**:
	+ Seu valor só é válido no trecho do script onde a variável foi **declarada**.
	+ Dentro de uma função, IF ou objeto.

###Declarando variáveis
Podemos declarar uma variável local com o uso da palavra-chave **var**:

**var nome_variável;**

Exemplo declarando variáveis:
```javascript

var nome; //valor undefined
var num1;
var a = 20, b = 40.65, codigo = "S43X"; //Varias variaves na mesma linha
var x = 6.02e23;
var estado = true;
var compra = null; //valor nulo

```
Exemplo escopo de variáveis:
```javascript
var y = 0;

function func01(){
	var x = 10; // variavel local
	y = 20; //variavel global
	alert(x);
	alert(y);
};

function func02(){
	y++;
	alert(y); //acessivel
	alert(x); //não acessivel
};

func01();
func02();

```

##Operador typeof
Podemos usar o operador typeof para descobrir o tipo de uma variável em JavaScript:

```javascript

var a = 10; 
var b = 4.50; 
var c = "Agua"; 
var d = true; 
var e;

document.write("a é "+ typeof a +"<br/>");
document.write("b é "+ typeof b +"<br/>");
document.write("c é "+ typeof c +"<br/>");
document.write("d é "+ typeof d +"<br/>");
document.write("e é "+ typeof e +"<br/>");

```

#A03 - Operadores Aritméticos

 - Operadores aritméticos são utlizados para a realização de cálculos simples em JavaScript.
 - Representam os operadores matemáticos básicos:
 	+ Soma, subtração, divisão e multiplicação. 
 - Além de algumas operações especiais:
 	+ Módulo e incremento / decremento. 
	 	+ *"Módulo é o resto de uma divisão inteira"*
	 	+ *"Incrementar significa aumentar o valor de algo, e decrementar significa diminuir o valor de algo."*

![Operadores](https://raw.githubusercontent.com/helintonf/Cursos/JAVASCRIPT/Boson/JavaScript/images/operadores.jpg)

##Exemplo 01:

```javascript

var a = 10;

var b = 20;

document.write("Soma: " + (a + b) + "<br/>");
document.write("Subtração: " + (a - b) + "<br/>");
document.write("Multiplicação: " + (a * b) + "<br/>");
document.write("Divisão: " + (a / b) + "<br/>");
document.write("Módulo: " + (b % a) + "<br/>");
document.write("Incremento: " + (++a) + "<br/>"); //préincremento
document.write("Decremento: " + (--b) + "<br/>"); //predecremento

```

##Exemplo 02 Calculando a área de um terreno:

```javascript

alert("Vamos calcular a área de um terreno.");

var a = prompt("Digite a largura em metros:");
var b = prompt("Digite o comprimento, em metros:");

var s = a * b;

document.write("A área do terreno é de " + s + " metros <br/>");

```

#A04 - Constantes

##Constantes em JavaScript

- Uma variável pode ter seu valor alterado a qualquer momento durante a execução do script.
- Às vezes precisamos armazenar valores que nunca mudarão.
- Uma constante é criada como uma variável inicializada, e seu valor é `permanente`, não podendo ser alterado durante a execução do script.

###Criando uma constante em JavaScript

- para criar uma constante usamos a palavra-chave **const**, seguida do nome desejado para a constante e de uma valor a ela atribuido.

```javascript

var nome;
const PERIODO = 10;
nome = prompt("Digite seu nome");
//PERIODO = 15; //vai dar erro.
alert(nome + ", o período é constante com o valor " + PERIODO);

```

###Boa prática:
- Nomear as constantes com letras maiúsculas para se diferenciarem de variáveis normais.
- Melhora a performace do Sistema.
- Se alterarmos o valor da constante no código, seu valor será automaticamente alterado em todos os pontos onde a constante aparece no script.

#A05 - Métodos JavaScript

##Métodos

- Os métodos **confirm()**, **alert()** e **prompt()** são usados para exibir uma caixa de diálogo `pop-up` para o usuário, com o intuito de exibir ou solicitar informações.
- Esses três métodos pertencem ao objeto `window`, e podem ser referenciados como:
	+ window.confirm
	+ window.alert
	+ window.prompt
- O objeto window representa uma janela aberta no navegador, e contém outros objetos, como o objeto `document`.

##Método alert()

- Usado para mostrar uma caixa de alerta *"diálogo"* e um botão de OK.
- pertence ao objeto `window`, que representa uma janela aberta em um navegador.

**Sintaxe:**
```javascript

alert("mensagem");

```

- **mensagem** indica o texto *"string"* a ser exibido na caixa de alerta.

Exemplo método alert()

```javascript

alert("Bom dia");
alert("Vamos estudar a linguaguem \n JavaScript hoje!");

```

##Método prompt()

- Caixa de diálogo para entrada de dados.
- Pertence ao objeto window.

**Sintaxe:**
```javascript

prompt("arg01","[arg02]");

```

Onde:
- **arg01** é uma mensagem de instrução direcionada ao usuário.
- **arg02** é um valor padrão, geralmente usado para fornecer uma dica ao usuário *"Opcional"*.

- Os argumentos devem sempre estar entre aspas, simples ou duplas.
- Se o usuário clicar no botão OK, retornará os dados digitados na caixa.
- Se clicar em Cancelar, retornará o valor **null**.

Exemplo método prompt()

```javascript

var a = prompt("Digite seu nome: ", "Nome");
var b = prompt("Digite seu sobrenome:");
document.write("Bom dia, "+ a +" " + b + "<br/>");

```

##Método confirm()

- Usado para mostrar uma `caixa de confirmação`, com uma mensagem especificada, e botões OK e Cancelar.
- Retorna **TRUE** se o usuário clicar em OK, e **FALSE** se clicar em Cancelar.
- Também pertence ao objeto window.

**Sintaxe:**
```javascript

confirm("mensagem");

```

- **mensagem** é uma string de texto, opcional, que especifica o texto a mostrar na caixa de confirmação.

Exemplo do método confirm()

```javascript

var mensagem;

var retorno = confirm("Clique em um dos botões!");

if (retorno == true){
	mensagem = "Operação confirmada";
}
else{
	mensagem = "Você cancelou a operação";
}
document.write(mensagem);

```

##Método document.write()

- Permite escrever texto e HTML em um documento.

**Sintaxe:**

```javascript

document.write("argumentos");

```

- **argumentos** podem ser texto *"string"* ou marcações HTML.
- O método `document.write()` somente funciona se estiver inserido no documento processado.
- Se for executado a partir de um evento, sobrescreverá todo HTML da página.

Exemplo do método document.write()

```javascript

var a = prompt("Digite nome do Aluno:","Nome Aluno");
var b = confirm("Deseja salvar o Aluno: "+a);
var i = 1;
if(b == true){
	document.write(i+ ") "+ a+"<br/>");
	alert("O Aluno "+ a +" foi salvo na tela.");	
	i++;
}
else{
	alert("Você cancelou o cadastro do Aluno "+a);
}

```

#A06 - Convertendo Tipos de Dados

- Às vezes precisamos informar em nosso código exatamente o tipo de dados que deve ser usado no processamento de informações.
- Como o JavaScript é uma linguagem não-tipada, existe o risco de um tipo de dado ser interpretado de forma errônea, causando problemas no processamento ods dados.
- Podemos converter entre tipos de dados usando funções especificas no JavaScript, como os métodos **parseInt()** e **parseFloat()**, entre outras.

##Operador typeof

- como operador **typeof()** podemos descobrir o tipo de um dado ou de uma variável.

```javascript

document.write(typeof "Helinton" + "<br/>");
document.write(typeof 345.89 + "<br/>");
document.write(typeof 12 + "<br/>");
document.write(typeof true + "<br/>");

```

##Converter para String

- Usando o método **String()**:
	+ Podemos converter um valor `numerico` em string.
	+ Podemos converter um valor `lógico` em string.

```javascript

//Number
var n = 20;
document.write("A variável n é do tipo "+ typeof n + "<br/>");
n = String(n);
document.write("A variável n agora é do tipo "+ typeof n +"<br/>");

//Boolean
var b = true;
document.write("A variável b é do tipo " + typeof b +"<br/>");
b =String(b);
document.write("A variável b agora é do tipo "+ typeof b + "<br/>");

//Podemor também usar o método toString() do objeto:

n = n.toString(); 
document.write("A variável n agora é do tipo "+ typeof n +"<br/>");

b = b.toString(); 
document.write("A variável b agora é do tipo "+ typeof b +"<br/>");

```

##Converter para Number

- Usando o método **Number()**:
	+ Podemos converter uma `string` em número.
	+ Podemos converter um `boolean` em número.

```javascript

//String Inteiro
var si = "10";
console.log("A variável si é do tipo "+ typeof si);
si = Number(si);
console.log("A variável si agora é do tipo "+ typeof si);

//String com ponto Flutuante
var sf = "23.6";
console.log("A variável sf é do tipo "+ typeof sf);
sf = Number(sf);
console.log("A variável sf agora é do tipo "+ typeof sf);

//Booleano
var bo = "23.6";
console.log("A variável bo é do tipo "+ typeof bo);
bo = Number(bo);
console.log("A variável bo agora é do tipo "+ typeof bo);

```

###Converter para número inteiro

- Usando o método **parseInt()**:
	+ Podemos converter uma `string` especificamente para um número inteiro.
	+ Podemos converter um numero de ponto flutuante `float` para um inteiro.

```javascript

var a ="10";
a = parseInt(a);
console.log("O valor "+ a +" da variável a agora é do tipo "+ typeof a);

var b = "12.45";
b = parseInt(b);
console.log("O valor "+ b +" da variável b agora é do tipo "+ typeof b);

var f = 56.26;
f = parseInt(f);
console.log("O valor "+ f +" da variável f agora é do tipo "+ typeof f);

```

###Converter para número de ponto flutuante

- Usando o método **parseFloat()**:
	+ Podemos converter uma `string` especificamente para um número de ponto flutuante.

```javascript

var a = "10.32";
a = parseFloat(a);
console.log("O valor "+ a +" da variável a agora é do tipo "+ typeof a);

```

####Precisão de ponto flutuante

- Usando o método **toFixed(n)**:
	+ Podemos controlar a `precisão` que será retornada do número de ponto flutuante.
	+ O método só tem efeito nas `casa decimais`.
	+ O método retorna uma `string`.

```javascript

var a = 10.2;
console.log("O Valor de a é: "+ a.toFixed(2));

```

####Comprimento de ponto flutuante

- Usando o método **toPrecision(n)**:
	+ Podemos controlar o `comprimento` total do número que será retornado.
	+ O comprimento é o `numero + as casas decimais`.
	+ O método retorna uma `string`.

```javascript

var a = 10.2;
console.log("O valor de a é: " + a.toPrecision(5));

```

#A07 - Operadores Relacionais

- Operadores relacionais ou de comparação são utilizados para comparar dois valores (contidos ou não em variaveis).
- Retorna um resultado booleano (true ou false), dependendo da comparação realizada.
- São usados para verificar se valores são iguais, diferentes, maiores ou menores entre si. 
- Geralmente associados a estruturas de repetição ou condicionais.

![Operadores Relacionais](https://raw.githubusercontent.com/helintonf/Cursos/JAVASCRIPT/Boson/JavaScript/images/relacionais.jpg)


```javascript

var logico = true;
var num = 10;
var texto = "10";
console.log(logico);

logico = num == texto;
console.log("10 == \"10\" "+logico);

logico = num ===texto;
console.log("10 === \"10\" "+logico);

logico = num != texto;
console.log("10 != \"10\" "+logico);

logico = num !== texto;
console.log("10 !== \"10\" "+logico);

logico = num >texto;
console.log("10 > \"10\" "+logico);

logico = num >= texto;
console.log("10 >= \"10\" "+logico);

logico = num <texto;
console.log("10 < \"10\" "+logico);

logico = num <= texto;
console.log("10 <= \"10\" "+logico);

```

#A08 - Operadores Lógicos

- Usamos operadores lógicos para que seja possível tomar decisões baseadas em valores booleanos true e false.
- Sua Principal aplicação é em estruturas de controle condicionais e estruturas de repetição.
- Os operadores lógicos disponíveis em Javascript são os seguintes:

![Operadores Logicos](https://raw.githubusercontent.com/helintonf/Cursos/JAVASCRIPT/Boson/JavaScript/images/logicos.jpg)

##AND lógico - &&

- Esse operador retorna true se `ambos` os operadores envolvidos na operação forem verdadeiros "true". 
- Retorna falso "false" em qualquer outro caso.

Operador 01 | Operador 02 | Resultado
:---------: | :---------: | :-------:
FALSE       | FALSE       | FALSE
FALSE       | TRUE        | FALSE
TRUE        | FALSE       | FALSE
TRUE        | TRUE        | TRUE

Exemplo AND lógico:

```javascript

var logico;
var num1 = 25;
var num2 = 30;

logico = (num1 != num2) && (num1 < num2);
console.log(logico);

console.log("Alterando num1: ");
num1 = 30;

logico = (num1 != num2) && (num1 < num2);
console.log(logico);

```

###Retornando operandos com &&

- É possível utilizar o operador && para que seja retornado o valor de um dos operadores, em vez de um booleano, de acordo com o resultado da operação.

Usamos para isso a sintaxe:

**variavel = operando01 && operando02;**

- Onde a `variável`:
	+ Receberá o valor de `operando01` caso seja falso.
	+ Receberá o valor de `operando02` caso contrario ou seja `operando01` for verdadeiro.

Exemplo retornando operando com &&:

```javascript

var logico;
var x =12;
var num1 = 25;
var num2 = 30;

logico = (num1 != num2) && (x);
console.log(logico);

logico = (num1 == num2) && (x);
console.log(logico);

```

##OR lógico - ||

- Esse operador retorna true se ao menos `um` dos operadores envolvidos na operação for verdadeiro true, e retorna false somente se ambos forem falsos.

Operador 01 | Operador 02 | Resultado
:---------: | :---------: | :-------:
FALSE       | FALSE       | FALSE
FALSE       | TRUE        | TRUE
TRUE        | FALSE       | TRUE
TRUE        | TRUE        | TRUE

Exemplo OR lógico:

```javascript

var logico;
var num1 = 25;
var num2 = 30;

logico = (num1 != num2) || (num1 < num2);
console.log(logico);

console.log("Alterando num1: ");
num1 = 30;

logico = (num1 != num2) || (num1 < num2);
console.log(logico);

```

###Retornando operandos com ||

- Tambem podemos utilizar o operador || para que seja retornado o valor de um dos operadores, em vez de um booleano, de acordo com o resultado da operação.

Usamos para isso a sintaxe:

**variavel = operando01 || operando02;**

- Onde a `variável`:
	+ Receberá o valor de `operando01` caso seja verdadeiro.
	+ Receberá o valor de `operando02` caso contrario ou seja `operando01` for false.

Exemplo retornando operando com &&:

```javascript

var logico;
var x =12;
var num1 = 25;
var num2 = 30;

logico = (num1 != num2) || (x);
console.log(logico);

logico = (num1 == num2) || (x);
console.log(logico);

```

##NOT lógico - !

- Esse operador inverte o valor booleano do operando envolvido na operação.
- Por isso é chamado de `"operador de negação"`.
- É um operador `unário` (*age apenas sobre um valor lógico*).

Operando | Resultado
:------: | :-------:
FALSE    | TRUE
TRUE     | FALSE

Exemplo NOT lógico:

```javascript

var logico;
var num1 = 25;
var num2 = 30;

logico = !(num1 != num2);
console.log(logico);

logico = !(num1 == num2);
console.log(logico);

```

#A09 - Estruturas de decisão Condicional IF

- Usamos o condicional simples em Javascript para especificar um bloco de código que deverá ser executado, caso uma condição de teste retorne o valor True (verdadeiro).
- Caso a condição de teste retorne False (falso), o script deve simplesmente seguir seu fluxo de xecução normal.

```javascript
/*
if(expressão_teste)
{
	Bloco de códigos a executar se a expressão_teste retornar True.
}
*/

var a = 10;
if(a % 2 == 0){
	alert("O número é par!");
}

```

##Estrutura Condicional Composta - if / else

- Usamos o condicional composto em Javascript para especificar um segundo bloco de código que deverá ser executado, quando a condição de teste não for valida.

```javascript
/*
if(expressão_teste)
{
	Bloco de códigos a executar se a expressão_teste retornar True.
}
else
{
	Bloco de códigos a executar se a expressão_teste retornar False.
}
*/

var a = 10;
if(a % 2 == 0){
	alert("O número é par!");
}
else{
	alert(" número é impar!");
}
```

##Estrutura Condicional Aninhada  ou Encadeado - else if

- Com a declaração `else if` podemos estabelecer uma nova condição a ser testada.
- Caso a primeira não for valida, antes de executar um bloco de códigos.

```javascript
/*
if(expressão_teste)
{
	Bloco de códigos a executar se a expressão_teste retornar True.
}
else if(expressão_teste_2)
{
	Bloco de códigos a executar se a expressão_teste retornar False.
}
else
{
	Bloco de códigos a executar caso ninhuma condição for valida.
}
*/

var a = 10;
if(a > 10){
	alert("O número é maior que dez!");
}
else if(a < 10){
	alert("O número é menor que dez!");
}
else{
	alert("O número é exato");
}
```

#A10 - Estrutura Condicional Switch Case

- É utilizada quando é preciso realizar deferentes ações baseadas em condições distintas.
- Geralmente é utilizada no lugar de um `condicional aninhado`, pois simplifica o código.

Sintaxe:

```javascript
switch(expressao){
	case "caso1":
		//comandos a executar;
		break;
	case "casoN":
		//comandos a executar;
		break;
	default:
		//comandos padrão a executar;
		break;
}
```

**case:**
- Valor que será comparado com a expressão.
- Se `corresponder`, o bloco de código associado será executado.

**break:**
- Garante que a estrutura seja `finalizada` ao ser encontrada uma correspondência.

**default:**
- O bloco de códigos `padrão` a serem executados se nenhum caso corresponder à expressão.

Exemplo:

```javascript
var fruta;
fruta = prompt("Digite o nome de uma fruta");
fruta = fruta.toLowerCase();

switch(fruta){
	case "morango":
		alert("Fruta boa para merengue!");
		break;
	case "laranja":
		alert("Fruta boa para suco!");
		break;
	case "banana":
		alert("Fruta boa para vitamina!");
		break;
	default:
		alert("Fruta desconhecida");
		break;
}

```

#A11 - Estrutura de Repetição FOR

- Permite construir estruturas de loop para casos onde se conhece de antemão o `número de repetições` que devem ser realizadas (número finito de laços).

Sintaxe:

```javascript
/*
for(variavel = valor_inicio; condicao_fim; incremento){
	instrucoes
}
*/
//variavel = variavel contadora
//valor_inicio = valor inicial atribudo a variavel
//condicao_fim = valor final que determina o final do loop
//incremento = valor para incrementar a variavel a cada loop.
```

Exemplo:

```javascript

var numero;
numero = prompt("Digite um número qualquer entre 10 e 100");

if((numero <10)||(numero > 100))
{
	alert("Valor fora do intervalo especificado!");
}
else
{
	for(contador = 1; contador <= numero; contador++)
	{
		console.log(contador);
	}
}

```

#A12 - Estrutra de Repetição While

- Em muitos casos é necessário `repetir` um trecho de um programa diversas vezes.
- Nesse caso podemos usar um `"loop"` que efetue essa repetição de código quantas vezes forem necessárias.
- Os loops são chamados também de `laços de repetição`.
- Realiza um teste lógico no início do loop.
- A cada vez que o teste é valido, os comandos associados ao laço são executados.
- Quando o teste não é valido, o laço é encerrado e o processamento volta para o fluxo principal do programa.

Sintaxe:

```javascript

/*
while(expressao)
{
	instruções executadas enquanto condição verdadeora
}
*/
```

Exemplo:

```javascript

var numero;
var contador = 0;

numero = prompt("Digite um número qualquer entre 10 e 100");

if((numero < 10) ||(numero > 100))
{
	alert("Valor fora do intervalo especificado!");
}
else
{
	while(contador <= numero)
	{
		console.log(contador);
		contador++;
	}
}
```

#A13 - Arrays Declaração e Atribuição

- Usamos arrays em Javascript para armazenar múltiplos valores em uma única variável.
- Os valores armazenados em um array podem ser de tipos diferentes no JS.
- Com o uso de arrays poupamos o esforço de criar uma variável para cada item a ser armazenado.
- Cada item de dados armazenado em uma posição do array é chamado de `elemento`.
- Cada elemento possui um `valor de índice`, oque permite distinguir cada elemento dentro da estrutura.
- O Javascript não suporta Arrays Associativos.

##Criando um Array literal

Exemplo:

```javascript
var Estados = []; //array vazio
var Cidades = ["São Paulo","Recife","Vitória","Aracaju"]; //array inicializado
//Podemos declarar os valores em linhas separadas:
Estados = [
	"São Paulo",
	"Rio de Janeiro",
	"Minas Gerais",
	"Amazonas",
	"Alagoas"
];
```

##Criando um Array com new

Exemplo:

```javascript

var Paises = new Array("Brasil","Inglaterra","Espanha","Mexico","Canada","Argentina");
console.log(Array.isArray(Paises)); //como saber se a variavel é array.

```

##Lendo os elementos do Array

- Os elementos em um array são lidos a partir de seu número de índice, que começa a ser contato a partir do zero.

Exemplo:

```javascript

var cidade = Cidades[0];
console.log("A cidade é "+cidade);

```

- Podemos também ler todo o conteúdo de um array efetuando um loop em seus elementos:

Exemplo:

```javascript

for(i = 0;i < Cidades.length; i++){
	console.log(Cidades[i]);
}

```

##Alterando um Array

- Podemos alterar um valor em um array simplesmente atribuindo um valor a uma de suas posições.
- Se a posição já contiver um valor ele será substituido pelo novo valor.

Exemplo:

```javascript

Cidades[1] = "Araras";
console.log("A cidade é "+Cidades[1]);

```

#A14 - Propriedades e Métodos de um Array

- Os arrays em Javascript possuem métodos e propriedades disponíveis:

##length

- A `propriedade` length retorna o número de elementos presentes no array.

```javascript

var qtd = Cidades.length;
console.log("O array possui "+qtd+" elementos");


```

##push()

- Usando o `método` push(), podemos facilmente `adicionar` mais elementos a um array.
- Acrecenta elementos no `final` do array.
- É similar ao conceito de pilha.

```javascript

Cidades.push("Leme");
Cidades.push("Campinas");
Cidades.push("Conchal");

```

##pop()

- Usando o `método` pop(), podemos `remover` o `último` elemento.
- O método retorna o último elemento.
- Não tem argumentos para passar.

```javascript

console.log(Cidades[Cidades.length -1]); //ultimo elemento
Cidades.pop();
console.log(Cidades[Cidades.length -1]); //ultimo elemento

```

##join()

- O `método` join permite `unir` todos os elementos de uma array em uma `string`, especificando um caractere separador entre eles.


```javascript

var ConjuntoCidades = Cidades.join(",");
console.log(ConjuntoCidades);

```

##shift()

- Usando o `método` shift(), podemos `remover` o `primeiro` elemento de um array e deslocar demais uma posição para "baixo".

```javascript

Cidades.push("Maceió");
console.log("Antes do deslocamento");
console.log("Tamanho: "+Cidades.length);
console.log("1º elemento: "+Cidades[0]);

Cidades.shift(); //deslocar em inglês

console.log("Após o deslocamento: ");
console.log("Tamanho: "+Cidades.length);
console.log("1º elemento: "+Cidades[0]);

```

##delete

- Usando o `operador` delete, podemos excluir um elemento em uma posição qualquer do array.
- A posição cujo conteúdo é excluido ficará com o valor `undefined`.
- Apaga somente o conteudo de uma posição.
- O Array não diminuo de tamanho e mantem o mesmo numero de posições.
- Apaga o indice do elemeto e não realoca os outros indices com valor.

```javascript

var Cidades = ["São Paulo", "Recife", "Vitória", "Aracaju"];
for(i = 0; i < Cidades.length; i++){
	console.log(Cidades[i]);
}

delete Cidades[2];
console.log("Após excluir o elemento: ");

for(i=0;i<Cidades.length;i++){
	console.log(Cidades[i]);
}

```

##splice()

- Usando o `método` splice(), podemos `inserir` um elemento em uma posição `específica`.
- Um novo elemento é adicionado ao array, sem alterar os elementos já existentes.
- Pode substituir os elemento tambem.
- Subistituir deversos elemtos de uma só vez.
- Re-organiza oos indices.

```javascript

for(i=0;i<Cidades.length;i++){
	console.log(Cidades[i]);
}

Cidades.splice(
	1, //indica a partir de qual posição os elementos serão adicionados ao array.
	0, //indica se e quantos elementos deverão ser removidos a partir da posição inicial indicada, deixar 0 para não remover nada.
	"Manaus", //são os valores a serem inseridos a partir.
	"Londrina", //são os valores a serem inseridos a partir.
	"CidadeN..."
	);
console.log("Após adicionar os elementos: ");

for(i=0;i<Cidades.length;i++){
	console.log(Cidades[i]);
}

```

###Removendo Elementos com método splice()

- Também podemos usar o método `splice()` para `remover elementos do meio do array` sem deixar posições com valor `undefined`.

```javascript

for(i=0;i<Cidades.length; i++){
	console.log(Cidades[i]);
}

Cidades.splice(1,2);

console.log("Após adicionar os elementos: ");

for(i=0;i<Cidades.length;i++){
	console.log(Cidades[i]);
}

```

##concat()

- Usando o `método` concat(), podemos unir dois ou mais arrays e formar um novo array.

```javascript

var Sudeste = ["SP","RJ","ES","MG"];
var Nordeste = ["PI","MA","CE","RN","PB","PE","SE","AL","BA"];
var Norte = ["AC","AM","AP","RO","RR","PA","TO"];
var Sul = ["PR","SC","RS"];
var CentroOeste = ["MS","MT","GO","DF"];

var Estados = Nordeste.concat(Sudeste,Norte,Sul,CentroOeste);

console.log("Listando os estados: ");

Estados.sort(); //Ordenando os estados alfabeticamente

for(i = 0; i < Estados.length; i++){
	console.log(Estados[i]);
}

```
