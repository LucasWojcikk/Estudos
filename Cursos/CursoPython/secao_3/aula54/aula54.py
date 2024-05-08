# EXERCÍCIO
# Faça uma lista de compras com lista
# O usuário deve ter a possibilidade de
# inserir, apagar e listar valores da sua lista
# Não permita que o programa quebre com 
# erros de índices inexistentes na lista.

import os

lista = []

while True:

    choice = input('Selecione uma opção: \n[i]nserir [a]pagar [l]istar:'.lower())

    if choice == 'i':
        os.system('cls')
        lista.append(input('Valor: '))
  

    elif choice == 'a':  
        os.system('cls')
        indice_str = input('Escolha o índice para apagar: ')
        try:
            indice = int(indice_str)
            if indice < len(lista):
                del lista[indice]
            else:
                print('Não foi possível apagar esse índice.')
        except ValueError:
            print('Escolha um número inteiro.')  

    elif choice == 'l':
        os.system('cls')
        if len(lista) < 1:
            print('Nada para listar')
        else:
            for indice, nome in enumerate(lista):
                print(indice, nome)   
    else: 
        print('Por favor, escolha uma opção váli')
    