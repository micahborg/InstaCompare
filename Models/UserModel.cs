// Model class that represents a user

namespace InstaCompare.Models
{
    public class UserModel
    {
        public string title { get; set; }
        public List<MediaModel> media_list_data { get; set; }
        public List<StringModel> string_list_data { get; set; }
    }

    public class MediaModel
    {
        public string href { get; set; }
        public string value { get; set; }
        public int timestamp { get; set; }
    }

    public class StringModel
    {
        public string href { get; set; }
        public string value { get; set; }
        public int timestamp { get; set; }
    }
}


