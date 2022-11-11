# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".

with open('incoming_text_1.txt','w') as file:
    file.write(input('Введите первоночальный текст: '))
with open('incoming_text_1.txt','r') as file:
    my_text = file.readline()
    print_incoding = my_text    


print()
print(print_incoding)
print()


result= my_text.replace("абв", "")
with open('format_text_1.txt','w') as file:
    file.write(f'{result}')
print(result)
print()



