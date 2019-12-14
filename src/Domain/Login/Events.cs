using Microsoft.Extensions.Logging;

namespace MyHomeBarV2.Domain.Login
{
    internal static class EventIds
    {
        public const int Update = 1000;
        public const int GetByName = 1001;
        public const int Add = 1002;
        public const int Delete = 1004;

        public static readonly EventId AddDrink = new EventId(Add, nameof(AddDrink));
        public static readonly EventId ViewDrink = new EventId(GetByName, nameof(ViewDrink));
        public static readonly EventId ServeDrink = new EventId(Update, nameof(ServeDrink));
        public static readonly EventId MakeParties = new EventId(Update, nameof(MakeParties));
        public static readonly EventId RemoveBottle = new EventId(Delete, nameof(RemoveBottle));
    }
}
