using E_Ticketing.CoreLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace E_Ticketing.Test.Entity.VehicleTest
{
    public class VehicleEntityTest
    {
        public readonly Vehicle vehicle;
        public readonly VehicleCategory category;
        public VehicleEntityTest()
        {
            category = new("Mini Bus");
            vehicle = new("Ba 1 Kha 1911",category,"Sakira");
        }
        [Fact]
        public void Test_Create_new_instance_with_default_value()
        {
            Assert.Equal("Ba 1 Kha 1911",vehicle.Vehicle_Number);
            Assert.Equal(category, vehicle.Vehicle_Category);
            Assert.Equal("Sakira", vehicle.Vehicle_Name);
        }

        [Fact]
        public void Test_IsActive_returns_true_if_vehicle_isActive()
        {
            Assert.True(vehicle.IsActive());
        }
        [Fact]
        public void Test_Activate_activates_the_vehicle()
        {
            vehicle.Deactivate();
            vehicle.Activate();
            Assert.True(vehicle.IsActive());
        }

        [Fact]
        public void Test_deactivate_deactivates_thevehicle_status()
        {
            vehicle.Deactivate();
            Assert.Equal(Vehicle.Inactive, vehicle.Vehicle_Status);
        }

    }
}
