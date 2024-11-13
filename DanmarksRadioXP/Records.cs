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

        public void ValidateTitle()
        {
            if (Title == null) 
            {
                throw new ArgumentNullException("title is null");
            }
            if (Title.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Title must be atleast 3 charchters");
            }
        }

        public void ValidateArtist() 
        {
            if (Artist == null)
            {
                throw new ArgumentNullException("Artist is null");
            }
            if (Artist.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Artist must be atleast 3 charchters");
            }
        }

        public void ValidateDuration()
        {
            if (Duration < 1)
            {
                throw new ArgumentOutOfRangeException("Duration must be postive");
            }
        }

        public void ValidatePublicationYear()
        {
            if (PublicationYear > 2024)
            {
                throw new ArgumentOutOfRangeException("Title cant be later 2024"); 
            }
        }

        public void Validate()
        {
            ValidateTitle();
            ValidateArtist();
            ValidateDuration();
            ValidatePublicationYear();
        }



    }
}
