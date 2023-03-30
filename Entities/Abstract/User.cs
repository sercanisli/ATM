using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public static class User
    {
        public static int UserNo { get; set; }
        public static int UserId { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static DateTime CreatedDate { get; set; }
    }
}
