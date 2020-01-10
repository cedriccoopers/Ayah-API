using System;
using System.Threading.Tasks;
using Ayah.Core.Repositories;

namespace Ayah.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployee Employee {get;}
        IGender Gender {get;}

        INationality Nationality {get;}
        ITown Town{get;}

    }
}