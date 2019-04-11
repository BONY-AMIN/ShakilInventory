using Domain.Repositories;
using Domain.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class RoleServices
    {
        private UnitOfWork unitOfWork;

        public RoleServices(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public void Create(RoleViewModel roleVM)
        {
            var Role = new Role
            {

                RoleName = roleVM.RoleName
            };

            unitOfWork.RoleRepository.Insert(Role);
            unitOfWork.Save();
        }


        public void Update(RoleViewModel roleVM)
        {
            var Role = new Role
            {
                RoleId = roleVM.RoleId,
                RoleName = roleVM.RoleName
            };
            unitOfWork.RoleRepository.Update(Role);
            unitOfWork.Save();
        }

        public RoleViewModel GetById(int id)
        {
            var data = (from s in unitOfWork.RoleRepository.Get()
                        where s.RoleId == id
                        select new RoleViewModel
                        {
                            RoleId = s.RoleId,
                            RoleName = s.RoleName
                        }).SingleOrDefault();
            return data;
        }
        public IEnumerable<RoleViewModel> GetAll()
        {
            var data = (from s in unitOfWork.RoleRepository.Get()
                        select new RoleViewModel
                        {

                            RoleId = s.RoleId,
                            RoleName = s.RoleName

                        }).AsEnumerable();
            return data;
        }

        public void Delete(int id)
        {
            var Role = new Role
            {
                RoleId = id
            };

            unitOfWork.RoleRepository.Delete(Role);
            unitOfWork.Save();

        }
    }
}
