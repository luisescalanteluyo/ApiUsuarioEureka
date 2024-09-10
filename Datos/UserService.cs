using Datos.DB;
using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class UserService
    {
        public readonly AppDbContext _dbContext;

        public UserService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddUser(Usuario user)
        {
            await _dbContext.usuario.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Usuario> GetAllUser(string nombres)
        {
            return await _dbContext.usuario.FirstAsync(user => user.nombres == nombres);
            // .Include(user => user.Roles)
            //   .FirstOrDefaultAsync(user => user.nombres == name);
        }
    }
}








