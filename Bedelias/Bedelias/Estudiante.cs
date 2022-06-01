using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedelias
{
    class Estudiante: Persona
    {
        private int[] notas = new int[4];

        public int[] Notas { get => notas; set => notas = value; }
    }
}
