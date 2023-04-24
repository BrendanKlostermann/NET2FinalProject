using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessFakes;
using DataAccessLayer;
using LogicLayerInterfaces;

namespace LogicLayer
{
    public class VehicleManager : IVehicleManager
    {
        List<Vehicle> _vehicles = null;
        VehicleFactoryOptions factoryOptions = null;
        Vehicle _vehicle = null;

        public bool DeleteVehicle(int vehicleID)
        {
            try
            {
                VehicleAccessor vehicleAccessor = new VehicleAccessor();
                return vehicleAccessor.RemoveVehicle(vehicleID);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Vehicle could not be deleted", ex);
            }

        }

        public List<Vehicle> GetAllAvailableVehicles()
        {
            _vehicles = new List<Vehicle>();

            try
            {
                VehicleAccessor _vehicleAccessor = new VehicleAccessor();
                _vehicles = _vehicleAccessor.RetrieveAllAvailableVehicles();
            } 
            catch(Exception ex)
            {
                throw new ApplicationException("Vehicles not found", ex);
            }
            

            return _vehicles;
        }

        public Vehicle GetVehicleByVehicleID(int vehicleID)
        {
            try
            {
                _vehicle = new Vehicle();

                VehicleAccessor vehicleAccessor = new VehicleAccessor();
                _vehicle = vehicleAccessor.RetrieveVehicleByVehicleID(vehicleID);
            }
            catch(Exception ex)
            {
                throw new ApplicationException("Vehicle ID " + vehicleID + " could not be found", ex);
            }
            

            return _vehicle;
            
        }

        public VehicleFactoryOptions GetVehicleFactoryOptionsByVehicleID(int vehicleID)
        {
            factoryOptions = new VehicleFactoryOptions();

            VehicleAccessor _vehicleAccessor = new VehicleAccessor();
            factoryOptions = _vehicleAccessor.RetreiveFactoryOptionsByVehicleID(vehicleID);


            return factoryOptions;
        }
    }
}
