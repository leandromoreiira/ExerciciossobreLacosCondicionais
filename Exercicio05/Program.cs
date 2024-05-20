
using System.Globalization;

Console.WriteLine("Escreva o código do item: ");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Qua a quantidade");
int quantidade = int.Parse(Console.ReadLine());

double valor;
if (codigo == 1) {
   valor = quantidade * 4.00;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else if (codigo == 2 ) {
    valor = quantidade * 4.50;
    Console.WriteLine("Total: R$ " + valor.ToString("F2",CultureInfo.InvariantCulture));
} else if( codigo == 3) {
    valor = quantidade * 5.00;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else if(codigo == 4) {
    valor = quantidade * 2.00;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else if (codigo == 5) {
    valor = quantidade * 1.50;
    Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
}
else {
    Console.WriteLine("O Código fornecido é invalido");
}

