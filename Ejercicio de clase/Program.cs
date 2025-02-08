// See https://aka.ms/new-console-template for more information

// Solo declaración:

using Ejercicio_de_clase;
using Microsoft.VisualBasic;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using String = System.String;

float temperatura;
string nombre;
Miclase miclase; 

// Declaración con inicializadores (cuatro ejemplos):

char primeraLetra = 'C';
var limite = 3;
int[] origen = { 0, 1, 2, 3, 4, 5 };

var consulta = from elemento in origen
               where elemento < limite
               select elemento;

//Conversión implícita.Un 'long' puede
// almacenar cualquier valor que un 'int' puede almacenar ¡y más!

int num = 2147483647;
long bigNum = num;

double x = 1234.7;
int a;
//Convertir(cast) de double a int.
a = (int)x;
System.Console.WriteLine(a);

// Operadores aritmeticos !!!
int i =3;
Console.WriteLine(i);// output: 3
Console.WriteLine(i--);// output: 3
Console.WriteLine(i);// output: 4

double e = 1.5;
Console.WriteLine(a); // output: 1.5
Console.WriteLine(--a); // output: 2.5
Console.WriteLine(a); // output: 2.5

Console.WriteLine(+4);      // output: 4
Console.WriteLine(-4);      // output: -4
Console.WriteLine(-(-4));  // output: 4

uint o = 5;
var b = -a;
Console.WriteLine(b);       // output: -5
Console.WriteLine(b.GetType()); // output: System.Int64
Console.WriteLine(-double.NaN); // output: NaN 

Console.WriteLine(5 * 2);// output: 10
Console.WriteLine(0.5 * 2.5);// output: 1.25
Console.WriteLine(0.1m * 23.4m); // output: 2.34

//Operador de divicion
Console.WriteLine(13 / 5.0); // output: 2.6
int j = 13;
int z = 5;
Console.WriteLine((double)a / b); // output: 2.6

Console.WriteLine(5 % 4); // output: 1
Console.WriteLine(5 % -4); // output: 1
Console.WriteLine(-5 % 4); // output: -1
Console.WriteLine(-5 % -4); // output: -1
DisplayMeasurement(45); // Output: The measurement value is 45
DisplayMeasurement(-3); // Output: Warning: not acceptable valuel The med


void DisplayMeasurement(double value)
{
    if (value < 0 || value > 100)
    {
        Console.Write("Warning: not acceptable valuel!");
        }
    Console.WriteLine($"The measurement value is {value}");
}

DisplayWeatherReport(15.0); // Output: Cold.
DisplayWeatherReport(24.0); // Output: Perfect!
void DisplayWeatherReport(double tempInCelsius)
{
    if (tempInCelsius < 20.0)
    {
        Console.WriteLine("Cold.");
    }
    else
    {
        Console.WriteLine("Perfect!");





        void DisplayCharacter(char ch)
        {
            if (char.IsUpper(ch))
            {
                Console.WriteLine($"An uppercase letter: (ch)");
            }
            else if (char.IsLower(ch))
            {
                Console.WriteLine($"A lowercase letter: (ch)");
            }

            else if (char.IsDigit(ch))
            {

                Console.WriteLine($"A digit: {ch}");

            }
            else
            {

                Console.WriteLine($"Not alphanumeric character: (ch)");
            }

        }

   
DisplayMeasurement(4); // Output: Measured value 15 -4; too high..
DisplayMeasurement(5); // Output: Measured value 1s 5.
DisplayMeasurement(30); // Output: Measured value As 30; too high.
DisplayMeasurement(double.NaN); // Output: Falled measuresent.

vold DisplayMeasurement(double measurenent)
{

    switch (measurement)
    {


        case < 0.0:
            Console.WriteLine($"Measured value is (measurement); too low.");
            break;


        case > 15.0:
            Console.WriteLine($"Measured value is (seasurement); too high.");
            break;


        case double.NaN:
            Console.WriteLine("falled measurement.");
            break;


        default:
            Console.WriteLine($"Measured value is (measurement).");

            break;
    }
}







//Estructura de iteracion
for (int k = 0; i < 3; i++)
{

    Console.Write(i);
}

        // Output:
        //012


        List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
        foreach (int element in fibNumbers)
        {
            Console.Write($"(element) ");
        }
        //Output:
        //0 1 2 3 4 5 8 13


        // Instruccion dowhile
        int n = 0;
        do
        {
            Console.Write(n);
            n++;

        } while (n < 5);
        //Output:
        //0 1 2 3 4

        //instruccion While
        int c= 0;
        while (n < 5) ;
        {
            Console.Write(n);
            n++;

        }
        //Output:
        //0 1 2 3 4

        // Funciones 
         string GetName(int ID )
        {
            if (ID < names.Length)
               return names[ID];
       else 
          return String.Empty;
        }
string[] names = { "Spencer", "Sally", "Doug"};





        Console.WriteLine("Hello, World!");
    }

}