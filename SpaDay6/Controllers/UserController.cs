using Microsoft.AspNetCore.Mvc;


namespace SpaDay6.Controllers;
public class UserController : Controller
{
    public IActionResult Index()
    {
        
        return View();
    }
   [HttpGet]
    //[Route("/spa/user")]
    public IActionResult Add(User newUser) //TAKE NOTE
    {
        return View("add");
    }
    [HttpPost]
   public IActionResult SubmitAddUserForm(User newUser, string verify) 
   {

       if (newUser.Password != verify)
       {
        return View("add");
       }
       else
       {
        ViewBag.username = newUser.UserName;
        
        return View("Index");
       }
       
    
    //   add form submission handling code here
        
   }
}

