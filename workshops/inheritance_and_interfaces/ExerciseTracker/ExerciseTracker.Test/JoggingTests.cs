using ExerciseTracker.Exercises;

namespace ExerciseTracker.Test
{
    public class JoggingTests
    {
        [Test]
        public void JoggingReportsDistanceTimeAndSpeed()
        {
            var jog = new Jogging
            {
                Distance = 1000,
                Time = 10
            };

            Assert.That(jog.Report(), Is.EqualTo("Jogging: 1000m, 10 minutes, 6kph"));
        }
    }
}