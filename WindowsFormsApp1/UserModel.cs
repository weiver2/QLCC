using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserModel
    {
        public string full_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string address { get; set; }
        public string image { get; set; }
        public string remember_token { get; set; }
        public int created_by { get; set; }
        public DateTime create_at { get; set; }
        public int updated_by { get; set; }
        public DateTime updated_at { get; set; }
        public int deleted_by { get; set; }
        public DateTime deleted_at { get; set; }
    }
}
