using DSO34BT_2.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DSO34BT_2.Services
{
    public class UserRepository : RepositoryBase
    {
        public override void Create(string lastName, string firstName, int age, string email)
        {
            string queryString = @"Insert into [dbo].[Users] values (@lastName, @firstName, @age, @email)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public List<UserDto> FindAll()
        {
            var users = new List<UserDto>();

            string queryString = @"select * from Users";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        users.Add(new UserDto
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Age = (int)reader["Age"]
                        });
                    }
                    return users.ToList();
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}