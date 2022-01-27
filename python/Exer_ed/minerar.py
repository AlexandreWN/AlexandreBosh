# -*- coding: utf-8 -*-
"""
Created on Mon Dec 20 16:03:33 2021

@author: DISRCT
"""
#bibliotecas
import pandas as pd
import matplotlib.pyplot as plt

#arq recebe a abertura do arquivo com  opandas, (Separado em DIA, MES e ANO)
arq = pd.read_csv('exercicioedjalma.csv',sep="/",names=["Dia","Mes","Ano"])


#REFERENTE A ANOS
#datas recebe os anos de forma ordenada
datas = pd.DataFrame(arq, columns=["Ano"]).sort_values(by="Ano")
#quantidade recebe a quantidade que cada ano repete 
quant = plt.bar(datas["Ano"].unique(),height = datas["Ano"].value_counts().sort_index())
#CRIA O GRAFICO
print(arq)
plt.ylabel('quantidade')
plt.xlabel('anos')
plt.title('quantidade que cada ano repete')
plt.show()


#REFERENTE A MESES
#datas recebe os meses de forma ordenada
datas = pd.DataFrame(arq, columns=["Mes"]).sort_values(by="Mes")
#quantidade recebe a quantidade que cada mes repete 
quant = plt.bar(datas["Mes"].unique(),height = datas["Mes"].value_counts().sort_index())
#CRIA O GRAFICO
plt.ylabel('quantidade')
plt.xlabel('Meses')
plt.title('quantidade que cada mes repete')
plt.show()


#REFERENTE A DIAS
#datas recebe os dia de forma ordenada
datas = pd.DataFrame(arq, columns=["Dia"]).sort_values(by="Dia")
#quantidade recebe a quantidade que cada dia repete 
quant = plt.bar(datas["Dia"].unique(),height = datas["Dia"].value_counts().sort_index())
#CRIA O GRAFICO
plt.ylabel('quantidade')
plt.xlabel('Dias')
plt.title('quantidade que cada dia repete')
plt.show()