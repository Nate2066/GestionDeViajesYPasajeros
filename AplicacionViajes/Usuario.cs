﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionViajes
{
    public class Usuario
    {
        public string userName {  get; set; }
        public string password { get; set; }
        public Usuario(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
