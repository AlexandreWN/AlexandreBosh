while True:
    idade = float(input ("digite sua idade: " ))
    if idade >= 0 and idade <= 150:
        break
if idade < 18:
    print("menor de idade ")
else:
    print("maior de idade ")