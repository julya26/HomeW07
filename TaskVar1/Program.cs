// Пример с треугольником Паскаля
 long[][] Pascle(long depth)
 {
   long[][] t = new long[depth][];
   for (int i = 0; i < depth; i++)
   {
    t[i] = new long[i + 1];
    t[i][0] = 1; t[i][t[i].Length - 1] = 1;
    }
    for (int i = 2; i < depth; i++)
    {
        for (int j = 1; j < t[i].Length - 1; j++)
        {
            t[i][j] = t[i - 1][j - 1] + t[i - 1][j];
        }
    } 
    return t;
 }

 var r = Pascle(5);
 foreach (var line in r)
 {
   foreach (var item in line)
   {
    Console.Write($"{item,3}");
   }
   Console.WriteLine(); 
 }
