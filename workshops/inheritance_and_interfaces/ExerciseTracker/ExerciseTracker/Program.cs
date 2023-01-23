using ExerciseTracker.Exercises;

namespace ExerciseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We'll use some dummy data for now. Annoyingly, there are loads of errors here, let's fix them!
            IExercise[] exercisesCompleted = new IExercise[] {
                new Deadlift { Reps = 5, Sets = 2, Weight = 35 },
                new Jogging { Distance = 2, Time = 20 },
                new Squat { Reps = 10, Sets = 4, Weight = 12 },
                new Rowing { Distance = 1000, Time = 6 }
            };

            foreach (var exercise in exercisesCompleted)
            {
                //this is also giving an error, what's wrong here?
                Console.WriteLine(exercise.Report());
            }

            // I'd also like to know the total weight lifted, and the total distance travelled - how can we manage those?

            Console.ReadLine();
        }
    }
}