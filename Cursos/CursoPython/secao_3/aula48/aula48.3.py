# Listas em Python
# tipo list - mutável
# suporta vários valores de qualquer tipo
# conhecimentos reutilizáveis - índices e fatiamento
# métodos úteis: append, insert, pop, del, clear, extend, +
# create, read, update, delete
# criar, ler,   alterar, apagar = lista[i] (CRUD)


#append = adiciona item final da lista
# pop: remove item final da lista e retorna ele pra voce
# del: deleta um item da lista por indice
# clear: limpa a lista, apaga tudo
# insert: adiciona um item a partir do indice
# + : faz concatecação das listas em uma outra lista
# extende: estende a lista

lista_a = [1, 2, 3]
lista_b = [4, 5, 6]
lista_c = lista_a + lista_b
lista_d = lista_a.extend(lista_b)
print(lista_c)