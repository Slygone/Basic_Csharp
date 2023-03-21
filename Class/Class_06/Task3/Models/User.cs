
namespace Task3.Models
{
  public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string[] Messages { get; set; }

    public User(int id, string username, string password)
    {
        Id = id;
        Username = username;
        Password = password;
        Messages = new string[] {
            "Hello",
            "Goodbye",
            "Welcome"
        };
    }

    //public void AddMessage(string message)
    //{
    //    Array.Resize(ref Messages, Messages.Length + 1);
    //    Messages[Messages.Length - 1] = message;
    //}

}
}
