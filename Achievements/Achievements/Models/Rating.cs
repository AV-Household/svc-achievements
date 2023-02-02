namespace Achievements.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public int ratingPoints { get; set; }

        public Rating(int ID, int ratingPoints)
        {
            this.ID = ID;
            this.ratingPoints = ratingPoints;
        }
    }
}
