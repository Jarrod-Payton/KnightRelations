using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using KnightRelations.Models;
using KnightRelations.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnightRelations.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CastleController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<Castle>> Get()
    {
      try
      {

      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}