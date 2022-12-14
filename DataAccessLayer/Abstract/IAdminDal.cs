using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IAdminDal
    {
        List<Admin> GetAllAdmins();
        void SaveAdmin(Admin admin);
        void DeleteAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        Admin GetAdminById(int id);
    }
}

