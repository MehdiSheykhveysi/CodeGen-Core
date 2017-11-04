using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CodeGen.Helpers
{
    public static class ClassHelper
    {
        public static IEnumerable<string> GetPropertyNames(string filePath)
        {
            var text = System.IO.File.ReadAllText(filePath);
            var tree = CSharpSyntaxTree.ParseText(text);
            var root = tree.GetRoot();
            var properties = root.DescendantNodes().OfType<PropertyDeclarationSyntax>();

            foreach (var item in properties)
            {
                yield return item.Identifier.Text.Trim();
            }
        }

        public static IEnumerable<string> GetPropertyDeclarations(string filePath)
        {
            var text = System.IO.File.ReadAllText(filePath);
            var tree = CSharpSyntaxTree.ParseText(text);
            var root = tree.GetRoot();
            var properties= root.DescendantNodes().OfType<PropertyDeclarationSyntax>();

            foreach (var item in properties)
            {
                yield return item.ToString().Trim();
            }
        }

        public static IEnumerable<PropertyDeclarationSyntax> GetPropertyTypes(string filePath)
        {
            var text = System.IO.File.ReadAllText(filePath);
            var tree = CSharpSyntaxTree.ParseText(text);
            var root = tree.GetRoot();
            return root.DescendantNodes().OfType<PropertyDeclarationSyntax>();

            //foreach (var item in properties)
            //{
            //    yield return item.ToString();
            //}
        }
    }
}