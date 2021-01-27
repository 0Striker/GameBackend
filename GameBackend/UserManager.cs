using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class UserManager
    {
        public void AddAdmin(Admin admin)
        {
            Console.WriteLine("Yeni Admin Eklendi...: " + admin.Name);
        }
        public Admin DeleteAdmin(Admin admin)
        {
            admin.Authority = "Üye";
            Console.WriteLine(admin.Name +" İsimli Admin Silindi! Yeni Rol...: "+ admin.Authority);
            return admin;
        }
        
        public void AddDefaultUser(DefaultUser defaultUser)
        {
            Console.WriteLine("Yeni Kullanıcı Eklendi...: " + defaultUser.Name);
        }
        public void DeleteDefaultUser(DefaultUser defaultUser)
        {
            Console.WriteLine(defaultUser.Name+ " İsimli Kullanıcı Silindi!");
        }
        public void UpdateDefaultUser(DefaultUser defaultUser)
        {
            Console.WriteLine(defaultUser.Name + " İsimli Kullanıcının Bilgileri Güncellendi!");
        }
        public DefaultUser MakeAdmin(DefaultUser defaultUser)
        {
            defaultUser.Authority = "'Admin - Eğitmen'";
            Console.WriteLine(defaultUser.Name+" İsimli Kullanıcıya " + defaultUser.Authority+" Rolü Başarıyla Verilidi");
            return defaultUser;
        }

    }
}
