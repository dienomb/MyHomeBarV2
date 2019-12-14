using MyHomeBarV2.Domain.Login;
using System;

namespace Microsoft.Extensions.Logging
{
    internal static class LoggerExtensions
    {
        private static Action<ILogger, string, Exception> _drinkAdded;

        private static Action<ILogger, int, string, Exception> _drinkAddedFailed;

        static LoggerExtensions()
        {
            _drinkAdded = LoggerMessage.Define<string>(
            LogLevel.Information,
            EventIds.AddDrink,
            "The drink with name {drinkName} was added.");

            _drinkAddedFailed = LoggerMessage.Define<int, string>(
                LogLevel.Error,
                EventIds.AddDrink,
                "The drink with name {drinkName} (Id = {Id}) failed");
        }

        public static void DrinkAdded(this ILogger logger, string drinkName, Exception ex = null)
        {
            _drinkAdded(logger, drinkName, ex);
        }

        public static void DrinkAddedFailed(this ILogger logger, int id, string name, Exception ex)
        {
            _drinkAddedFailed(logger, id, name, ex);
        }
    }
}
