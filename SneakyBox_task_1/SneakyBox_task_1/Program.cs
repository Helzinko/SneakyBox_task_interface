using System.Collections.Generic;

namespace SneakyBox_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of object of the SBTask class.
            SBTask sbTask = new SBTask();

            // Creation of list that contains integers from 1 to 100.
            List<int> dataList = sbTask.createData();

            // Creation of list that will contain conditions.
            List<ICondition<int>> conditionsList = new List<ICondition<int>>();

            // Creating conditions and adding to the conditions list.
            // The conditions will be checked in the order in which they will be listed.
            conditionsList.AddRange(new List<ICondition<int>>
            {
                // this condition will be checked first (i % 3 == 0 && i % 5 == 0)
                new Condition_3(),
                // this condition will be checked second (i % 3 == 0)
                new Condition_1(),
                // this condition will be checked third (i % 5 == 0)
                new Condition_2()
            });

            // Starting method that will check the conditions.
            run(dataList, sbTask, conditionsList);
        }

        /// <summary>
        /// Generic method for checking the conditions for each element of the list.
        /// </summary>
        /// <typeparam name="DataType">The data type used.</typeparam>
        /// <param name="dataList">List of the data.</param>
        /// <param name="task">Task class that implements ICondition interface.</param>
        /// <param name="conditionsList">List of conditions.</param>
        public static void run<DataType>(List<DataType> dataList, ITask<DataType> task, List<ICondition<DataType>> conditionsList)
        {
            // Creating condition object.
            ICondition<DataType> correctCondition;
            foreach(DataType item in dataList)
            {
                // Assigning null value to the condition in case of no condition is met.
                correctCondition = null;
                foreach(ICondition<DataType> condition in conditionsList)
                {
                    if (condition.condition(item))
                    {
                        // An appropriate condition is assigned.
                        correctCondition = condition;
                        break;
                    }
                }
                // Starting method that will check which action to run.
                task.conditionCheck(item, correctCondition);
            }
        }
    }
}
