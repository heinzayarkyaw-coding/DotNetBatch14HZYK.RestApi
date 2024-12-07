﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KpayTransferSystemHZYK.RestApi.Features.KpayTransfer
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase
    {
        private readonly UserService _userService;

        public DepositController()
        {
            _userService = new UserService();
        }

        [HttpPost]
        public IActionResult Deposit([FromBody] UserDepositModel requestModel)
        {
            var model = _userService.Deposit(requestModel);
            if (!model.IsSuccess)
            {
                return BadRequest(model);
            }
            return Ok(model);
        }
    }

}