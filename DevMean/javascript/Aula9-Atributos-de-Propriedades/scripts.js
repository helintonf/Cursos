// Atributos de Proriedades do objeto
//atributos  comuns entre proriedades de  dados e proriedades de acesso configurable e enumerable
//atritubos para propriedades de dados é value e writable
//atributos para propriedaes de acesso é 
var pessoa ={
    nome: 'Helinton',
    _idade:26,
    _sexo:'masculino',
    casado:true,
    state:'pristine',
    get idade(){
        return this._idade;
    },
    set idade(value){
        this._idade = value;
    }
};

//acesso a diferenca é que o primeiro é gerando na criacao o outro o objeto ja esta gerado permitindo uma modificacao
Object.defineProperty(pessoa,'sexo',{
    get: function(){
        return this._sexo;
    },
    set: function(value){
        this._sexo = value;
    }
});

pessoa.sexo = 'Feminino';
var sexo = pessoa.sexo;

console.log(sexo);



//enumerable - não inumerar sair da interação 

Object.defineProperty(pessoa,'idade',{
  enumerable:false   //enumerable - não inumerar sair da interação 
    
});

//configurable - define que a propriedade vai fazer parte do objeto pra sempre
//
Object.defineProperty(pessoa,'nome',{
    configurable:false, //configurable - define que a propriedade vai fazer parte do objeto pra sempre
    value: 'Roberto',//defino valor
    writable:false //não pode ser reescrita
    
});


pessoa.nome = 'casa';




console.log(pessoa);

console.log(pessoa.propertyIsEnumerable('idade'));

for(propriedade in pessoa){
    console.log(propriedade);
}


console.log(pessoa);


console.log('---------------------------------------------------------');












