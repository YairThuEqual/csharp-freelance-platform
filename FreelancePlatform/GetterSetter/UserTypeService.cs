using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.GetterSetter
{
    public class UserTypeService
    {

        private int id;
        private string name;
        private string password;
        private string type;

        public UserTypeService(string name, string password, string type)
        {
            this.name = name;
            this.password = password;
            this.type = type;   
        }

        public UserTypeService(int id, string name, string password, string type)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.type = type;
        }

        public int getId() { return id; }
        public string getName() { return name; }
        public string getPassword() { return password; }
        public string getType() { return type; }
    }
}
