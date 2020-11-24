using System.Reflection;
using FlixOne.InventoryManagement.Command;
using FlixOne.InventoryManagement.UserInterface;

namespace FlixOne.InventoryManagementClient
{
    interface ICatalogService
    {
        void Run();
    }
    public class CatalogService : ICatalogService
    {
        private readonly IUserInterface _userInterface;        

        public CatalogService(IUserInterface userInterface)
        {
            _userInterface = userInterface;            
        }

        public void Run()
        {
            Greeting();

            var response = GetCommand("?").RunCommand();

            while (!response.shouldQuit)
            {
                // look at this mistake with the ToLower()
                var input = _userInterface.ReadValue("> ").ToLower();
                var command = GetCommand(input);

                response = command.RunCommand();

                if (!response.wasSuccessful)
                {
                    _userInterface.WriteMessage("Enter ? to view options.");
                }
            }
        }

        private void Greeting()
        {
            // get version and display
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();            

            _userInterface.WriteMessage( "*********************************************************************************************");
            _userInterface.WriteMessage( "*                                                                                           *");
            _userInterface.WriteMessage( "*               Welcome to FlixOne Inventory Management System                              *");
            _userInterface.WriteMessage($"*                                                                                v{version}   *");
            _userInterface.WriteMessage( "*********************************************************************************************");
            _userInterface.WriteMessage( "");
        }

        public InventoryCommand GetCommand(string input)
        {
            switch (input)
            {
                case "q":
                case "quit":
                    return new QuitCommand(_userInterface);
                case "a":
                case "addinventory":
                    return new AddInventoryCommand(_userInterface);
                case "g":
                case "getinventory":
                    return new GetInventoryCommand(_userInterface);
                case "u":
                case "updatequantity":
                    return new UpdateQuantityCommand(_userInterface);
                case "?":
                    return new HelpCommand(_userInterface);
                default:
                    return new UnknownCommand(_userInterface);
            }
        }
    }
}
