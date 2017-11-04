using CodeGen.Common;
using CodeGen.Templates;
using CodeGen.Templates.Views;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class DetailsCommand : ICommand
    {
        public void Execute()
        {
            var temp = new DetailsTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewsPath + "Details.cshtml", temp, new UTF8Encoding());

            Console.WriteLine("Details.cshtml created");
        }
    }
}