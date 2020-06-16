using System;
using System.Collections.Generic;
using System.Linq;
using dotnet1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace dotnet1.Controllers
{
  public class LoginController : Controller
  {

    public IActionResult Login(){
        return View();
    }

    public LoginController(ClicknextDBContext _DatabaseContext){
        IEnumerable<UserInfo> data = _DatabaseContext.UserInfo.ToList();
    }
  }
}