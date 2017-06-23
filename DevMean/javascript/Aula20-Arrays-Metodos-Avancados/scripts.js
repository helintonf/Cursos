//Arrays é um objeto. metodos de array e tipos de array, cria indice a partir de zero

var carros = ['gol','celta','uno'];
//filter recebe uma funcao  e retorna um array com valor filtrado
var filter = carros.filter(function(value){
    return value == 'gol';
});

carros.forEach(function(item){
   if( item == 'gol'){
       var carro = new Array(item);
      // console.log(carro);
   }
});

//se encontrar o valor no array ele retorna um true se nao false
var some = carros.some(function(valor){
    return valor == 'gol';
});
//se encontrar retorna uma string com o valor do array encontrado
var find = carros.find(function(valor){
    return valor == 'gol';
});

console.log(filter);
console.log(some);
console.log(find);

var numeros = [10,15,20];
//faz operações matematicas no arrays com o total e o procimo indice
var res = numeros.reduce(function(total,numero){
    return total + numero;
});

var soma = function(total,numero){
    return total + numero;
}

console.log(res);









