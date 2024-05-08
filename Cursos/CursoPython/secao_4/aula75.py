# Exercícios
# Crie funções que duplicam, triplicam e quadruplicam
# o número recebido como parâmetro

# -----------------------------------------------------------------------------#
# MEU JEITO

def calculation(*args):
    def calculation_formula():
        number_asked_str = input('Digite um número: ')
        number_asked = float(number_asked_str)
        multiplier = [2,3,4]
        product = []
        for number in multiplier:
            product.append(number_asked * number)
        return product
    return calculation_formula()

final = calculation()

print(*final)
      


# -----------------------------------------------------------------------------#
# JEITO AULA (PROFESSOR)

# def criar_multiplicador(multiplicador):
#     def multiplicar(numero):
#         return numero * multiplicador
#     return multiplicar


# duplicar = criar_multiplicador(2)
# triplicar = criar_multiplicador(3)
# quadruplicar = criar_multiplicador(4)

# print(duplicar(2))
# print(triplicar(2))
# print(quadruplicar(2))