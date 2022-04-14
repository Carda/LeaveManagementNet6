using AutoMapper;
using LeaveManagementWeb.Configuration.Contracts;
using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementWeb.Controllers
{
    public class EmployeesController : Controller
    {
        public UserManager<Employee> UserManager { get; }
        public IMapper Mapper { get; }
        public ILeaveAllocationRepository LeaveAllocationRepository { get; }
        public ILeaveTypeRepository LeaveTypeRepository { get; }

        public EmployeesController(UserManager<Employee> userManager,
            IMapper mapper,
            ILeaveAllocationRepository leaveAllocationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            UserManager = userManager;
            Mapper = mapper;
            LeaveAllocationRepository = leaveAllocationRepository;
            LeaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees = await UserManager.GetUsersInRoleAsync(Roles.User);
            var model = Mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await LeaveAllocationRepository.GetEmployeeAllocations(id);
            return View(model);
        }


        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await LeaveAllocationRepository.GetEmployeeAllocation(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (await LeaveAllocationRepository.UpdateEmployeeAllocation(model))
                    {
                        return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId }); 
                    }
                    
                }
            }
            catch
            {
                ModelState.AddModelError(string.Empty, "An Error has Occurred. Please try again later.");
            }
            model.Employee = Mapper.Map<EmployeeListVM>(await UserManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = Mapper.Map<LeaveTypeVM>(await LeaveTypeRepository.GetAsync(model.leavaTypeId));
            return View(model);
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
