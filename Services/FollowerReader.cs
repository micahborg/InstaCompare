using System.IO;
using Newtonsoft.Json;
using InstaCompare.Models;


namespace InstaCompare.Services
{ 
    public class FollowerReader
    {
        public static UserModel[] FollowerReader()
        {
            string json = File.ReadAllText("followers_and_following/followers_1.json");
            UserModel[] followers = JsonConvert.DeserializeObject<UserModel[]>(json);
            return followers;
        }
        else
        {
            throw new FileNotFoundException("File not found.");
        }
    }
}