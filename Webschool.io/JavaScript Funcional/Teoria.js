//Teoria

#A01

	Oque é programação funcional?
		-Programação funcional é um paradigma de programação que trata a computação como uma avaliação de funções matemáticas e evita estados ou dados mutáveis.
		-Utiliza a aplicação de funções, em contraste da programação imperativa, que infatiza mudanças no estado do programa.
		-Assim como na orientação a objetos a menor parte de um sistema é um objeto, você pode atribuir objetos a variaveis pode passá-los por parâmetro e ter métodos retornando objetos, na programação funcional, a menor parte do seu sistema é uma função.

		Ex.:
			-a função f(x) = x^2 +5 é definida utilizando funções de exponenciação e adição. Do mesmo modo, a linguagem deve oferecer funções básicas que não requerem definições adicionais.

		Possuimos 2 grandes paradigmas de programação:
			-Funcional.
			-Imperativo.
				-Você manda as coisas serem feitas.

	Por que user PF?
		-Temos 4 grandes motivos para usar programação funcional, são eles:

			-Concorrência:
				-Não temos deadlocks ou race conditions simplesmente porque não precisamos de locks - o dado é imutável.

			-Teste:
				-Criar testes unitários sem se preocupar com o estado simplesmente porque não existe estado.
				-Devemos preocupar apenas com os argumentos das funções que nós testamos.

			-Debugging:
				-Rastrear algum valor no stack trace é bem simples.

			-Base teórica:
				-Linguagens funcoinais são baseados no cálculo lambda, que é um sistema formal.
				-Esta fundamentação teórica faz a prova para correção dos programas seja muito simples(por exemplo, usando indução).

	Onde usar?
		-BI.
		-Sistemas concorrentes.

		Ex.
			-Quase todo o Yahoo utiliza fortemente Hadoop que utiliza fortemente map/reduce.

	Linguagens funcionais:
		-Erlang.
		-Kaskell para programadores javascript.
		-LISP introduziu a maioria das caracteristicas hoje encontradas nas modernas linguaguens de programação funcional.
		-Scheme foi uma tentativa posterior de simplificar e melhorar LISP.
		-Haskell foi lançada no fim dos anos 1980 numa tentativa de juntar muitas ideias na pesquisa de programação funcional.
		-Além da Ericsson, é logico, há algumas outras grandes empresas e projetos estão usnado Erlang, como por exemplo:

	Por que o JavaScript é funcional?
		-Vamos ver algumas features que fazem do JavaScript uma linguagem com conceitos funcionais.

		Funções:
			-No JavaScript uma função nada mais é que um objeto que possui atributos como:
				-arguments.
				-name.
				-length.
			-E funções importantes como:
				-apply
				-call
			-A diferença entre elas é que o apply aceita como parâmetro um array de argumentos, enquanto que, o call aceita uma lista, ou seja, passando um-a-um.

			-Para criarmos uma função no JavaScript é muito simples, como já vimos anteriormente, precisamos apenas utilizar a palavra 'function'.
				function nome_funcao(parametros){
					alert('ola');
				}

			!--TODA FUNÇÃO PRECISA RETORNAR UM VALOR--!
				encapsular em uma função.
				var idade = 30; //como fazer

				//função identidade.
				function setIdade(idade){return idade;}

				var idade = setIdade(30);


				function maioridade(idade){
					return idade >= 18;
				}

				posso passar uma função como argumento:
					maioridade(setIdade(30));

			Atomic Design Funcional:
				-Dessa forma podemos pensar que ele se assemelha muito ao ATOMIC DESIGN onde criamos pequenos átomos independentes.
				-nesse caso as funções e com elas vamos compondo funções maiores, exatamente como visto aqui no artigo do Brad Frost.

			Função que duplica Strings:

				var repeat = function(s){
					return s+s;
				};

				repeat('Na');
				//precisamos de um contrato.
					var str = function(s){
						if(typeof s !== 'string'){
							throw new TypeError('Expected a string');
						}else{
							return s;
						}
					}

					var repeat = function(s){
						var s = str(s);
						return s+s;
					};

#A02 - Lambda λ
	-Lambda é uma regra de transformação.
	-Expressão forma de uma função vai trabalhar.

	expressões simples
		int x;

		int f(int x){
			return x;
		}

		x: int 
		f: int -> int
		_______

		x: a
		f: a -> a

	x E Z
		-x pertence ao conjunto dos inteiros função f recebe um inteiro e retorna um inteiro.
		-Se fosse apenas os inteiros positivos falariamos que pertence aos naturais.	

	Composição de funções

		x: a
		f: a -> a
		g: a -> a

		f(g(a))

		Notação
			(f.g) = h : a -> a

	-A sintaxe das expressões-lambda é determinada por duas operações:
		-abstração.
		-aplicação.(sendo que a aplicação envolve uma operação de substituição chamada conversão-Beta)

	-Uma expressão-lambda pode ser uma variável, uma abstração de uma expressão, ou uma aplicação de duas expressões:
		-Variáveis:
		 	-x, y, z, um conjunto qualquer de nomes de variáveis;

		-Abstrações:
			-dada uma expressão-lambda E, podemos formar uma adstração de E usando `λ + variável +'.'+E`. Por exemplo: 'λx.x';

		-Aplicações:
			-dadas duas expressões-lambda E e F, a expressão da aplicação é formada pela justaposição de uma ao lado da outra: EF.

	Exemplos

		x //Apenas uma variável
		λx.x
		λx.y
		(λx.x x)(λx.x x)
		λm.λn.λb. m (n b a) (n a b)

		Significado:
			-a abstração significa a criação de uma função;
			-aplicação significa o uso ou chamada dessa função em cima de um parâmetro.
			-a conversão-Beta é a regra de substituição que diz como a aplicação deve funcionar.

			Expressão Lambda
				(λx.x)
					-Onde x é a variavel que entrará na expressão λx
					function(x){
						return x;
					}

				(λy.x)

					function(y){
						return x;
					}

				(λx.(λy.x))

					λx.λy.x

					function(x){
						return function(y){
							return x;
						}
					}

			Aplicação Lambda

				(λx.x) y

					-Onde (λx.x) tem como resultado a apressão avaliada passando o y como valor.

				(λx.E) F

					-Dada a aplicação (λx.E) F, o resultado é a expressão E, mas substituindo todas a ocorrências de x por F (o argumento da função).
					-Onde (E=x e F = y), sendo E a função onde x é substituido pelo valor F.

				λx.x UNICORNIO -> UNICORNIO

				function(x){
					return x;
				}(UNICORNIO);

			Conversão-Beta
				-Analisemos essa expressão
				-trocar por valor de verdade.

				(λx.+x 1)4

				conversão-Beta é 
				+4 1

			//EXERCICIOS

				λx.λy.x  UNICORNIO -> UNICORNIO

					function(UNICORNIO){
						return function(y){
							return UNICORNIO;
						}
					}

				Multiplicação

					function(x){
						return function(y){
							return x * y;
						}
					}

#A03 

	Por que JavaScript é funcional?
		-por causa de suas funções.

	Funções
		-No JavaScript uma função nada mais é que um objeto que possui atributos como:
			-arguments
			-name
			-length

		E funções importantes como:
			-apply
			-bind
			-call

	TODA FUNÇÃO PRECISA RETORNAR UM VALOR

		function setIdade(idade){
			this.idade = idade;
			return this;
		}

	Funções - anônima
		-A função anônima é apenas a chamada do 'function' sem nomeá-la, 
			sendo o lambda uma função anônima que aceita apenas um parâmetro.
		-Server pra usar sem instanciar e armazenar em variavel em memoria.

		function(nome){
			return 'Ola '+nome;
		};

	Funções - IIFE
		Immediately-Invoked Function Expression

		-No JavaScript cada vez que você executa uma função você cria um escopo fechado 
			para ela de onde as variáveis não podem "sair", tendo assim um mecanismo simples de privacidade.

		-Bom se para executarmos uma função basta colocar () após o nome da função, podemos então substituir 
			o nome da função pela própria declaração dela.
			function(){--Code--}();
		-O problema aqui é que quando o interpretador do javaScript encontra a palavra
			function ele trata como uma declaração de função, para resolver esse problema nós
			só precisamos encapsular ela entre ().
				
				(function(){--Code--}());
				(function(){--Code--})();

				(function(){alert('oi')})();

				function foo(){ foo();}
					var foo = function(){arguments.callee();};

#A04 First-class e High-order

	First-class Functions
		-No JavaScript e função é first-class citizen, assim como objeto, entidade ou valor,
			porque ela suporta todas as operações comuns às outras entidades.

		Operações:
			-Assinada a uma variável.
			-Retornada de uma função.
			-Ser passada por parâmetro.

			var hello = function(name){alert('Olá '+name);}
			var hello = function(name){return function(){alert('Olá '+name);}}
			function ola(msg,name){msg(name);}

			-Assinada a uma variável.
				var add = function (a,b){
					return a + b;
				}

			-Retorna uma função.
				function adder(a){
					return function(b){
						return a + b;
					}
				}

				var _add = adder(20);
				_add(420);

			-Passar parâmetro
				function multi(a){
					var sum = 0;
					return function(b){
						sum =b;
						for(i=1;i<a;i++){
							sum += b;
						}
						return sum;
					}
				}
				var mult = multi(2);
				mult(3);
				multi(2)(3)

				function adder(a){
					console.log('a',a);
					return function(b){
						console.log('b',b);
						return a+b;
					}
				}

		No JavaScript uma função tambem poder ser um objeto.

			var plus1 = new Function('a', 'return a+1;');
			var sum = new Function('a','b','return a + b;');

			var numbers = [1,2,3,4,5,6,7,8,9,10];
			var pares = function(numero){
				return !(numero % 2)
			}

			var resposta = numbers.filter(pares);

			console.log(resposta)

		High-order Functions
			-Uma função é chamada de *high-order* quando ela faz duas coisas:
				-Recebe uma ou mais funções como parâmetro.
				-Retorna uma função.

			-Basicamente é uma função que recebe outra função como parâmetro ou devolve uma função como resultado.
			-Quando você usa callbacks no JavaScript e no Jquery, você está fazendo uso de high order functions.

			function somar(x,y){
				return x+y;
			};
			function subtrair(x,y){
				return x-y;
			};
			function multiplicar(x,y){
				return x*y;
			};
			function dividir(x,y){
				return x /y;
			};
			-Função high order
			function calcular(op,x,y){
				return op(x,y);
			};


			function mp (op,valor,vezes){
				var sum =valor;
				for(i = 0; i <= vezes; i++){
					sum = op(valor,sum);
				}
				return sum;
			}

#A05 - Closures
	-É importante que você entenda como funciona o escopo no JavaScript para que não fique
		confuso ao ver colsures e currying, existem até livros apenas sobre esse tema como:
			-Closure the definitive guide.
			-Scope & Closures, you dont know JS

	-Como na maioria das linguagues do mercado, uma variável declarada em um escopo maior é visível em um escopo menor,
		enquanto o contrário não é verdadeiro.

		var name = 'helinton'
		function foo(){
			console.log(name);
		}

	-Significa também que uma variável local só é vista dentro do escopo em que foi criada, 
		mesmo que tenha o mesmo nome de uma variável global.

	-função criar uma variavel local se for passado o variavel global por parametro.

#P01 - JavaScript Funcional ES6 (Palestra)

	Oque é programação funcional?
		-Basear em funções.
		-menor entidade é a função.

	Porque usar?
		-concorrência.

	Onde usar?
		-BI
		-Filtro de spam
		-Radupe
		-map
		-reduce

	Lambda
		-λx.x

	ES6
		-Proxima versão do javascript.

		LET
			function varTeste(){
				var x = 420;
				if(true){
					var x = 666;// same variable.
					console.log(x); //666
				}
				console.log(x); //666
			}

			function letTest(){
				let x =420;
				if(true){
					let x = 666; //different variable
					console.log(x); //666
				}
				console.log(x); //420
			}

		CONST 
			const x = 10;

		DEFAULT PARAMETERS
			function makeRequest(url,timeout = 2000,callback = function(){}){

			}

		DESTRUCTURING

		SPREAD OPERATOR
			-LISTA valores um por um
			let values = [25,50,100]
			console.log(Math.max(...values));

		Arrow function 
			-Não aceita new.
			-Não possui o argments.
			-this não pode ser mudado.
			-this tem valor de onde é criado e não de onde é chamado.

			function = (arguments){expression}
			arguments => expression

			normal
				var hello = function(name){
					return "Ola, "+name+"!";
				}
				console.log(hello('Helinton'));

			Arrow Function
				let hello = name => 'Olá, ${name}!';
				let hello = () => 'Olá, ${name}!';
				let sum = (num1,num2) => num1 + num2;
				console.log(hello('Helinton'));

		Interators
			-interação

			let arr = [3,5,7];
			arr.foo = "hello";

			for (let i in arr){
				console.log(i); //0,1,2,foo
			}
				//in nomes das chaves

			for (let i of arr){
				console.lo(i); //3,5,7
			}
				// of pegamos os valores instanciados.

		PROMISE
			function httpGet(url){
				return new Promise(
					function (resolve,reject){
						var request = new XMLHttpRequest();
						request.onreadystatechange = function (){
							if(this.status === 200){
								//Success
								resolve(this.response);
							}else{
								//Something went wrong (404 etc.)
								reject(new Error(this.statusText));
							}
						}
						request.onerror = function (){
							reject(new Error(
								'XMLHttpRequest Error:'+this.statusText
								));
						};
						request.open('GET',url);
						request.send();
					}
					);
			}
			//chamada da função
			httpGet('http://hfweb.com.br')
			.then(
				function(value){
					console.log('Contents:' + value);
				},
				function(reason){
					console.error('Something went wrong', reason);
				}
				);

		Funções
			função anonima
			IIFE
				função anonima autoexecutada.
			(function(){}());
			(function(){})();

			First-class Function
				-FUNÇÃO COMO VARIAVEL, PARAMETRO.
				-OQUE VC PODE FAZER COM UMA VARIAVEL PODE FAZER COM UMA FUNÇÃO(){}

			Hight - ORDER Function
				-PODER RECEBER UM PARAMETRO DE UMA FUNÇÃO
				-RETORNAR UMA FUNÇÃO

			Currying
				-ARGUMENTOS UM POR UM CHAMANDO DE FORMA simples COM FUNÇÃO.

			Closures
				-Encapsular variaveis e escopos.

			Hoisting
				-mudar variavel da função filho pro pai e pai pra filho.

			recursion
				-interações 

			Immutability
				-não mudar valores.
				-criar copia deles com valores mudados.

			Pure function
				-funções puras
				-oque entra e sai da funçãos não tem alteração é o mesmo valor e tipo de dados.(){}

			Loops

			map 

			reduce

			filter

