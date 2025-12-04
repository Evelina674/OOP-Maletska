using System.Collections.Generic;

namespace lab4v7
{
    /// <summary>
    /// Абстрактний базовий клас для сенсорів.
    /// Містить спільну логіку зберігання та обробки вимірювань.
    /// </summary>
    public abstract class SensorBase : ISensor
    {
        // Список усіх вимірювань сенсора
        private readonly List<double> _readings = new List<double>();

        /// <summary>
        /// Назва сенсора.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Мінімальне допустиме значення (норма).
        /// </summary>
        protected abstract double NormalMin { get; }

        /// <summary>
        /// Максимальне допустиме значення (норма).
        /// </summary>
        protected abstract double NormalMax { get; }

        protected SensorBase(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Додати нове вимірювання.
        /// </summary>
        public void AddReading(double value)
        {
            _readings.Add(value);
        }

        /// <summary>
        /// Отримати всі збережені вимірювання (тільки для читання).
        /// </summary>
        public IReadOnlyList<double> GetReadings()
        {
            return _readings.AsReadOnly();
        }

        /// <summary>
        /// Обчислити середнє значення показників.
        /// </summary>
        public double GetAverage()
        {
            if (_readings.Count == 0)
                return 0;

            double sum = 0;
            foreach (var r in _readings)
                sum += r;

            return sum / _readings.Count;
        }

        /// <summary>
        /// Перевірити, чи останнє значення виходить за межі норми.
        /// </summary>
        public bool IsLastValueOutOfRange()
        {
            if (_readings.Count == 0)
                return false;

            // Беремо останній елемент БЕЗ ^1
            double last = _readings[_readings.Count - 1];
            return last < NormalMin || last > NormalMax;
        }
    }
}
