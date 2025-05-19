double SalarioHoraBase, SalarioTotal;
int HorasTrabalhadas, HorasExtrasFeitas;

Console.WriteLine("-----Sálario Mensal-----");
Console.WriteLine();
Console.WriteLine("Informe o seu salário-hora base em reais: ");
SalarioHoraBase = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
HorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o número de horas-extras feitas: ");
HorasExtrasFeitas = Convert.ToInt32(Console.ReadLine());

SalarioTotal = SalarioHoraBase * HorasTrabalhadas + (SalarioHoraBase * HorasExtrasFeitas * 1.4);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"O seu salário mensal é de: R${SalarioTotal:C2} ");
