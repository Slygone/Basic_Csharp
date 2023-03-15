
namespace Task3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

        //public User() 
        //{
        //    Messages = new string[1];
        //    Messages[0] = "Welcome";
        //}

        public User(int id,string username, string password, string messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }
        public void Login(string username, string password)
        {
            if(username == Username && password == Password)
            {
                Console.WriteLine($"Welcome {username}. Here are your messages: \n{Messages}");
            }
            else
            {
                Console.WriteLine("Error, incorrect password or username");
            }
        }
        public void Register(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
         }
    }
}
