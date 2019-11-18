using System.Collections.Generic;
using CompuTrabajo.Test.Repository;
using CompuTrabajo.Test.Entities;
using CompuTrabajo.Test.Repository.Factory;

namespace CompuTrabajo.Test.Service
{
    public class EmployeesService : IEmployeesService
    {
        private readonly RepositoryFactoryAbstract _factory;
        private readonly IEmployeesRepository _repository;
        public EmployeesService()
        {
            _factory = RepositoryFactoryAbstract.getSQLFactory();
            _repository = _factory.GetEmployeesRepository();
        }

        public void create(Employee employee)
        {
            _repository.create(employee);
        }

        public IList<Employee> read()
        {
            return _repository.read();
        }

        public Employee read(int id) 
        {
            return _repository.read(id);
        }

        public void update(int id) 
        {
            _repository.update(id);
        }
        public void update(Employee employee) 
        {
            _repository.update(employee);
        }

        public void delete(int id)
        {
            _repository.delete(id);
        }
    }
}
