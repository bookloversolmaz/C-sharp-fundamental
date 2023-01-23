using ExerciseTracker.Exercises;

namespace ExerciseTracker.Test
{
    public class RowingTests
    {
        [Test]
        public void RowingReportsDistanceAndTime()
        {
            var row = new Rowing
            {
                Distance = 1000,
                Time = 6
            };

            Assert.That(row.Report(), Is.EqualTo("Rowing: 1000m, 6 minutes"));
        }
    }
}