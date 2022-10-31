using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Business.BL
{
    class AccountsBL
    {
        private readonly SignInManager<StoreUser> _signInManager;
        private readonly UserManager<StoreUser> _userManager;
    }
}
