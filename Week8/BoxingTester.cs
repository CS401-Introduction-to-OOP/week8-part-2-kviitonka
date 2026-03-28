namespace Week8;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a; //Boxing. У стеку в нас зʼявляється ref на b, a в heap обʼєкт  зі значенням 10  
        int c = (int)b;// Unboxing. Достається з обʼєкту heap значення b (10) і воно зʼявляється у stack
        
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
}