//exclarecendo Membros e metodos privados

//modulo
var pessoa = (function(nome,idade,sexo){
    //membros privados
    var nome = nome;
    var idade = idade;
    var sexo = sexo;
    //-------------------------
    //revealing module pattern javascript
        //especifica os membro privados no inicio
    //metodos privilegiados porque eles podem acessar e modificar
    var getNome = function(){
        return nome;
    }   
    var getIdade = function(){
        return idade;
    } 
    var getSexo = function(){
        return sexo;
    }
    
    var metodos ={
        getNome: getNome,
        getIdade: getIdade,
        getSexo: getSexo
    }
    //congelou o objeto - garantir que os metodos não seja auterado
    Object.freeze(metodos);
    
    return metodos;
    
})('Helinton',26,'M');

pessoa.getNome = 'sd';
console.log(pessoa);