using System;
using FlixOne.InventoryManagement.UserInterface;

namespace FlixOne.InventoryManagement.Command
{
    public class UpdateQuantityCommand : NonTerminatingCommand, IParameterisedCommand
    {

        public UpdateQuantityCommand(IUserInterface userInterface) : base(userInterface)
        {            
        }

        internal string InventoryName { get; private set; }

        private int _quantity;
        internal int Quantity { get => _quantity; private set => _quantity = value; }

        /// <summary>
        ///     UpdateQuantity requires name and an integer value
        /// </summary>
        /// <returns></returns>
        public bool GetParameters()
        {
            if (string.IsNullOrWhiteSpace(InventoryName))
                InventoryName = GetParameter("name");

            if (Quantity == 0)
                int.TryParse(GetParameter("quantity"), out _quantity);

            return !string.IsNullOrWhiteSpace(InventoryName) && Quantity != 0;
        }

        protected override bool InternalCommand()
        {
            throw new NotImplementedException("Implemented in next chapter!");
        }
    }
}