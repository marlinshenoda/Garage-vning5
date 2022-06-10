namespace GarageÖvning5
{
    internal interface IVehicle
    {
        string Color { get; set; }
        uint NumberOfWheels { get; set; }
        string RegisterNumber { get; init; }
    }
}