using System.Collections.Generic;

namespace SneakyBox_task_1
{
    /// <summary>
    /// Interface for task.
    /// </summary>
    /// <typeparam name="DataType">Type of the data that will be used.</typeparam>
    interface ITask<DataType>
    {
        /// <summary>
        /// Method for filling list with data.
        /// </summary>
        /// <returns>Returns list with selected data type.</returns>
        List<DataType> createData();

        /// <summary>
        /// Methof for checking which condition is met by item and assignment of an action.
        /// </summary>
        /// <param name="value">The number for which the condition is now being checked</param>
        /// <param name="condition">Condition that the number meets</param>
        void conditionCheck(DataType value, ICondition<DataType> condition);

        /// <summary>
        /// The method that performs the action with the assigned variable.
        /// </summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="value">Assigned variable.</param>
        void action<Type>(Type value);
    }
}
