# importando as bibliotecas
from kafka import KafkaConsumer
import pandas as pd

#configuração do kafka
brokers = ['ct-br.exaas.bosch.com:9092']
topic = 'testCt-ETS'
consumer = KafkaConsumer(topic, group_id = 'Alexandre', bootstrap_servers = brokers)

#geração da nuvem de palavras em tempo real
lista = []
try:
    arq = open ('arquivo.csv', 'w')
    for messagem in consumer:
        mensagem = ""
        messagem = messagem.value.decode('utf-8')
        for c in messagem:
            if(c == '{' or c == '}' or c == '"'):
                pass
            else:
                mensagem += c
        print(mensagem)
        print('\n')
        lista.append(mensagem)
        lista = mensagem.split(' ')
        
        
        arq.write(f'{lista}\n')
except Exception:
    print('deu erro')
finally:
    arq.close()
  