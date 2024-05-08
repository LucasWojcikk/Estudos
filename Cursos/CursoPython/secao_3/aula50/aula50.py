# Exiba os índices da lista


# ---------------------------------------------------------------------------------------------------
# -----------------COMO EU FIZ

# lista = ['Maria', 'Helena', 'Luiz', 'lucas', 'pedro']
# i = 0
# for nome in lista:
#     print(i, nome)
#     i += 1


# ---------------------------------------------------------------------------------------------------
# -----------------COMO PROFESSOR FEZ


lista = ['Maria', 'Helena', 'Luiz', 'lucas', 'pedro']
indices = range(len(lista))
for indice in indices:
    print(indice, lista[indice])