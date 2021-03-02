using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, int carId)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageSızeOk(carId));
            if (result!=null)
            {
                return result;
            }
            CarImage carImage = new CarImage();
            carImage.CarId = carId;
            carImage.ImagePath = FileHelper.Add(formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdding);
        }
        
        public IResult Delete(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CarImageDelete(carImage),
                FileHelper.Delete(_carImageDal.Get(cı => cı.Id == carImage.Id).ImagePath));
            if (result != null)
            {
                return result;
            }
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(ci => ci.Id == id));
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int Id)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(Id));
        }

        
        public IResult Update(IFormFile formFile, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(cı=>cı.Id == carImage.Id).ImagePath, formFile);
            carImage.Date = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IResult CheckIfCarImageSızeOk(int CarId)
        {
            var result = _carImageDal.GetAll(cı => cı.CarId == CarId).Count;
            if (result>5)
            {
                return new ErrorResult(Messages.CarImageSızePassing);
            }
            return new SuccessResult();
        }
        private IResult CarImageDelete(CarImage carImage)
        {
            try
            {
                File.Delete(carImage.ImagePath);
            }
            catch (Exception exception)
            {

                return new ErrorResult(exception.Message);
            }
            return new SuccessResult();
        }

        private List<CarImage> CheckIfCarImageNull(int Id)
        {
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\UploadCarImages\default.jpg");
            var result = _carImageDal.GetAll(cı => cı.CarId == Id).Any();
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = Id, ImagePath = path, Date = DateTime.Now } };
            }
            return _carImageDal.GetAll(cı => cı.CarId == Id);
        }
    }
}
