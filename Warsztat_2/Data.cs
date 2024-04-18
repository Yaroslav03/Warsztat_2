namespace Warsztat_2
{
    public class Client
    {
        public byte ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? NIP { get; set; }
        public string? AdressCompany { get; set; }
        public static Client Reset()
        {
            return new Client();
        }
    }
    public record ChceckSchedule(string? Name, string? PhoneNumber, string? Marka, string? Model, string? Problem, string? ScheduleCar);

    public class Car
    {
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Engine { get; set; }
        public string? YearOfProduktion { get; set; }

        public string? VIN { get; set; }

        public static Car Reset()
        {
            return new Car();
        }
    }
    class Pay
    {
        public ushort PriceFinall { get; set; }
        public ushort PricePartMarg { get; set; }
        public ushort EstimatedCost { get; set; }
        public bool PaymentMethod { get; set; } // if true card, if false then cash
        public string? CardCode { get; set; }

        public static Pay Reset()
        {
            return new Pay();
        }
    }
    class HistoryCar
    {
        public string? DateofAdoption { get; set; }
        public string? NumberofRegister { get; set; }
        public string? Mileage { get; set; }
        public bool LeftDocument { get; set; }
        public bool TestDrive { get; set; }
        public bool KeyCar { get; set; }
        public string? Zlecenie { get; set; }
        public string? Diagnostic { get; set; }
        public string? Repair { get; set; }
        public string? VIN { get; set; }
        public string? DateOfAcceptance { get; set; }

        public static HistoryCar Reset() { return new HistoryCar(); }
    }

    public class Repair
    {
        public string? Problem { get; set; }
        public string? ScheduleCar { get; set; }
        public string? AdmissionDateCar { get; set; }
        public string? Description { get; set; }
        public string? NrPart { get; set; }

        public decimal Price { get; set; }
        public byte Ilość { get; set; }
        public decimal Sum { get; set; }
        public bool Stan { get; set; }
        public string? DateOfAcceptance { get; set; }
        public static Repair Reset()
        {
            return new Repair();
        }
    }
    public class OrderManagment
    {
        /// <summary>
        /// Status zlecnia
        /// </summary>
        public bool OrderAddopted { get; set; }
        public bool RealiseOrder { get; set; }
        public string? DateOrderAddopted { get; set; }
        public string? DateRealiseOrder { get; set; }
        /// <summary>
        /// Płatność
        /// </summary>
        public string? DateOfPay { get; set; }
        public string? TypeOfPay { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal Cost { get; set; }
        public decimal TotalCostOfParts { get; set; }
        public decimal CostWithMarge { get; set; }
        public string? WorkPerfomed { get; set; }
        public string? Employer { get; set; }
        public static OrderManagment Reset() { return new OrderManagment(); }
    }
    public class WarehouseData
    {
        public ushort? Id { get; set; }
        public string? Type { get; set; }
        public string? PartNumber { get; set; } //Numer części
        public string? Name { get; set; } //nazwa
        public string? Description { get; set; } //opis
        public ushort Price { get; set; }
        public ushort Quantity { get; set; } // ilość

        public static WarehouseData Reset()
        {
            return new WarehouseData();
        }
    }
}