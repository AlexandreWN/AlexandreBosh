//ASSINC
/*
function rand(min, max) {
  min *= 1000;
  max *= 1000;
  return Math.floor(Math.random() * (max - min) + min);
}

function wait(msg, time) {
  setTimeout(() => {
    console.log(msg);
  }, time);
}

wait("Evento1", rand(1, 3));
wait("Evento2", rand(1, 3));
wait("Evento3", rand(1, 3));
*/
/*-----------------------------------------------------------------------*/
/*
//SINC
function wait2(msg, time) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve(msg);
    }, time);
  });
}

function wait2(msg, time) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve(msg);
    }, time);
  });
}

wait2("Evento 1", rand(1, 3))
  .then((resposta) => {
    console.log(resposta);
    return wait("Evento 2", rand(1, 3));
  })
  .then((resposta) => {
    console.log(resposta);
    return wait("Evento 3", rand(1, 3));
  })
  .then((resposta) => {
    console.log(resposta);
  })
  .catch();
function rand(min, max) {
  min *= 1000;
  max *= 1000;
  return Math.floor(Math.random() * (max - min) + min);
}
function wait(msg, time) {
  return new Promise((resolve, reject) => {
    if (typeof msg !== "string") reject("Bad value");
    setTimeout(() => {
      resolve(msg);
    }, time);
  });
}

wait2("Evento 1", rand(1, 3))
  .then((resposta) => {
    console.log(resposta);
    return wait("Evento 2", rand(1, 3));
  })
  .then((resposta) => {
    console.log(resposta);
    return wait("Evento 3", rand(1, 3));
  })
  .then((resposta) => {
    console.log(resposta);
  })
  .catch((e) => {
    console.log("ERRO:", e);
  });
console.log("Evento assíncrono");

*/
/*-----------------------------------------------------------------------*/

//Promise.all
/*
function rand(min, max) {
  min *= 1000;
  max *= 1000;
  return Math.floor(Math.random() * (max - min) + min);
}

function wait(msg, time) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve(msg);
    }, time);
  });
}

const promises = [
  "Primeiro valor",
  wait("Promise 1", rand(1,3)),
  wait("Promise 2", rand(1,3)),
  wait("Promise 3", rand(1,3)),
  "Outro valor",
];

Promise.all(promises)
  .then(function (valor) {
    console.log(valor);
  })
  .catch(function (erro) {
    console.log(erro);
  });
*/
/*-----------------------------------------------------------------------*/

/*
function rand(min, max) {
    min *= 1000;
    max *= 1000;
    return Math.floor(Math.random() * (max - min) + min);
}

function wait(msg, time) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
        resolve(msg);
        }, time);
    });
}

const promises = [
    wait('Promise 1', rand(1,3)),
    wait('Promise 2', rand(1,3)),
    wait('Promise 3', rand(1,3))
]

async function executa(){
    try {
        const fase1 = await wait( 'Fase 1' , rand(1,5));
        console.log(fase1);
        const fase2 = await wait( 'Fase 2' , rand(1,5));
        console.log(fase2);
        const fase3 = await wait( 'Fase 3' , rand(1,5));
        console.log(fase3);
        } catch (e){
        console.log(e)
    }
}
executa();
*/

