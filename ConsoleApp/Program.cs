using ConsoleApp;

Console.WriteLine("Hello, World!");

var calculator = new Calculator();

void DemoCalculatorOperations(Calculator calculator)
{
    int sum = calculator.Sum(5.5f, 2.3f);
    int sub = calculator.Subtract(5.5f, 2.3f);
    int mul = calculator.Multiply(5.5f, 2.3f);
    float? div = calculator.Divide(5.5f, 2.3f);

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Subtract: {sub}");
    Console.WriteLine($"Multiply: {mul}");
    Console.WriteLine($"Divide: {div}");
}

// Call the method
DemoCalculatorOperations(calculator);

Point3D CreatePoint3D(float[] tab)
{
    if (tab.Length < 3)
    {
        throw new ArgumentException("Array must contain at least three elements.");
    }
    return new Point3D(tab[0], tab[1], tab[2]);
}

// Test Product.ToJson()
var product = new Product
{
 Name = "Laptop",
 Price =1299.99M,
 Description = "High-end gaming laptop",
 Category = "Electronics",
 CategoryName = "Computers"
};
Console.WriteLine("Product JSON:");
Console.WriteLine(product.ToJson());


