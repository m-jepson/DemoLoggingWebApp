using Microsoft.Extensions.Options;
using System;

namespace LoggingWebApp
{
    public class Car : ICar
    {
        private readonly IOptions<CarOptions> _carOptions;
        private bool _running = false;
        public string ChassisNr { get; set; }

        public Car()
        {
            ChassisNr = Guid.NewGuid().ToString();
        }

        public Car(IOptions<CarOptions> carOptions) : this()
        {
            _carOptions = carOptions;
        }

        public string Start()
        {
            var result = _running ? $"Car {ChassisNr} already running." : $"Car {ChassisNr} started.";
            result = result +
                     $"{Environment.NewLine}Brand: {_carOptions.Value.Brand}{Environment.NewLine}Type: {_carOptions.Value.Type}";
            _running = true;
            return result;
        }

        public string Stop()
        {
            var result = _running ? $"Car {ChassisNr} stopped." : $"Car {ChassisNr} is not running.";
            result = result +
                     $"{Environment.NewLine}Brand: {_carOptions.Value.Brand}{Environment.NewLine}Type: {_carOptions.Value.Type}";
            _running = false;
            return result;
        }
    }
}
