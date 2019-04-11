﻿using Domain.Repositories;
using Domain.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class SupplierCompanyServices
    {
        private UnitOfWork unitOfWork;

        public SupplierCompanyServices(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public void Create(SupplierCompanyViewModel supplierCompanyVM)
        {
            var SupplierCompany = new SupplierCompany
            {

                SupplierCompanyName = supplierCompanyVM.SupplierCompanyName,
                SupplierName = supplierCompanyVM.SupplierName,
                SupplierCompanyAddress = supplierCompanyVM.SupplierCompanyAddress,
                Email = supplierCompanyVM.Email,
                MobileNumber=supplierCompanyVM.MobileNumber
                
                
            };

            unitOfWork.SupplierCompanyRepository.Insert(SupplierCompany);
            unitOfWork.Save();
        }


        public void Update(SupplierCompanyViewModel supplierCompanyVM)
        {
            var SupplierCompany = new SupplierCompany
            {
                SupplierCompanyId = supplierCompanyVM.SupplierCompanyId,
                SupplierCompanyName = supplierCompanyVM.SupplierCompanyName,
                SupplierName = supplierCompanyVM.SupplierName,
                SupplierCompanyAddress = supplierCompanyVM.SupplierCompanyAddress,
                Email = supplierCompanyVM.Email,
                MobileNumber = supplierCompanyVM.MobileNumber
            };
            unitOfWork.SupplierCompanyRepository.Update(SupplierCompany);
            unitOfWork.Save();
        }

        public SupplierCompanyViewModel GetById(int id)
        {
            var data = (from s in unitOfWork.SupplierCompanyRepository.Get()
                        where s.SupplierCompanyId == id
                        select new SupplierCompanyViewModel
                        {
                            SupplierCompanyId = s.SupplierCompanyId,
                            SupplierCompanyName = s.SupplierCompanyName,
                            SupplierName = s.SupplierName,
                            SupplierCompanyAddress = s.SupplierCompanyAddress,
                            Email = s.Email,
                            MobileNumber = s.MobileNumber
                        }).SingleOrDefault();
            return data;
        }
        public IEnumerable<SupplierCompanyViewModel> GetAll()
        {
            var data = (from s in unitOfWork.SupplierCompanyRepository.Get()
                        select new SupplierCompanyViewModel
                        {

                            SupplierCompanyId = s.SupplierCompanyId,
                            SupplierCompanyName = s.SupplierCompanyName,
                            SupplierName = s.SupplierName,
                            SupplierCompanyAddress = s.SupplierCompanyAddress,
                            Email = s.Email,
                            MobileNumber = s.MobileNumber

                        }).AsEnumerable();
            return data;
        }


        public IEnumerable<SupplierCompanyViewModel> GetAll(int id)
        {
            var data = (from s in unitOfWork.SupplierCompanyRepository.Get()
                        where s.SupplierCompanyId==id
                        select new SupplierCompanyViewModel
                        {

                            SupplierCompanyId = s.SupplierCompanyId,
                            SupplierCompanyName = s.SupplierCompanyName,
                            SupplierName = s.SupplierName,
                            SupplierCompanyAddress = s.SupplierCompanyAddress,
                            Email = s.Email,
                            MobileNumber = s.MobileNumber

                        }).AsEnumerable();
            return data;
        }





        public void Delete(int id)
        {
            var SupplierCompany = new SupplierCompany
            {
                SupplierCompanyId = id
            };

            unitOfWork.SupplierCompanyRepository.Delete(SupplierCompany);
            unitOfWork.Save();

        }
    }
}