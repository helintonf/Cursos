//Arrays é um objeto. metodos de array e tipos de array, cria indice a partir de zero

var carros = ['gol','celta','uno'];
//carros.pop(); //tira o ultimo
//carros.length; //tamanho do array
//carros.push('Corcel'); //coloca no final do array
//carros.shift(); //remove o primeiro
//carros.unshift('EcoSport'); //coloca no primeiro

//console.log(carros);


//carros.splice(1,1); //remove e retorna os indices especificados


//console.log(carros);

var getCarro = function(posicao,qtd){
    var carros = ['gol','celta','uno'];
    
    return carros.splice(posicao,qtd);
    //console.log(carros);
}

//var NovosCarros = getCarro(1,2);

var NovosCarros = carros.slice(); //copia o array

var carro = NovosCarros[1];

console.log(NovosCarros);   
console.log(carro);

NovosCarros.forEach(function(item, index){//foreah percorre o array dinamicamente
    console.log(index,item);
})



