namespace BookShare.Common.Dto.Response
{
    public class UserResponseDto
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string IsVerified { get; set; }
    }
}
