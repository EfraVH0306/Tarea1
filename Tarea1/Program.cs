using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                int tipoOperario = 0, tipoTecnico = 0, tipoProfesional = 0;
                double acumSalarioNetoOperarios = 0, acumSalarioNetoTecnicos = 0, acumSalarioNetoProfesionales = 0;
                int contadorOperarios = 0, contadorTecnicos = 0, contadorProfesionales = 0;

                while (true)
                {
                    Console.WriteLine("Ingrese los datos del empleado (o escriba 'salir' para terminar):");

                    Console.Write("Cédula: ");
                    string cedula = Console.ReadLine();

                    if (cedula.ToLower() == "salir")
                        break;

                    Console.Write("Nombre del Empleado: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Tipo de Empleado (1-Operario, 2-Técnico, 3-Profesional): ");
                    int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Precio por Hora: ");
                    double precioHora = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Cantidad de Horas Laboradas: ");
                    double horasLaboradas = Convert.ToDouble(Console.ReadLine());

                    double salarioOrdinario = precioHora * horasLaboradas;

                    double aumento = 0;
                    switch (tipoEmpleado)
                    {
                        case 1:
                            aumento = salarioOrdinario * 0.15;
                            tipoOperario++;
                            contadorOperarios++;
                            acumSalarioNetoOperarios += salarioOrdinario + aumento;
                            break;
                        case 2:
                            aumento = salarioOrdinario * 0.10;
                            tipoTecnico++;
                            contadorTecnicos++;
                            acumSalarioNetoTecnicos += salarioOrdinario + aumento;
                            break;
                        case 3:
                            aumento = salarioOrdinario * 0.05;
                            tipoProfesional++;
                            contadorProfesionales++;
                            acumSalarioNetoProfesionales += salarioOrdinario + aumento;
                            break;
                        default:
                            Console.WriteLine("Tipo de empleado no válido.");
                            continue;
                    }

                    double salarioBruto = salarioOrdinario + aumento;
                    double deduccionCCSS = salarioBruto * 0.0917;
                    double salarioNeto = salarioBruto - deduccionCCSS;

                    Console.WriteLine("\nDatos del Empleado:");
                    Console.WriteLine($"Cédula: {cedula}");
                    Console.WriteLine($"Nombre del Empleado: {nombre}");
                    Console.WriteLine($"Tipo de Empleado: {tipoEmpleado}");
                    Console.WriteLine($"Salario por Hora: {precioHora:C}");
                    Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
                    Console.WriteLine($"Salario Ordinario: {salarioOrdinario:C}");
                    Console.WriteLine($"Aumento: {aumento:C}");
                    Console.WriteLine($"Salario Bruto: {salarioBruto:C}");
                    Console.WriteLine($"Deducción CCSS: {deduccionCCSS:C}");
                    Console.WriteLine($"Salario Neto: {salarioNeto:C}\n");
                }

                Console.WriteLine("\nEstadísticas:");
                Console.WriteLine($"1) Cantidad Empleados Tipo Operarios: {contadorOperarios}");
                Console.WriteLine($"2) Acumulado Salario Neto para Operarios: {acumSalarioNetoOperarios:C}");
                Console.WriteLine($"3) Promedio Salario Neto para Operarios: {(contadorOperarios > 0 ? acumSalarioNetoOperarios / contadorOperarios : 0):C}");
                Console.WriteLine($"4) Cantidad Empleados Tipo Técnico: {contadorTecnicos}");
                Console.WriteLine($"5) Acumulado Salario Neto para Técnicos: {acumSalarioNetoTecnicos:C}");
                Console.WriteLine($"6) Promedio Salario Neto para Técnicos: {(contadorTecnicos > 0 ? acumSalarioNetoTecnicos / contadorTecnicos : 0):C}");
                Console.WriteLine($"7) Cantidad Empleados Tipo Profesional: {contadorProfesionales}");
                Console.WriteLine($"8) Acumulado Salario Neto para Profesional: {acumSalarioNetoProfesionales:C}");
                Console.WriteLine($"9) Promedio Salario Neto para Profesionales: {(contadorProfesionales > 0 ? acumSalarioNetoProfesionales / contadorProfesionales : 0):C}");
            
        }

    }
}