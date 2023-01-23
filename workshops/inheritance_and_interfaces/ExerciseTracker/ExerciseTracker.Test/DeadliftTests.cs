using ExerciseTracker.Exercises;

namespace ExerciseTracker.Test
{
    public class DeadliftTests
    {
        [Test]
        public void DeadliftReportsRepsSetsAndWeight()
        {
            var deadlift = new Deadlift
            {
                Reps = 5,
                Sets = 3,
                Weight = 35
            };

            Assert.That(deadlift.Report(), Is.EqualTo("Deadlift: 5 reps, 3 sets, 35kg"));
        }
    }
}