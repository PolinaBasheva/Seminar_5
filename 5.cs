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
