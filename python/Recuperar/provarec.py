'''Exercicio 01'''
'''
cotacao = 3.77
dolar = float(input("Informe a quantidade de dólar para conversão:"))
print (dolar*cotacao) 
'''

'''Exercicio 02'''
'''
c = 0
tupla = ("Estados Unidos", "Noruega", "Estados Unidos", "Alemanha", "Alemanha","Japão","Estados Unidos","Estados Unidos")
for i in tupla:
  if (c >= 3):
    print(f"ganhador: {i}")
  c+=1
'''
'''Exercicio 03'''
'''
print("Cardapio")
print("0 = Combo 1 X salada + fritas + KS (sabores)")
print("1 = Combo 2 X Picanha Bacon + fritas + KS (sabores)")
print("2 = Combo 3 X Calabresa Vinagrete + fritas + KS (sabores)")
print("3 = Combo 4 X Frango salada + fritas + KS (sabores)")
print("4 = Combo 5 Duplo cheddar bacon + fritas + KS (sabores)")
print("5 = Combo Kids X burguer + batata sorriso + coca 200ml ou suco + danoninho")
op = int(input("Escolha qual combo vai querer:"))

if op == 0:
    valor = 23.99
elif op == 1:
    valor = 27.99
elif op == 2:
    valor = 26.99
elif op == 3:
    valor = 25.99
elif op == 4:
    valor = 32.99
elif op == 5:
    valor = 16.99

print("O valor do combo selecionado é:")
print(valor)
'''

'''Exercicio 04'''
'''
numeros = []
x = True

while x:
    print("Digite 1 para digitar um numero")
    print("digite 2 para parar")
    op = int(input("Escolha sua opção"))
    if op == 1:
        numero = int(input("Digite um numero"))
        numeros.append(numero * 2)
    else:
        x  = False
for i in numeros:
    print(i)
'''

'''Exercicio 05'''
'''
import os
item = ''

def subtracao():
  try:
    n1 = float(input("Digite um numero: "))
    n2 = float(input("Digite outro numero: "))
    sub = n1 - n2
    return (sub)
  except ValueError:
    print("Valor invalido")
  except KeyboardInterrupt:
    print("Erro inesperado :(")
  except Exception:
    print("Erro inesperado :(")

def adicao():
  try:
    n1 = float(input("Digite um numero: "))
    n2 = float(input("Digite outro numero: "))
    adi = n1 + n2
    return (adi)
  except ValueError:
    print("Valor invalido")
  except KeyboardInterrupt:
    print("Erro inesperado :(")
  except Exception:
    print("Erro inesperado :(")

def divisao():
  try:
    n1 = float(input("Digite um numero: "))
    n2 = float(input("Digite outro numero: "))
    div = n1 / n2
    return (div)
  except ValueError:
    print("Valor invalido")
  except KeyboardInterrupt:
    print("Erro inesperado :(")
  except ZeroDivisionError:
    print("divisão invalida")
  except Exception:
    print("Erro inesperado :(")

def multiplicacao():
  try:
    n1 = float(input("Digite um numero: "))
    n2 = float(input("Digite outro numero: "))
    mult = n1 * n2
    return (mult)
  except ValueError:
    print("Valor invalido")
  except KeyboardInterrupt:
    print("Erro inesperado :(")
  except Exception:
    print("Erro inesperado :(")

while True:
  try:
    print ("Apert (-) para subitração")
    print ("Apert (+) para soma")
    print ("Apert (/) para divisão")
    print ("Apert (*) para multiplicação")
    print ("Para sair da calculadora digite (s)")
    item = input("Digite a opção: ")
    os.system('cls')
  except KeyboardInterrupt:
    print("Erro inesperado :(")
  except Exception:
    print("Erro inesperado :(")

  if item == ("-"):
    a = subtracao()
    print (f"seu valor é: {a}")
  elif item == ("+"):
    a = adicao()
    print (f"seu valor é: {a}")
  elif item == ("/"):
    a = divisao()
    print (f"seu valor é: {a}")
  elif item == ("*"):
    a = multiplicacao()
    print (f"seu valor é: {a}")
  elif item == ("s"):
    break
'''

'''Exercicio 06'''
'''
def cont(x):
    i = 0
    while i < x + 1:
        print(i)
        print("-"*50)
        i = i + 1
        
valor = int(input("Digite até que valor deseja que o programa conte"))
cont(valor)
'''

'''Exercicio 07'''
'''
digitado = input("Digite alguma coisa para guardar no arquivo:")
try:
  arq = open('questao_7.txt', 'a+')
  arq.write(digitado)
except Exception:
  print("erro")
finally:
  arq.close()
'''

'''Exercicio 08'''

'''Exercicio 09'''
'''
x = True
while x:
    num = input("Digite o número: ")
    num = int(num)
    div = 2
    primo = True
    mini = num/2
    if num%div == 0:
        primo = False
        print("É divisível por: ", div)
        div += 1
    if num <= 1:
        primo = False

    if primo == True:
        print("É primo")
        x = False
    else:
        print("Não é primo")
'''
'''Exercicio 10'''

"""
lista = [] '''Declara a lista'''
tam = int (input("digite o tamanho da lista:")) '''Recebe o tamanho da lsita'''
for i in range (1,tam+1,1): '''loop'''
    x=int(input("valor {}:" . format(i))) '''x recebe o valor de i'''
    lista.append(x) '''insere os valores de x na lista'''
print("\nLISTA:")
print(lista) '''printa a lista desoredenada'''
'''Esse bloco ordena a lista en oredem crescente'''
for i in range(tam):
    for j in range(tam):
        if lista[j] > lista[i]:
            lista[i],lista[j] = lista[j],lista[i]
print("\nLISTA ORDENADA")
print(lista) '''printa a lista ordenada'''
"""
'''Esse programa recebe um tamanho desejado parar uma lista, logo em seguida recebe os valores insere em lista, printa a lista, ordena a lista e printa a lista ordenada'''

