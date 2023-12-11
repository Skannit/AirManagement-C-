using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane:IService<Plane>
    {
       public bool IsAvailablePlane(Flight f, int nbPlaces);

        public void DeletePlanes();

        public IEnumerable<Flight> GetFlights(int n);

        public IEnumerable<Passenger> GetPassenger(Plane p);
    }
}
