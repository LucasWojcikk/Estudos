
# Argumentos nomeados e não nomeados em funções Python
# Argumento nomeado tem nome com sinal de igual
# Argumento não nomeado recebe apenas o argumento (valor)

# Definição

# Definição: x e y são PARÂMETROS = nome variável
def soma(x, y, z):
    print(f'{x=} {y=} {z=}' , '|', 'x + y + z = ', x + y + z)


# 1 e 2 são argumentos que os parâmetros recebem = valores da "variável" (argumento posicional)
soma(1, 2, 3)
# soma(2, 1)  # ORDEM FAZ DIFERENÇA

# argumento nomeado
soma(y = 2, x = 1, z = 3)  # ORDEM FAZ DIFERENÇA

# sempre passar argumento nomeados



