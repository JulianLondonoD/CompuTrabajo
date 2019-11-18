using System;
using System.Collections.Generic;
using System.Text;
using CompuTrabajo.Test.Entities;

namespace CompuTrabajo.Test.Service
{
    public interface IEmployeesService
    {
        void create(Employee entityObject);
        IList<Employee> read();
        Employee read(int id);
        void update(int id);
        void update(Employee employee);
        void delete(int id);
    }
}
