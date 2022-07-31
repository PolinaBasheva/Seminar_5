Задача 41.
   
 Console.Write("Введите элементы: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
     
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
Console.ReadKey();

Задача 43.
double[,] n = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < n.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < n.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      n[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] n)
{
  crossPoint[0] = (n[1,1] - n[0,1]) / (n[0,0] - n[1,0]);
  crossPoint[1] = crossPoint[0] * n[0,0] + n[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (n[0,0] == n[1,0] && n[0,1] == n[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (n[0,0] == n[1,0] && n[0,1] != n[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(n);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(n);
            
