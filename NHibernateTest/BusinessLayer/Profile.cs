using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateTest.BusinessLayer
{
    public class Profile
    {
        private string _name;
        private string _bio;
        private byte[] _profileImage;

        public string Name { get => _name; set => _name = value; }
        public string Bio { get => _bio; set => _bio = value; }
        public byte[] ProfileImage { get => _profileImage; set => _profileImage = value; }

        public Profile() { }
    }
}