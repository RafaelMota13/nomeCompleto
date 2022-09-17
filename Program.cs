Console.Clear();

Console.Write("Digite seu nome: ");
string nome = Console.ReadLine()!;
Console.Clear();


Console.Write("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine()!;
Console.Clear();


string inicial = nome.Substring(0,1).ToUpper();
string restante = nome.Substring(1);
nome = $"{inicial}{restante}";

string inicial1 = sobrenome.Substring(0,1).ToUpper();
string restante1 = sobrenome.Substring(1);
sobrenome = $"{inicial1}{restante1}";


Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de Catálogo: {sobrenome.ToUpper()}, {nome}\n");
