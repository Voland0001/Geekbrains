# Задайте список из n чисел последовательности 
# $(1+\frac 1 n)^n$ и выведите на экран их сумму.
# Пример:
# - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

def inputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f'{inputText}'))
            is_OK = True
        except ValueError:
            print('Введено нечисловое значение. Введите число.')
    return number

n = inputNumbers('Введите число n: ')
d={}
sum=0
for i in range(1, n+1):
    d[i]=round((1+1/i)**i, 2)
    sum+=d[i]
print(f'Для n = {n}: {d}')    
print(f'Сумма последовательности из {n} чисел равна: {sum}')