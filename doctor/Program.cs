/* Aula 1 */

string nomePaciente = "Mariana Oliveira";
int idadePaciente = 27;
decimal valorConsulta = 220.50m;
bool consultaConfirmada = true;
string especialidade = "Cardiologia";

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
    valorFinal = valorConsulta - (valorConsulta * 0.20m);

    Console.WriteLine("Desconto de 20% aplicado!");
}
else
{
    Console.WriteLine("Nenhum desconto aplicado.");
}

Console.WriteLine($"Valor original: R$ {valorConsulta:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");