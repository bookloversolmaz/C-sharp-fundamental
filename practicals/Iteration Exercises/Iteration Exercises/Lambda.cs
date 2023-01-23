using System;
namespace Iteration_Exercises
{
	public static class Lambda
	{
        // Please work through the initial questions in Looping.cs first, before working on this material

        public static Func<string, string> Greet = name => "Hi " + name;
        public static Func<string, string, string> Title = (honorific, name) => throw new NotImplementedException();

        /* Test-drive more lambdas which will:
         * Check if a name starts with "A"
         * Give the length of a name
         * Check if 2 names are the same
         */

        /* Discussion question: should name be a string? 
         * Talk to Alex with reasons both for and against - you'll want at 
         * least one reason on each side!
         */

        /* ===== PART TWO ===== */

        public static IEnumerable<string> GreetAll(IEnumerable<string> names)
        {
            return names.Select(Greet);
        }

        /* using the lambdas you created above, test-drive methods to:
         * filter and include only names beginning with A
         * get a list of name lengths
         * keep only unique names in the list given
         */

        /* ===== BONUS WORK ===== */

        /* Create your own Map, Filter and Reduce extension methods which take 
         * an IEnumerable and a lambda, and behave similarly to Ruby's map, 
         * filter and reduce (these are standard methods often used on big 
         * datasets, so it's worthwhile knowing about them)
         * 
         * Once you've created those methods, talk to Alex about how large a 
         * dataset you could use them with, and why
         */
    }
}

