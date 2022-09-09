using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using assignment_4_rcanpolaat.Models;

namespace assignment_4_rcanpolaat.Context
{
    public interface IMapperSession
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void CloseTransaction();

        void Save(Models.Container entity);
        void Update(Models.Container entity);
        void Delete(Models.Container entity);

        IQueryable<Models.Container> Containers { get; }

    }
}