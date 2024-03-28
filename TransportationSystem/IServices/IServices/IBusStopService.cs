using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices.IServices
{
    public interface IBusStopService
    {
        Task<List<BusStop>> busStops();
        Task<List<Bus>> GetBusesByBusStopId(Guid id);
    }
}
