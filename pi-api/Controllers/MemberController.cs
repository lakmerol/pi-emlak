using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using pi_api.Response;
using System.Text.Json.Nodes;

namespace pi_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly AgentService _agentService;
        private readonly CustomerService _customerService;
        private readonly EstateService _estateService;
        public MemberController(AgentService agentService, CustomerService customerService, EstateService estateService)
        {
            _agentService = agentService;
            _customerService = customerService;
            _estateService = estateService;

        }
        [HttpGet(Name = "Member")]
        public MemberResponse Get()
        {
            return new MemberResponse()
            {
                Message = "Succesfully Sended",
                Status = true,
                Members = null
            };
        }
        [HttpPost(Name = "Member")]
        public MemberResponse Post(MemberDTO member)
         {
            try
            {
                _customerService.AddUser(member);
            }
            catch (Exception)
            {

                return new MemberResponse()
                {
                    Message = "Succesfully Added",
                    Status = true,
                    Members = null
                };
            }
            return new MemberResponse()
            {
                Message = "Succesfully Added",
                Status = true,
                Members = null
            };

        }
        [HttpDelete(Name = "Member")]
        public MemberResponse Delete()
        {
            return new MemberResponse()
            {
                Message = "Succesfully Deleted",
                Status = true,
                Members = null
            };
        }
       
    }
}
