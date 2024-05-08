# Listas em Python
# tipo list - mutável
# suporta vários valores de qualquer tipo
# conhecimentos reutilizáveis - índices e fatiamento
# métodos úteis: append, insert, pop, del, clear, extend, +

#      +01234
#      -54321    

string = 'ABCDE' # 5 caracteres 
#print(bool(lista))
#print(lista, type(lista))

#         0     1      2      3   4
#        -5    -4     -3     -2  -1
lista = [123, True, 'Lucas', 1.2, []] 
print(lista[2].upper(), type(lista[2]))

lista[1] = False
print(lista)
