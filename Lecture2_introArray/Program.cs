int[] array = {16,12,33,42,73,66,73,28,91};

int n = array.Length;
int find = 73;

int index = 0;

while (index < n)
{

      if(array[index] == find)
      {
          Console.WriteLine(index);
          break;
      } 
    index++;      
}