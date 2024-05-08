# Métodos úteis dos dicionários em Python
# len - quantas chaves
# keys - iterável com as chaves
# values - iterável com os valores
# items - iterável com chaves e valores
# setdefault - adiciona valor se a chave não existe
# copy - retorna uma cópia rasa (shallow copy)
# get - obtém uma chave
# pop - Apaga um item com a chave especificada (del)
# popitem - Apaga o último item adicionado
# update - Atualiza um dicionário com outro
pessoa = {
    'nome': 'Luiz Otávio',
    'sobrenome': 'Miranda',
    'idade': 900,
}

# # para setar um item e seu valor no dicionario
# pessoa.setdefault('idade', 0)
# print(pessoa['idade'])
# # print(len(pessoa))


# valores (nome "variaveis")
# print(list(pessoa.keys()))

# valor da "variavel" e esta convertendo pra lista
# print(list(pessoa.values())[1])

# mostre a chave e o valor junto
# print(list(pessoa.items()))

# for valor in pessoa.values():
#     print(valor)

for chave, valor in pessoa.items():
    print(valor)