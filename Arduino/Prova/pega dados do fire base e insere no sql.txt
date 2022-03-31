import requests
import json
import pyodbc
import time
import seaborn


proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
url = 'https://teste-912f4-default-rtdb.firebaseio.com/Sensor.json'

def sinal():
    proxies = {'https': 'https://disrct:saladigital0311@10.224.200.26:8080'}
    url_Sensor = 'https://esp32-fbcfe-default-rtdb.firebaseio.com/Sensor/Alexandre/Luminosidade.json'
    Luminosidade = float(requests.get(url_Sensor, proxies=proxies).content)
    return Luminosidade

def InserirBD(sinal):
    server = 'CTPC3625\SQLSERVER'
    database = 'dados'
    username = 'Nikitin'
    password = '05032awn'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
    cursor = cnxn.cursor()
    cursor.execute(f"INSERT INTO dbo.dadosss (valor) VALUES ({sinal});")
    cursor.commit()
    print("Inserido com sucesso!")

while True:
    InserirBD(sinal())
    time.sleep(1)

'''create table dadosss( id int not null identity(1,1) primary key, valor int not null, tempo datetime default current_timestamp);'''