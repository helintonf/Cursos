// TIPOS PRIMITIVOS
var idade = 18; //Number
var sexo = 'F'; //String
var nome = 'undefined'; //indefinido
var existe = true; //boolean
var endereco = null; //nulo --object



//Metodos --String

var primeiroChar = nome.charAt(0);
var nomeMaiusculo = nome.length;


//Metodos --Number

var AlterarCasaDec = idade.toFixed(2);




//console.log(AlterarCasaDec);
//console.log(endereco === null);

//console.log(typeof endereco);


//TIPOS DE REFERENCIA

var pessoa = new Object();
var pessoa2 = {'nome':'Rodrigo','idade':'21','sexo':'M'};

var mostraNome = new Function("console.log('Helinton');");

mostraNome();


var carro = new Array('Gol','Uno','Corolla');

console.log(carro);


////forma literal



var carros = ['Gol','Uno','Corolla'];

console.log(carros);


function mostraIdade(){
    
    console.log('Idade é igual '+ 25);
    
}
mostraIdade();








