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
    // funcoes de metodos privados
    var getNome = function(){
        return nome;
    }   
    var getIdade = function(){
        return idade;
    } 
    var getSexo = function(){
        return sexo;
    }
    var setNome = function(value){
        nome = value;
    }
    var setIdade = function(value){
        idade =  value;
    }
    var setSexo = function(value){
        sexo = value;
    }
    //objeto com os metodos de leitura e escrita
    var metodos ={
        getNome: getNome,
        getIdade: getIdade,
        getSexo: getSexo,
        setNome:setNome,
        setIdade:setIdade,
        setSexo:setSexo
    }
    //configurar os objeto de metodos 
    Object.defineProperties(metodos,{
       getNome:{
            enumerable:false   //não é visivel
       },
       getIdade:{
            enumerable:false   
       },
       getSexo:{
            enumerable:false   
       }, 
        setNome:{
            enumerable:false   
       } ,
        setIdade:{
            enumerable:false   
       } ,
        setSexo:{
            enumerable:false   
       }
    });
    
    
    //congelou o objeto - garantir que os metodos não seja auterado
    Object.freeze(metodos);
    
    return metodos;
    
})('Helinton',26,'M');

for(propriedade in pessoa){
    console.log(propriedade);
}

pessoa.setNome('Maria');
pessoa.setSexo('F');


console.log(pessoa.getNome());
console.log(pessoa.getSexo());