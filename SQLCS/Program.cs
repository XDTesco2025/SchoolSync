using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Microsoft.Data.SqlClient;

#pragma warning disable

namespace SQLCS
{
    class Program
    {
        public static void Main()
        {
            SQLWrapper SQLWrapperService = new SQLWrapper();
            
            
            SQLWrapperService.OpenConnection();

            Console.WriteLine(SQLWrapperService.GetMemberDataViaID(88).GetAllDataString());
            
            SQLWrapperService.CloseConnection();
        }
    }
}