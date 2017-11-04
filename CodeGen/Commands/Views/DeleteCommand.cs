using CodeGen.Common;
using CodeGen.Templates;
using CodeGen.Templates.Views;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class DeleteCommand : ICommand
    {
        public void Execute()
        {
            var temp = new DeleteTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewsPath + "Delete.cshtml", temp, new UTF8Encoding());

            Console.WriteLine("Delete.cshtml created");
        }
    }
}