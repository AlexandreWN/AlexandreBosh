#separa americanos
import pandas as pd
d = pd.read_csv("netflix_titles.csv")
ameri = d.loc[d['country']=="United States"]
ameri.to_csv('Americanos.csv')

# 2015 a 2020
d = pd.read_csv("Americanos.csv")
ameri = d.loc[d['release_year'] >= 2015]
ameri.to_csv('Data1.csv')

d = pd.read_csv("Data1.csv")
ameri = d.loc[d['release_year'] <= 2020]
ameri.to_csv('Data2.csv')

d = pd.read_csv("Data2.csv")
ameri = d.loc[d['release_year'] == 2015]
ameri.to_csv('2015.csv')
oi = open("2015.csv")
q = len(oi.readlines())

#dados pro grafico
d = pd.read_csv("Data2.csv")
ameri = d.loc[d['release_year'] == 2016]
ameri.to_csv('2016.csv')
oii = open("2016.csv")
qw = len(oii.readlines())

d = pd.read_csv("Data2.csv")
ameri = d.loc[d['release_year'] == 2017]
ameri.to_csv('2017.csv')
oiii = open("2017.csv")
qwe = len(oiii.readlines())

d = pd.read_csv("Data2.csv")
ameri = d.loc[d['release_year'] == 2018]
ameri.to_csv('2018.csv')
oiiii = open("2018.csv")
qwer = len(oiiii.readlines())

d = pd.read_csv("Data2.csv")
ameri = d.loc[d['release_year'] == 2019]
ameri.to_csv('2019.csv')
oiiiii = open("2019.csv")
qwert = len(oiiiii.readlines())

d = pd.read_csv("Data2.csv")
ameri = d.loc[d['release_year'] == 2020]
ameri.to_csv('2020.csv')
oiiiiii = open("2020.csv")
qwerty = len(oiiiiii.readlines())

#grafico
import matplotlib.pyplot as plt

valores = [q,qw,qwe,qwer,qwert,qwerty]
grupos = '2015', '2016', '2017', '2018','2019','2020'
plt.bar(grupos, valores)
plt.title('quant filmes por ano')
plt.show()
