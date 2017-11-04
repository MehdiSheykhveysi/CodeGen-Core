using CodeGen.Common;
using CodeGen.Templates;
using System;
using System.Text;

namespace CodeGen.Commands
{
    public class RepositoryCommand : ICommand
    {
        public void Execute()
        {
            var temp = new RepositoryTemp().TransformText();
            System.IO.File.WriteAllText(Config.RepositoryPath + Config.Model + "Repository.cs", temp, new UTF8Encoding());
            Console.WriteLine("Repository created");
        }
    }
}