using System.Security.Cryptography

using System.Text;

namespace SQLCS
{
    class HashingAlgorthim
    {
        public string HashForPass(string input)
        {
            // Hashing Algorithm - fit for passwords

            using (System.Security.Cryptography.SHA384 sHA384 = System.Security.Cryptography.SHA384.Create())
            {
                byte[] bytes = sHA384.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();

                foreach(byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

}