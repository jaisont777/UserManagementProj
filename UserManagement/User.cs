using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class User
    {
        public int id;
        public string fname;
        public string lname;
        public string gender;
        public int age;
        public List<Role> roles;

        public User()
        {
        }

        public User(int id, string fname, string lname, string gneder, int age, List<Role> roles)
        {
            this.id = id;
            this.fname = fname;
            this.lname= lname;
            this.gender = gneder;
            this.age = age;
            this.roles = roles;
                
        }
        public void getWomenLessThan25(List<User> ul)
        {
            if (Validate(ul))
            {
                Console.WriteLine("Women Less Than 25 Years");
                foreach (string fname in from u in ul where u.age < 25 && u.gender == "Female" select u.fname)
                {
                    Console.WriteLine(fname);
                }
            }
        }
        public void getyoungestMan(List<User> ul)
        {
            if (Validate(ul))
            {
                Console.WriteLine("\n\nYoungest Man");

                foreach (User u in ul.Where(x => x.gender == "Male" && x.age == (ul.Where(x => x.gender == "Male").ToList().Min(x => x.age))).ToList())
                {
                    Console.WriteLine(u.fname);
                }
            }
            
        }

        public void getMenGreaterThan40(List<User> ul)
        {
            if (Validate(ul))
            {
                Console.WriteLine("\n\nMen Greater Than 40 Years");
                foreach (string fname in from u in ul where u.age > 40 && u.gender == "Male" select u.fname)
                {
                    Console.WriteLine(fname);
                }
            }
        }
        public void getWomenWithManageAdminRole(List<User> ul)
        {
            if (Validate(ul))
            {
                Console.WriteLine("\n\nWomen With Manage and Admin Role");
                foreach (string fname in from u in ul where u.roles.Where(x => x.roleName == "Manage and Admin").ToList().Count > 0 && u.gender == "Female" select u.fname)
                {
                    Console.WriteLine(fname);
                }
            }

        }

        public void getManagersStartswithJO(List<User> ul)
        {
            if (Validate(ul))
            {
                Console.WriteLine("\n\nManagers With first Name Starting with Jo");
                foreach (string fname in from u in ul where u.roles.Where(x => x.roleName == "Manager").ToList().Count > 0 && u.fname.StartsWith("Jo") select u.fname)
                {
                    Console.WriteLine(fname);
                }
            }
        }

        public bool Validate(List<User> ul)
        {
            if (ul == null)
            {
                Console.WriteLine("Invalid Input");
                return false;
            }
            if (ul.Count == 0)
            {
                Console.WriteLine("Invalid Input");
                return false;
            }
            return true;
        }

        public void logUserdetails(List<User> ul)
        {
            if (Validate(ul))
            {

                List<string> loglist = new List<string>();
                foreach (User u in ul)
                {
                    string gender = u.gender == "Male" ? "Man" : "Women";
                    string log = "\n" + u.fname + " " + u.lname + " is " + u.age + " old. It is a " + gender + ". He has the following roles ";
                    foreach (string role in u.roles.Select(x => x.roleName).ToList())
                    {
                        log += " " + role;
                    }
                    Console.Write(log);
                    loglist.Add(log);
                }
                string path = @"C:\Test\log.txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }


                using (FileStream fs = File.Create(path))
                {
                    foreach (string log in loglist)
                    {
                        Byte[] title = new UTF8Encoding(true).GetBytes(log);
                        fs.Write(title, 0, title.Length);
                    }
                }

            }
        }

    }
   
}
