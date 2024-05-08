# Listas em Python
# tipo list - mutável
# suporta vários valores de qualquer tipo
# conhecimentos reutilizáveis - índices e fatiamento
# métodos úteis: append, insert, pop, del, clear, extend, +
# create, read, update, delete
# criar, ler,   alterar, apagar = lista[i] (CRUD)


#append = adiciona item final da lista
# pop = remove item final da lista e retorna ele pra voce
# del = deleta um item da lista por indice
# clear limpa a lista, apaga tudo
# insert adiciona um item a partir do indice

#        0   1   2   3
lista = [10, 20, 30, 40]
lista.append('Lucas')
nome = lista.pop()
lista.append(1233)
del lista[-1]
# lista.clear()
lista.insert(100, 5)
print(lista[4])

# se colocar um indice maior do que o range da lista, ele joga para ultima posição, NÃO USAR
