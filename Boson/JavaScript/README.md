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

