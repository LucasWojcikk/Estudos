# Exercício - Salve sua classe em JSON
# Salve os dados da sua classe em JSON
# e depois crie novamente as instâncias
# da classe com os dados salvos
# Faça em arquivos separados.

import json

caminho_arquivo = 'aula127.json'

class Pessoa:
    def __init__(self, nome, idade):
        self.nome = nome 
        self.idade = idade

pessoa1 = Pessoa('Joao', 33)
pessoa2 = Pessoa('Helena', 21)
pessoa3 = Pessoa('Joana', 11)

db = [vars(pessoa1),vars(pessoa2), vars(pessoa3)]

with open(caminho_arquivo, 'w') as arquivo:
    json.dump(db, arquivo, ensure_ascii=False, indent=2)
