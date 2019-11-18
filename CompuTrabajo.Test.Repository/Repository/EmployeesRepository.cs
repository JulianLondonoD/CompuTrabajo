using CompuTrabajo.Test.Entities;
using CompuTrabajo.Test.Repository.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace CompuTrabajo.Test.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        public void create(Employee employee)
        {
            try
            {
                string query = "INSERT INTO [dbo].[employees]" +
                                                            "(CompanyId" +
                                                            ",CreatedOn" +
                                                            ",DeletedOn" +
                                                            ",Email" +
                                                            ",Fax" +
                                                            ",Name" +
                                                            ",Lastlogin" +
                                                            ",Password" +
                                                            ",PortalId" +
                                                            ",RoleId" +
                                                            ",StatusId" +
                                                            ",Telephone" +
                                                            ",UpdatedOn" +
                                                            ",Username)" +
                            "VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)";

                RepositoryFactory.ExecuteNonQuery(query, new string[] {  employee.CompanyId.ToString(),
                                                                        employee.CreatedOn.ToString(),
                                                                        employee.DeletedOn.ToString(),
                                                                        employee.Email.ToString(),
                                                                        employee.Fax.ToString(),
                                                                        employee.Name.ToString(),
                                                                        employee.Lastlogin.ToString(),
                                                                        employee.Password.ToString(),
                                                                        employee.PortalId.ToString(),
                                                                        employee.RoleId.ToString(),
                                                                        employee.StatusId.ToString(),
                                                                        employee.Telephone.ToString(),
                                                                        employee.UpdatedOn.ToString(),
                                                                        employee.Username.ToString()
                                                                      });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList<Employee> read()
        {
            try
            {
                var query = "SELECT CompanyId" +
                                    ",CreatedOn" +
                                    ",DeletedOn" +
                                    ",Email" +
                                    ",Fax" +
                                    ",Name" +
                                    ",Lastlogin" +
                                    ",Password" +
                                    ",PortalId" +
                                    ",RoleId" +
                                    ",StatusId" +
                                    ",Telephone" +
                                    ",UpdatedOn" +
                                    ",Username" +
                                " FROM [dbo].[employees]";
                DataTable dt = RepositoryFactory.GetQueryResult(query, new string[] { });
                var result = (from index in dt.AsEnumerable()
                              select new Employee()
                              {
                                  CompanyId = index.Field<int>("CompanyId"),
                                  CreatedOn = Convert.ToString(index.Field<DateTime>("CreatedOn")),
                                  DeletedOn = Convert.ToString(index.Field<DateTime>("DeletedOn")),
                                  Email = index.Field<string>("Email"),
                                  Fax = index.Field<string>("Fax"),
                                  Lastlogin = Convert.ToString(index.Field<DateTime>("Lastlogin")),
                                  Name = index.Field<string>("Name"),
                                  Password = index.Field<string>("Password"),
                                  PortalId = index.Field<int>("PortalId"),
                                  RoleId = index.Field<int>("RoleId"),
                                  StatusId = index.Field<int>("StatusId"),
                                  Telephone = index.Field<string>("Telephone"),
                                  UpdatedOn = Convert.ToString(index.Field<DateTime>("UpdatedOn")),
                                  Username = index.Field<string>("Username"),
                              }).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Employee read(int id)
        {
            try
            {
                var query = "SELECT CompanyId" +
                                    ",CreatedOn" +
                                    ",DeletedOn" +
                                    ",Email" +
                                    ",Fax" +
                                    ",Name" +
                                    ",Lastlogin" +
                                    ",Password" +
                                    ",PortalId" +
                                    ",RoleId" +
                                    ",StatusId" +
                                    ",Telephone" +
                                    ",UpdatedOn" +
                                    ",Username" +
                                " FROM [dbo].[employees]" +
                                " WHERE CompanyId = @1";
                DataTable dt = RepositoryFactory.GetQueryResult(query, new string[] { id.ToString() });
                var result = (from index in dt.AsEnumerable()
                              select new Employee()
                              {
                                  CompanyId = index.Field<int>("CompanyId"),
                                  CreatedOn = Convert.ToString(index.Field<DateTime>("CreatedOn")),
                                  DeletedOn = Convert.ToString(index.Field<DateTime>("DeletedOn")),
                                  Email = index.Field<string>("Email"),
                                  Fax = index.Field<string>("Fax"),
                                  Lastlogin = Convert.ToString(index.Field<DateTime>("Lastlogin")),
                                  Name = index.Field<string>("Name"),
                                  Password = index.Field<string>("Password"),
                                  PortalId = index.Field<int>("PortalId"),
                                  RoleId = index.Field<int>("RoleId"),
                                  StatusId = index.Field<int>("StatusId"),
                                  Telephone = index.Field<string>("Telephone"),
                                  UpdatedOn = Convert.ToString(index.Field<DateTime>("UpdatedOn")),
                                  Username = index.Field<string>("Username"),
                              }).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(Employee employee)
        {
            try
            {
                var query = "UPDATE [dbo].[employees] SET CreatedOn = @1, DeletedOn = @2, Email = @3, Fax = @4, " +
                                "Lastlogin = @5, Name = @6, Password = @7, PortalId = @8, RoleId = @9, " +
                                "StatusId = @10, Telephone = @11, UpdatedOn = @12, Username = @13 WHERE CompanyId = @14";
                RepositoryFactory.ExecuteNonQuery(query, new string[] {
                                                                        employee.CreatedOn.ToString(),
                                                                        employee.DeletedOn.ToString(),
                                                                        employee.Email.ToString(),
                                                                        employee.Fax.ToString(),
                                                                        employee.Lastlogin.ToString(),
                                                                        employee.Name.ToString(),
                                                                        employee.Password.ToString(),
                                                                        employee.PortalId.ToString(),
                                                                        employee.RoleId.ToString(),
                                                                        employee.StatusId.ToString(),
                                                                        employee.Telephone.ToString(),
                                                                        employee.UpdatedOn.ToString(),
                                                                        employee.Username.ToString(),
                                                                        employee.CompanyId.ToString()
                                                                      });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(int id)
        {
            try
            {
                var query = "UPDATE [dbo].[employees] SET Username = 'test1updated' WHERE CompanyId = @1";
                RepositoryFactory.ExecuteNonQuery(query, new string[] {id.ToString()});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(int id) 
        {
            try
            {
                var query = "DELETE FROM [dbo].[employees] WHERE CompanyId = @1";
                RepositoryFactory.ExecuteNonQuery(query, new string[] { id.ToString() });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
