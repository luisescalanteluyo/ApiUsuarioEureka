using Datos;
using Datos.DB;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioLogica
    {
        public Usuario UsuariosById(int id)
        {
            Usuario user = null;

            using (AppDbContext context = new AppDbContext())
            {
                if (context.usuario.Any(d => d.id == id)) {
                    user = context.usuario.First(d => d.id == id);
                }                  
            }

            return user;
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> employees = null;

            using (AppDbContext context = new AppDbContext())
            {
                employees = context.usuario.ToList();
            }

            return employees;
        }

        public Usuario GrabarUsuario(Usuario value) {


            using (AppDbContext context = new AppDbContext())
            {

                value.nombrecompleto = value.nombres +" "+ value.apellidos ;
                value.fechahora = DateTime.UtcNow;
                value.edad = 18;


                context.usuario.Add(value);
                int iResult = context.SaveChanges();
            }

            return value;
        
        }
        public Usuario ActualizarUsuario(Usuario value)
        {

            using (AppDbContext context = new AppDbContext())
            {
                value.nombrecompleto = value.nombres + " " + value.apellidos;
                value.fechahora = DateTime.UtcNow;
                value.fechahoramodificacion = DateTime.UtcNow;
                value.edad = 18;

                context.usuario.Update(value);
                int iResult = context.SaveChanges();
            }

            return value;

        }


    }
}
