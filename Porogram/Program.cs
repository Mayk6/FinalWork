﻿// Написать программу, которая из имеющегося массива строк формирует массив из сторк, длинна которых меньше либо равна 3 символа. 

string[] arrayString = { "AAAA", "SSS", "DD", "FFFFF", "X" };
string[] finalArray = new string[arrayString.Length];
int count = 0;
for (int i = 0; i < arrayString.Length; i++)
{
    if (arrayString[i].Length <= 3)
    {
        finalArray[count] = arrayString[i];
        count++;
    }
}
