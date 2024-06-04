namespace SpaDay6;

public class User
{
    public int Id { get; }

    public int nextId = 1;
    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public User() 
    {
        Id = nextId;
        nextId++;
    }

    public User(string username, string email, string password) : this()
    {
        UserName = username;
        Email = email;
        Password = password;
    }

    public override string ToString()
    {
        return UserName;
    }

    public override bool Equals(object? obj)
    {
        return obj is User @user && Id == @user.Id;
        
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}
