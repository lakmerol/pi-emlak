using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using pi_api.Response;
using System.Text.Json.Nodes;

namespace pi_api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SignInController : ControllerBase
    {
        private readonly AgentService _agentService;
        private readonly CustomerService _customerService;
        private readonly EstateService _estateService;
        public SignInController(AgentService agentService, CustomerService customerService, EstateService estateService)
        {
            _agentService = agentService;
            _customerService = customerService;
            _estateService = estateService;

        }
        [HttpGet(Name = "SignIn")]
        public MemberResponse Get()
        {
            return new MemberResponse()
            {
                Message = "Succesfully Sended",
                Status = true,
                Members = null
            };
        }
        [HttpPost(Name = "SignIn")]
        public UserResponse Post(RequestDTO user)
         {

            bool IsCustomer = _customerService.IsExistEmailAndPass(user.MailAdress, user.Password);
            bool IsAgent = _agentService.IsExitsByEmailAndPass(user.MailAdress, user.Password);
            if (IsCustomer)
            {
                int id = _customerService.GetByEmailAndPass(user.MailAdress, user.Password).Id;
                return new UserResponse()
                {
                    UserID = id,
                    IsExists = true
                };
            }
            else if (IsAgent)
            {
                int id = _agentService.GetByEmailAndPass(user.MailAdress, user.Password).Id;
                return new UserResponse()
                {
                    UserID = id,
                    IsExists = true
                };
            }

            return new UserResponse()
            {
                UserID = 0,
                IsExists = false
                };
          


        }
    }
}
