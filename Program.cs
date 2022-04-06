// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, C#!");

int x = 0;
x = 2 + 3;
Console.WriteLine(x);

for (int i = 0; i <= x * 10; i++)
{
    if ( i%2 == 0)
    {
        Console.WriteLine(i+"は偶数");
    }else{
        Console.WriteLine(i+"は奇数");
    }
}