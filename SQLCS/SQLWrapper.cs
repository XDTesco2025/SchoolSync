using Microsoft.Data.SqlClient;
#pragma warning disable

namespace SQLCS
{
    class SQLWrapper
    {
        SqlConnection connection;

        //Attobutes
        static private bool isConnectionActive = false;

        //Attrobutes Pull Requests
        public bool GetisConnectionActive(){ return isConnectionActive; }

        //Functions
        public void OpenConnection()
        {
            var builder = new SqlConnectionStringBuilder();
                builder.DataSource = "KAB-SQL\\KABSQL22";
                builder.UserID = "csharp";
                builder.Password = "BlueCat12";
                builder.InitialCatalog = "jpullen"; 
                builder.TrustServerCertificate = true;
            connection = new SqlConnection(builder.ConnectionString);

            connection.Open();

            isConnectionActive = true;
        }
        public List<BookMasterData> GetAllMembersData()
        {
            /* 
                Notes: For the output the being a 2D List (List[n][i])
                n = index of user
                i = what number arross (1 to final) (unless you want to pull the id?)
            */
            if(isConnectionActive == false)
            {
                Console.WriteLine("GetAllMembersData() Failed connection is not open");
                return null;
            }
            else
            {
                const string sql = "SELECT * FROM Members";
                
                SqlCommand SQLCommand = new SqlCommand(sql, connection);
                SqlDataReader reader = SQLCommand.ExecuteReader();

                List<BookMasterData> Users = new List<BookMasterData>();
                
                while(reader.Read()){

                    BookMasterData temp = new BookMasterData(
                        Convert.ToUInt16(reader[1]),
                        Convert.ToUInt16(reader[2]),
                        Convert.ToUInt16(reader[3]),
                        Convert.ToUInt16(reader[4]),
                        Convert.ToString(reader[5]),
                        Convert.ToString(reader[6])
                        );
                    Users.Add(temp);
                }
                reader.Close();
                return Users;
            }
        }       
        public MembersData GetMemberDataViaID(int i)
        {
            if(isConnectionActive == false)
            {
                Console.WriteLine("GetMemberDataViaID() Failed connection is not open");
                return null;
            }
            else
            {
                string sql = $"SELECT * FROM Members WHERE MemberID = {i};";
                
                SqlCommand SQLCommand = new SqlCommand(sql, connection);
                SqlDataReader reader = SQLCommand.ExecuteReader();

                reader.Read();
                MembersData User = new MembersData(
                    Convert.ToInt32(reader[0]),
                    Convert.ToString(reader[1]),
                    Convert.ToString(reader[2]),
                    Convert.ToString(reader[3]),
                    DateOnly.FromDateTime(Convert.ToDateTime(reader[4])),
                    DateOnly.FromDateTime(Convert.ToDateTime(reader[5])),
                    DateOnly.FromDateTime(Convert.ToDateTime(reader[6])),
                    Convert.ToString(reader[7])
                );
                reader.Close();
                return User;
            }
        }
        public void CloseConnection()
        {
            if(isConnectionActive == false)
            {
                Console.WriteLine("CloseConnection() Failed Cornection is not open");
            }
            else
            {
                connection.Close();
            }
        }
    }

}