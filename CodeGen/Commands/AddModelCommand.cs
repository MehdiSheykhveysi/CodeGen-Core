using CodeGen.Common;
using CodeGen.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Commands
{
    public class AddModelCommand : ICommand
    {
        public void Execute()
        {
            var temp = new AddModelTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewModelsPath + "\\" + Config.Model + "AddModel.cs", temp, new UTF8Encoding());

            Console.WriteLine("AddModel created");
        }
    }
}
