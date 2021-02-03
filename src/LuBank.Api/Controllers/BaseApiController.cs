﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuBank.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseApiController: Controller
    {
    }
}
