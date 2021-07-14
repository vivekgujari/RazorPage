using System;
using System.Collections.Generic;
using System.Text;

namespace MyGym.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        public IApplicationUserRepository ApplicationUser { get;}
    }
}
