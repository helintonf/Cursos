//OBJETOS

var pessoa = {};
//adicionando novas propriedades
//as propriedades sao inumeraveis, podendo ir no array
pessoa.nome = 'Helinton';
pessoa.idade = 29;
pessoa.sexo = 'Masculino';
pessoa.casado = false; //falsy falso negativo

//deletar propriedades
//delete pessoa.idade;

//remover propriedade com base em uma condicao
    // in verifica uma propriedade em um objeto, cuidado com a heranca

    //if("casado" in pessoa){
    //    delete pessoa.casado;
    //}

  //  if(pessoa.hasOwnProperty("casado")){
//        delete pessoa.casado;
//    }

//------

//for(propriedade in objeto)

//for(propriedade in pessoa){
//     console.log(propriedade);
//     console.log(pessoa[propriedade]);
//}

//var i, size;
//var propriedade = Object.keys(pessoa);
    //console.log(propriedade);

//for(i = 0,size = propriedade.legth; i < size; i++){
//    console.log(pessoa[propriedade[i]]);
//}

console.log(pessoa.propertyEnumerable("idade"));

//console.log(pessoa.hasOwnProperty("casado")); //pesquisa somente no objeto local que envoca
//console.log(pessoa);