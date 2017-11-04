using CodeGen.Common;
using CodeGen.Templates;
using CodeGen.Templates.Views;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class EditCommand : ICommand
    {
        public void Execute()
        {
            var temp = new EditTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewsPath + "Edit.cshtml", temp, new UTF8Encoding());
            Console.WriteLine("Edit.cshtml created");
        }
    }
}