using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructOOP1
{
    public struct Organizer
    {
        /// <summary>
        /// База заметок
        /// </summary>
        public Note[] Notes;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Args">Заметка</param>
        public Organizer(params Note[] Args)
        {
            Notes = Args;
        }
    }
}
