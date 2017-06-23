// FUNCTION = DECLARACAO X EXPRESSAO


// FUNCTION = DECLARACAO
    //NO CARREGAMENTO ARRASTA PRA CIMA PODE AS VEZES CAUSAR ALGUNS PROBLEMAS 

//    function mostraNome(){

//        console.log('HelintonDeclaracao');
//    }
//    mostraNome();


// FUNCTION = EXPRESSAO
 //--PODE PASSAR FUNCTION COMO VALORES
//--quantos parametros quiser pode passar
// todas function tem arguments que pega os parametros de entrada e converte em array

var mostrarNome = function(nome,sobreNome){
 // return nome; 
   // return arguments[0];
    //return arguments.length;
        //ACESSAR TODOS ARGUMENTOS
        var qtd = arguments.length;
        var nomeCompleto = '';
        while(qtd > 0){
            //console.log(arguments[qtd]);
            nomeCompleto += ' '+arguments[qtd-1] ;
            qtd--;
        }

    console.log(nomeCompleto);
    //return qtd;
}

//var nome = mostrarNome('Helinton','Fioramonte','casa');
mostrarNome('Helinton','Fioramonte','casa');
//console.log(nome);