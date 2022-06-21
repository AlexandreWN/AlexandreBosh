numeros = window.prompt('Digite 10 numeros')
numeros = numeros.split(' ')

par = []
impar = []
for(c = 0; c < 3; c++){
    if(numeros[c] % 2 == 0){
        par.push(numeros[c])
    }else{
        impar.push(numeros[c])
    }
}
window.alert(par)
window.alert(impar)

impar.push(par[0])
par.shift();

window.alert(par)
window.alert(impar)

Array3 = []

par.forEach(element => {
    if(par.indexOf(element) % element == 0){
        Array3.push(element)
    }
});
impar.forEach(element => {
    if(element % impar.indexOf(element) == 0){
        Array3.push(element)
    }
});
alert(Array3)