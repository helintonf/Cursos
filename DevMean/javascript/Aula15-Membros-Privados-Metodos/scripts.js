//Membros privados e privilegiados são funções para acessar os dados privados

//var pessoa = function(nome,idade,sexo){
//    var nome = nome;
//    return{
//        getNome: function(){
//            return nome;    
//        },
//        setNome: function(value){
//            nome = value;
//        },
//        idade:idade,
//        sexo:sexo
//    }
//}


//var helinton = pessoa('Helinton',25,'M');



//helinton.setNome('Casa');
//console.log(helinton.getNome());
//helinton.getNome = 'teste';
//console.log(helinton);

// como criar um modulo IIFE

var pessoa = (function(nome,idade,sexo){
    var nome = nome;
    var idade = idade;
    var sexo = sexo;
    
    var getNome = function(){
            return nome;
        }
    var  setNome = function(value){
            nome = value;
        }
    
    var access = {
        getNome:getNome ,
        setNome:setNome
    }
    
    Object.freeze(access);
    
    return access;
    
})('Helinton',25,'M');

pessoa.setNome('Casa');
console.log(pessoa.getNome());




