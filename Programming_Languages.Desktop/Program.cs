using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming_Languages.Entities;
using Programming_Languages.Database;
using System.Data.Entity;


namespace Programming_Languages.Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingLanguagesDatabase db = new ProgrammingLanguagesDatabase();

            var languages = db.ProgrammingLanguages;

            //Print all data from database

            //Method syntax

            languages.OrderBy(pl=>pl.Name).ToList().ForEach(pl => Console.WriteLine($"\t{pl.Name}, {pl.ListChiefDeveloper}, {pl.ListPredecessors}, {pl.Year}"));

            //Query syntax

            var printAllLanguages = from l in languages
                                    orderby l.Name
                                    select l;

            foreach (var lang in printAllLanguages)
            {   
            Console.WriteLine($"\t{ lang.Name}, {lang.ListChiefDeveloper}, {lang.ListPredecessors}, {lang.Year}");
            }

            //-------------------------------------------------------------------------------------------------------------------

            //a query that returns a string for each language, includes the year, name, and chief developer of each language.

            //method syntax

            languages.OrderBy(pl=>pl.Name).AsEnumerable().Select(pl => $"\t{pl.Year} - {pl.Name} - {pl.ListChiefDeveloper}")
                     .ToList().ForEach(pl => Console.WriteLine(pl));

            //Query syntax

            var returnString = from l in languages.AsEnumerable()
                               orderby l.Name
                               select $"\t{l.Year} - {l.Name} - {l.ListChiefDeveloper}";

            foreach (var lang in returnString)
            {
                Console.WriteLine(lang);
            }

            //------------------------------------------------------------------------------------------

            //Find the language with the name "C#".

            //Method syntax

            languages.Where(pl => pl.Name.Contains("C#"))
                     .ToList().ForEach(pl => Console.WriteLine($"\t{pl.Name} - {pl.ListChiefDeveloper} - {pl.ListPredecessors} - {pl.Year}"));

            //Query syntax

            var findCSharp = from l in languages
                             where l.Name.Contains("C#")
                             select l;

            foreach (var langcsharp in findCSharp)
            {
                Console.WriteLine($"\t{langcsharp.Name} - {langcsharp.ListChiefDeveloper} - {langcsharp.ListPredecessors} - {langcsharp.Year}");
            }

            //----------------------------------------------------------------------------------------------------------------------------------------

            //Find all of the languages that descend from Lisp.

            //method syntax

            languages.OrderBy(pl=>pl.Name).Where(pl => pl.ListPredecessors.Contains("Lisp"))
                     .ToList().ForEach(pl => Console.WriteLine($"\t{pl.Name} - {pl.ListChiefDeveloper} - {pl.ListPredecessors} - {pl.Year}"));


            //Query syntax

            var descendentsOfLangLisp = from l in languages
                                        orderby l.Name
                                        where l.ListPredecessors.Contains("Lisp")
                                        select l;

            foreach (var langlisp in descendentsOfLangLisp)
            {
                Console.WriteLine($"\t{langlisp.Name} - {langlisp.ListChiefDeveloper} - {langlisp.ListPredecessors} - {langlisp.Year}");
            }

            //=================================================================================================================================

            //Find all of the language names that contain the word "Script"(capital S)

            //Method syntax

            languages.OrderBy(pl=>pl.Name).Where(pl => pl.Name.Contains("Script"))
                     .Select(pl => pl.Name).ToList()
                     .ForEach(pl => Console.WriteLine("\t{0}",pl));

            var scripts = from l in languages
                          orderby l.Name
                          where l.Name.Contains("Script")
                          select l.Name;

            foreach (var s in scripts)
            {
                Console.WriteLine("\t{0}",s);
            }

            //==========================================================================================================================

            //How many languages were launched between 1995 and 2005?

            //Method syntax

            var langsfrom1995_2005 = languages.Count(pl => pl.Year >= 1995 && pl.Year <= 2005);
            Console.WriteLine(langsfrom1995_2005);

            languages.OrderBy(pl=>pl.Name).AsEnumerable().Where(pl=>pl.Year>=1995 && pl.Year<=2005).Select(pl => $"\t{pl.Name} was invented in {pl.Year}")
                     .ToList().ForEach(pl => Console.WriteLine(pl));

            //Query syntax

            var alterlangsfrom1995_2005 = (from l in languages
                                           where l.Year >= 1995 && l.Year <= 2005
                                           select l).Count();

            Console.WriteLine(langsfrom1995_2005);

            var langsfrom1995to2005 = from l in languages.AsEnumerable()
                                      orderby l.Name
                                      where l.Year >= 1995 && l.Year <= 2005
                                      select $"\t{l.Name} was invented in {l.Year}";

            foreach (var pl in langsfrom1995to2005)
            {
                Console.WriteLine(pl);
            }

            Console.ReadKey();
        }
    }
}
