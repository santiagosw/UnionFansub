using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BE
{
    
    public class Users
    {
        public DataTable accounts = new DataTable();
        public Users()
        {
            accounts.TableName = "Users";
            accounts.Columns.Add("Email", typeof(string));
            accounts.Columns.Add("User", typeof(string));
            accounts.Columns.Add("Pass", typeof(string));

            if (System.IO.File.Exists("user.xml"))
            {
                accounts.WriteXml("user.xml");

            }

            accounts.ReadXml("user.xml");
 
        }
   
        public void savedata(string Email, string User, string Pass)
        {
            accounts.Rows.Add();
            accounts.Rows[accounts.Rows.Count - 1]["Email"] = Email;
            accounts.Rows[accounts.Rows.Count - 1]["User"] = User;
            accounts.Rows[accounts.Rows.Count - 1]["Pass"] = Pass;

            accounts.WriteXml("user.xml");
        }
    
    
    
    
    
    }





}
