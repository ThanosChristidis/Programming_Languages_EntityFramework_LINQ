namespace Programming_Languages.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Programming_Languages.Entities;
    using Programming_Languages.Database;

    internal sealed class Configuration : DbMigrationsConfiguration<ProgrammingLanguagesDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProgrammingLanguagesDatabase context)
        {
            //===================================== LANGUAGES' SEED =================================================================

            ProgrammingLanguage pl1 = new ProgrammingLanguage() { Name = "Haskell", ListChiefDeveloper =  "multiple",  ListPredecessors = "Miranda"  , Year = 1990 };
            ProgrammingLanguage pl2 = new ProgrammingLanguage() { Name = "EuLisp", ListChiefDeveloper = "multiple" , ListPredecessors = "Common Lisp , Scheme" , Year = 1990 };
            ProgrammingLanguage pl3 = new ProgrammingLanguage() { Name = "Visual Basic", ListChiefDeveloper = "Alan Cooper" , ListPredecessors = "QuickBASIC" , Year = 1991 };
            ProgrammingLanguage pl4 = new ProgrammingLanguage() { Name = "AppleScript", ListChiefDeveloper = "Apple Computer Inc.", ListPredecessors = "HyperTalk" , Year = 1993 };
            ProgrammingLanguage pl5 = new ProgrammingLanguage() { Name = "R", ListChiefDeveloper = "Robert Gentleman" , ListPredecessors =  "S" , Year = 1993 };
            ProgrammingLanguage pl6 = new ProgrammingLanguage() { Name = "NewtonScript", ListChiefDeveloper = "Walter Smith" , ListPredecessors = "Self, Dylan" , Year = 1993 };
            ProgrammingLanguage pl7 = new ProgrammingLanguage() { Name = "Java", ListChiefDeveloper = "James Gosling (Sun Microsystems)" , ListPredecessors = "C, Simula, C++, SmallTalk, Objective-C" , Year = 1995 };
            ProgrammingLanguage pl8 = new ProgrammingLanguage() { Name = "LiveScript", ListChiefDeveloper = "Brendan Eichat (NetScape)" , ListPredecessors = "Self, C, Scheme" , Year = 1995 };
            ProgrammingLanguage pl9 = new ProgrammingLanguage() { Name = "PHP", ListChiefDeveloper = "Rasmus Lerdorf" , ListPredecessors = "Perl" , Year = 1995 };
            ProgrammingLanguage pl10 = new ProgrammingLanguage() { Name = "Ruby", ListChiefDeveloper = "Yukihiro Matsumoto" , ListPredecessors = "SmallTalk, Perl" , Year = 1995 };
            ProgrammingLanguage pl11 = new ProgrammingLanguage() { Name = "JavaScript", ListChiefDeveloper = "Brendan Eichat(NetScape)" , ListPredecessors = "LiveScript" , Year = 1995 };
            ProgrammingLanguage pl12 = new ProgrammingLanguage() { Name = "Perl", ListChiefDeveloper = "Larry Wall" , ListPredecessors = "BASIC, C, C++, Lisp" , Year = 1987 };
            ProgrammingLanguage pl13 = new ProgrammingLanguage() { Name = "C", ListChiefDeveloper = "Dennis Ritchie , Bell Labs" , ListPredecessors =  "FORTRAN , ALGOL 68, Assembly" , Year = 1972 };
            ProgrammingLanguage pl14 = new ProgrammingLanguage() { Name = "Objective-C", ListChiefDeveloper = "Tom Love, Brad Cox" , ListPredecessors = "C, SmallTalk" , Year = 1984 };
            ProgrammingLanguage pl15 = new ProgrammingLanguage() { Name = "C++", ListChiefDeveloper = "Bjarne Stroustrup" , ListPredecessors = "C, Simula, ALGOL 68, ML, SmallTalk" , Year = 1985 };
            ProgrammingLanguage pl16 = new ProgrammingLanguage() { Name = "C#", ListChiefDeveloper = "Anders Hejlsberg (Microsoft, ECMA)" , ListPredecessors = "C, C++, Java, Delphi" , Year = 2000 };
            ProgrammingLanguage pl17 = new ProgrammingLanguage() { Name = "Visual Basic .NET", ListChiefDeveloper = "Microsoft" , ListPredecessors =  "Visual Basic" , Year = 2001 };
            ProgrammingLanguage pl18 = new ProgrammingLanguage() { Name = "Scala", ListChiefDeveloper = "Martin Odersky" , ListPredecessors = "Smalltalk, Java, Haskell, Standard ML, OCaml" , Year = 2003 };
            ProgrammingLanguage pl19 = new ProgrammingLanguage() { Name = "F#", ListChiefDeveloper = "Don Syme (Microsoft Research)" , ListPredecessors = "OCaml, C#, Haskell" , Year = 2005 };
            ProgrammingLanguage pl20 = new ProgrammingLanguage() { Name = "Cobra", ListChiefDeveloper =  "ChuckEsterbrook" , ListPredecessors = "Python, C#, Eiffel, Objective-C" , Year = 2006 };
            ProgrammingLanguage pl21 = new ProgrammingLanguage() { Name = "Python", ListChiefDeveloper = "Guido van Rossum, Python Software Foundation" , ListPredecessors =  "ALGOL 68, C, C++, Dylan, Haskell, Java, Lisp, Perl, ML" , Year = 1990 };
            ProgrammingLanguage pl22 = new ProgrammingLanguage() { Name = "SQL", ListChiefDeveloper = "Donald D.Chamberlin, Raymond F.Boyce" , ListPredecessors = "Datalog" , Year = 1974 };
            ProgrammingLanguage pl23 = new ProgrammingLanguage() { Name = "Clojure", ListChiefDeveloper =  "Rich Hickey" , ListPredecessors = "Lisp, ML, Haskell, Erlang" , Year = 2007 };
            ProgrammingLanguage pl24 = new ProgrammingLanguage() { Name = "Swift", ListChiefDeveloper =  "University of Chicago (Argonne National Laboratory)" , ListPredecessors = "none" , Year = 2007 };
            ProgrammingLanguage pl25 = new ProgrammingLanguage() { Name = "Go", ListChiefDeveloper =  "Google" , ListPredecessors = "C, Oberon, Limbo, Smalltalk" , Year = 2009 };
            ProgrammingLanguage pl26 = new ProgrammingLanguage() { Name = "CoffeeScript", ListChiefDeveloper =  "Jeremy Ashkenas" , ListPredecessors =  "JavaScript, Ruby, Python, Haskell" , Year = 2009 };
            ProgrammingLanguage pl27 = new ProgrammingLanguage() { Name = "Idris", ListChiefDeveloper = "Edwin Brady" , ListPredecessors = "Haskell, Agda, Coq" , Year = 2009 };
            ProgrammingLanguage pl28 = new ProgrammingLanguage() { Name = "Coq", ListChiefDeveloper =  "Thierry Coquand, Gerard Huet" , ListPredecessors =  "OCaml" , Year = 1989 };
            ProgrammingLanguage pl29 = new ProgrammingLanguage() { Name = "TypeScript", ListChiefDeveloper =  "Microsoft" , ListPredecessors =  "C#, Java, JavaScript" , Year = 2012 };
            ProgrammingLanguage pl30 = new ProgrammingLanguage() { Name = "Kotlin", ListChiefDeveloper =  "JetBrains" , ListPredecessors = "C#, Eiffel, Gosu, Groovy, Java, ML, Python, Scala, Swift" , Year = 2012 };
            ProgrammingLanguage pl31 = new ProgrammingLanguage() { Name = "Erlang", ListChiefDeveloper =  "Joe Armstrong,Robert Virding, Mike Williams" , ListPredecessors = "Lisp, PLEX, Prolog, Smalltalk" , Year = 1986 };
            ProgrammingLanguage pl32 = new ProgrammingLanguage() { Name = "Elixir", ListChiefDeveloper =  "Jose Valim" , ListPredecessors = "Clojure, Erlang, Ruby" , Year = 2011 };

            context.ProgrammingLanguages.AddOrUpdate(x => x.Name, pl1,pl2,pl3,pl4,pl5,pl6,pl7,pl8,pl9,pl10,pl11,pl12,pl13,pl14,pl15,pl16,
                                                         pl17,pl18,pl19,pl20,pl21,pl22,pl23,pl24,pl25,pl26,pl27,pl28,pl29,pl30,pl31,pl32);

            context.SaveChanges();

        }
    }
}
