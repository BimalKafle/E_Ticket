using E_Ticketing.CoreLayer.DTO.VehicleSeat;
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
    public class VehicleSeatService : VehicleSeatServiceInterface
    {
        private readonly VehicleSeatRepositoryInterface vehicleSeatRepository;

        public VehicleSeatService(VehicleSeatRepositoryInterface _vehicleSeatRepository)
        {
            this.vehicleSeatRepository = _vehicleSeatRepository;
        }

        public async Task BookSeat(long Id)
        {
           
                using TransactionScope scope = TransactionScopeHelper.GetInstance();
                var vehicleSeat = await vehicleSeatRepository.GetById(Id).ConfigureAwait(false) ?? throw new VehicleSeatNotFoundException();
                
                if (vehicleSeat.IsAvailable())
                {
                    vehicleSeat.BookSeat();
                }
                else
                {
                    throw new SeatIsAlreadyBookedException();
                }
                scope.Complete();
           
            
        }

        public Task Create(VehicleSeatInsertDto dto)
        {
            throw new NotImplementedException();
        }

        public Task CancelSeat(long Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(VehicleSeatUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
