using CodeGen.Common;

namespace CodeGen.Commands
{
    public class GoCommand : ICommand
    {
        public void Execute()
        {
            var iserviceCommand = new IServiceCommand();
            var serviceCommand = new ServiceCommand();
            var irepositoryCommand = new IRepositoryCommand();
            var repositoryCommand = new RepositoryCommand();
            var viewModelCommand = new ViewModelCommand();
            var addModel = new AddModelCommand();
            var indexCommand = new IndexCommand();
            var createCommand = new CreateCommand();
            var editCommand = new EditCommand();
            var deleteCommand = new DeleteCommand();
            var detailsCommand = new DetailsCommand();
            var controllerCommand = new ControllerCommand();

            viewModelCommand.Execute();
            addModel.Execute();
            irepositoryCommand.Execute();
            repositoryCommand.Execute();
            iserviceCommand.Execute();
            serviceCommand.Execute();
            indexCommand.Execute();
            createCommand.Execute();
            editCommand.Execute();
            deleteCommand.Execute();
            detailsCommand.Execute();
            controllerCommand.Execute();
        }
    }
}