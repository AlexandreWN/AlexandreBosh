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




print("para inserir a quantidade de peças produzidas digite (a)")
print("para visializar a quantidade de peças produzidas no mes digite (b)")
print("para terminar o programa digite (-1)")

op = input("digite a opção desejada: ")
listames = []
listaquant = []
lsitaval = []
if op == "a":
  
    try:
      arq = open('quatidade','a+')
      arq1 = open('valores','w+' )
      while True:
        quant = int(input("digite a quantidade de peças: "))
        if quant == -1:
          break
        else:
          mes = int(input("Digite o mes de forma numerica ex(1 = janeiro): "))
        if mes >= 1 and mes <=12:
          arq.write(f'quantia de peças produzidas:{quant}, mes da produção: {mes}\n')
          arq1.write(f'{quant}\n')
          listaquant.append(quant)
          listames.append(mes)
        else:
          print("mes ivalido")
        
    except Exception:
      print("erro")
    finally:
      arq.close()
      arq1.close()
print(listames)
print(listaquant)

if op == "b":
  try:
    arq = open('quatidade', 'r')
    print(arq.read())
  except Exception:
    print("erro")
  finally:
    arq.close()