// METODOS DE OBJETOS
//var nome = 'casa';
//-- a variavel this é atribuida automaticamente quando abre o contexto
var pegarNome = function(nome, sobreNome){
    this.nome = nome;
    this.sobreNome = sobreNome;
    
    console.log(this);
    
}
//pegarNome();

var pessoa = {
    nome:'Helinton Fioramonte',
    sobreNome:'Lima',
    idade:'26',
    getNome: pegarNome
//    getNome:function(){
//        console.log(this.nome);
//    }
};

var carros = {
    nome:'Gol',
    marca:'VW',
    getNome:function(){
        console.log(this.nome);
    }
};


//pessoa.getNome();
//carros.getNome();


//METODOS PARA O THIS manipular 

    //call(CONTEXTO,PARAMETROS DE DADOS)
    pegarNome.call(pessoa,'Pedro','Silva');
    pegarNome.apply(pessoa,['Pedro','Silva']); //multiplos parametros em um array
    var getNome =  pegarNome.bind(pessoa,'Pedro','Silva'); //nova function parametros inseridos permanetemente na nova funcao que vai ser criada

getNome();