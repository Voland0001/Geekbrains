# Напишите программу, которая по заданному номеру четверти, 
# показывает диапазон возможных координат точек в этой четверти (x и y).


def inputNumber(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f'{inputText}'))
            is_OK = True
        except ValueError:
            print('Введено нечисловое значение. Введите число.')
    return number

def checkNumber(num):
    if num == 1:
        print('В первой четверти x > 0 y > 0')
    elif num == 2:
        print('Во второй четверти x < 0 y > 0')
    elif num == 3:
        print('В третьей четверти x < 0 y < 0')
    elif num == 4:
        print('В четвертой четверти x > 0 y < 0')
    else:
        print('Такой четверти нет.')

num = inputNumber('Введите № четверти в которой хотите узнать диапозон координат: ')    
checkNumber(num)