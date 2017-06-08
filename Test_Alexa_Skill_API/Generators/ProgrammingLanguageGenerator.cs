using System;
using System.Collections.Generic;

namespace Test_Alexa_Skill_API.Generators
{
    public class ProgrammingLanguageGenerator
    {
        List<string> FunctionalLanguages = new List<string>();
        List<string> OOLanguages = new List<string>();
        List<string> ProceduralLanguages = new List<string>();

        public ProgrammingLanguageGenerator()
        {
            AddFunctionalLanguages();
            AddOOLanguages();
            AddProceduralLanguages();
        }

        public string GetProgrammingLanguage(string type)
        {
            string language;
            switch (type)
            {
                case "functional":
                    language = FunctionalLanguages[(new Random()).Next(0, FunctionalLanguages.Count)];
                    break;
                case "object oriented":
                    language = OOLanguages[(new Random()).Next(0, OOLanguages.Count)];
                    break;
                case "procedural":
                    language = ProceduralLanguages[(new Random()).Next(0, ProceduralLanguages.Count)];
                    break;
                default:
                    language = null;
                    break;
            }
            return language;
        }

        private void AddFunctionalLanguages()
        {
            FunctionalLanguages.Add("Haskell");
            FunctionalLanguages.Add("Elm");
            FunctionalLanguages.Add("Lisp");
            FunctionalLanguages.Add("Curry");
            FunctionalLanguages.Add("Clojure");
            FunctionalLanguages.Add("Scheme");
            FunctionalLanguages.Add("Scala");
            FunctionalLanguages.Add("Erlang");
            FunctionalLanguages.Add("R");
        }

        private void AddOOLanguages()
        {
            OOLanguages.Add("C Sharp");
            OOLanguages.Add("C Plus Plus");
            OOLanguages.Add("Python");
            OOLanguages.Add("Java");
            OOLanguages.Add("Ruby");
            OOLanguages.Add("Small talk");
            OOLanguages.Add("Lua");
            OOLanguages.Add("Perl");
            OOLanguages.Add("P H P");
        }

        private void AddProceduralLanguages()
        {
            ProceduralLanguages.Add("Pascal");
            ProceduralLanguages.Add("Rust");
            ProceduralLanguages.Add("Visual Basic");
            ProceduralLanguages.Add("Go");
            ProceduralLanguages.Add("Fortran");
        }

    }
}