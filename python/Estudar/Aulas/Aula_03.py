frase = 'Eu criei essa frase criei'
print(len(frase)) #conta quantos caracteres tem a frase
print(frase.count('e')) #conta quantos desse caractere tem a frase
print(frase.find('ei')) #indica a posição que encontrou o primeiro 
#(obs se a string não existir ele retorna o valor de -1)
print(frase.replace('criei','OI')) #troca o primeiro elemento pelo segundo
print(frase.upper()) #deixa tudo em maiuscula
print(frase.lower()) #deixa tudo em minuscula
print(frase.capitalize()) #deixa a primeira letra da frase em maiusculo e tudo em minuscula
print(frase.title()) #deixa todas a primeiras letras em maiusculo e o resto em minusculo
print(frase.strip()) #remove espaços inuteis no inicio e do final da string
print(frase.rstrip()) #remove espaços inuteis da direita da string
print(frase.lstrip()) #remove espaços inuteis da esquerda da string
print(frase.split()) #separa a string em uma lista
print('-'.join(frase))