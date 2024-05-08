
# Calculo do primeiro dígito do CPF
# CPF: 746.824.890-70
# Colete a soma dos 9 primeiros dígitos do CPF
# multiplicando cada um dos valores por uma
# contagem regressiva começando de 10

# Ex.:  746.824.890-70 (746824890)
#    10  9  8  7  6  5  4  3  2
# *  7   4  6  8  2  4  8  9  0
#    70  36 48 56 12 20 32 27 0

# Somar todos os resultados: 
# 70+36+48+56+12+20+32+27+0 = 301
# Multiplicar o resultado anterior por 10
# 301 * 10 = 3010
# Obter o resto da divisão da conta anterior por 11
# 3010 % 11 = 7
# Se o resultado anterior for maior que 9:
#     resultado é 0
# contrário disso:
#     resultado é o valor da conta

# O primeiro dígito do CPF é 7


# Calculo do segundo dígito do CPF
# CPF: 746.824.890-70
# Colete a soma dos 9 primeiros dígitos do CPF,
# MAIS O PRIMEIRO DIGITO,
# multiplicando cada um dos valores por uma
# contagem regressiva começando de 11

# Ex.:  746.824.890-70 (7468248907)
#    11 10  9  8  7  6  5  4  3  2
# *  7   4  6  8  2  4  8  9  0  7 <-- PRIMEIRO DIGITO
#    77 40 54 64 14 24 40 36  0 14

# Somar todos os resultados:
# 77+40+54+64+14+24+40+36+0+14 = 363
# Multiplicar o resultado anterior por 10
# 363 * 10 = 3630
# Obter o resto da divisão da conta anterior por 11
# 3630 % 11 = 0
# Se o resultado anterior for maior que 9:
#     resultado é 0
# contrário disso:
#     resultado é o valor da conta

# O segundo dígito do CPF é 0

# ------------------------------------------------------------------------------------------#

# MEU 1º JEITO

# O CPF teste
# cpf_string = input('Digite seu CPF: ') 


# Remover os pontos e o traço
# cpf = cpf_string.replace('.', '').replace('-', '')

# Transformar os números em uma lista
# cpf_list = [int(digit) for digit in cpf]

# Fazer a multiplicação decrescente e somar
# i = 0
# soma = 0
# multiplicador = 10
# while i < 9:
    # soma += cpf_list[i] * multiplicador
    # multiplicador -= 1
    # i += 1

# Multiplicar por 10 a soma
# mult_10 = soma * 10

# Primeiro digito
# resto = mult_10 % 11
# if resto > 9:
    # primeiro_digito = 0
# else: 
    # primeiro_digito = resto

# print(f'O primeiro dígito do CPF é: {primeiro_digito}')

# ------------------------------------------------------------------------------------------#

#REFAZENDO - MEU JEITO

import os

# Criando variável e formatando ela para os cálculos
cpf_cru = input('Digite o CPF: ')
cpf_str = cpf_cru.replace('.', '').replace('-', '')


nove_digitos = cpf_str[:9]
multiplicador_1 = 10

# Fazendo calculo com multiplicador decrescente
calculo_1 = 0
for digito in nove_digitos:
    calculo_1 += int(digito) * multiplicador_1
    multiplicador_1 -= 1

# Multiplicar por 10 a soma
mult_10 = calculo_1 * 10

# Primeiro digito
resto = mult_10 % 11
if resto > 9:
    primeiro_digito = 0
else: 
    primeiro_digito = resto

os.system('cls')
# print('-='*50)
# print(f'O primeiro dígito do CPF: {cpf_cru} é: {primeiro_digito}')
# print('-='*50)

dez_digitos = cpf_str[:10]

# Fazendo calculo com multiplicador decrescente
multiplicador_2 = 11
calculo_2 = 0
for digito_1 in dez_digitos:
    calculo_2 += int(digito_1) * multiplicador_2
    multiplicador_2 -= 1

# Multiplicar por 10 a soma
mult_10_2 = calculo_2 * 10

# Primeiro digito
resto_2 = mult_10_2 % 11
if resto_2 > 9:
    segundo_digito = 0
else: 
    segundo_digito = resto_2

# print(f'O primeiro dígito do CPF: {cpf_cru} é: {segundo_digito}')
# print('-='*50)

if segundo_digito == int(cpf_str[-1]) and primeiro_digito == int(cpf_str[-2]):
    print(f'O CPF: {cpf_cru} é válido.')
else:
    print(f'O CPF: {cpf_cru} é inválido.')


# ------------------------------------------------------------------------------------------#

# JEITO PROFESSOR (ESTUDAR)

# # cpf = '36440847007'  # Esse CPF gera o primeiro dígito como 10 (0)
# cpf_enviado_usuario = '74682489070'
# nove_digitos = cpf_enviado_usuario[:9]
# contador_regressivo_1 = 10

# resultado_digito_1 = 0
# for digito in nove_digitos:
#     resultado_digito_1 += int(digito) * contador_regressivo_1
#     contador_regressivo_1 -= 1
# digito_1 = (resultado_digito_1 * 10) % 11
# digito_1 = digito_1 if digito_1 <= 9 else 0

# dez_digitos = nove_digitos + str(digito_1)
# contador_regressivo_2 = 11

# resultado_digito_2 = 0
# for digito in dez_digitos:
#     resultado_digito_2 += int(digito) * contador_regressivo_2
#     contador_regressivo_2 -= 1
# digito_2 = (resultado_digito_2 * 10) % 11
# digito_2 = digito_2 if digito_2 <= 9 else 0

# cpf_gerado_pelo_calculo = f'{nove_digitos}{digito_1}{digito_2}'

# if cpf_enviado_usuario == cpf_gerado_pelo_calculo:
#     print(f'{cpf_enviado_usuario} é válido')
# else:
#     print('CPF inválido')



















   
