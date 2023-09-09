using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter // Service Provider
    {
        public static void PrintRecipe (Product FinalProduct, ArrayList recipeList)
        {
            Console.WriteLine($"Receta de {FinalProduct.Description}");

            foreach(Step step in recipeList) 
            {

                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                $"usando '{step.Equipment.Description}' durante {step.Time}");

            }
    
        }  
    
    }
}
