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
