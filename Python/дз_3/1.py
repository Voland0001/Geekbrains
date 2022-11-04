# Задайте список из нескольких чисел. 
# Напишите программу, которая найдёт сумму элементов списка, 
# стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12


from random import Random, randint

def InputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f"{inputText}"))
            is_OK = True
        except ValueError:
            print("Введено не целое число, повторите попытку.")
    return number

def OddPosition(numbers, quantity):
    sumOdd=0
    for i in range(1, len(numbers), 2):          
        if i < quantity:
            sumOdd += numbers[i]
            continue
        else:
            break  
    print(f'Cумма элементов списка, стоящих на нечётной позиции равна {sumOdd}') 

def NewList(numbers, N1, N2, quantity):
    for i in range(quantity):
        numbers.append(randint(N1,N2))
    print(f'Список в диапазоне от {N1} до {N2}: {numbers}')

N1 = InputNumbers('Введите начало диапазона списка: ')
N2 = InputNumbers('Введите конец диапазона списка: ')
quantity = InputNumbers('Введите количество цифр списка: ')
numbers = []
print() 
NewList(numbers, N1, N2, quantity)
OddPosition(numbers, quantity)