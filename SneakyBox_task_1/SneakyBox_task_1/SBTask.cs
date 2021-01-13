using System;
using System.Collections.Generic;
namespace SneakyBox_task_1
{
    /// <summary>
    /// Class for current task, that implements ITask interface. 
    /// SB - Sneaky Box.
    /// </summary>
    class SBTask : ITask<int>
    {
        /// <summary>
        /// Method for filling list with data.
        /// In this class this method fills list with integers from 1 to 100.
        /// </summary>
        /// <returns>Returns list with integers.</returns>
        public List<int> createData()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 100; i++)
                list.Add(i);
            return list;
        }

        /// <summary>
        /// Methof for checking which condition is met by item and assignment of an action.
        /// In this class this method assigns on of three words or the integer value.
        /// </summary>
        /// <param name="number">The number for which the condition is now being checked</param>
        /// <param name="condition">Condition that the number meets</param>
        public void conditionCheck(int number, ICondition<int> condition)
        {
            if (condition is Condition_3)
                action("SneakyBox");
            else if (condition is Condition_1)
                action("Sneaky");
            else if (condition is Condition_2)
                action("Box");
            else action(number);
        }

        /// <summary>
        /// The method that performs the action with the assigned variable.
        /// In this class this method prints the variable to the Console.
        /// </summary>
        /// <typeparam name="Type">Assigned variable</typeparam>
        public void action<Type>(Type value)
        {
            Console.WriteLine(value);
        }
    }

    /// <summary>
    /// Class for first condition for SB task that implements ICondition interface.
    /// i % 3 == 0
    /// </summary>
    class Condition_1 : ICondition<int>
    {
        public bool condition(int value)
        {
            if (value % 3 == 0)
                return true;
            else return false;
        }
    }

    /// <summary>
    /// Class for second condition for SB task that implements ICondition interface.
    /// i % 5 == 0
    /// </summary>
    class Condition_2 : ICondition<int>
    {
        public bool condition(int value)
        {
            if (value % 5 == 0)
                return true;
            else return false;
        }
    }

    /// <summary>
    /// Class for third condition for SB task that implements ICondition interface.
    /// i % 3 == 0 && i % 5 == 0
    /// </summary>
    class Condition_3 : ICondition<int>
    {
        public bool condition(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
                return true;
            else return false;
        }
    }
}
