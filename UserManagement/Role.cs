using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
    public class Role
    {
        public int roleId;
        public string roleName;
        public Role(int roleid , string rolename)
        { 
            this.roleId = roleid;
            this.roleName = rolename;           
        }
    }
}
