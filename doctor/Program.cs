/* Aula 1 */

string nomePaciente = "Mariana Oliveira";
int idadePaciente = 27;
decimal valorConsulta = 220.50m;
bool consultaConfirmada = false;
string especialidade = "Cardiologia";

Console.WriteLine("=== CLÍNICAFLOW ===");

Console.WriteLine($"Paciente: {nomePaciente}");
Console.WriteLine($"Idade: {idadePaciente} anos");
Console.WriteLine($"Especialidade: {especialidade}");
Console.WriteLine($"Valor da consulta: R$ {valorConsulta:F2}");
Console.WriteLine($"Consulta confirmada: {consultaConfirmada}");
