# -*- coding: utf-8 -*-
"""
Created on Mon Dec 20 08:48:15 2021

@author: DISRCT
"""
#Bibliotecas
import matplotlib.pyplot as plt 
import numpy as np

#variaveis
aprovados = list()
reprovados = list()
x = True
reprovadoM = 0
reprovadoF = 0
aprovadoM = 0
aprovadoF = 0

#loop principal
while(x):
    x = str(input('digite S para adicionar ou P para parar: '))
    
    #entrada de dados/inicio do programa
    if(x == 'S' or x == 's'):
        nome = str(input('Digite o nome: '))
        sexo = str(input('digite M para masculino ou F para feminino: '))
        dataat = int(input('Digite o ano atual: '))
        datanas = int(input('Digite o ano de nasc: '))
        peso = float(input('Digite o peso: '))
        altura = float(input('Digite a altura: '))
        idade = dataat - datanas
        reprovado_por = ''
        
        #Masculino
        if(sexo == 'M' or sexo == 'm'):
            if(idade > 18 and idade < 22 and peso == 76 and altura == 1.70):
                aprovados.append(f'nome: {nome}, sexo: {sexo}, idade: {idade}, peso: {peso}, altura: {altura}')
                aprovadoM+=1;
            else:
                reprovado_por += nome + ' foi reprovado por :'
                if(not idade > 18 and idade < 22):
                    reprovado_por += ' idade'
                if(peso != 76):
                    reprovado_por += ' peso'
                if(altura != 1.70):
                            reprovado_por += ' altura'
                reprovadoM+=1
                reprovados.append(reprovado_por)
                reprovado_por = ''
                
        #Feminino
        elif(sexo == 'F' or sexo == 'f'):
            if(idade > 16 and idade < 20 and peso == 70 and altura == 1.70):
                aprovados.append(f'nome: {nome}, sexo: {sexo}, idade: {idade}, peso: {peso}, altura: {altura}')
                aprovadoF+=1
            else:
                reprovado_por += nome + ' foi reprovado por: '
                if(not idade > 16 and idade < 20):
                    reprovado_por += ' idade'
                if(peso != 70):
                    reprovado_por += ' peso'
                if(altura != 1.70):
                    reprovado_por += ' altura'
                reprovadoF+=1
                reprovados.append(reprovado_por)
                reprovado_por = ''
    #saida
    else:
        x = False
        
#print das listas
print('\nLista de aprovados')
print(aprovados)

print('\nLista de reprovados')
print(reprovados)

#grafico masculino
fig = plt.figure()
ax = fig.add_axes([0,0,1,1])
ax.axis('equal')
langs = ['aprovados', 'reprovados']
students = [aprovadoM,reprovadoM]
plt.title('MASCULINO')
ax.pie(students, labels = langs,autopct='%1.2f%%')
plt.show()

#grafico feminino
fig = plt.figure()
ax = fig.add_axes([0,0,1,1])
ax.axis('equal')
langs = ['aprovados', 'reprovados']
students = [aprovadoF,reprovadoF]
plt.title('FEMININO')
ax.pie(students, labels = langs,autopct='%1.2f%%')
plt.show()