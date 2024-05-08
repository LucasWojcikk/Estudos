# enumerate - enumera iteraveis (indices)


# [(0, 'Maria'), (1, 'Helena'), (2, 'Luiz'), (3, 'João')]
lista = ['Maria', 'Helena', 'Luiz']
lista.append('João')

# lista_enumerada = enumerate(lista)
# assim ele cria um iterator por vez e deixa voce "bloqueado"
# lista_enumerada = list(enumerate(lista))



# for item in enumerate(lista):
#     indice, nome = item
#     print(indice, nome) 

for indice, nome in  enumerate(lista):
    print(indice, nome, lista[indice])