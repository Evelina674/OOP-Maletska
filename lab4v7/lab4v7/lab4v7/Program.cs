using System;

namespace lab4v7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Створюємо сенсори
            var temperatureSensor = new TemperatureSensor("Температура в кімнаті");
            var pressureSensor = new PressureSensor("Атмосферний тиск");

            // Додаємо кілька вимірювань температури (одне вище норми)
            temperatureSensor.AddReading(19.5);
            temperatureSensor.AddReading(21.0);
            temperatureSensor.AddReading(27.3); // вище норми

            // Додаємо кілька вимірювань тиску (одне вище норми)
            pressureSensor.AddReading(748);
            pressureSensor.AddReading(755);
            pressureSensor.AddReading(770); // вище норми

            // Створюємо систему моніторингу та додаємо в неї сенсори
            var monitoringSystem = new MonitoringSystem();
            monitoringSystem.AddSensor(temperatureSensor);
            monitoringSystem.AddSensor(pressureSensor);

            // Виводимо звіт по всіх сенсорах
            monitoringSystem.PrintReport();

            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
