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


pessoa.nome = 'Maria';
pessoa.sexo = 'F';



console.log(pessoa.sexo);












