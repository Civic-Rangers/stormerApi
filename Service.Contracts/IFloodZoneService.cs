using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DataTransferObjects; 

namespace Service.Contracts
{
    public interface IFloodZoneService
    {
     
        Task<IEnumerable<FloodZoneDTO>> GetFloodZonesAsync(bool trackChanges);
  
        Task<FloodZoneDTO> CreateFloodZoneAsync(FloodZoneDTO floodZone);
    }
}
