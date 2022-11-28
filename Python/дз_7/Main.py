from Writing_file import writing_scv
from Writing_file import writing_txt
from os.path import exists
from Creating_CSV import creating

path = 'Телефонная книга.csv'
valid = exists(path)
if not valid:
    creating()

writing_scv()
writing_txt()