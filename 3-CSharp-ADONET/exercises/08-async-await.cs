// Exercise 8: Asynchronous Programming with Async/Await
// Concepts: Task, async/await, exception handling in async code,
// ValueTask vs Task (conceptual)

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // TODO 1: Write an async method Task<int> FetchNumberAsync()
        // that uses await Task.Delay(1000) to simulate work, then
        // returns a number. Call it with await and print the result.


        // TODO 2: Write an async method that awaits FetchNumberAsync()
        // twice SEQUENTIALLY, and measure the elapsed time using
        // System.Diagnostics.Stopwatch (should take ~2 seconds).


        // TODO 3: Rewrite TODO 2 to run both calls CONCURRENTLY using
        // Task.WhenAll(task1, task2) and compare the elapsed time
        // (should take ~1 second instead of ~2).


        // TODO 4: Write an async method that throws an exception (e.g.
        // after a delay), and handle it with try/catch around the
        // await call - confirm the exception propagates correctly
        // through the async call chain.


        // TODO 5: Add a short comment explaining, in your own words,
        // when you would prefer ValueTask<T> over Task<T> (hint: hot
        // paths where the result is often available synchronously,
        // to avoid allocating a Task object every call).
    }

    // Add your FetchNumberAsync() and other async method definitions
    // below Main().
}
