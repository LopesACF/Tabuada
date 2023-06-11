Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;

Console.WriteLine("--- Tabuada ---");

Console.WriteLine("Digite o numero.");

int resultado;
int fator2 = 0;

int fator1 = Convert.ToInt32(Console.ReadLine()!.Trim());

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;

while (fator2 <= 10){
    resultado = fator1 * fator2;
    Console.WriteLine($"{fator1}x{fator2} = {resultado}");
    fator2 += 1;
}

Console.ResetColor();