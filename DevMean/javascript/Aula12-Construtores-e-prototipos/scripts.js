// construtures funções  prototipada

function Pessoa(nome,idade,sexo){
    this._nome = nome;
    this.idade = idade;
    this.sexo = sexo;
    
    
    Object.defineProperties(this,{
        _nome:{
            enumerable: true,
            configurable: true,
            writable: true
        },
        nome:{
            get: function(){
                return this._nome;
            },
            set: function(value){
                this._nome = value;
            }
        }
    });
    Object.preventExtensions(this);
}


var helinton = new Pessoa('Helinton',26,'M');


helinton.endereco = 'casa';

console.log(helinton);

console.log(helinton instanceof Pessoa);

console.log(helinton.constructor === Pessoa);

helinton.nome = 'jose';

for(propriedade in helinton){
    console.log(propriedade + ': ' + helinton[propriedade]);
}