namespace BookShare.Common.RequestFeature
{
    public class UserRequestParameters:RequestParameters
    {
        public UserRequestParameters()
        {
            OrderBy = "firstname";
        }
        public DateTime MinJoinDate { get; set; } = DateTime.MinValue;
        public DateTime MaxJoinDate { get; set; } = DateTime.MaxValue;
        public bool IsValidDate => MaxJoinDate >= MinJoinDate;
    }
}
