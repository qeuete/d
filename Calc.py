import math 

while (True):
   try:
      print ('''Выберите номер операции
      1 - Сложение
      2 - Вычитание
      3 - Умножение
      4 - Деление
      5 - Деление с остатком
      6 - Деление нацело 
      7 - Возвездение в степень
      ''')
      d = int (input())
   

      if d == 1:
         print ('Введите число a=')
         a = int (input ())
         print ('Введите число b=')
         b = int (input ())

         print('Результат сложения', a+b)

      elif d == 2:
         print ('Введите число a=')
         a = int (input ())
         print ('Введите число b=')
         b = int (input ())
   
         print('Результат разности', a-b)

      elif d == 3:
         print ('Введите число a=')
         a = int (input ())
         print ('Введите число b=')
         b = int (input ())
         
         print('Результат умножения', a*b)
   
      elif d == 4:
         print ('Введите число a=')
         a = int (input ())
         
         print ('Введите число b=')
         b = int (input ())
         if b == 0:
            print ('Ошибка')
         else:
            print ('Результат деления', a/b) 

      elif d == 5:
         print ('Введите число a=')
         a = int (input ())
         
         print ('Введите число b=')
         b = int (input ())
         if b == 0:
            print ('Ошибка')
         else:
               print ('Результат деления с отстатком', a/b) 

      elif d == 6:
         print ('Введите число a=')
         a = int (input ())
         
         print ('Введите число b=')
         b = int (input ())
         if b == 0:
            print ('Ошибка')
         else:
            print ('Результат деления нацело', a//b) 

      elif d == 7:
         print ('Введите число a=')
         a = int (input ())
         print ('a!=', math.factorial(a)) 

      else:
         print ('Операция не найдена')
   except:
      print('Ошибка, попробуйте снова')
         
