Задача 34
Console.Write("Массив заполненный случайными положительными трехзначными числами: ");
int[] chislo = new int[4];

void massiv (int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteMassiv(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int Chetnoe(int[] array){
    int N = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      N++;
    }
  }
  return N;
}

massiv(chislo, 100, 1000);
WriteMassiv(chislo);
Console.WriteLine();

int N = Chetnoe(chislo);
Console.Write("Количество чётных чисел в массиве: ");
Console.Write(N);
Console.ReadKey();

Задача 36
Console.Write("Введи количество элементов массива: ");
int  KolElementsMassiva= Convert.ToInt32(Console.ReadLine()); 

int RandomMassiv(int KolElementsMassiva, int min, int max)
  {
  int[] randomMassiv = new int[KolElementsMassiva];
  int SummChisel = 0;
  Console.Write("Массив чисел: ");

    for (int i = 0; i <randomMassiv.Length; i++ ){
      randomMassiv[i] = new Random().Next(min, max);

      Console.Write(randomMassiv[i] + " ");

      if (i % 2 != 1)
      {
SummChisel = SummChisel + randomMassiv[i];
      }
    }
  return SummChisel;
  }

int randomMassiv =  RandomMassiv(KolElementsMassiva, 1, 10);
Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.Write(randomMassiv);
Console.ReadKey();

Задача 38

            int[] chislo = new int[100];
 
            Random random = new Random();
           int n = 11;
           int i = 0;
            Console.WriteLine("Исходный массив");
            for ( i = 0; i < n; i++)
            {
               chislo[i] = random.Next(0, 50);
                Console.Write(chislo[i] + " ");
            }
 
            var min = chislo[0];
            var max = chislo[0];
 
            for (i = 0; i < n; i++)
            {
                if (chislo[i] < min)
                {
                    min = chislo[i];
                }
                else if (chislo[i] > max)
                {
                    max = chislo[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            int sum =0;
            sum = max - min;
            Console.WriteLine("Разница между максимальным и минимальным элементом: " + sum);
            Console.ReadKey();
