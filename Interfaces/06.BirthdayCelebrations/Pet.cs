using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BirthdayCelebrations
{
    public class Pet : IIdentificationable
    {
        private string birthday;
        private string name;

        public string Birthday
        {
            get
            {
                return this.birthday;
            }

            private set
            {
                this.birthday = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
    }
}
