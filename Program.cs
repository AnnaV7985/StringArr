string array = "Hello, 2, world, :-)";
string[] simbol1 = array.Split(' ');
Console.WriteLine ($"Первый массив строк [{String.Join (" " , simbol1)}]");
string[] simbol2 = new string [4]{"1234", "1567", "-2", "computer science"};
Console.WriteLine ($"Второй массив строк [{String.Join (", " , simbol2)}]");
string[] simbol3 = new string [3]{"Russia", "Denmark", "Kazan"};
Console.WriteLine ($"Третий массив строк [{String.Join (", " , simbol3)}]");

