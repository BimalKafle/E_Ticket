using E_Ticketing.CoreLayer.DTO.VehicleCategory;
using E_Ticketing.CoreLayer.Entity;
using E_Ticketing.CoreLayer.Exceptions;
using E_Ticketing.CoreLayer.Helper;
using E_Ticketing.CoreLayer.Repository;
using E_Ticketing.CoreLayer.Service.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace E_Ticketing.CoreLayer.Service
{
    public class VehicleCategoryService : VehicleCategoryServiceInterface
    {
        private readonly VehicleCategoryRepositoryInterface vehicleCategoryRepository;

        public VehicleCategoryService(VehicleCategoryRepositoryInterface _vehicleCategoryRepository)
        {
            vehicleCategoryRepository = _vehicleCategoryRepository;
        }

        public async Task Activate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await vehicleCategoryRepository.GetById(Id).ConfigureAwait(false) ?? throw new VehicleCategoryNotFoundException();
            vehicleCategory.Activate();
            scope.Complete();
        }

        public async Task Create(VehicleCategoryInsertDto dto)
        {
            using TransactionScope scope =TransactionScopeHelper.GetInstance();
            var vehicleCategory = new VehicleCategory(dto.Name);
            await vehicleCategoryRepository.Insert(vehicleCategory);
            scope.Complete();
        }

        public async Task Deactivate(long Id)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await vehicleCategoryRepository.GetById(Id).ConfigureAwait(false) ?? throw new VehicleCategoryNotFoundException();
            var anyActiveVehicle=vehicleCategory.Vehicles.Any(a => a.IsActive()) ;
            if (anyActiveVehicle)
            {
                throw new VehicleCategoryContainsActiveVehicleException();
            }
            vehicleCategory.Deactivate();
            scope.Complete();
        }

        public async Task Update(VehicleCategoryUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var vehicleCategory = await vehicleCategoryRepository.GetById(dto.Id) ?? throw new VehicleCategoryNotFoundException();
            vehicleCategory.UpdateName(dto.Name);
            await vehicleCategoryRepository.Update(vehicleCategory);
            scope.Complete();
        }
    }
}
