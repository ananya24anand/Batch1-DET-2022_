using Batch1_DET_2022_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace Batch1_DET_2022_
{
    internal class LearningEF
    {

        public static void Main()
        {
            //GetAllEmp();
            //Console.ReadLine();
            //UpdateEmployee();
            //DeleteEmp();
            //DeleteEmpSP();
            //GetEmployeeSP();
            //UpdateNameSP();
            //AddEmpSP();
            AddEmployeeSP();

        }




        private static void GetEmployeeSP()
        {
            var ctx = new learningContext();
            try
            {
                var employees = ctx.Emps.FromSqlRaw("getallempdetails");
                foreach (var e in employees)
                {
                    Console.WriteLine(e.Ename);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }

        private static void AddEmployeeSP()
        {
            var ctx = new learningContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 2000
                        },

                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Ross"},

                         new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Trainee"},

                          new SqlParameter() {
                            ParameterName = "@mgr",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7839},

                          new SqlParameter() {
                            ParameterName = "@hire",
                            SqlDbType =  System.Data.
                            SqlDbType.DateTime,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "10/08/2022"},

                          new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 10000},

                           new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 1000},


                          new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 10}

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("addemp @empno, @ename, @job, @mgr, @hire, @sal, @comm, @deptno", param);
                Console.WriteLine("added");
                
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }


        private static void DeleteEmpSP()
        {
            var ctx = new learningContext();
            try
            {
                var Value = 1234;
                int employee = ctx.Database.ExecuteSqlRaw("deleteemp @p0", Value);
                Console.WriteLine(employee);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }

        private static void DeleteEmp()

        {
            var ctx = new learningContext();
            try
            {

                Emp employee = ctx.Emps.Where(E => E.Empno == 7900).SingleOrDefault();
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("Employee deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }




        private static void UpdateEmployee()

        {
            var ctx = new learningContext();
            try
            {


                Emp employee = ctx.Emps.Where(E => E.Empno == 7566).SingleOrDefault();
                employee.Ename = " Mike";
                employee.Sal = 10000;
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("Updated done");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

            private static void GetAllEmp ()
            {
                var ctx = new learningContext();
                var emp = ctx.Emps.Where(e => e.Empno == 7566).SingleOrDefault();

                Console.WriteLine(emp.Ename + " " + emp.Sal);
            }

       


    }
}
