double saldo, debito, credito, SaldoAtual;
string conta;
Console.WriteLine("Insira o número da conta do cliente:");
conta = Console.ReadLine();
Console.WriteLine("Insira o saldo do cliente:");
saldo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o dépito do cliente:");
debito = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o crédito do cliente:");
credito = Convert.ToDouble(Console.ReadLine());
SaldoAtual = saldo - debito + credito;
Console.WriteLine("\n\tO saldo atual é R${0}",
SaldoAtual);
if (SaldoAtual > 0)
{ Console.WriteLine("Saldo Positivo"); }
else
{ Console.WriteLine("Saldo Negativo"); }
