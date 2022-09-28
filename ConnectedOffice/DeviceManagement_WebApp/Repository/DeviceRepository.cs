using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Data;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Device GetMostRecentCategory()
        {
            return _context.Device.OrderByDescending(service => service.DateCreated).FirstOrDefault();
        }

        public Category GetMostRecentDevice()
        {
            throw new System.NotImplementedException();
        }
    }

}
