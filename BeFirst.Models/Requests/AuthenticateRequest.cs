using System;
using System.Collections.Generic;
using System.Text;

namespace BeFirst.Models.Requests
{
    public class AuthenticateRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int KorisnikId { get; set; }
    }
}
