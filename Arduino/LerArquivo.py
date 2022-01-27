import pandas as pd
import os
import time
from kafka import KafkaProducer
import json as json

# Variaveis
path = r'S:\COM\Human_Resources\01.Engineering_Tech_School\02.Internal\10 - Aprendizes\5 - Desenvolvimento de Sistemas\datastream\melissa\stat010'
broker = 'ct-br.exaas.bosch.com:9092'
topic = 'testCt-ETS'

# open kafka connection
producer = KafkaProducer(bootstrap_servers=broker, value_serializer=lambda v: json.dumps(v).encode('utf-8'))

def SendToBroker(topic, msg):
    producer.send(topic, msg)
    print(producer.metrics)


while(True):
    files = os.listdir(path)
    
    for file in files:
        fileName = os.path.join(path,file)
        data = pd.read_csv(fileName)
        data['ntuser'] = 'melissa'
        msg = data.to_dict('records')
        SendToBroker(topic, msg)
        os.remove(fileName)
    time.sleep(1)