# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. 
# Найдите произведение элементов на указанных позициях. 
# Позиции хранятся в файле file.txt в одной строке одно число.

from random import Random, randint

N = int(input('Введите число: '))

print()

numbers = []
for i in range(N):
    numbers.append(randint(-N,N+1))
print(f'Список из {N} элементов заполненных числами из диапазна [{-N};{N}]: {numbers}')

print()

f = open('file.txt', 'w')
while True:
    print('Укажите позицию для вычисления - ')
    s = input()
    if s == "":
        break
    elif int(s) > N:
        print('Указана неверная позиция ')
        continue
    elif int(s) < N:
        f.write(s+"\n")
f.close()

print()

result = 1
f = open('file.txt', 'r')
print('Содержание файла c указанием позиций: ')
for line in f:
    if line == "":
        break
    print(line, end="")
    result *= numbers[int(line)]
f.close()
print()
print(f'Произведение элементов на указанных позициях: {result}')
