const fs = require("fs").promises;
const path = require("path");

async function readDir(roodDir) {
  rootDir = roodDir || path.resolve(__dirname); // Caso seja mandado um diretório ele será usado, caso contrario usara o diretório de onde o arquivo JS está

  const files = await fs.readdir(rootDir); // Retorna um array com todos os arquivos desse diretório

  walk(files, roodDir);
}

async function walk(files, roodDir) {
  for (let file of files) {
    const fileFullPath = path.resolve(roodDir, file); // Retorna o caminho do arquivo mais o nome do arquivo

    const stats = await fs.stat(fileFullPath);

    if (stats.isDirectory()) {
      // Retorna se o arquivo é um diretório (pasta) ou não

      readDir(fileFullPath); // Volta a chamar a função que chamou essa função, aplicando a recursão mutua no sistema

      continue;
    }

    if (!/\.css$/g.test(fileFullPath)) continue; // Filtra apenas os arquivos css

    console.log(fileFullPath);
  }
}

readDir("C:/Users/disrct/Desktop/ProjetoLoja");
