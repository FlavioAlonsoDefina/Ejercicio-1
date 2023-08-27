// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    float c=0.0f,f=0.0f;
    Console.Write("Ingrese la Temperatura en grados Fahrenheit: ");
    f = Convert.ToSingle(Console.ReadLine());
    c = (f - 32) * 5 / 9;
    Console.WriteLine("La temperatura equivalente de {0} grados Fahrenheit en Celsius es: {1}", f, c);
    Console.ReadKey();
}