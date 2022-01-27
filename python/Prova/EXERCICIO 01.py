import math

def bhaskara(n1, n2, n3):
  try:

    delta = (n2 ** 2 - 4 * n1 *n3)
    delta = math.sqrt(delta)
    x1 = (-n2 + delta) / (2 * n1)

    x2 = (-n2 - delta) / (2 * n1)
    
    print("Teremos duas raizes:")
    lista = [x1, x2]
    return lista
  except Exception:
   print ("não teremos raizes")

n1 = float(input("Digite seu valor a: "))
n2 = float(input("Digite seu valor b: "))
n3 = float(input("Digite seu valor c: "))

print (bhaskara(n1,n2,n3))