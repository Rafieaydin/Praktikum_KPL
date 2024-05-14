namespace Program;
using System.Text.Json;
using ConsoleApp1;
class Program {
    
    public static void Main(string[] args)
    {
        string jsonString = 

        // Deserialize the JSON string into a UserData object
        user userData = JsonSerializer.Deserialize<user>(jsonString);

        // Access properties using getters
        Console.WriteLine(userData.Name); // Output: joko
        Console.WriteLine(userData.Comment.Title); // Output: test

        // Modify properties using setters
        userData.Name = "Alice";
        userData.Comment.Title = "New comment";

        // Serialize back to JSON (optional)
        string newJsonString = JsonSerializer.Serialize(userData);

        
    }
}