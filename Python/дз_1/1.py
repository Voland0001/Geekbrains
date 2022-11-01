# Напишите программу, которая принимает на вход цифру, 
# обозначающую день недели, и проверяет, является ли этот день выходным.
# Пример:
# - 6 -> да
# - 7 -> да
# - 1 -> нет

def inputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f'{inputText}'))
            is_OK = True
        except ValueError:
            print('Введено нечисловое значение. Введите число.')
    return number

# def checkNumber(num):
#     if num == 6 or num == 7:
#         print('Выходной день')
#     elif num > 0 and num < 8:
#         print('Будний день')  
#     else:
#         print('День недели введён некорректно') 

num = inputNumbers('Введите число: ')   
print(num) 
# checkNumber(num)