using EjericicioExcepciones;

string opcion = "";
Operaciones operaciones = new Operaciones();

try
{
    do
    {
        Console.WriteLine("Ingrese el tipo de operación a realizar");
        Console.WriteLine("1. Sumar \n2. Restar \n3. Dividir \n4. Multiplicar");
        string tipoOperacion = Console.ReadLine();
        Console.WriteLine("Ingrese el num1");
        string num1 = Console.ReadLine();
        Console.WriteLine("Ingrese el num2");
        string num2 = Console.ReadLine();
        controladorOperaciones(num1, num2, tipoOperacion, operaciones);

        Console.WriteLine("Desea continuar? (S/N)");
        opcion = Console.ReadLine();
    } while (opcion != "N");
}
catch(Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
}



void controladorOperaciones(string num1, string num2,string tipoOperacion,Operaciones operaciones)
{
    //Validaciones
    double n1, n2,resultado;

    if (!double.TryParse(num1, out n1))
        throw new Exception("El dato de entrada del número 1 debe ser númerico");

    if (!double.TryParse(num2, out n2))
        throw new Exception("El dato de entrada del número 2 debe ser númerico");

    switch (tipoOperacion)
    {
        case "1":
            resultado = operaciones.Sumar(n1, n2);
            break;
        case "2":
            resultado = operaciones.Restar(n1, n2);
            break;
        case "3":
            resultado = operaciones.Dividir(n1, n2);
            break;
        case "4":
            resultado = operaciones.Multiplicar(n1, n2);
            break;
        default:
            throw new Exception("Opción no válida para el tipo de operación. Por favor, seleccione una opción válida.");
           
    }
    Console.WriteLine($"El resultado es {resultado}");
}