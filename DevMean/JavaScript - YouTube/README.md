
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
