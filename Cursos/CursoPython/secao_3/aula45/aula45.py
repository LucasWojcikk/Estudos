# iterável -> str, range, etc
# iterador -> quem sabe entregar um valor por vez
# next -> me entregue o próximo ValueErroriter 0> me entregue seu iterador

#--------------------------------------------------------

# numeros = range(0, 100, 8)

# for numero in numeros:
#     print(numero) 

#--------------------------------------------------------

# texto = iter('Lucas') # __iter__()

# print(next(texto)) #__iter__()
# print(next(texto))
# print(next(texto))
# print(next(texto))
# print(next(texto))

#--------------------------------------------------------

# for letra in texto

# FOR POR BAIXO DOS PANOS (COMO FUNCIONA O FOR UTILIZANDO O WHILE)

# texto = 'Lucas' # iterável
# iterador = iter(texto) # iterator

# while True:
#     try:
#         letra = next(iterador)
#         print(letra)
#     except StopIteration:
#         break

# O COMANDO ACIMA UTILIZANDO O FOR FICAR:

texto = 'Lucas'

for letra in texto:
    print(letra)