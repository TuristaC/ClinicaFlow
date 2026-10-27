/* Aula 1 */

Console.Write("Digite o nome do paciente: ");
string? nomePaciente = Console.ReadLine();
if (string.IsNullOrWhiteSpace(nomePaciente))
{
    Console.WriteLine("Erro: o nome do paciente é obrigatório.");
    return;
}
Console.Write("Digite a idade do paciente: ");
string? idadeInformada = Console.ReadLine();

if (!int.TryParse(idadeInformada, out int idadePaciente) || idadePaciente < 0)
{
    Console.WriteLine("Erro: informe uma idade válida.");
    return;
}
decimal valorConsulta = 220.50m;
bool consultaConfirmada = true;
Console.Write("Digite a especialidade: ");
string? especialidade = Console.ReadLine();
if (string.IsNullOrWhiteSpace(especialidade))
{
    Console.WriteLine("Erro: a especialidade é obrigatória.");
    return;
}
Console.WriteLine("=== CLÍNICAFLOW ===");

Console.WriteLine($"Paciente: {nomePaciente}");
Console.WriteLine($"Idade: {idadePaciente} anos");
Console.WriteLine($"Especialidade: {especialidade}");
Console.WriteLine($"Valor da consulta: R$ {valorConsulta:F2}");
Console.WriteLine($"Consulta confirmada: {consultaConfirmada}");

Console.WriteLine();
Console.WriteLine("=== STATUS DO AGENDAMENTO ===");

if (consultaConfirmada)
{
    Console.WriteLine("Consulta confirmada com sucesso!");
}
else
{
    Console.WriteLine("Aguardando confirmação do paciente.");
}

bool possuiCupom = true;

Console.WriteLine();
Console.WriteLine("=== VALOR DA CONSULTA ===");

decimal valorFinal = valorConsulta;

if (consultaConfirmada && possuiCupom)
{
    valorFinal = valorConsulta - (valorConsulta * 0.10m);

    Console.WriteLine("Desconto de 10% aplicado!");
}
else
{
    Console.WriteLine("Nenhum desconto aplicado.");
}

Console.WriteLine($"Valor original: R$ {valorConsulta:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");