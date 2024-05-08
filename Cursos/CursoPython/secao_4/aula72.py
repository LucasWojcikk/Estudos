
# Exercício com funções

# Crie uma função que multiplica todos os argumentos não nomeados recebidos
# retorne o total para uma variável e mostre o valor da variável	

def multiplier(*args):
    total = 1
    for number in args:
        total *= number
    return total

numbers = 10, 15, 10
calculation = multiplier(*numbers)
print(calculation)

# Crie uma função fala que fala se um número é par ou  ímpar.
# retorne se o número é par ou ímpar

def even_or_odd():
    number_str = input('Digite um número: ')
    number = int(number_str)
    index = None
    if number % 2 == 0:
        return print(f'O número "{number}" é par')
    return print(f'O número "{number}" é impar')

even_or_odd()
  