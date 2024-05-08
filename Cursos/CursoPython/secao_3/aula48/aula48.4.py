# Cuidado com dados mutáveis
# = - copiado o valor (imutáveis)
# = - aponta para o mesmo valor na memória (mutável)

lista_a = ['Lucas', 'Eloisa', 1, True, 1.2]
lista_b = lista_a.copy()

lista_a[0] = 'Chato'
print(lista_a)
print(lista_b)