using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{

    

    public class ProcurementServices
    {

        private UnitOfWork unitOfWork;

        public ProcurementServices(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }


    }
}
