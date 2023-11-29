using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-KPI2L3M");
    
        public void InsertContact(Contact contact)
        {
            try { 
                conn.Open();
                string query = @"
                                INSERT INTO Contacts (FirstName, LastName, Phone, Address)
                                VALUES (@FirstName, @LastName, @Phone, @Address)";

                SqlParameter FirstName = new SqlParameter();
                FirstName.ParameterName = "@FirstName";
                FirstName.Value = contact.FirstName;
                FirstName.DbType = System.Data.DbType.String;

                SqlParameter LastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter Phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter Address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(FirstName);
                command.Parameters.Add(LastName);
                command.Parameters.Add(Phone);
                command.Parameters.Add(Address);

                command.ExecuteNonQuery();

            } 
            
            catch (Exception){


                throw;
            }
            finally { 
                conn.Close(); 
            }
        }
    
        public List<Contact> GetContacts(string search = null)
        {

            List<Contact> contacts = new List<Contact>();

            try
            {
                conn.Open();
                string query = @"SELECT Id, FirstName, LastName, Phone, Address
                                FROM Contacts";

                SqlCommand command = new SqlCommand();


                if (!string.IsNullOrEmpty(search)) {
                    query += @" WHERE FirstName LIKE @Search 
                               OR LastName LIKE @Search 
                               OR Phone LIKE @Search 
                               OR Address LIKE @Search";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                command.CommandText = query;
                command.Connection = conn;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        Address = reader["Address"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                conn.Close();
            }
            return contacts;
        }


        public void UpdateContact(Contact contact) {
            try {
                conn.Open();

                string query = @"UPDATE Contacts
                                SET FirstName = @FirstName,
                                LastName = @LastName,
                                Phone = @Phone,
                                Address = @Address
                                WHERE Id = @Id";

                SqlParameter Id = new SqlParameter("@Id", contact.Id);
                SqlParameter FirstName = new SqlParameter("@FirstName", contact.FirstName);
                SqlParameter LastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter Phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter Address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(Id);
                command.Parameters.Add(FirstName);
                command.Parameters.Add(LastName);
                command.Parameters.Add(Phone);
                command.Parameters.Add(Address);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            finally { 
                conn.Close(); 
            }

        }


        public void DeleteContact(int Id) {
            try
            {
                conn.Open();
                string query = @"DELETE
                                FROM Contacts
                                WHERE Id = @Id";

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(new SqlParameter("@Id", Id));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
