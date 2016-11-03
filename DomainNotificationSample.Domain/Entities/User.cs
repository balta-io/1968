using System;

namespace DomainNotificationSample.Domain.Entities
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
            Active = false;
        }

        public User(string username, string password)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
            Active = false;
        }

        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
    }
}
