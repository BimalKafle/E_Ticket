using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.CoreLayer.DTO.City
{
    public class CityUpdateDto : CityInsertDto
    {
        public long Id { get; protected set; }
        public CityUpdateDto(long Id,string name) : base(name)
        {
        }
    }
}
