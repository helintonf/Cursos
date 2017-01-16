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






