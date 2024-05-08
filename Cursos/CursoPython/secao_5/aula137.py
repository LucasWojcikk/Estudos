# Exercício com classes
# 1 - Crie uma classe Carro (Nome)
# 2 - Crie uma classe Motor (Nome)
# 3 - Crie uma classe Fabricante (Nome)
# 4 - Faça a ligação entre Carro tem um Motor
# Obs.: Um motor pode ser de vários carros
# 5 - Faça a ligação entre Carro e um Fabricante
# Obs.: Um fabricante pode fabricar vários carros
# Exiba o nome do carro, motor e fabricante na tela


class Carro:
    def __init__(self, nome):
        self.nome = nome
        self._motor = None
        self._fabricante = None

    @property
    def motor(self):
        return self._motor

    @motor.setter
    def motor(self, valor):
        self._motor = valor

    @property
    def fabricante(self):
        return self._fabricante

    @fabricante.setter
    def fabricante(self, valor):
        self._fabricante = valor

class Motor:
    def __init__(self, nome):
        self.nome = nome
        
class Fabricante:
    def __init__(self, nome):
        self.nome = nome

# Fusca
fusca = Carro('Fusca')
volkswagen = Fabricante('Volkswagen')
motor_1_0 = Motor('1.0')
fusca.fabricante = volkswagen
fusca.motor = motor_1_0
print(fusca.nome, fusca.fabricante.nome, fusca.motor.nome)

# Palio
fiat_palio = Carro('Palio')
fiat = Fabricante('Fiat')
fiat_palio.fabricante = fiat
fiat_palio.motor = motor_1_0
print(fiat_palio.nome, fiat_palio.fabricante.nome, fiat_palio.motor.nome)

# Focus
focus = Carro('focus')
ford = Fabricante('Ford')
focus.fabricante = ford
motor_2_0_titanium = Motor('2.0 Titanium')
focus.motor = motor_2_0_titanium
print(focus.nome, focus.fabricante.nome, focus.motor.nome)