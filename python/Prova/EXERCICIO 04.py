lista = ['1_palmeiras', '2_coritiba', '1_corintians', '3_juventude', '2_parana clube', '3_volta redonda']
lista1 = []
lista2 = []
lista3 = []
for i in lista:
  print (i)
  a = i.split('_')
  print (a)
  if a[0] == '1':
    lista1.append(a)
  elif a[0] == '2':
    lista2.append(a)
  else:
    lista3.append(a)
print(f'primeira divisão: {lista1}')
print(f'segunda divisão: {lista2}')
print(f'terceira divisão: {lista3}')