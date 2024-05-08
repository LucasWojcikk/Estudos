
# split e join com list e str
# split - divide uma String 
# join - une uma string 

frase = '    Olha só que          , coisa interessante           '

# sem argumentos quebra a frase pelos espaços
lista_frases_cruas = frase.split(', ')

lista_frases = []
for i, frase in enumerate(lista_frases_cruas):
    
    # .strip() tira os espaços do começo e fim da str, .rstrip() tira espaço da direita da str, .lstrip() tira espaço da esquerda da str
    lista_frases.append(lista_frases_cruas[i].strip())

# print(lista_frases_cruas)
# print(lista_frases)

# join junta iteraveis com separação 
frase_unidas = ', '.join(lista_frases)
print(frase_unidas)