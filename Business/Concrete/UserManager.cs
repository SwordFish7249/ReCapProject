using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        
        
        public UserManager(IUserDal userDal)
        {
            _userdal = userDal;
            
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length > 2)
            {
                _userdal.Add(user);

                return new SuccessResult(Messages.PersonAdded);
            }
            else
            {
                return new ErrorResult(Messages.PersonNameInvalid);
            }

        }

        public IResult Delete(User user)
        {
                 _userdal.Delete(user);
                
                return new SuccessResult(Messages.PersonDeleted);
            
        }

        public IDataResult<List<User>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userdal.GetAll(), Messages.PersonsListed);
        }

        public User GetByMail(string email)
        {
            return _userdal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userdal.GetClaims(user);
        }

        public IDataResult<List<User>> GetUsersById(int id)
        {
             return new SuccessDataResult<List<User>>(_userdal.GetAll(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.PersonUpdated);
        }

        
    }
}
