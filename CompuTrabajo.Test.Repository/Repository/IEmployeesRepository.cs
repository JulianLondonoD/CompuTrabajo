using CompuTrabajo.Test.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompuTrabajo.Test.Repository
{
    public interface IEmployeesRepository
    {
        void create(Employee employee);
        IList<Employee> read();
        Employee read(int id);
        void update(int id);
        void update(Employee employee);
        void delete(int id);
    }
}
