from asyncore import read
from webbrowser import get

# Export

def export_data():
    with open('Data.txt', 'r',encoding='utf-8') as a,open ('Export.csv','a', encoding='utf-8') as b:
        b.write(a.read())
        b.write('\n')

# Export with commas

def export_with_commas():
    with open('Data.txt', 'r', encoding='utf-8') as d:
        lst = d.readlines()
    s = ''
    for i, elem in enumerate(lst):
        if elem != '\n':
            s += elem.strip()+', '
        else:
            with open('Export.csv', 'a', encoding='utf-8') as mf:
                mf.write(s + '\n')
            s = ''

# Import

def import_data():
    with open('Import.txt', 'r') as a, open ('Data.txt','a') as b:
        read = a.read()
        read_2 = read.replace(', ', '\n')
        b.writelines('\n')
        b.write(f'\n{read_2}')





