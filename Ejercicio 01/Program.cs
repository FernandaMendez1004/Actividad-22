int filas, columnas;
bool correcto = false;
do {
    Console.WriteLine("Ingrese el numero de filas");
    correcto = int.TryParse(Console.ReadLine(), out filas);
    if (!correcto)
    {
        Console.WriteLine("ingrese un número entero");
    }
    else if (filas <= 0)
    {
        Console.WriteLine("El número de filas debe ser mayor que cero");
        correcto = false;
    }
} while (!correcto);
do {
    Console.WriteLine("Ingrese el numero de columnas");
    correcto = int.TryParse(Console.ReadLine(), out columnas);
    if (!correcto)
    {
        Console.WriteLine(" ingrese un número entero ");
    }
    else if (columnas <= 0)
    {
        Console.WriteLine("El número de columnas debe ser mayor que cero");
        correcto = false;
    }
} while (!correcto);
int[,] matriz = new int[filas, columnas];
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Valor: ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Matriz:");
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
