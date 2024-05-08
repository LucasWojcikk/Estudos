nome = 'Lucas'
altura = 1.72
peso = 81
imc = peso / altura ** 2

"f-strings"
linha_1 = f'{nome} tem {altura:.2f} de altura,'
linha_2 = f'pesa {peso} quilos e seu imc é'
linha_3 = f'{imc:.2f}'
a1 = 13
a2 = 'lucas'

print(linha_1)
print(linha_2)
print(linha_3)

print(f'{a2} marcou 5 gols aos {a1} anos')

# Luiz Otávio tem 1.80 de altura,
# pesa 95 quilos e seu IMC é
# 29.320987654320987
