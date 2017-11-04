using CodeGen.Common;
using CodeGen.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen.Commands
{
    public class ServiceCommand : ICommand
    {

        public void Execute()
        {
            var temp = new ServiceTemp().TransformText();
            System.IO.File.WriteAllText(Config.ServicePath + Config.Model + "Service.cs", temp, new UTF8Encoding());
            Console.WriteLine("Service created");
        }
    }
}
