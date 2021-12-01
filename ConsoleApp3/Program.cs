using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection sqll = new SqlConnection(connstr))
            {
                sqll.Open();


                //_____________________Employee_____________________
                SqlDataAdapter empDataAdapter = new SqlDataAdapter("SELECT * FROM[dbo].[Employee]", sqll);
                SqlCommandBuilder merbuilder = new SqlCommandBuilder(empDataAdapter);
                DataSet dataSet = new DataSet();
                empDataAdapter.Fill(dataSet, "Employee");
                //Обращение
                DataTable employee = dataSet.Tables["Employee"];
               // Извлечение
                foreach (DataRow customerrow in employee.Rows)
                {
                    var merID = customerrow["EmployeeID"];
                    var merFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                    var merBD = customerrow["BirthDate"];
                    var posID = customerrow["PositionID"]; 
                    Console.WriteLine($"{merID} {merFN} {merBD} {posID}");
                }
                Console.WriteLine("__________________________________________________");
                //ADD
                //empDataAdapter.InsertCommand = new SqlCommand("[dbo].[stp_EmployeeAdd]", sqll);
                //empDataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                //empDataAdapter.InsertCommand.Parameters.AddWithValue("@FirstName", "Rebyioly");
                //empDataAdapter.InsertCommand.Parameters.AddWithValue("@LastName", "Luoi");
                //empDataAdapter.InsertCommand.Parameters.AddWithValue("@BirthDate","2000-02-08");
                //empDataAdapter.InsertCommand.Parameters.AddWithValue("@PositionID", 1);

                //empDataAdapter.InsertCommand.ExecuteNonQuery();
                //employee.Clear();
                //empDataAdapter.Fill(dataSet, "Employee");
                ////DELETE
                //empDataAdapter.DeleteCommand = new SqlCommand("[dbo].[stp_EmployeeDelete]", sqll);
                //empDataAdapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
                //empDataAdapter.DeleteCommand.Parameters.AddWithValue("@EmployeeID", 2);
                //empDataAdapter.DeleteCommand.Parameters.AddWithValue("@Result", DBNull.Value);
                //empDataAdapter.DeleteCommand.ExecuteNonQuery();
                //employee.Clear();
                //empDataAdapter.Fill(dataSet, "Employee");
                ////Update
                //empDataAdapter.UpdateCommand = new SqlCommand("[dbo].[stp_EmployeeUpdate]", sqll);
                //empDataAdapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                //empDataAdapter.UpdateCommand.Parameters.AddWithValue("@EmployeeID", 1);
                //empDataAdapter.UpdateCommand.Parameters.AddWithValue("@FirstName", "WhoAmI");
                //empDataAdapter.UpdateCommand.Parameters.AddWithValue("@LastName", "AnonYm");
                //empDataAdapter.UpdateCommand.Parameters.AddWithValue("@BirthDate", "2000-01-01");
                //empDataAdapter.UpdateCommand.Parameters.AddWithValue("@PositionID", 2);
                //empDataAdapter.UpdateCommand.ExecuteNonQuery();
                //employee.Clear();
                //empDataAdapter.Fill(dataSet, "Employee");



                //______________________________________________________________________________


                ////INSERT

                //DataRow newnewcustomersRow = employee.NewRow();//создает новую запись четко соответствующей таблицу базы данных
                // newnewcustomersRow["FirstName"] = "Mar";
                // newnewcustomersRow["LastName"] = "Leion";
                // newnewcustomersRow["BirthDate"] = "2012-02-06";
                // newnewcustomersRow["PositionID"] = 3;
                // employee.Rows.Add(newnewcustomersRow);
                // //Обязателен,чтобы добавился в бд
                // empDataAdapter.Update(dataSet, "Employee");
                // employee.Clear();
                // empDataAdapter.Fill(dataSet, "Employee");


                // employee.PrimaryKey = new DataColumn[] { employee.Columns["EmployeeID"] };
                // empDataAdapter.Update(dataSet, "Employee");
                // employee.Clear();
                // empDataAdapter.Fill(dataSet, "Employee");

                // //DELETE

                // DataRow userdel = employee.Rows.Find(4);
                // if (userdel != null)
                // {
                //     userdel.Delete();
                // }
                // else
                // {
                //     Console.WriteLine("Error!");
                // }
                // empDataAdapter.Update(dataSet, "Employee");
                // employee.Clear();
                // empDataAdapter.Fill(dataSet, "Employee");
                // foreach (DataRow customerrow in employee.Rows)
                // {
                //     var merID = customerrow["EmployeeID"];
                //     var merFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //     var merBD = customerrow["BirthDate"];
                //     var merP = customerrow["PositionID"];
                //     Console.WriteLine($"{merID} {merFN} {merBD} {merP}");
                // }

                ////Update
                //empDataAdapter.Update(dataSet, "Employee");
                //employee.Clear();
                //empDataAdapter.Fill(dataSet, "Employee");
                //employee.PrimaryKey = new DataColumn[] { employee.Columns["EmployeeID"] };
                //empDataAdapter.Update(dataSet, "Employee");
                //employee.Clear();
                //empDataAdapter.Fill(dataSet, "Employee");
                //DataRow up = employee.Rows.Find(3);
                //if (up != null)
                //{
                //    up["FirstName"] = "MAry";
                //    up["LastName"] = "BBEST";
                //    up["BirthDate"] = "2000-09-06";
                //    up["PositionID"] = 3;
                //    //можно много раз изменять благодаря этой комманде  up.AcceptChanges();
                //}
                //else
                //{
                //    Console.WriteLine("Error");
                //}
                //empDataAdapter.Update(dataSet, "Employee");
                //employee.Clear();
                //empDataAdapter.Fill(dataSet, "Employee");
                //foreach (DataRow customerrow in employee.Rows)
                //{
                //    var merID = customerrow["EmployeeID"];
                //    var merFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //    var merBD = customerrow["BirthDate"];
                //    var merP = customerrow["PositionID"];
                //    Console.WriteLine($"{merID} {merFN} {merBD} {merP}");
                //}












                //CLASSWORK!!!_____CLASSWORK!!!_____CLASSWORK!!!_____CLASSWORK!!!_____CLASSWORK!!!_____CLASSWORK!!!_____CLASSWORK!!!


                //____________________________________DataSet________________________________________________
                //SqlDataAdapter customerDataAdapter = new SqlDataAdapter("SELECT * FROM[dbo].[Customers]", sqll);
                //SqlDataAdapter employeeDataAdapter = new SqlDataAdapter("SELECT * FROM[dbo].[Employee]", sqll);
                //DataSet dataSet = new DataSet();
                ////Если 1 адаптер
                //customerDataAdapter.Fill(dataSet);

                //2 Если несколько адаптеров,то надо обозначить,какой именно
                //customerDataAdapter.Fill(dataSet, "Customers");

                ////3 Обращение
                //DataTable customers = dataSet.Tables["Customers"];

                //DataTable employee = dataSet.Tables[1];
                //Извлечение
                //foreach (DataRow customerrow in customers.Rows)
                //{
                //    var customerID = customerrow["id"];
                //    var customerFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //    var customerBD = customerrow["DateOfBirth"];
                //    Console.WriteLine($"{customerID} {customerFN} {customerBD}");
                //}

                //customerDataAdapter.InsertCommand = new SqlCommand("[dbo].[stp_CustomerAdd]", sqll);//Вставка данных
                //customerDataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                //customerDataAdapter.InsertCommand.Parameters.AddWithValue("@FirstName", "Anton");
                //customerDataAdapter.InsertCommand.Parameters.AddWithValue("@LastName", "Korol");
                //customerDataAdapter.InsertCommand.Parameters.AddWithValue("@DateOfBirth", "2001-01-01");
                ////customerDataAdapter.InsertCommand.Parameters.Add("@cusomerId", SqlDbType.Int).Direction = ParameterDirection.Output; ////Если output,а не return 
                //customerDataAdapter.InsertCommand.ExecuteNonQuery();
                ////Update Обновили, заново перезаполнили
                //customers.Clear();//Очистка данных
                //customerDataAdapter.Fill(dataSet, "Customers");//Запись измененных данных
                //foreach (DataRow customerrow in customers.Rows)//Вывод
                //{
                //    var customerID = customerrow["id"];
                //    var customerFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //    var customerBD = customerrow["DateOfBirth"];
                //    Console.WriteLine($"{customerID} {customerFN} {customerBD}");
                //}



                //Delete
                //customerDataAdapter.DeleteCommand = new SqlCommand("[dbo].[stp_CustomerDelete]", sqll);
                //customerDataAdapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
                //customerDataAdapter.DeleteCommand.Parameters.AddWithValue("@CustomerID", 5);
                //customerDataAdapter.DeleteCommand.Parameters.AddWithValue("@Result", DBNull.Value);
                //customerDataAdapter.DeleteCommand.ExecuteNonQuery();
                //customers.Clear();
                //customerDataAdapter.Fill(dataSet, "Customers");
                //foreach (DataRow customerrow in customers.Rows)
                //{
                //    var customerID = customerrow["id"];
                //    var customerFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //    var customerBD = customerrow["DateOfBirth"];
                //    Console.WriteLine($"{customerID} {customerFN} {customerBD}");
                //}



                //___________________________________SqlCommandBuilder______________________________________________________________



                //Добавление записи в базу(минус: огромная нагрузка на сервер) Код не работает
                //SqlDataAdapter customerDataAdapter = new SqlDataAdapter("SELECT * FROM[dbo].[Customers]", sqll);
                //SqlCommandBuilder customerbuolder = new SqlCommandBuilder(customerDataAdapter);//принимает адаптер на вход
                //DataSet dataSet = new DataSet();            
                //customerDataAdapter.Fill(dataSet, "Customers");

                //DataTable customers = dataSet.Tables["Customers"];
                //customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
                //DataRow up = customers.Rows.Find(4);
                //if (up != null)
                //{
                //    up["FirstName"] = "Mary";
                //    up["LastName"] = "Leioyr";
                //    up["DateOfBirth"] = "2012-02-06";
                //    //можно много раз изменять благодаря этой комманде  up.AcceptChanges();
                //}
                //else
                //{
                //    Console.WriteLine("Error");
                //}
                //customerDataAdapter.Update(dataSet,"Customers");
                //customers.Clear();
                //customerDataAdapter.Fill(dataSet, "Customers");
                //foreach (DataRow customerrow in customers.Rows)
                //{
                //    var customerID = customerrow["id"];
                //    var customerFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //    var customerBD = customerrow["DateOfBirth"];
                //    Console.WriteLine($"{customerID} {customerFN} {customerBD}");
                //}







                //SqlDataAdapter customerDataAdapter = new SqlDataAdapter("SELECT * FROM[dbo].[Customers]", sqll);
                //SqlCommandBuilder customerbuilder = new SqlCommandBuilder(customerDataAdapter);//принимает адаптер на вход
                //DataSet dataSet = new DataSet();
                //customerDataAdapter.Fill(dataSet, "Customers");

                //DataTable customers = dataSet.Tables["Customers"];
                //DataRow newnewcustomersRow = customers.NewRow();//создает новую запись четко соответствующей таблицу базы данных
                //newnewcustomersRow["FirstName"] = "Mar";
                //newnewcustomersRow["LastName"] = "Leion";
                //newnewcustomersRow["DateOfBirth"] = "2012-02-06";
                //customers.Rows.Add(newnewcustomersRow);

                ////Обязателен,чтобы добавился в бд
                //customerDataAdapter.Update(dataSet, "Customers");
                //customers.Clear();
                //customerDataAdapter.Fill(dataSet, "Customers");


                //customers.PrimaryKey = new DataColumn[] { customers.Columns["id"] };
                //customerDataAdapter.Update(dataSet, "Customers");
                //customers.Clear();
                //customerDataAdapter.Fill(dataSet, "Customers");


                //DataRow userdel = customers.Rows.Find(18);
                //if (userdel != null)
                //{
                //    userdel.Delete();
                //}
                //else
                //{
                //    Console.WriteLine("Error!");
                //}
                //customerDataAdapter.Update(dataSet, "Customers");
                //customers.Clear();
                //customerDataAdapter.Fill(dataSet, "Customers");
                //foreach (DataRow customerrow in customers.Rows)
                //{
                //    var customerID = customerrow["id"];
                //    var customerFN = customerrow["FirstName"] + " " + customerrow["LastName"];
                //    var customerBD = customerrow["DateOfBirth"];
                //    Console.WriteLine($"{customerID} {customerFN} {customerBD}");
                //}







            }
            //Последовательность.
            //Адаптер только если напрямую
            //Если пакетом или накапливая то работать через DATATABLE
        }
    }
}

