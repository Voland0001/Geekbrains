# Напишите программу, которая будет преобразовывать 
# десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10

def InputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f"{inputText}"))
            is_OK = True
        except ValueError:
            print("Введено не целое число, повторите попытку.")
    return number

s = ""
n = InputNumbers("Введите десятичное число для преобразовывания в двоичное: ")
while n != 0:
    s = str(n%2) + s
    n //=2
print(f'Преобразованное число равно {s}')