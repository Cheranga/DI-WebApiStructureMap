using System;

namespace DI_WebApiStructureMap.DAL
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }
        public string Director { get; set; }
    }
}