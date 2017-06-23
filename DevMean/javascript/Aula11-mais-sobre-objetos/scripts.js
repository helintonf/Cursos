// Definir varias propriedades

var pessoa = {};

Object.defineProperties(pessoa,{
    _nome:{
        value:'Helinton',
        enumerable:true,
        configurable:false,
        writable: true
    },
    _sexo:{
        value:'M',
        enumerable:true,
        configurable:true,
        writable:true
    },
    _idade:{
        value:20,
        enumerable:true,
        configurable:true,
        writable:true
    },
    nome:{
        get: function (){
            return this._nome;
        },
        set: function(value){
            this._nome = value;
        }
    },
     sexo:{
        get: function (){
            return this._sexo;
        },
        set: function(value){
            this._sexo = value;
        }
    }
    
});


///metodo dos objetos javasript

var atributo = Object.getOwnPropertyDescriptor(pessoa,'_nome');


//console.log(atributo);


var atributo = Object.getOwnPropertyDescriptor(pessoa,'nome');


//console.log(atributo);


//como evitar modificações em objetos na estrutura


//Object.preventExtensions(pessoa);
//console.log(Object.isExtensible(pessoa));

//Object.seal(pessoa);
//console.log(Object.isSealed(pessoa));

Object.freeze(pessoa); //permacene nesse estado para sempre
console.log(Object.isFrozen(pessoa));

pessoa.nome = 'jose';

pessoa.altura = '1,80m';

delete pessoa._nome;

console.log(pessoa);












