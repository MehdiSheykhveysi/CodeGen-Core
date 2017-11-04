using CodeGen.Common;
using CodeGen.Templates;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class ViewModelCommand : ICommand
    {
        public void Execute()
        {
            var temp = new ViewModelTemp().TransformText();
            System.IO.File.WriteAllText(Config.ViewModelsPath + "\\" + Config.Model + "ViewModel.cs", temp, new UTF8Encoding());
            Console.WriteLine("ViewModel created");
        }
    }
}