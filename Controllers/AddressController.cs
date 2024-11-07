using Microsoft.AspNetCore.Mvc;
using MNJ_CRUD_OPERATION_FINAL.Models;
using MNJ_CRUD_OPERATION_FINAL.Repository;

namespace MNJ_CRUD_OPERATION_FINAL.Controllers
{
    public class AddressController : Controller
    {
        private readonly IGenericRepo<AddressModel> genericRepo;

        public AddressController(IGenericRepo<AddressModel> genericRepo)
        {
            this.genericRepo = genericRepo;
        }

        [HttpGet]
        public IActionResult Index() // Removed async and Task<IActionResult>
        {
            return View(new AddressModel()
            {
                employeeId = 0,
                HouseNumber = string.Empty,
                LocalityCity = string.Empty,
                State = string.Empty,
                pincode = string.Empty,
                PeriodOfStay = string.Empty,
                Telephone = string.Empty,
                MobileNumber = string.Empty,
                EmailId = string.Empty,
                InstantMessagingSystemID = string.Empty,
            });
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress(AddressModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await genericRepo.AddAsync(model); // Asynchronous database call
                    TempData["success"] = "Address Data Added Successfully";
                    return RedirectToAction("Passport");
                }
                catch (Exception ex)
                {
                    TempData["error"] = "An error occurred while processing your request." + ex;
                    // Log the exception here
                }
            }
            return View(model);
        }

        public IActionResult Passport() // Removed async and Task<IActionResult>
        {
            return View("Views/Passport/Index.cshtml");
        }
    }
}
