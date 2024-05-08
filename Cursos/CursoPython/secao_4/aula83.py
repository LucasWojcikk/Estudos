# empacotamento e desempacotamento de dicionários

a, b = 1, 2
a, b = b, a
# print(a, b)


# (a1, a2), (b1, b2) = pessoa.items()
# print(a1, a2)
# print(b1, b2)

# # isso acima é o msm que isso aqui

# for chave, valor in pessoa.items():
#     print(chave, valor)

pessoa = {
    'nome': 'Aline',
    'sobrenome': 'Souza',
}


dados_pessoa = {
    'idade': 16,
    'altura': 1.6,

}


#serve para somar dicionarios
pessoa_completa = {**pessoa, **dados_pessoa}
# print(pessoa_completa)

# args e kwargs 
# args (já vimos)
# kwargs - keyword arguments (argumentos nomeados)

def mostro_argumentos_nomeados(*args, **kwargs):
    print('NÃO NOMEADOS: ', args)
    for chave, valor in kwargs.items():
        print(chave, valor)


# mostro_argumentos_nomeados(1, 2, nome = 'Lucas', qlq = 123)
# mostro_argumentos_nomeados(**pessoa_completa)


configuracoes = {
    'arg1': 1,
    'arg2': 2,
    'arg3': 3,
    'arg4': 4,
}

mostro_argumentos_nomeados(**configuracoes)