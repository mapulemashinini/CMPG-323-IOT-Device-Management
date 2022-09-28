using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Category GetMostRecentZone()
        {
            return _context.Category.OrderByDescending(service => service.CreatedDate).FirstOrDefault();
        }

        Zone IZoneRepository.GetMostRecentZone()
        {
            throw new System.NotImplementedException();
        }
    }

}
