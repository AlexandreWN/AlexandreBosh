import requests
import json
import pyodbc
import time
import seaborn


proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
url = 'https://prova-8aed1-default-rtdb.firebaseio.com/Sensor.json'

def sinal():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
    url_temperatura = 'https://prova-8aed1-default-rtdb.firebaseio.com/Sensor/temperatura.json'
    url_umidade = 'https://prova-8aed1-default-rtdb.firebaseio.com/Sensor/umidade.json'
    temperatura = float(requests.get(url_temperatura, proxies=proxies).content)
    umidade = float(requests.get(url_umidade, proxies=proxies).content)
    return temperatura, umidade

def InserirBD(sinal):
    server = 'CTPC3625\SQLSERVER'
    database = 'dados'
    username = 'Nikitin'
    password = '05032awn'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()
    cursor.execute(f"INSERT INTO dbo.Sensor (Temperatura, Umidade) VALUES ({sinal[0]}, {sinal[1]});")
    cursor.commit()
    print("Inserido com sucesso!")

while True:
    InserirBD(sinal())
    time.sleep(30)
    
'''create table Sensor( id int not null identity(1,1) primary key, Temperatura float not null, Umidade float not null, tempo datetime default current_timestamp);'''