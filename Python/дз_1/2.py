# Напишите программу для проверки истинности утверждения 
# ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

def inputNumbers(x):
    xyz = ["X", "Y", "Z"]
    a = []
    for i in range(x):
        a.append(input(f"Введите значение {xyz[i]}: "))
    return a


def checkPredicate(x):
    left = not (x[0] or x[1] or x[2])
    right = not x[0] and not x[1] and not x[2]
    result = left == right
    return result


statement = inputNumbers(3)

if checkPredicate(statement) == True:
    print(f"Утверждение истинно")
else:
    print(f"Утверждение ложно")

#¬(0 ⋁ 0 ⋁ 0) = ¬0 ⋀ ¬0 ⋀ ¬0 is True
#¬(0 ⋁ 0 ⋁ 1) = ¬0 ⋀ ¬0 ⋀ ¬1 is True
#¬(0 ⋁ 1 ⋁ 0) = ¬0 ⋀ ¬1 ⋀ ¬0 is True
#¬(0 ⋁ 1 ⋁ 1) = ¬0 ⋀ ¬1 ⋀ ¬1 is True
#¬(1 ⋁ 0 ⋁ 0) = ¬1 ⋀ ¬0 ⋀ ¬0 is True
#¬(1 ⋁ 0 ⋁ 1) = ¬1 ⋀ ¬0 ⋀ ¬1 is True
#¬(1 ⋁ 1 ⋁ 0) = ¬1 ⋀ ¬1 ⋀ ¬0 is True
#¬(1 ⋁ 1 ⋁ 1) = ¬1 ⋀ ¬1 ⋀ ¬1 is True
# Итог: Все истинно!