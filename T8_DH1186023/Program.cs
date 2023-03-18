// See https://aka.ms/new-console-template for more information

String b = " ";
Console.WriteLine("Ingrese el numero que desea convertir en sistema binario");
int n = int.Parse(Console.ReadLine());

while (true)
{
    if ((n % 2) == 0)
    {
        b = ((n % 2) + b);
    }
    else if ((n % 2) == 1)
    {
        b = ((n % 2) + b);
    }
    n /= 2;

    if (n <= 0)
    {
        break;
    }
}

Console.WriteLine("El numero ingresado en sistema binario es " + b);
Console.ReadKey();
Console.Clear();

Console.WriteLine("Ingrese el numero que desea convertir en sistema hexadecimal");
int n2 = Convert.ToInt32(Console.ReadLine());

string h = " ";

while (true)
{
    if ((n2 % 16) != 0)
    {
        if ((n2 % 16) == 0)
        {
            switch (n2 % 16)
            {
                case 10:
                    h = "A" + h;
                    break;
                case 11:
                    h = "B" + h;
                    break;
                case 12:
                    h = "C" + h;
                    break;
                case 13:
                    h = "D" + h;
                    break;
                case 14:
                    h = "E" + h;
                    break;
                case 15:
                    h = "F" + h;
                    break;
            }
        }
        else
        {
            h = (n2 % 16) + h;
        }
    }
    else
    {
        h = "0" + h;
    }
    n /= 16;
    if (n <= 0)
    {
        break;
    }
}
Console.WriteLine("El numero en sistema hexadecimal es: " + h);
Console.ReadKey();
Console.Clear();