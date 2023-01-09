using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thrid.Models
{
    public class Calculadora
    {  
       public void Somar(int x, int y){
        Console.WriteLine($"{x} + {y} = {x+y}");
       } 

       public void Subtrair(int x, int y){
        Console.WriteLine($"{x} - {y} = {x-y}");
       }

       public void Multiplicar(int x, int y){
        Console.WriteLine($"{x} * {y} = {x*y} ");
       }

       public void Dividir(int x, int y){
        Console.WriteLine($"{x} / {y} = {x/y}");
       }

       public void Potencia(int x, int y){
        double r = Math.Pow(x, y);
        Console.WriteLine($"{x}**{y} = {r}");
       }

        // Os processos trigonométricos funcionam apenas em radianos
       public void Seno(double angulo){
        double radiano = angulo * Math.PI/180;
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo}º = {seno}");
       }
    }
}