using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega3
{
    public class RegisterEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}