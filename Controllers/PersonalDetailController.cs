using Microsoft.AspNetCore.Mvc;
using MNJ_CRUD_OPERATION_FINAL.Models;
using MNJ_CRUD_OPERATION_FINAL.Repository;

namespace MNJ_CRUD_OPERATION_FINAL.Controllers
{
    public class PersonalDetailController : Controller
    {
        private readonly IGenericRepo<EmployeeModel> genericRepo;

        public PersonalDetailController(IGenericRepo<EmployeeModel> genericRepo)
        {
            this.genericRepo = genericRepo;
        }
        public IActionResult Index()
        {
                return View(new EmployeeModel()
                {
                    EmployeeName = string.Empty,
                    EmployeeDepartment = string.Empty,
                    EmployeeSalary = string.Empty,
                    FatherName = string.Empty,
                    Nationality = string.Empty,
                    sex = string.Empty,
                    Martial_Status = string.Empty,
                    Pan_card_number = string.Empty,
                    Date_of_Birth = string.Empty,
                    Place_of_Birth = string.Empty,
                    Nationality_2 = string.Empty,
                    Social_Security_Number = string.Empty

                });
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await genericRepo.AddAsync(model);
                    TempData["success"] = "Employee Data Added Successfully";
                    
                    return RedirectToAction("Address");
                }
                catch (Exception ex)
                {
                    TempData["error"] = "An error occurred while processing your request."+ ex;
                    // Log the exception here
                }
            }
            return View(model);
        }

        public IActionResult Address()
        {
            return View("Views/Address/Index.cshtml");
        }
    }
}
