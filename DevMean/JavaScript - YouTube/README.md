
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