using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Shared.DataTransferObjects;

namespace Contracts
{
    public interface IFloodZoneRepository
    {
        Task<IEnumerable<FloodZone>> GetAllFloodZonesAsync(bool trackChanges);
        //void CreateFloodZoneAsync(FloodZone floodZone);
        void DeleteFloodZoneAsync(FloodZone floodZone);
        void CreateFloodZone(FloodZone floodZone);
    }
}
