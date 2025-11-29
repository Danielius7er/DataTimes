// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //var data = new DateTime(2025, 12, 25,  8, 30, 0);
        //var formatado = String.Format("{0:dd/MM/yyyy HH:mm:ss:ff:z}", data);
        DateTime? mata = DateTime.Now;
        var data = DateTime.Now;
        if (mata.HasValue)
        {
            mata = mata.Value.AddDays(10);
            Console.WriteLine(mata);
        }
        else
        {
            Console.WriteLine("Mata é nulo");
            mata = DateTime.Now;
        }

        if (data.Date == DateTime.Now.Date)
        {
            Console.WriteLine("As datas são iguais");
        }
        else
        {
            Console.WriteLine("As datas são diferentes");
        }
        //Console.WriteLine(data.AddDays(12));
        //Console.WriteLine(formatado);
        //Console.WriteLine((int)data.DayOfWeek);
        //var teste = String.Format("{0:R}", data);
        //Console.WriteLine(teste);
        TimeSpan();
    }
    static void TimeSpan()
    {
        Console.Clear();
        var timespan1 = new TimeSpan(1, 30, 45);
        Console.WriteLine(timespan1);
        var TimespanNanos = new TimeSpan(1);
        Console.WriteLine(TimespanNanos);
        var timespan2 = new TimeSpan(12, 1, 30, 45);
        var timespan3 = new TimeSpan(12, 1, 30, 45, 500);
        Console.WriteLine(timespan2);
        Console.WriteLine(timespan3);

        //Console.WriteLine("Total de dias: " + timespan3.TotalDays);
        //Console.WriteLine("Total de horas: " + timespan3.TotalHours);
        Console.WriteLine(timespan3.Add(timespan2));
        Console.WriteLine(timespan3.Duration());
        Console.WriteLine(timespan3.Add(new TimeSpan(2, 0, 0, 0))); 
        Console.WriteLine(timespan3.Days);
        Console.WriteLine(DateTime.DaysInMonth(2024, 2));
        Console.WriteLine(ValidarData(DateTime.Now.DayOfWeek));
    }
    static bool ValidarData(DayOfWeek dia)
    {
       return dia == DayOfWeek.Friday || dia == DayOfWeek.Saturday;
    }
}


