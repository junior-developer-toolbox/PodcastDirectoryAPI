using System;
using System.ComponentModel.DataAnnotations;
using PodcastDirectoryAPI.Data;

namespace PodcastDirectoryAPI.Data
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int PodcastID { get; set; }
    }
}
