using Microsoft.AspNetCore.Mvc;
using workeshope_bank.Entity;

namespace workeshope_bank.Controllers
{
    public class CarditCardController : Controller
    {
        public OwnerShiptotal shiptotals = new OwnerShiptotal();
        public IActionResult Index(List<CarditCard> cards)
        {
            return View(shiptotals.GetAllCard());
        }
       
    }
}
