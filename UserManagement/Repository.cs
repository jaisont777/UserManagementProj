using System;
using System.Collections.Generic;

namespace UserManagement
{
    public class Repository
    {
        public Repository()
        {
            List<User> us = new List<User>();
            List<Role> rol = new List<Role>();
            rol.Add(new Role(1, "Manage and Admin"));
            rol.Add(new Role(2, "Manager"));
            List<Role> rol1 = new List<Role>();
            rol.Add(new Role(1, "Team Lead"));
            rol.Add(new Role(2, "Admin"));
            us.Add(new User(1, "fnamemale1", "lname1", "Male", 25, rol));
            us.Add(new User(2, "fnamemale2", "lname2", "Male", 50, rol1));
            us.Add(new User(3, "fnamemale3", "lname3", "Male", 45, rol1));
            us.Add(new User(4, "fnamefemale1", "lname4", "Female", 22, rol));
            us.Add(new User(4, "fnamefemale2", "lname5", "Female", 21, rol));

            

            (new User()).getWomenLessThan25(us);
            (new User()).getyoungestMan(us);
            (new User()).getMenGreaterThan40(us);
            (new User()).getWomenWithManageAdminRole(us);
            (new User()).getManagersStartswithJO(us);
            (new User()).logUserdetails(us);
           
        }
     
    }
}
