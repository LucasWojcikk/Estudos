# Listas em Python
# tipo list - mutável
# suporta vários valores de qualquer tipo
# conhecimentos reutilizáveis - índices e fatiamento
# métodos úteis: append, insert, pop, del, clear, extend, +
# create, read, update, delete
# criar, ler,   alterar, apagar = lista[i] (CRUD)


#         +01234
#         -54321    
#string = 'ABCDE' # 5 caracteres 


#           0     1      2      3   4
#          -5    -4     -3     -2  -1
# lista = [123, True, 'Lucas', 1.2, []] 
# print(lista[2].upper(), type(lista[2]))

lista = [10, 20, 30, 40]

#lista[2] = 300
#del lista[2]
# print(lista)
# print(lista[2])

lista.append(50)
lista.pop()
lista.append(60)
lista.append(70)
ultimo_valor = lista.pop(3)
print(lista,'Removido:',ultimo_valor)
