using CompuTrabajo.Test.Repository.ConnectionBuilder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompuTrabajo.Test.Repository.Factory
{
    public abstract class RepositoryFactoryAbstract
    {
        public static RepositoryFactoryAbstract getSQLFactory() 
        {
            return new RepositoryFactory();
        }

        public abstract IEmployeesRepository GetEmployeesRepository();
    }
}
