function Vai(){

    function getRandom(min, max) {
        min = Math.ceil(min);
        max = Math.floor(max);
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }
    
    function geraMaiuscula(){
        return String.fromCharCode(getRandom(65, 90))
    }
    
    function geraMinuscula(){
        return String.fromCharCode(getRandom(97, 122))
    }
    
    function geraNumeros(){
        return String.fromCharCode(getRandom(48, 57))
    }
    
    function geraSimbolos(){
        return String.fromCharCode(getRandom(33, 47))
    }

    var maiusculas = document.querySelector("#maiusculas").checked;
    var minusculas = document.querySelector("#minusculas").checked;
    var numeros = document.querySelector("#numeros").checked;
    var simbolos = document.querySelector("#simbolos").checked;
    let tamanho  = document.querySelector("#tamanho").value;
    var texto = ""
    if(tamanho <= 200){
        if(maiusculas != false || minusculas != false || numeros != false || simbolos != false){
            for(var c = 0; c < tamanho; c++){
                value = getRandom(1, 4)
                if(value == 1 && maiusculas == true){
                    texto += geraMaiuscula()
                }
                else if(value == 2 && minusculas == true){
                    texto += geraMinuscula()
                }
                else if(value == 3 && numeros == true){
                    texto += geraNumeros()
                }
                else if(value == 4 && simbolos == true){
                    texto += geraSimbolos()
                }
                else{
                    c--;
                }
            }
        
            let botao = document.body.querySelector('#s')
            botao.textContent = texto
        }
        else{
            window.alert("escolha ao menos uma opção")
        }
    }
    else{
        window.alert("A senha deve possuir no maximo 200 caracteres")
    }
}