
using ConsoleApp;

Console.WriteLine("Hello, World!");


//funkcja wygenerowana na podstawie nagłówka funkcji
int Sum(float a, float b) //Tokenizacja: int, Sum, (, float, a, ,, float, b, )
    => (int)(a + b);


//funkcja wygenerowana na podstawie komentarza
//substract two float numbers and return an integer. Use block body syntax.
int Subtract(float a, float b)
{
    return (int)(a - b);
}


//multiply two numebrs
int Multiply(float a, float b)
{
    return (int)(a * b);
}

//pierwotnie wygenerowana funkcja Multiply została zmodyfikowana przez użytkownika
//co spwodowało, że model dostosował kolejny generowany kod (Divide) do zmian użytkownika
//kontenst "nauki" copilot jest ograniczony do bieżącej sesji - np. wyłączenie IDE powoduje utratę kontekstu

//divide two numbers
int Divide(float a, float b) 
{
    if (b == 0)
    {
        throw new DivideByZeroException("Denominator cannot be zero.");
    }
    return (int)(a / b);
}


Point3D CreatePoint3D(float[] tab)
{
    if (tab.Length < 3)
    {
        throw new ArgumentException("Array must contain at least three elements.");
    }
    return new Point3D(tab[0], tab[1], tab[2]);
}
