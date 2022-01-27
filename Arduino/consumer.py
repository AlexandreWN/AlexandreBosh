# -*- coding: utf-8 -*-
"""
Created on Fri Nov 26 16:28:26 2021

@author: DISRCT
"""

from kafka import KafkaConsumer
import pandas as pd
import json as json
import matplotlib.pyplot as plt
from datetime import datetime

# To consume latest messages and auto-commit offsets
consumer = KafkaConsumer('testCt-ETS',
                         group_id='melissa',
                         bootstrap_servers=['ct-br.exaas.bosch.com:9092'],
                         value_deserializer=lambda m: json.loads(m.decode('ascii')),
                         auto_offset_reset='earliest', enable_auto_commit=False
                         )
dic = {}
temp = []
time = []
air_pressure = []
i = 0

for message in consumer:
    ts = int(message.value['time'])
    time.append(datetime.utcfromtimestamp(ts).strftime('%H:%M:%S'))
    
    temp.append(message.value['temp'])
    
    ap = int(message.value['air_pressure'])/40
    air_pressure.append(ap)
    
    i = i + 1
    
    if i > 10:
        break;
        
dic["Time"] = time
dic["Temp"] = temp
dic["Air Pressure/40"] = air_pressure

d = pd.DataFrame.from_dict(dic)
print(d)

d.plot.barh(x='Time');
plt.close("all")