#!/usr/bin/env python
# coding: utf-8

# In[1]:


import numpy as np
def func(x, a, b, c, d, e):
    function = a*(x**4)*np.sin(np.cos(x))+b*(x**3)+c*(x**2)+d*x+e
    return function


# In[2]:


koef = [-12, -18, 5, 10, -30]
x_limit = [-100, 100]
x = np.arange(x_limit[0], x_limit[1], 0.004)
root = 0
i = 1


# In[3]:


root_list = []
x_change = []
func_direct = -1
color = 'r'
line = 'k'


# In[4]:


def change_color():
    global color
    if color == 'r':
        color = 'b'
    else:
        color = 'r'
    return color


# In[5]:


def change_line():
    global line
    if line == '-.':
        line = '-'
    else:
        line = '-.'
    return line


# In[6]:


while i < np.size(x):
    if (func(x[i-1], *koef)*func(x[i], *koef) < 0):
        root = round(x[i-1], 2)
        root_list.append((root, round(func(x[i-1], *koef), 2)))

    i = i+1


# In[7]:


x = np.arange(x_limit[0], x_limit[1], 0.4)
for i in range(len(x)-1):
    if func_direct == -1:
        if func(x[i], *koef) < func(x[i+1], *koef):
            x_change.append((round(x[i], 2), round(func(x[i], *koef), 2)))
            func_direct = 1
    else:
        if func(x[i], *koef) > func(x[i+1], *koef):
            x_change.append((round(x[i], 2), round(func(x[i], *koef), 2)))
            func_direct = -1
x_cur = np.arange(x_limit[0], x_change[0][0], 0.1)            


# In[8]:


import matplotlib.pyplot as plt
plt.plot(x_cur, func(x_cur, *koef), change_color())
for i in range(len(x_change)-1):
    x_cur = np.arange(x_change[i][0], x_change[i+1][0], 0.1)
    plt.plot(x_cur, func(x_cur, *koef), change_color())
x_cur = np.arange(x_change[-1][0], x_limit[1], 0.1)
plt.plot(x_cur, func(x_cur, *koef), change_color())
for x_c in root_list:
    plt.plot(x_c[0], func(x_c[0], *koef), 'gx', label='Корни функции')
for x_c in x_change:
    plt.plot(x_c[0], func(x_c[0], *koef), 'rD', label='Вершины')
x_cur = np.arange(x_limit[0], root_list[0][0], 0.1)
plt.plot(x_cur, func(x_cur, *koef), change_line())
for i in range(len(root_list)-1):
    x_cur = np.arange(root_list[i][0], root_list[i+1][0], 0.1)
    plt.plot(x_cur, func(x_cur, *koef), change_line())
x_cur = np.arange(root_list[-1][0], x_limit[1], 0.1)
plt.plot(x_cur, func(x_cur, *koef), change_line())
plt.xlabel('Ось X')
plt.ylabel('Ось Y')
plt.grid()
plt.show()


# In[9]:


root_list


# In[ ]:




