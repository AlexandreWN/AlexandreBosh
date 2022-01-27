lista_gol = []

nome = input("digite o nome do jogador: ")
partidas = int(input("Digite a quantidade de partidas jogadas: "))

x = 0
for i in range(partidas):
  gols = int(input("digite a quantidade de gols feitos na partida: "))
  lista_gol.append(gols)
  a = lista_gol
b = (f"nome: {nome},gols: {a},total: {sum(lista_gol)}")
print(b)
for i in a:
  print(f"Na partida {x} fez {i} gols")
  x += 1