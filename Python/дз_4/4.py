# Задана натуральная степень k. 
# Сформировать случайным образом список коэффициентов 
# (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
# Пример:
# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0

def inputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f'{inputText}'))
            is_OK = True
        except ValueError:
            print('Введено нечисловое значение. Введите число.')
    return number

def write_file(st):
    with open('file_dz_4.txt', 'w') as data:
        data.write(st)

import random

k = inputNumbers('Введите коэффициент: ')
a = int(random.randint(0,100))
b = int(random.randint(0,100))
c = int(random.randint(0,100))

if a != 0:
    first = (str(a) + "x^" + str(k) + " + ")
else:
    first = (str())

if b != 0:
    second = (str(b) + "x" + " + ")
else:
    second = (str())

if c != 0:
    third = (str(c) + " = 0")
else:
    third = (str())

print(f'{first}{second}{third}')
write_file(f'{first}{second}{third}')