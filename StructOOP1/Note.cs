using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructOOP1
{
    public class Note
    {
        /// <summary>
        /// Дата выполнения заметки
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// Автор заметки
        /// </summary>
        public string Author;

        /// <summary>
        /// Заголовок заметки
        /// </summary>
        public string Heading;

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string Body;

        /// <summary>
        /// Дата добавления заметки
        /// </summary>
        public DateTime DateAdd;

        /// <summary>
        /// Конструктор создания заметки
        /// </summary>
        /// <param name="Date">Дата выполнения заметки</param>
        /// <param name="Author">Автор заметки</param>
        /// <param name="Heading">Заголовок заметки</param>
        /// <param name="Body">Текст заметки</param>
        /// <param name="DateAdd">Дата добавления заметки</param>
        public Note(DateTime Date, string Author, string Heading, string Body, DateTime DateAdd)
        {
            this.Date = Date;
            this.Author = Author;
            this.Heading = Heading;
            this.Body = Body;
            this.DateAdd = DateTime.Now;
        }

        /// <summary>
        /// Конструктор создания заметки
        /// </summary>
        /// <param name="Date">Дата выполнения заметки</param>
        /// <param name="Author">Автор заметки</param>
        /// <param name="Heading">Заголовок заметки</param>
        /// <param name="Body">Текст заметки</param>
        public Note(DateTime Date, string Author, string Heading, string Body) :
            this(Date, Author, Heading, Body, DateTime.Now)
        {

        }

        /// <summary>
        /// Конструктор создания заметки
        /// </summary>
        /// <param name="Date">Дата выполнения заметки</param>
        /// <param name="Author">Автор заметки</param>
        /// <param name="Body">Текст заметки</param>
        public Note(DateTime Date, string Author, string Body) :
            this(Date, Author, "Без темы", Body, DateTime.Now)
        {

        }

        /// <summary>
        /// Получение информации о заметке
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{Date}\n{Author}\n{Heading}\n{Body}\n{DateAdd}\n";
        }
    }
}
