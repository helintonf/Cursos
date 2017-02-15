
#A01 - Variaveis e Tipos de Dados

- Existem `5` tipos de dados em javascript.
    + `string` que pode ser acessado como objeto.
    + `number` que pode ser acessado como objeto.
    + `boolean` que pode ser acessado como objeto.
    + `null`.
    + `undefined`.

Exemplos.
```javascript

var nome = "Helinton"; 
var numero = 15;
var boolean = true;
var idade = null;
var endereco;

console.log("Nome é: "+ typeof nome);
console.log("Numero é: "+ typeof numero);
console.log("Boolean é: "+ typeof boolean);
console.log("Idade é: "+ TypeNull(idade));
console.log("Endereço é: "+ typeof endereco);

function TypeNull(variavel){
    if(variavel === null){
        return "null";
    }
}
```

#A02 - Funções e Escopo

- Escopo global.
    + Acessivel em todo codigo.
    + Risco de poluir o escopo global.
    + Evite variaveis no escopo global.
    + Crie objetos de configuração.

```javascript

var contador = 0;

function incrementar(){
    contador += 1;
    console.log(contador);
}

incrementar();

var contador = "joão";

incrementar();

////-----------

var objConf = {};

objConf.contador = 0;

objConf.incrementar = function(){
    objConf.contador += 1;
    console.log(objConf.contador);
}

objConf.incrementar();

```

##Funções Declaration

- Ocorre o içamento da função `Hosting`.
- Função vai para o inicio do arquivo.

```javascript

function modificaNome(){

}

```


##Funções Expression

- é executado na seguencia do codigo.

```javascript

var modificaNome = function(){

}

```

Exemplo Funções:

```javascript

var add = function(num1,num2){
    var result = num1 + num2;
    //console.log(num1+num2);
    return result;
}

var calc = function(x){
    console.log(x+1);
}
//função como parametro.
calc(add(2,2));
console.log(add(2,4));

```

#A03 - Closures
- Closures = encapsulamento, conseguir acessar um escopo esterno a ela (função, global, etc).
- Criar `ambientes isolados` onde variaveis e funções só existem nesse escopo.
- Uma função prove encapsulamento.
- Quando quiser trazer dados publicos use `return` um objeto.
- Quando não quiser mostrar dados não use return nem em dados e variavel.

Exemplo 01:

```javascript

var getNome = function(name){
    var nome = name;
    var mostraNome = function(){
        console.log(nome);
    }
    mostraNome();
}
getNome("helinton");
//mostraNome(); //não funciona pq o escopo dela é na função getNome();
```

Exemplo 02:

```javascript

var incrementar = function(){
    var contador = 0; //dados privados
    var dadosPublicos = {
        nome:"Helinton",
        idade:27,
        inc: function(){
            return contador += 1;
        }
    }
    return dadosPublicos;
    //return function (){  //var inc //expor a função
    //    contador +=1;
    //    return contador;
    //}
}
var dados = incrementar(); //referencia
console.log(dados.inc());

```

#A04 - Objetos, Funções e Métodos

- É possivel acessar funções a partir de objetos. 
- Função só tem this quando ela é executada dentro de um objeto.

Exemplo:

```javascript

//var getIdade = function(){
//       return this.idade;//this
//} 

var pessoa = {
    nome:"Helinton",
    idade:27,
    getIdade: function(){
        return this.idade;//this getIdade
    }
};



console.log(pessoa.getIdade());

```

##Função Construtura:

- Criar objetos a partir de uma função.
- Sempre função construtura começa com a primeira letra maiuscula

Exemplo:

```javascript

function Pessoa(nome,idade,sexo){ //Primeira letra maiuscula
    this.nome = nome;
    this.idade = idade;
    this.sexo = sexo;
}

var novaPessoa = new Pessoa("Helinton",27,"Masculino");

console.log(novaPessoa);

```

##Função Fabrica:

- a Diferença é o operador `new`.

Exemplo:

```javascript

var pessoa = function(nome,idade,sexo){
    return {
        nome :nome,
        idade : idade,
        sexo : sexo
    };
};

console.log(pessoa("João",23,"Masculino"));

```

##Métodos call e apply

- Método nativo das funções.
- Chamo as funções relacionando ao escopo especifico de um objeto.
- O objeto passado como parâmetro passa a ser o `this` da função.
- Call:
    + Recebe diversos parametros.
- Apply:
    + Recebe 2 parâmetros, sendo o primeiro o escopo e o segundo um `array` de parâmetros.


```javascript

var getIdade = function(){
    return this.idade;
}

var setInfo = function(nome,sexo){
    this.nome = nome;
    this.sexo = sexo;
}

var pessoa = {
    nome : "helinton",
    idade : 27,
    sexo : "Masculino",
    getIdade: getIdade
}

//console.log(getIdade.call(pessoa,nome,sexo));

setInfo.call(pessoa,"Maria","Feminino");
console.log(pessoa);

//console.log(getIdade.apply(pessoa,[nome,sexo]));

```
