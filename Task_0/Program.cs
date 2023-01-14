// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

Console.WriteLine("Введите количество элементов");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите строки");
string [] arrayStrings = new string [size];
string [] arrayFinal = new string [size];
int len = 3;
int pos = 0;

void ArrayStrings ()
{
    for (int i = 0; i < size; i++)
{
    string element = Console.ReadLine(); 
     arrayStrings [i] = element;
}
Console.Write($"[{string.Join(", " , arrayStrings)}] "); 
for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= len) 
{
        arrayFinal[pos] = arrayStrings[j]; 
        pos++; 
}
}
arrayFinal = arrayFinal.Where(x => x != null).ToArray();

Console.Write($"[{string.Join(", " , arrayFinal)}] ");
} 
ArrayStrings();
 

