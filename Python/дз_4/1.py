# Вычислить число c заданной точностью d
# Пример:
# - при d = 0.001, π = 3.141.    10^(-1) ≤ d ≤10^(-10)

from math import pi

def inputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f'{inputText}'))
            is_OK = True
        except ValueError:
            print('Введено нечисловое значение. Введите число.')
    return number

d =  inputNumbers("Введите число для заданной точности числа Пи:\n")
print(f'число Пи с заданной точностью {d} равно {round(pi, d)}')