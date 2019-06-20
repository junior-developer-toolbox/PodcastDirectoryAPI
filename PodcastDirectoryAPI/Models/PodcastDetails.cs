using System;
using System.ComponentModel.DataAnnotations;
using PodcastDirectoryAPI.Data;

namespace PodcastDirectoryAPI.Domain
{
    public class PodcastDetails
    {
        [Key]
        public int PodcastID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public int YearLaunched { get; set; }

        public string LogoPath { get; set; }

        //public bool Active { get; set; }
    }
}
