# Массив строк С# 

*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массив*

## 1. Пишем код для введения на консоль трех массивов с строчным значением:
```csharp
string array = "Hello, 2, world, :-)";
string[] simbol1 = array.Split(' ');
Console.WriteLine ($"Первый массив строк [{String.Join (" " , simbol1)}]");
string[] simbol2 = new string [4]{"1234", "1567", "-2", "computer science"};
Console.WriteLine ($"Второй массив строк [{String.Join (", " , simbol2)}]");
string[] simbol3 = new string [3]{"Russia", "Denmark", "Kazan"};
Console.WriteLine ($"Третий массив строк [{String.Join (", " , simbol3)}]");
```
## 2. Создаем функцию _NewArray_ (метод), которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам
``` csharp string[ ]result1 = NewArray(simbol1);
string[ ]result2 = NewArray(simbol2);
string[ ]result3 = NewArray(simbol3);
string [] NewArray (string[] array)
{
string[] arrSimb = new string [array.Length] ;
int index = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <= 3)
{
arrSimb[index] = array[i];
index++;
}

}
return arrSimb;
}
```
## 3. Выводим результат в терминал.
```Console.WriteLine ($"Первый результат [{String.Join (" " , result1)}]");
Console.WriteLine ($"Второй результат [{String.Join (" " , result2)}]");
Console.WriteLine ($"Третий результат [{String.Join (" " , result3)}]");```
