using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using templates.bussiness;
using templates.infrastructure;

namespace templates
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandProcessor = new CommandQueueProcessor
                                        {
                                            Commands = new Queue<ICommand>()
                                        };
            var order = new Order
                                        {
                                            List = new List<IProduct>()
                                        };


            var addFirstProductCommand = new AddProductCommand
                                        {
                                            Order = order,
                                            Product = new Product
                                                          {
                                                              Name = "First",
                                                              Count = 10, 
                                                              Price = 100, 
                                                              Guid = Guid.NewGuid()
                                                          }
                                        };
            var addSecondProductCommand = new AddProductCommand
                                        {
                                            Order = order,
                                            Product = new Product
                                                          {
                                                              Name = "Secnd",
                                                              Count = 20, 
                                                              Price = 200, 
                                                              Guid = Guid.NewGuid()
                                                          }
                                        };
            var addThirdProductCommand = new AddProductCommand
                                        {
                                            Order = order,
                                            Product = new Product
                                                          {
                                                              Name = "Third",
                                                              Count = 30, 
                                                              Price = 300, 
                                                              Guid = Guid.NewGuid()
                                                          }
                                        };
            var getSumPriceCommand = new GetSumPriceCommand { Order = order };

            commandProcessor.AddCommandToExecute(addFirstProductCommand);
            commandProcessor.AddCommandToExecute(addSecondProductCommand);
            commandProcessor.AddCommandToExecute(addThirdProductCommand);
            
            commandProcessor.Run();
            commandProcessor.Run();
            commandProcessor.Run();

            commandProcessor.AddCommandToExecute(getSumPriceCommand);

            Console.Write(order.ToString());
            Console.WriteLine(commandProcessor.Run());
            Console.WriteLine("-----------------------------------------------------------------------");

            commandProcessor.Undo();
            commandProcessor.AddCommandToExecute(getSumPriceCommand);
            
            Console.Write(order.ToString());
            Console.WriteLine(commandProcessor.Run());
            Console.WriteLine("-----------------------------------------------------------------------");

            commandProcessor.Undo();
            commandProcessor.AddCommandToExecute(getSumPriceCommand);

            Console.Write(order.ToString());
            Console.WriteLine(commandProcessor.Run());
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
