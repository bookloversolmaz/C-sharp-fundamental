using ExerciseTracker.Exercises;

namespace ExerciseTracker.Test
{
    public class SquatTests
    {
        [Test]
        public void SquatReportsRepsSetsAndWeight()
        {
            var squats = new Squat
            {
                Reps = 8,
                Sets = 3,
                Weight = 12
            };

            Assert.That(squats.Report(), Is.EqualTo("Squats: 8 reps, 3 sets, 12kg"));
        }

        [Test]
        public void SquatCalculatesTotalWeightLifted()
        {
            var squats = new Squat
            {
                Reps = 8,
                Sets = 3,
                Weight = 12
            };

            Assert.That(squats.TotalLifted(), Is.EqualTo(288));
        }
    }
}