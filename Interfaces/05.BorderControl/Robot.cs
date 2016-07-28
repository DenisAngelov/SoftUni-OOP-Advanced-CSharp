using System;

namespace _05.BorderControl
{
    public class Robot : IEntity
    {
        private string id;
        private string model;

        public string Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                this.id = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                this.model = value;
            }
        }

        public string endOfId
        {
            get
            {
                return this.id.Substring(id.Length - 3, 3);
            }
        }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        } 

    }
}
