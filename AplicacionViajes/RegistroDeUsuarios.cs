using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionViajes
{
    public class RegistroDeUsuarios
    {
        public List<Usuario> usuariosRegistrados = new List<Usuario>() {new Usuario("user", "123") };

        public bool _IniciarSesion(TextBox pUserName, TextBox pPassword)
        {
            foreach(var user in usuariosRegistrados)
            {
                if(user.userName == pUserName.Text && user.password == pPassword.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool _RegistrarNuevoUsuario(TextBox pUserName, TextBox pPassWord)
        {
            if(pUserName.Text != "")
            {
                if(pPassWord.Text != "")
                {
                    if (usuariosRegistrados.Count == 0)
                    {
                        return true;
                    }
                    else
                    {
                        foreach(var user in usuariosRegistrados)
                        {
                            if(user.userName == pUserName.Text && user.password == pPassWord.Text)
                            {
                                return false;
                            }
                            
                        }
                        usuariosRegistrados.Add(new Usuario(pUserName.Text, pPassWord.Text));
                        return true;
                    }
                }
                else
                {
                    pPassWord.Focus();
                    return false;
                }
            }
            else
            {
                pUserName.Focus();
                return false;
            }
        }
    }
}
