using Microsoft.AspNetCore.Mvc;
using AdminService.Services;
using AdminService.Models;


namespace AdminService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _Adminservice;

        public AdminController(IAdminService adminService)
        {
            _Adminservice = adminService;
        }

        [HttpGet("GetAdmins")]
        public IEnumerable<Admin> GetAdmins()
        {
            return _Adminservice.GetAdminList();  
        }
        [HttpGet("GetAdmin")]
        public Admin GetAdmin(int id) {
            return _Adminservice.GetAdminById(id);
        }
        [HttpPost("AddAdmin")]
        public Admin AddAdmin(Admin admin) {
            var res= _Adminservice.AddAdmin(admin);
            return res;
        }
        [HttpPut("UpdateAdmin")]
        public Admin UpdateAdmin(Admin admin)
        {
            var res= _Adminservice.UpdateAdmin(admin);
            return res;
        }
        [HttpDelete("DeleteAdmine")]
        public bool DeleteAdmine(int id) {
            return _Adminservice.DeleteAdmin(id);   
        }

        
    }
}
