using InstaCompare.Services;
using InstaCompare.Models;

class Program
{
    // use FollowerReader.FollowerReader() to get the array of followers
    static void Main(string[] args)
    {
        try
        {
            // get the array of followers from the service
            UserModel[] followers = FollowerReader.FollowerReader();
            // loop and print the followers
            foreach (UserModel follower in followers)
            {
                Console.WriteLine(follower.title);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}