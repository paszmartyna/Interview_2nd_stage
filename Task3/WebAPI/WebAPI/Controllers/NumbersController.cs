﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class NumbersController : Controller
    {
        [HttpGet("{id}")]
        public int GetData(int id)
        {
            return 2 * id;
        }
    }
}
