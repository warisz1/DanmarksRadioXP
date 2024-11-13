using System.Net.Http.Headers;

namespace DanmarksRadioXP
{
    public class Records
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public Records(int id, string title, string artist, int duration, int publicationYear)
        {
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public Records()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Title)}={Title}, {nameof(Artist)}={Artist}, {nameof(Duration)}={Duration.ToString()}, {nameof(PublicationYear)}={PublicationYear.ToString()}}}";
        }

    }
}
