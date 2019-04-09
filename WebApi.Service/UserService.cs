using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data.Infastracture;
using WebAPI.Data.Repositorys;
using WebAPI.Model.Models;

namespace WebApi.Service
{
    public interface IUserService
    {
        void Add(User user);
        User GetById(int Id);
        void SaveChange();

    }
    public class UserService : IUserService
    {
        IAuthRepository _authRepository;
        IUnitOfWork _unitOfWork;

        public UserService(IAuthRepository authRepository, IUnitOfWork unitOfWork)
        {
            _authRepository = authRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
