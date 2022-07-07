var perguntas = ['pergunta1', 'pergunta2', 'pergunta3', 'pergunta4','Confirme para ver o resultado']
var respostas = [true, false, true, true]

var contador = 0
var score = 0

var pergunta = document.querySelector('#perguntas')
pergunta.textContent = perguntas[0];
var scores = document.querySelector('#score')
scores.textContent = score;

function sleep(milliseconds) {
    const date = Date.now();
    let currentDate = null;
    do {
      currentDate = Date.now();
    } while (currentDate - date < milliseconds);
  }

function confirm(){
    console.log(perguntas[contador])
    var verdadeiro = document.querySelector("#Verdadeiro").checked
    var falso = document.querySelector("#Falso").checked

    pergunta.textContent = perguntas[contador];

    
    scores.textContent = score;

    if(contador < 4){
        if(verdadeiro == true && falso == false || verdadeiro == false && falso == true){
            if(verdadeiro == true){
                if(respostas[contador] == true){
                    score += 1
                    pergunta.textContent = "Acertou"
                    sleep(2000)
                    contador++
                }
                else{
                    pergunta.textContent = "Errou"
                    sleep(2000)
                    contador++
                }
            }
            else{
                if(respostas[contador] == false){
                    score += 1
                    pergunta.textContent = "Acertou"
                    sleep(2000)
                    contador++
                }
                else{
                    pergunta.textContent = "Errou"
                    sleep(2000)
                    contador++
                }
            }
        }
        else{
            pergunta.textContent = "Selecione uma alternativa";
            sleep(2000)
            pergunta.textContent = perguntas[contador];
        }
    
        pergunta.textContent = perguntas[contador];
        scores.textContent = score;
    }
    else{
        if(score > 3){
            pergunta.textContent = "Mito";
        }
        else if(score > 2){
            pergunta.textContent = "Na média";
        }
        else{
            pergunta.textContent = "Vai estudar"
        }
    }
    contador--
    contador++
}
