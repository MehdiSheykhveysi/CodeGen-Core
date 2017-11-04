using CodeGen.Common;
using CodeGen.Templates;
using CodeGen.Templates.Views;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class CreateCommand : ICommand
    {
        public void Execute()
        {
            var temp = new CreateTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewsPath + "Create.cshtml", temp, new UTF8Encoding());

            Console.WriteLine("Create.cshtml created");
        }
    }
}