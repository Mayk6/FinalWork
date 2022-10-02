# Контрольная работа
## Задача :
### Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
## Описание алгоритма решения:
1) Обявляем два массива и счетчик, второй массив получает длинну из длинны первого.
2) Метод, в котором цикл соразмерный длинне первого массива, проверяет условие: длинна строки ( <=3 ), если да, то элемент первого массива заносится в count. элемент второго массива.
3) После присвоения переменная count увеличивается на 1 и возвращается к циклу for в котором i увеличивается на 1.
### (Переменная count нужна, для избегания пробелов, между значениями) 
### Диаграмма метода находиться в папке Diagram
### Реализация алгоритма по пути Porogram/Program.cs
