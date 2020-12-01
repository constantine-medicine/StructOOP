using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructOOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Note[] notes = new Note[0];
            int counter = 0;

            while (true)
            {
                Array.Resize(ref notes, counter + 1);

                WriteLine("Введите дату заметки: ");
                DateTime date = new DateTime(long.Parse(ReadLine()));

                WriteLine("Автор заметки: ");
                string author = Convert.ToString(ReadLine());

                WriteLine("Текст заметки: ");
                string text = Convert.ToString(ReadLine());

                if (notes[counter].Date == date)
                {
                    notes[counter].Body += $"\n{text}";
                }
                notes[counter] = new Note(date, author, text);

                counter++;

                if (counter == 3)
                {
                    break;
                }
            }

            Organizer org = new Organizer(notes);

            for (int i = 0; i < org.Notes.Length; i++)
            {
                WriteLine(org.Notes[i].Print());
            }

            
            
            

            Console.ReadKey();
        }
    }
}
