// construtures funções  prototipada, compartilhar caracteristicas entre objetos

function Pessoa(nome,idade,sexo){
    this.nome = nome;
    this.idade = idade;
    this.sexo = sexo;
    //this.getNome = function (){
    //     return this.nome;
    //}
 
}

Pessoa.prototype = {
    constructor: Pessoa,
    getNome: function(){
        return this.nome;
    },
    getIdade: function(){
        return this.idade;
    },
    getSexo: function(){
        return this.sexo;
    }
}

//Pessoa.prototype.getNome = function(){
//    return this.nome;
//}

//Pessoa.prototype.getIdade = function(){
//    return this.idade;
//}

//Pessoa.prototype.getSexo = function(){
//    return this.sexo;
//}



var helinton = new Pessoa('helinton',26,'M');
var joao = new Pessoa('joao',18,'M');

console.log(helinton.getNome(),helinton.getIdade(), helinton.getSexo());
console.log(joao.getNome(),joao.getIdade(),joao.getSexo());

console.log(helinton instanceof Pessoa);
console.log(helinton.constructor === Pessoa);