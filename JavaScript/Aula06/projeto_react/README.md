1-npx create-react-app <nome do projeto>
----------------------------------------------------------------------------------------------------------------------------------------------------
2-Ao concluir a criação da pasta podemos rodar a nossa aplicação com "npm start", feito isso devemos
esperar um pouco e uma pagina Web ira abrir com a tela inicial do React
----------------------------------------------------------------------------------------------------------------------------------------------------
3-deletar arquivos começando pela pasta "src" vamos deixar apenas os arquivos index.js, App.js e App.css e na pasta "public" vamos deixar apenas
index.html
----------------------------------------------------------------------------------------------------------------------------------------------------
4-index.js
import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
    <React.StrictMode>
        <App />
    </React.StrictMode>
 );
----------------------------------------------------------------------------------------------------------------------------------------------------
5-App.js
import './App.css';

function App() {
    return (
        <h1>Hellow world!</h1>
    );
}
export default App;
----------------------------------------------------------------------------------------------------------------------------------------------------
6-index.html
<!DOCTYPE html>
<html lang="pt-BR">
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Exemplo</title>
    </head>
    <body>
        <noscript>You need to enable JavaScript to run this app.</noscript>
        <div id="root"></div>
    </body>
</html>
----------------------------------------------------------------------------------------------------------------------------------------------------
