using BlazorCliente.Client.Pages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCliente.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ShopController
    {
            

            private readonly ILogger<ShopController> _logger;

            public ShopController(ILogger<ShopController> logger)
            {
                _logger = logger;
            }

            [HttpGet]
            public IEnumerable<Shop> Get()
            {
            return null;

            }
        }
    }

