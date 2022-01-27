# importando as bibliotecas
from kafka import KafkaProducer
import pandas as pd
import os
import time
import json

path = 'S:/COM/Human_Resources/01.Engineering_Tech_School/02.Internal/10 - Aprendizes/5 - Desenvolvimento de Sistemas/datastream/alexandre/stat010'
broker = 'ct-br.exaas.bosch.com:9092'
topic = 'testCt-ETS'
producer = KafkaProducer(bootstrap_servers=broker, value_serializer=lambda v: json.dumps(v).encode('utf-8'))
 
def mensagem(topic, msg):
    producer.send(topic, msg)
    
while(True):
    file = os.listdir(path)
    
    for arquivo in file:
            
        fileName = os.path.join(path, arquivo)
        data = pd.read_csv(fileName)
        data['ntuser'] = 'Alexandre'
        print(data.to_dict('records'));
        os.remove(fileName)
            
        #chama função
        mensagem(topic, data.to_dict('records'))
            
    time.sleep(1)