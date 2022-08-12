string[] array1 = { "hello", "a", "word", ":-)" };

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

string[] newarray = new string[array1.Length];
int count = 0;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        newarray[count] = array1[i];
        count++;
    }
}

Print(newarray);
