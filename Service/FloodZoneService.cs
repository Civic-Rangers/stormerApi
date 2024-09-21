using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities;
using Service.Contracts;
using Shared.DataTransferObjects;


namespace Service
{
    public class FloodZoneService : IFloodZoneService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;


        public FloodZoneService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<FloodZoneDTO> CreateFloodZoneAsync(FloodZoneDTO floodZone)
        {

            var floodZoneEntity = _mapper.Map<FloodZone>(floodZone);
            _repositoryManager.FloodZone.CreateFloodZone(floodZoneEntity);
            await _repositoryManager.SaveAsync();
            var floodZoneToReturn = _mapper.Map<FloodZoneDTO>(floodZoneEntity);
            return floodZoneToReturn;
        }

        public async Task<IEnumerable<FloodZoneDTO>> GetFloodZonesAsync(bool trackChanges)
        {
            var floodZone = await _repositoryManager.FloodZone.GetAllFloodZonesAsync(trackChanges);
            var floodZonesToReturn = _mapper.Map<IEnumerable<FloodZoneDTO>>(floodZone);
            return floodZonesToReturn;
        }
    }
}
