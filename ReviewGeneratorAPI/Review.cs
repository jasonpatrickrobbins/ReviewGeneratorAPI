using System;
namespace ReviewGeneratorAPI
{
    public class Review
    {
        public int StarRating { get; set; }
        public string Overall { get; set; }
        public bool Verified { get; set; }
        public string ReviewTime { get; set; }
        public string ReviewerID { get; set; }
        public string ASIN { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewText { get; set; }
        public string Summary { get; set; }
    }
}
