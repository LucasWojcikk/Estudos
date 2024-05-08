import re
import sys


# cpf = '36440847007'  # Esse CPF gera o primeiro dígito como 10 (0)

                      # jeito para tirar tudo que não for número.  
entrada_cpf = input('Digite um CPF: ')
cpf_enviado_usuario = re.sub(r'[^0-9]', '', entrada_cpf)

entrada_e_sequencial = entrada_cpf == entrada_cpf[0] * len(entrada_cpf)
if entrada_e_sequencial:
    print('Você enviou dados sequênciais.')
    
    # serve para sair do arquivo sem executar o resto (para quebrar código)
    sys.exit()

nove_digitos = cpf_enviado_usuario[:9]
contador_regressivo_1 = 10

resultado_digito_1 = 0
for digito in nove_digitos:
    resultado_digito_1 += int(digito) * contador_regressivo_1
    contador_regressivo_1 -= 1
digito_1 = (resultado_digito_1 * 10) % 11
digito_1 = digito_1 if digito_1 <= 9 else 0

dez_digitos = nove_digitos + str(digito_1)
contador_regressivo_2 = 11

resultado_digito_2 = 0
for digito in dez_digitos:
    resultado_digito_2 += int(digito) * contador_regressivo_2
    contador_regressivo_2 -= 1
digito_2 = (resultado_digito_2 * 10) % 11
digito_2 = digito_2 if digito_2 <= 9 else 0

cpf_gerado_pelo_calculo = f'{nove_digitos}{digito_1}{digito_2}'

if cpf_enviado_usuario == cpf_gerado_pelo_calculo:
    print(f'{entrada_cpf} é válido')
else:
    print('CPF inválido')
