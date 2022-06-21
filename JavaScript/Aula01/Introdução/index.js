//PRINT NO CONSOLE

/*
console.log('Curso JS');
console.log("Curso JS");
console.log(`Curso JS`);
console.log(55,48.9,'Curso JS');
*/


//VARIAVEIS

/*
d = 10
const pi = 3.1415;
//pode redeclarar a vaiavel no memsmo bloco
var nome = 'Geraldo'
//não pode redeclarar a variavel no mesmo cloco
let nome = 'Geraldo'
*/

//PRINT NO WEB

/*
window.alert('alerta')
var c = window.prompt('digite')
window.alert(typeof(c))
c = parseFloat(c)
window.alert(typeof(c))
window.confirm(c)
window.confirm('adwad')
*/

//UTILITARIOS

/*
c.toString() converte para string
c.toSting(2) converte para binario
c.toFixed(2) arruma as casas decimais do numero
Number.isInteger(c) verifica se é um numero inteiro
Number.isNaN(c) verifica se o nuero é NaN
*/ 

//MATH

/*
Math.floot(num) arredonda para baixo
Math.ceil(num) arredonda o numero para cima
Math.round(num) arredonda o numero
Math.random() gera um numero aleatorio entre 0 e 1
*/

//LAÇO FOR

/*
 for(c = 0; c < 10; c++){
    console.log(`Curso JS`)
}
*/

//FUNÇÃO

/*
function sobrenome(){

}
*/

//OPERACÃO TERNARIA

/*
var usuario = 1000
var tipoUsuario = usuario >= 1000 ? 'Usuario Vip' : 'Usuario normal' //(condição) ? (valor verdadeiro) : (valor falso)
console.log(tipoUsuario)

var usuario = 100
var tipoUsuario = usuario >= 1000 ? 'Usuario Vip' : 'Usuario normal'
console.log(tipoUsuario)

var corUsuario = null
var corPadrao = corUsuario || 'azul'
console.log(corPadrao)

var corUsuario = 'Roxo'
var corPadrao = corUsuario || 'azul'
console.log(corPadrao)
*/

//ARRAY

/*
const nome = ['Luiz','Maria','João']
var nomes = 'Luiz, Maria ,João'
console.log(nome)

nome.push('Otavio') //Adiciona um item no final
console.log(nome)

nome.unshift('Luiza') //Adiciona um item no começo
console.log(nome)

nome.pop() //Tira um item do final
console.log(nome)

nome.shift() //Tira um item do começo
console.log(nome)

delete nome[1] //Tira o item referente ao indice passado, mas sem mudar o array
console.log(nome)

nome.length //mostra o tamanho do array

var novo_nomes = nome // referencia direta, se alterar ele vai alterar o pai
console.log(novo_nomes)

var novo_nomes2 = [...nome] //se alterar ele não vai alterar o pai
console.log(novo_nomes2)

var primeiro = nome.slice(0, 1) //pega apenas o primeiro elemento do array
console.log(primeiro)

var primeiro = nome.slice(0, -2) //vai mlostrar todos os elementos menos os dois ultimos
console.log(primeiro)

var primeiro = nome.slice(2) //vai mlostrar todos os elementos menos os dois primeiros
console.log(primeiro)


var juntado = nome.join(',') // junta o array em uma string
console.log(juntado)

var splitado = juntado.split(',') // separa a string
console.log(splitado)

var novos = nome.splice(2, 3, "Thiago", "Jose") // pesquisar splice dps
console.log(novos)

var c = array1.concat(array2) //coloca os arrays lado a lado
var c2 = array1.concat(array2, typeof(array2)) //não ão ser concatenados juntos

filter //filtra (pesquisar)

map //da para fazer calculos no inteiro (pesquisar)

reduce //pesquisar

nome.forEach() //pesquisar
*/