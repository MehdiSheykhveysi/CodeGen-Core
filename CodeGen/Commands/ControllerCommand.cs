using CodeGen.Common;
using CodeGen.Templates;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class ControllerCommand : ICommand
    {
        public void Execute()
        {
            var temp = new ControllerTemp().TransformText();
            System.IO.File.WriteAllText(Config.ControllerPath + Config.Model + "Controller.cs", temp, new UTF8Encoding());
            Console.WriteLine("Controller created");
        }
    }
}