using CodeGen.Common;
using CodeGen.Templates;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class IRepositoryCommand : ICommand
    {
        public void Execute()
        {
            var temp = new IRepositoryTemp().TransformText();
            System.IO.File.WriteAllText(Config.RepositoryPath + "I" + Config.Model + "Repository.cs", temp, new UTF8Encoding());

            Console.WriteLine("IRepository created");
        }
    }
}