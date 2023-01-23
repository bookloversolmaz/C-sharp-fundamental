using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Exercises
{
    public class Deadlift: IExercise
    {
        public int Weight { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }

        public string Report()
        {
            return $"Deadlift: {Reps} reps, {Sets} sets, {Weight}kg";
        }
    }
}
