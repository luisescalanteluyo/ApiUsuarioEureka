using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        [Key]
      //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; } //= DateTimeOffset.Now.ToUnixTimeMilliseconds();

        [StringLength(100)]
        public string? nombres { get; set; }

        [StringLength(200)]
        public string? apellidos { get; set; }

        [StringLength(300)]
        public string? nombrecompleto { get; set; }

        [StringLength(8)]
        public string? nrodocumentoidentidad { get; set; }

        [StringLength(250)]
        public string? correoelectronico { get; set; }

        [StringLength(50)]
        public string? fechanacimiento { get; set; }
        
        public int? edad { get; set; }

        public DateTime? fechahora { get; set; }

        public DateTime? fechahoramodificacion { get; set; }

    }
}
