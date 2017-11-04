using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public static class Config
    {
        public static string Model { get; set; }

        public static string ModelLower => Model.ToLower();

        public static string Area { get; set; }

        public static string ModelsPath { get; set; }
        public static string ViewModelsPath { get; set; }
        public static string RepositoryPath { get; set; }
        public static string ServicePath { get; set; }

        public static string ControllerPath { get; set; }
        public static string ViewsPath { get; set; }



        public static IEnumerable<string> PropertyNames { get; set; }

        public static IEnumerable<string> PropertyDeclarations { get; set; }

        public static IEnumerable<PropertyDeclarationSyntax> PropertyTypes { get; set; }
    }
}
