using Aula_08___ATV___Insertion_Sort;

int[] ints = [0, 12, 7, 1, 2, 8];

Aula_08___ATV___Insertion_Sort.InsertionSort.Print(ints, 100);
Console.WriteLine("Sorted with Insertion: ");

Aula_08___ATV___Insertion_Sort.InsertionSort.Sort<int>(ints);
Aula_08___ATV___Insertion_Sort.InsertionSort.Print(ints, 100);

Console.WriteLine("Char Test");
char[] chars = ['x', 'z', 'b', 'c', 'a'];

Aula_08___ATV___Insertion_Sort.InsertionSort.Print(chars, 100);

Aula_08___ATV___Insertion_Sort.InsertionSort.Sort(chars);
Aula_08___ATV___Insertion_Sort.InsertionSort.Print(chars, 100);