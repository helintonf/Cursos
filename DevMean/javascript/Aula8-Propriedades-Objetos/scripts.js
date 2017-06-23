//Propriedades OBJETOS
//propriedades de dados armazena valor

var pessoa = {
    nome : "Helinton",
    _idade : 26,
    sexo : "masculino",
    casado : false,
    get idade(){
        this.casado = true;
        return this._idade;
    },
    set idade(value){
        this._idade = value;
    }
};
pessoa.idade = 21
console.log(pessoa.idade);
console.log(pessoa.casado);

//propriedades de acesso nao armazeman valor ervem para modificar prorpiedades de dados get e seters

