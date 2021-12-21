﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.UserAccountFeatures.Commands;
using Application.Model.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1
{
    /// <summary>
    /// 
    /// </summary>
    [ApiVersion("1.0")]
    public class UserAccountController : BaseApiController
    {
        /// <summary>
        /// Register  New User.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser(CreateUserAccountCommand command)
        {
            var obj = await Mediator.Send(command);
            return StatusCode(obj.StatusCode, new { UserId = (string)obj.Data, Message = obj.Messege });
        }
        /// <summary>
        /// Create new admin user.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("CreateAdmin")]
        public async Task<IActionResult> CreateAdmin(CreateAdminUserAccountCommand command)
        {
            var obj = await Mediator.Send(command);
            return StatusCode(obj.StatusCode, new { Data = (JWTTokenModel)obj.Data, Message = obj.Messege });
        }
        /// <summary>
        /// Create new admin user.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("UserLogin")]
        public async Task<IActionResult> UserLogin(LoginCommand command)
        {
            var obj = await Mediator.Send(command);
            return StatusCode(obj.StatusCode, new { Data =(JWTTokenModel) obj.Data, Message = obj.Messege });
        }
    }
}