using coffee_machine_project_kata.Domain;
using coffee_machine_project_kata.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace coffee_machine_project_kata
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, Recipe>[] availableBeverage = GetFieldValues(typeof(Recipe)).ToArray();
           
            int index = ConsoleHelper.MultipleChoice(true, availableBeverage);
            Console.WriteLine($"Le Prix de {availableBeverage[index].Value.Name} est de : {availableBeverage[index].Value.GetPrice()}");
            Console.ReadKey();
        }
        public static Dictionary<string, Recipe> GetFieldValues(Type type)
        {
            return type
                      .GetFields()
                      .Where(f => f.FieldType == typeof(Recipe))
                      .ToDictionary(f => f.Name,
                                    f => (Recipe)f.GetValue(null));
        }
    }
}
