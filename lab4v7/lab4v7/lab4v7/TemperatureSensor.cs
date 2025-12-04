namespace lab4v7
{
    /// <summary>
    /// Сенсор температури.
    /// Нормою вважаємо, наприклад, від 18 до 26 °C.
    /// </summary>
    public class TemperatureSensor : SensorBase
    {
        protected override double NormalMin => 18.0;
        protected override double NormalMax => 26.0;

        public TemperatureSensor(string name) : base(name)
        {
        }
    }
}
