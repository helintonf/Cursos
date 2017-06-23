//function mostraNome(){
//    return 'Helinton';
//}
//mostraNome();

//var recebeNome = mostraNome();

//var mostraNome = {'nome': 'Helinton'};

var teste = (typeof mostraNome);

if(teste === 'function'){
    var recebeNome = mostraNome();
}else{
    console.log('mostraNome não é uma função')
}
console.log(recebeNome);



function showName(){
    return 'joão';
}

if(showName instanceof Function){
    var nome = showName();
}

console.log(nome);



var carros = ['gol','uno','corolla'];

var auto = new Object();

if(auto instanceof Array){
    console.log(carros);
}else{
    console.log(typeof auto);
}


if(Array.isArray(carros)){
     console.log(carros);
}

