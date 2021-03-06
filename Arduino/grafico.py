import matplotlib.pyplot as plt
import seaborn as sns
import pandas as pd
import numpy as np
import pyodbc


server = 'CTPC3625\SQLSERVER'
database = 'dados'
username = 'Nikitin'
password = '05032awn'
conn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+';DATABASE='+database+';UID='+username+';PWD='+ password)
cursor = conn.cursor()
cursor.execute(f"SELECT valor,tempo FROM dadosss;")
row = cursor.fetchone()

lista = []
listaid = []

while row:
    lista.append(row[0])
    listatempo.append(str(row[1]))
    row = cursor.fetchone()
    
df = pd.DataFrame({"Luminosidade":lista, "Tempo":listatempo})

df['Tempo'] = pd.to_datetime(df['Tempo'])
sns.relplot(x='Tempo', y='Luminosidade', data=df, kind='line')
plt.title('Luminosidade por Tempo')
plt.xticks(rotation=90)


'''create table dadosss( id int not null identity(1,1) primary key, valor int not null, tempo datetime default current_timestamp);'''