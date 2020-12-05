using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BE
{
    
    public class accountsList
    {
        public DataTable accounts = new DataTable();
        public accountsList()
        {
            accounts.TableName = "Users";
            accounts.Columns.Add("Email", typeof(string));
            accounts.Columns.Add("User", typeof(string));
            accounts.Columns.Add("Pass", typeof(string));
            accounts.Columns.Add("Premium", typeof(string));

            if (!System.IO.File.Exists("user.xml"))
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
            accounts.Rows[accounts.Rows.Count - 1]["Premium"] = "N";

            accounts.WriteXml("user.xml");
        }
    
        public bool validate(string User, string Pass)
        {
            bool condicion = false;

            for (int i = 0; i != accounts.Rows.Count; i++)
            {
                if (User == accounts.Rows[i]["User"].ToString())
                {

                    if (Pass == accounts.Rows[i]["Pass"].ToString())
                    {
                        condicion = true;
                        break;
                    }
                }

            }

            return condicion;
        }

        public void validateCode(string User)
        {

            for (int i = 0; i != accounts.Rows.Count; i++)
            {
                if (User == accounts.Rows[i]["User"].ToString())
                {
                    accounts.Rows[i]["Premium"] = "Y";
                    accounts.WriteXml("user.xml");
                    i = accounts.Rows.Count - 1;
                }

            }

        }
    
        public string premiumState(string user)
        {
            string premiumState = "";

            for (int i = 0; i != accounts.Rows.Count; i++)
            {
                if (user == accounts.Rows[i]["User"].ToString())
                {
                    premiumState = accounts.Rows[i]["Premium"].ToString();
                    i = accounts.Rows.Count - 1;
                }


            }

            return premiumState;
        }






    }





}
