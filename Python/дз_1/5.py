# Напишите программу, которая принимает на вход 
# координаты двух точек и находит расстояние между ними в 2D пространстве.
# Пример:
# - A (3,6); B (2,1) -> 5,09
# - A (7,-5); B (1,-1) -> 7,21

import math
import os

os.system('cls')

def inputNumbers(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = float(input(f'{inputText}'))
            is_OK = True
        except ValueError:
            print('Введено нечисловое значение. Введите число.')
    return number

x_coordinate_A = inputNumbers('Введите координату точки А по оси Х: ')
y_coordinate_A = inputNumbers('Введите координату точки А по оси Y: ')
x_coordinate_B = inputNumbers('Введите координату точки B по оси Х: ')
y_coordinate_B = inputNumbers('Введите координату точки B по оси Y: ')

distance = round(math.sqrt((x_coordinate_B - x_coordinate_A)**2 + (y_coordinate_B - y_coordinate_A)**2), 2)
print(distance)