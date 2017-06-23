// heranca, todo o objeto herda de Object.Prototipy

function Pessoa(nome,idade,sexo){
    this.nome = nome;
    this.idade = idade;
    this.sexo = sexo;
 
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

//facture function

var makePessoa = function(nome,idade,sexo){
    return{
        constructor: makePessoa,
        nome:nome,
        idade:idade,
        sexo:sexo,
        getIdade: function(){
            return this.idade;
        }
    }
}



var helinton = new Pessoa('Helinton', 26, 'M');

var roberto = makePessoa('Roberto', 32, 'M');

var pessoaCriada = Object.create(helinton,{
    endereco:{
        value:'Rua seila da onde',
        writable:true,
        configurable:true,
        enumerable:true
    }
});


//console.log(helinton,roberto);
//console.log(Object.getPrototypeOf(roberto));

console.log(roberto.getIdade());


console.log(pessoaCriada);