namespace SneakyBox_task_1
{
    /// <summary>
    /// Interface for conditions.
    /// </summary>
    /// <typeparam name="DataTask">Type of the data that will be used.</typeparam>
    interface ICondition<DataTask>
    {
        /// <summary>
        /// Method for checking condition for item.
        /// </summary>
        /// <param name="value">The item for which the condition will be checked.</param>
        /// <returns>Returns true if condition is met and false if not.</returns>
        bool condition(DataTask value);
    }
}
