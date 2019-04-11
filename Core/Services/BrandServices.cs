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
   public class BrandServices
    {

        private UnitOfWork unitOfWork;

        public BrandServices(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public void Create(BrandViewModel BrandViewModel)
        {
            var Brand = new Brand
            {

                BrandName = BrandViewModel.BrandName,
                CategoryId= BrandViewModel.CategoryId,
                SubCategoryId=BrandViewModel.SubCategoryId,
                SubSubCategoryId=BrandViewModel.SubSubCategoryId,
                SubSubSubCategoryId=BrandViewModel.SubSubSubCategoryId,
                SubSubSubSubCategoryId=BrandViewModel.SubSubSubSubCategoryId
            };

            unitOfWork.BrandRepository.Insert(Brand);
            unitOfWork.Save();

        }


        public void Update(BrandViewModel BrandViewModel)
        {
            var Brand = new Brand
            {
                BrandId = BrandViewModel.BrandId,
                BrandName = BrandViewModel.BrandName,
                CategoryId = BrandViewModel.CategoryId,
                SubCategoryId = BrandViewModel.SubCategoryId,
                SubSubCategoryId = BrandViewModel.SubSubCategoryId,
                SubSubSubCategoryId = BrandViewModel.SubSubSubCategoryId,
                SubSubSubSubCategoryId = BrandViewModel.SubSubSubSubCategoryId
            };
            unitOfWork.BrandRepository.Update(Brand);
            unitOfWork.Save();
        }

        public BrandViewModel GetById(int id)
        {
            var data = (from s in unitOfWork.BrandRepository.Get()
                        where s.BrandId == id
                        select new BrandViewModel
                        {
                            BrandId = s.BrandId,
                            BrandName = s.BrandName,
                            CategoryId = s.CategoryId,
                            SubCategoryId = s.SubCategoryId,
                            SubSubCategoryId = s.SubSubCategoryId,
                            SubSubSubCategoryId = s.SubSubSubCategoryId,
                            SubSubSubSubCategoryId = s.SubSubSubSubCategoryId,
                            CategoryName=s.Category.CategoryName,
                            SubCategoryName=s.SubCategory.SubCategoryName,
                            SubSubCategoryName=s.SubSubCategory.SubSubCategoryName,
                            SubSubSubCategoryName=s.SubSubSubCategory.SubSubSubCategoryName,
                            SubSubSubSubCategoryName=s.SubSubSubSubCategory.SubSubSubSubCategoryName


                        }).SingleOrDefault();
            return data;
        }
        public IEnumerable<BrandViewModel> GetAll()
        {
            var data = (from s in unitOfWork.BrandRepository.Get()
                        select new BrandViewModel
                        {

                            BrandId = s.BrandId,
                            BrandName = s.BrandName,
                            CategoryId = s.CategoryId,
                            SubCategoryId = s.SubCategoryId,
                            SubSubCategoryId = s.SubSubCategoryId,
                            SubSubSubCategoryId = s.SubSubSubCategoryId,
                            SubSubSubSubCategoryId = s.SubSubSubSubCategoryId,
                            CategoryName = s.Category.CategoryName,
                            SubCategoryName = s.SubCategory.SubCategoryName,
                            SubSubCategoryName = s.SubSubCategory.SubSubCategoryName,
                            SubSubSubCategoryName = s.SubSubSubCategory.SubSubSubCategoryName,
                            SubSubSubSubCategoryName = s.SubSubSubSubCategory.SubSubSubSubCategoryName

                        }).AsEnumerable();
            return data;
        }


        public IEnumerable<BrandViewModel> GetAll(int id)
        {
            var data = (from s in unitOfWork.BrandRepository.Get()
                        where s.BrandId==id
                        select new BrandViewModel
                        {

                            BrandId = s.BrandId,
                            BrandName = s.BrandName
                            

                        }).AsEnumerable();
            return data;
        }


        public void Delete(int id)
        {
            var Brand = new Brand
            {
                BrandId = id
            };

            unitOfWork.BrandRepository.Delete(Brand);
            unitOfWork.Save();

        }



    }
}
