using System;
namespace webapi_starter.Models
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
