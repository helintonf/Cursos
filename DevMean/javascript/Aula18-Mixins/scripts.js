//construtor de escopo seguro

function Pessoa(nome,idade,sexo){
    if(this instanceof Pessoa){
    this.nome = nome;
    this.idade = idade;
    this.sexo = sexo;
    }else{
        //console.log('vc precisa utilizar o operador new');
        return new Pessoa(nome,idade,sexo);
    }
}

var helinton =  Pessoa('Helinton',21,'M');

console.log(helinton instanceof Pessoa);

console.log(helinton);