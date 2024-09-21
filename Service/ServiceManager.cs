using Microsoft.EntityFrameworkCore.Metadata;
using Service.Contracts;
using Contracts;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Service
{
    public class ServiceManager : IServiceManager
    {

        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IFloodZoneService> _floodZoneService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, mapper));
            _floodZoneService = new Lazy<IFloodZoneService>(() => new FloodZoneService(repositoryManager, mapper));
        }


        public IUserService User => _userService.Value;

        public IFloodZoneService FloodZone => _floodZoneService.Value;

        //public IParkingService ParkingSpot => throw new NotImplementedException();

        //IParkingService IServiceManager.ParkingSpot => throw new NotImplementedException();
    }
}
