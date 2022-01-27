# -*- coding: utf-8 -*-
"""
Created on Mon Jul  5 14:40:22 2021

@author: DISRCT
"""
import paho.mqtt.client as mqtt
import time
import socket
import requests
import pyodbc
import json

socket.getaddrinfo('localhost', 8080)

def on_connect(client, userdata, flags, rc):
	if rc==0:
		print("Cliente conectado ao Broker!\n")
		try:
			client.subscribe("Treinamento/ets/alexandre", qos=0)
			print("Cliente inscrito no tópico!\n")
         
		except:
			print("Não foi possível inscrever o cliente no tópico\n")
	else:
		print("Cliente não conectado ao Broker.\n")


def on_disconnect(client, userdata, rc):
	if rc != 0:
		print("Cliente desconectado do Broker inesperadamente.\n")	


def on_message(client, userdata, msg):
    msgPayload = str(msg.payload.decode('utf-8'))
    msgTopic = str(msg.topic)
    print(msgPayload + "\n")
    texto = json.parse(str(msg.payload.decode('utf-8')))
    return texto

broker_address='broker.hivemq.com'
broker_port=1883

def inserirBD(on_message):
    server = 'CTPC3625\SQLSERVER'
    database = 'DadosEsp'
    username = 'Nikitin'
    password = '05032awn'
    cnxn = pyodbc.connect('DRIVER={ODBC Driver 17 for SQL Server};SERVER='+server+',DATABASE='+database+';UID='+username+';PWD='+password)
    cursor = cnxn.cursor()
    cursor.execute(f"INSERT dbo.DadosEsp(humid,temp,Lumi) VALUES ({on_message[0]},{on_message[1]},{on_message[2]});")
    cursor.commit()
    
client = mqtt.Client()
client.on_connect = on_connect
client.on_disconnect = on_disconnect
client.on_message = on_message
print("Conectando ao Broker")
client.connect(broker_address, broker_port)
print("Broker!!")

while(True):
    inserirBD(on_message())
    time.sleep(60)
    print("foi")
    
time.sleep(4)
client.loop_forever()

'''CTPC3625\SQLSERVER'''
