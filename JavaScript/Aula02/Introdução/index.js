/*----------------------------------------------------------------------------*/
//Function hoisting
function_hoisting();

function function_hoisting(){
    //console.log("Pode ser declarada depois de usada")
}
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//First class
const FuncaoComoDado = function(){
    //console.log("Sou um dado")
}

FuncaoComoDado();
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//Arrow function
const FuncaoArrow = () => console.log(/*"Outra forma de declaração"*/);

const FuncaoArrow2 = () => {
    //console.log("Tambem pode ser assim")
}

FuncaoArrow();
FuncaoArrow2();
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//Funçao dentro de objeto
const objeto ={
    metodoDeObjeto(){
        //console.log("Sou um metodo de objeto");
    }
};

objeto.metodoDeObjeto();
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//Callback
function funcao1(callback){
    setTimeout(function() {
        console.log('Função1');
        if(callback) callback();
    }, 2500);
};

function funcao2(callback){
    setTimeout(function() {
        console.log('Função2');
        if(callback) callback();
    }, 2000);
};

function funcao3(callback){
    setTimeout(function() {
        console.log('Função3');
        if(callback) callback();
    }, 1000);
};

function fim(){
    console.log("Acabo");
};
/*
funcao1(f1callback);

function f1callback(){
    funcao2(f2callback);
};

function f2callback(){
    funcao3(f3callback);
};

function f3callback(){
    fim();
};
*/
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//IIFE
(function(){
    //console.log("Essa função vai ser executada imediatamente!")
})();

var nome = "Um nome" ;
( function (){
    const nome = "Outro nome" ;
    //console.log(nome);
})();

//console.log(nome);

var nome = "Thiago" ;

( function (nome){
    //console.log(nome);
})(nome);

/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//Factory Functions
/*
function criaPessoa(nome){
    return {
        nome,
        fala (assunto){
            return `${nome} está falando sobre ${assunto}`;
        }
    };
}

var pessoa = criaPessoa( "Luiz" );
console.log(pessoa);
console.log(pessoa.fala( "JavaScript" ));


function criaPessoa2(name, height, weight){
    return {
        nome: name,
        altura: height,
        peso: weight,
        imc (assunto){
            let indice = ( this .peso / this .altura**2).toFixed(2);
            return `${ this .nome} tem o IMC de ${indice}`;
        }
    };
}

var pessoa = criaPessoa2( "Luiz" , 1.7, 65);
console.log(pessoa);
console.log(pessoa.imc());
*/

/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//Constructor Functions
/*
function Pessoa(nome, sobrenome){
    this .nome = nome;
    this .sobrenome = sobrenome;

    const metodoPrivado = () => console.log( "Esse metodo não aparece para ser chamado" );
    this .metodo = () => {
        console.log( "Esse metodo pode ser chamado e chamar os metodos internos" );
        metodoPrivado();
    };
}
    
const pessoa = new Pessoa( 'Marcio' , 'Antonio' );

pessoa.metodo();
*/
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/

//Funções Recursivas
/*
function recursiva(i){
    if(i>10) return;
    console.log(i)
    i++;
    recursiva(i);
}
recursiva(0);
*/
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
//funções Geradoras
function * geradorFinito(){
    yield "Valor 1" ;
    yield "Valor 2" ;
    yield "Valor 3" ;
}

const gerador = geradorFinito();
console.log(gerador.next());
console.log(gerador.next());
console.log(gerador.next());
console.log(gerador.next());