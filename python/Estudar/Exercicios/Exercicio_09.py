#pessoas = {'nome':'Gustavo','sexo':'M','idade':22}
#print(pessoas.items())
#pessoas['nome'] = 'Leandro'
#for k,v in pessoas.items():
#    print(f'{k} = {v}')

#brasil  = list()
#estado1 =  {'uf':'Rio de Janeiro', 'sigla':'RJ'}
#estado2 =  {'uf':'São Paulo', 'Sigla':'SP'}
#brasil.append(estado1)
#brasil.append(estado2)
#print(brasil[0]['sigla'])

#estado = dict()
#brasil = list()
#for c in range(0,3):
#    estado['uf'] =  str(input('Unidade Federal: '))
#    estado['sigla'] = str(input('Sigla do estado: '))
#    brasil.append(estado.copy())
#for e in brasil:
#    for k,v in e.items():
#        print(f'A {k} é {v}')

#from random import randint
#from time import sleep
#from operator import itemgetter
#
#jogo = {'jogador1': randint(1,6),
#'jogador2': randint(1,6),
#'jogador3': randint(1,6),
#'jogador4': randint(1,6)}
#
#ranking = list ()
#
#print('Valores Sorteados: ')
#
#for k,v in jogo.items():
#    print(f'{k} tirou {v} no dado.')
#    sleep(1)
#ranking = sorted(jogo.items(), key=itemgetter(1), reverse=True)
#print('-=' * 30)
#print(' == RANKING DOS JOGADORES ==')
#for i,v in enumerate(ranking):
#    print(f'    {i+1} lugar: {v[0]} com {v[1]}.')
#    sleep(1)

