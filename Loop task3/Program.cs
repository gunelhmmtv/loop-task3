int number = 304001;
int sum = 0;
int count = 0;  


while (number>0)
{

    int say = number % 10;
    if (say > 0)
    {
        sum += say;
    }
    else
    { 
        count++;
    }
    number /= 10;
}
Console.WriteLine($"Musbet reqemlerin cemi= {sum}");
Console.WriteLine($"Musbet ve menfi olmayan ededlerin sayi={count}");