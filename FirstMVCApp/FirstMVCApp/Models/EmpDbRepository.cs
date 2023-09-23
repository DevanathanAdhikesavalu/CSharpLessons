using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpDbRepository
    {
        public static List<Employee> GetEmpList() 
        {
            List<Employee> emplist = new List<Employee>();

            using (SqlConnection cn =SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "Select * from emptbl";
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Employee emp = new Employee
                    {
                        EmpID = empdr.GetInt32(0),
                        EmpName = empdr.GetString(1),
                        EmpSalary = empdr.GetDecimal(2),
                        EmpCity = empdr.GetString(3),
                    };
                    emplist.Add(emp);
                }
            }
            return emplist;
        }

        public static Employee GetEmpById(int id) 
        {
            Employee empFound = null;
            using(SqlConnection  cn = SqlHelper.CreateConnection()) 
            {
                if(cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectEmps = "Select * from emptbl where eno=@id";
                selectempcmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
                selectempcmd.CommandText=selectEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while(empdr.Read())
                {
                    empFound = new Employee
                    {
                        EmpID = empdr.GetInt32(0),
                        EmpName = empdr.GetString(1),
                        EmpSalary = empdr.GetDecimal(2),
                        EmpCity = empdr.GetString(3),
                    };
                }
            }
            return empFound;
        }

        public static int AddNewEmp(Employee newEmp) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {

                if (cn.State != ConnectionState.Open)
                {

                    cn.Open();

                }

                SqlCommand insertEmpcmd = cn.CreateCommand();

                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";

                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.EmpID;

                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.EmpName;

                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.EmpCity;

                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.EmpSalary;

                insertEmpcmd.CommandText = insertNewEmpQuery;

                query_result = insertEmpcmd.ExecuteNonQuery();

            }
            return query_result;

        }

        public static int UpdateEmp(Employee modifiedEmp)
        {

            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.EmpID;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.EmpName;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.EmpCity;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.EmpSalary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }

        public static int DeleteEmp(int id) {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
