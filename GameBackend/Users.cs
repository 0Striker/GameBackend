using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class User
    {
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Authority { get; set; }
    }
    class DefaultUser:User
    {
        public int Id { get; set; }
        public string DateOfBirth { get; set; }
    }
    class Admin:User
    {
        public string DateOfJoin { get; set; }
    }
}
