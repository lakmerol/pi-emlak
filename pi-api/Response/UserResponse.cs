
namespace pi_api.Response
{
    public class UserResponse
    {
        public UserResponse()
        {
            IsExists = false;
            UserID = 0;
        }
        public bool IsExists { get; set; }
        public int UserID { get; set; }
    }
}
