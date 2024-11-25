using System.Diagnostics;

namespace HelloWorldCS
{
    /// <summary>
    /// The <c>GuessingGame</c> class provides a simple number guessing game.
    /// The user tries to guess a random number within a given range.
    /// </summary>
    public class GuessingGame
    {
        private readonly int _min;
        private readonly int _max;

        /// <summary>
        /// Initializes a new instance of the <c>GuessingGame</c> class with a specified range.
        /// </summary>
        /// <param name="min">The minimum value of the guessable range.</param>
        /// <param name="max">The maximum value of the guessable range.</param>
        public GuessingGame(int min, int max)
        {
            _min = min;
            _max = max;
        }

        /// <summary>
        /// Runs the guessing game. The user is asked to guess a number, and feedback is given
        /// until the correct number is guessed. The time taken to guess the number is displayed at the end.
        /// </summary>
        public void Run()
        {
            var answer = GenerateAnswer();
            var guess = 0;

            // Create a Stopwatch to track the time taken
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // Start the timer

            while (guess != answer)
            {
                guess = GetUserGuess();
                ProvideFeedback(guess, answer);
            }

            // Stop the timer when the correct answer is guessed
            stopwatch.Stop();

            // When the user guesses correctly
            Console.WriteLine("You got it!");

            // Display the time taken to guess the number
            Console.WriteLine($"It took you {stopwatch.Elapsed.TotalSeconds:F2} seconds to guess the correct number.");
        }

        /// <summary>
        /// Generates a random number between the specified minimum and maximum (inclusive).
        /// </summary>
        /// <returns>A random number between <c>_min</c> and <c>_max</c>.</returns>
        private int GenerateAnswer()
        {
            return (new Random()).Next(_min, _max + 1); // Generates a random number
        }

        /// <summary>
        /// Prompts the user for a guess, validates the input, and returns the valid guess.
        /// The method loops until a valid integer is entered by the user.
        /// </summary>
        /// <returns>The valid integer guessed by the user.</returns>
        private int GetUserGuess()
        {
            // Loop until a valid integer is entered
            while (true)
            {
                Console.WriteLine($"Make a guess ({_min}-{_max}): ");
                var input = Console.ReadLine();

                // Try to parse the input as an integer
                if (int.TryParse(input, out var guess))
                {
                    // Return the valid guess if parsing is successful
                    return guess;
                }
                // Inform the user if the input is invalid
                Console.WriteLine("Invalid input, please enter a number.");
            }
        }

        /// <summary>
        /// Provides feedback on the user's guess compared to the correct answer.
        /// </summary>
        /// <param name="guess">The user's current guess.</param>
        /// <param name="answer">The correct answer.</param>
        private static void ProvideFeedback(int guess, int answer)
        {
            if (guess < answer)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > answer)
            {
                Console.WriteLine("Too high!");
            }
        }
    }
}
