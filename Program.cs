string array = "Hello, 2, world, :-)";
string[] simbol1 = array.Split(' ');
Console.WriteLine ($"Первый массив строк [{String.Join (" " , simbol1)}]");
string[] simbol2 = new string [4]{"1234", "1567", "-2", "computer science"};
Console.WriteLine ($"Второй массив строк [{String.Join (", " , simbol2)}]");
string[] simbol3 = new string [3]{"Russia", "Denmark", "Kazan"};
Console.WriteLine ($"Третий массив строк [{String.Join (", " , simbol3)}]");

string[ ]result1 = NewArray(simbol1);
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

