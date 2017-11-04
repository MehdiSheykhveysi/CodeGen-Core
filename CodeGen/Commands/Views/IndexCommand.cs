using CodeGen.Common;
using CodeGen.Templates.Views;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class IndexCommand : ICommand
    {
        public void Execute()
        {
            var temp = new IndexTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewsPath + "Index.cshtml", temp, new UTF8Encoding());
            Console.WriteLine("Index.cshtml created");
        }
    }
}