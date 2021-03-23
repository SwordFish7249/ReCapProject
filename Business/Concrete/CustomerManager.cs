using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;


        public CustomerManager(ICustomerDal customerDal)
        {
            _customerdal = customerDal;

        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName.Length > 2)
            {
                _customerdal.Add(customer);

                return new SuccessResult(Messages.PersonAdded);
            }
            else
            {
                return new ErrorResult(Messages.PersonNameInvalid);
            }

        }

        public IResult Delete(Customer customer)
        {
            _customerdal.Delete(customer);

            return new SuccessResult(Messages.PersonDeleted);

        }

        public IDataResult<List<Customer>> GetAll()
        {
        //    if (DateTime.Now.Hour == 22)
        //    {
        //        return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
        //    }
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(), Messages.PersonsListed);
        }

        public IDataResult<List<Customer>> GetCustomersById(int customerId)
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(c => c.CustomerId == customerId));
        }

        public IResult Update(Customer customer)
        {
            _customerdal.Update(customer);
            return new SuccessResult(Messages.PersonUpdated);
        }
    }
}
