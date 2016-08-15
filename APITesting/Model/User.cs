using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITesting.Model
{
 public   class User
    {
        public int id;
        public string name;
        public string password;

        public User()
        {
        }

        public User(int id,string name,string password)
        {
            this.Id = id;
            this.Name = name;
            this.Password = password;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}
