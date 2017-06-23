//laços de interação


var contador = 0;
var limite = 15;

var mostrar = function(value){
    //console.log('mostar');
    //return 'mostrar';
    return 'mostrar' +' '+ value;
}


//while execua com base em uma condicao, nao sei o numero de vezes, verifica a comdicao no inicio
while(contador < limite){
    contador++;
    //console.log(contador);
    
    //console.log(mostrar(contador));
}
//for executa com base em uma variavel, eu sei o numero de vezes da interacao, verifica a variavel no inicio for(inicializacao,condicao,incrementacao)
for(var i = 1;i <=15;i++){
    //console.log(i);
    console.log(mostrar(i));
}
//objetos
for(in){
    
}
//para arrays
array.forEach()