int[] Array(int size)
    {
      int [] array = new int [size];
      for(int i = 0 ;i < size;i++)
      {
          Console.Write("введите число: ");
          array[i] = Convert.ToInt32(Console.ReadLine());
      }
      return array;
    }
void ShowArray(int [] array)
{
  for(int i = 0;i < array.Length;i++)
  {
Console.Write(array[i] + " ");
  }
  Console.Write(" -> ");
}
void CountArray(int []array)
{
  int k = 0;
  for(int i = 0;i<array.Length;i++)
  {
    if(array[i] > 0)
    {
     k++;
    }
    
  }
  Console.WriteLine(k);
}
Console.WriteLine("введите кол-во чисел в массиве");
int size = Convert.ToInt32(Console.ReadLine()); 
int [] cArray = Array(size);
ShowArray(cArray);
CountArray(cArray);

