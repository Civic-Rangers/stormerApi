

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService User { get; }
        IFloodZoneService FloodZone { get; }
      
        //IParkingService ParkingSpot { get; }
    }
}
