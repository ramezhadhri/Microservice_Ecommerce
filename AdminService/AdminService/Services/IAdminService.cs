using AdminService.Models;

namespace AdminService.Services
{
    public interface IAdminService
    {
        Admin AddAdmin(Admin admin);
        bool DeleteAdmin(int id);
        Admin GetAdminById(int id);
        IEnumerable<Admin> GetAdminList();
        Admin UpdateAdmin(Admin admin);

        public interface IAdminService
        {
          public  IEnumerable<Admin> GetAdminList();
            public Admin GetAdminById(int id);
            public Admin GetAdminByName(string name);
            public Admin AddAdmin(Admin admin);
            public Admin UpdateAdmin(Admin admin);
            public bool DeleteAdmin(int id);
        }


    }
}
