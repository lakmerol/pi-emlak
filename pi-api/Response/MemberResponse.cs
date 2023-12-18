using BLL.DTOs;

namespace pi_api.Response
{
    public class MemberResponse
    {
        public MemberResponse()
        {
            Status = false;
            Message = String.Empty;
            Members = null;
        }
        public bool Status { get; set; }
        public string Message { get; set; }
        public IEnumerable<MemberDTO> Members { get; set; }
    }
}
