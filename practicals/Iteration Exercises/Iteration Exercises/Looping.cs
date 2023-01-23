namespace Iteration_Exercises;
public static class Looping
{
    public static IEnumerable<string> WhileLoop(IList<string> names)
    {
        int i = 0;
        string[] output = new string[names.Count()];
        while (i < names.Count())
        {
            output[i] = "Hello " + names[i];
            i++;
        }

        return output;
    }

    /* Test drive equivalent implementations using:
     * A for loop `for(;;)`
     * A foreach loop
     * Select
     * one other method of your choice
     */

    /* Bonus material:
     * The implementations with a while, for or foreach can be implemented using `yield return`
     * Research why we'd want to use yield return, and implement it
     */

    /* Bonus material 2:
     * Write an extension method so we can use a while loop directly on our List
     * Using it should look like this: `new List<string>{"Alex"}.WhileLoopExtension()`
     */
}

