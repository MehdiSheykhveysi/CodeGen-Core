using CodeGen.Commands;
using CodeGen.Helpers;
using System;

namespace CodeGen.App
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Not enough arguments !");
                return;
            }

            Config.Model = args[0].ToLower().UppercaseFirst();
            var command = "";

            if (args.Length > 1)
            {
                command = args[1].ToLower();
            }

            if (args.Length > 2)
            {
                Config.Area = args[2].ToLower().UppercaseFirst();
            }

            Config.ModelsPath = Environment.CurrentDirectory+"\\";
            Config.ViewModelsPath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.FullName + "\\ViewModels\\";
            Config.RepositoryPath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.Parent.FullName + "\\Repository\\";
            Config.ServicePath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.Parent.FullName + "\\Service\\";

            if (string.IsNullOrEmpty(Config.Area))
            {
                Config.ControllerPath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.Parent.Parent.FullName + "\\Portal.Web\\Controllers\\";
                Config.ViewsPath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.Parent.Parent.FullName + "\\Portal.Web\\Views\\"+ Config.Model+"\\";

              
            }
            else
            {
                Config.ControllerPath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.Parent.Parent.FullName + "\\Portal.Web\\Areas\\" + Config.Area + "\\Controllers\\";
                Config.ViewsPath = new System.IO.DirectoryInfo(Config.ModelsPath).Parent.Parent.Parent.FullName + "\\Portal.Web\\Areas\\" + Config.Area + "\\Views\\" + Config.Model + "\\";
            }

            var viewsDir = new System.IO.DirectoryInfo(Config.ViewsPath);
            if (!viewsDir.Exists)
            {
                viewsDir.Create();
            }

            Config.PropertyNames = ClassHelper.GetPropertyNames(Config.ModelsPath + Config.Model + ".cs");
            Config.PropertyTypes = ClassHelper.GetPropertyTypes(Config.ModelsPath + Config.Model + ".cs");
            Config.PropertyDeclarations = ClassHelper.GetPropertyDeclarations(Config.ModelsPath + Config.Model + ".cs");

            switch (command)
            {
                case "sr":
                case "service":
                    var iserviceCommand = new IServiceCommand();
                    var serviceCommand = new ServiceCommand();
                    iserviceCommand.Execute();
                    serviceCommand.Execute();
                    break;

                case "rp":
                case "repository":
                    var irepositoryCommand = new IRepositoryCommand();
                    var repositoryCommand = new RepositoryCommand();
                    irepositoryCommand.Execute();
                    repositoryCommand.Execute();
                    break;

                case "vm":
                case "viewmodel":
                    var viewModelCommand = new ViewModelCommand();
                    viewModelCommand.Execute();
                    break;

                case "ad":
                case "addmodel":
                    var addModel = new AddModelCommand();
                    addModel.Execute();
                    break;

                case "vi":
                case "views":
                    var indexCommand = new IndexCommand();
                    var createCommand = new CreateCommand();
                    var editCommand = new EditCommand();
                    var deleteCommand = new DeleteCommand();
                    var detailsCommand = new DetailsCommand();

                    indexCommand.Execute();
                    createCommand.Execute();
                    editCommand.Execute();
                    deleteCommand.Execute();
                    detailsCommand.Execute();

                    break;

                case "cr":
                case "controller":
                    var controllerCommand = new ControllerCommand();
                    controllerCommand.Execute();
                    break;

                case "go":
                default:
                    var goCommand = new GoCommand();
                    goCommand.Execute();

                    
                    break;
            }
        }

        private static string UppercaseFirst(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}