# Métodos úteis:
# add, update, clear, discard
s1 = set()
s1.add('Luiz')
s1.add(1)   # adiciona item um por um
s1.update(('Olá mundo', 1, 2, 3, 4)) # adiciona varios itens de uma vez (tem que passar por iterável)
# s1.clear()
s1.discard('Olá mundo') #apagada utilizando o valor como parametro
s1.discard('Luiz')
print(s1)

# Operadores úteis:
# união | união (union) - Une