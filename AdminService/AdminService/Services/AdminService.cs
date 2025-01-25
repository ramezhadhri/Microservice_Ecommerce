using AdminService.Data;
using AdminService.Models;

namespace AdminService.Services
{
    public class AdminService:IAdminService
    {
        protected readonly  DbContextClassy _dbcontext;
        public AdminService(DbContextClassy dbcontext)
        {
           _dbcontext = dbcontext;
        }
        public IEnumerable<Admin> GetAdminList() {
            return _dbcontext.Admins.ToList();
        
        }
        public Admin GetAdminById(int id) {
            return _dbcontext.Admins.Where(x=>x.AdminId == id).FirstOrDefault();
        }
        public Admin GetAdminByName(string name)
        {
            return _dbcontext.Admins.Where(x => x.AdminName == name).FirstOrDefault();
        }
        public Admin AddAdmin(Admin admin) { 
             var res=_dbcontext.Admins.Add(admin);
            _dbcontext.SaveChanges();
            return res.Entity;
        }
        public Admin UpdateAdmin(Admin admin) {
            var res = _dbcontext.Admins.Update(admin);
            _dbcontext.SaveChanges();
            return res.Entity;
        }
        public bool DeleteAdmin(int id) {
            var res = _dbcontext.Admins.Where(x => x.AdminId == id).FirstOrDefault();
            _dbcontext.Remove(res);
            _dbcontext.SaveChanges();
            return res != null ? true : false;
        }



    }
}
