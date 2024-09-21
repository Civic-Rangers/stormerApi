using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Shared.DataTransferObjects;

namespace Repository
{
    public class FloodZoneRepository: RepositoryBase<FloodZone>, IFloodZoneRepository
    {

        public FloodZoneRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<FloodZone>> GetAllFloodZonesAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        //public void CreateFloodZoneAsync(FloodZone floodZone)=>CreateFloodZoneAsync(floodZone);

        public void DeleteFloodZoneAsync(FloodZone floodZone)
        {
             DeleteFloodZoneAsync(floodZone);
        }

        public void CreateFloodZone(FloodZone floodZone)=> Create(floodZone);
    }
}
