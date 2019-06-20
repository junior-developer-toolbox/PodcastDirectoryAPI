using System;
using System.ComponentModel.DataAnnotations;
using PodcastDirectoryAPI.Data;

namespace PodcastDirectoryAPI.Domain
{
    public class ContactInfo
    {
        public ContactInfo()
        {
        }
        [Key]
        public int ContactID { get; set; }

        public int PodcastID { get; set; }

        public string WebsiteURL { get; set; }

        public string FacebookPageURL { get; set; }

        public string TwitterPageURL { get; set; }

        public string InstagramHandle { get; set; }
    }
}
