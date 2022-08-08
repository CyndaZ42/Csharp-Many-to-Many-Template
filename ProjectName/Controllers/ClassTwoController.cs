using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
  public class ClassTwoController : Controller
  {
    private readonly ProjectNameContext _db;

    public ClassTwoController(ProjectNameContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.ClassTwos.ToList());
    }
  }
}