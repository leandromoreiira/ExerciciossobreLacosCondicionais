
Console.WriteLine("Qual hora o jogo começou? ");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Qual horario o jogo terminou? ");
int horariofinal = int.Parse(Console.ReadLine());

int duracao;

if (hora < horariofinal) {
    duracao = hora - horariofinal;
}else
{
    duracao = 24 - hora + horariofinal;
}

Console.WriteLine("O Jogo durou "+ duracao+" Horas");
