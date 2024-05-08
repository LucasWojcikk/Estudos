# Calculadora com while

while True:
    numero_1 = input('Digite um número: ')
    numero_2 = input('Digite outro número: ')
    operador = input('Digite o operador (+ - / *): ')

    numeros_validos = None
    numero_1_float = 0
    numero_2_float = 0

    try: 
        numero_1_float = float(numero_1)
        numero_2_float = float(numero_2)
        numeros_validos = True
    except:
        numeros_validos = None

    if numeros_validos is None:
        print('Um ou ambos os números são inválidos.')
        continue 

    operadores_permitidos = '+-/*'
    
    if operador not in operadores_permitidos:
        print('Operador inválido.')
        continue
    
    if len(operador) > 1:
        print('Digite apenas um operador.')
        continue
    
    if len(operador) < 1:
        print('Digite um operador.')
        continue

    adicao = operadores_permitidos[0]
    subtracao = operadores_permitidos[1]
    divisao = operadores_permitidos[2]
    multiplicacao = operadores_permitidos[3]

    if operador == adicao:
        print(f'A adição entre {numero_1_float} e {numero_2_float} é: {numero_1_float + numero_2_float}.')
    elif operador == subtracao:
        print(f'A subtração entre {numero_1_float} e {numero_2_float} é: {numero_1_float - numero_2_float}.')
    elif operador == divisao:
        print(f'A divisão entre {numero_1_float} e {numero_2_float} é: {numero_1_float / numero_2_float}.')
    elif operador == multiplicacao:
        print(f'A multiplicação entre {numero_1_float} e {numero_2_float} é: {numero_1_float * numero_2_float}.')

    #########
    sair = input('Quer sair? [s]im: ').lower().startswith('s')

    if sair is True:
        break