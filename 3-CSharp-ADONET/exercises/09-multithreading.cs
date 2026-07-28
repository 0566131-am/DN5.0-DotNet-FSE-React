// Exercise 9: Multi-Threading
// Concepts: System.Threading.Thread, Thread lifecycle, background
// threads, race conditions, locks/Monitor, Mutex

using System;
using System.Threading;

class Program
{
    static int sharedCounter = 0;
    static readonly object lockObj = new object();

    static void Main()
    {
        // TODO 1: Create and start a new Thread that runs a method
        // PrintNumbers() printing 1-5 with a small delay between each.
        // Join the thread before Main exits so the program waits for it.


        // TODO 2: Create a background thread (IsBackground = true) and
        // explain in a comment how its lifecycle differs from a
        // foreground thread (background threads don't keep the process
        // alive - they're killed when all foreground threads finish).


        // TODO 3: Demonstrate a RACE CONDITION - start 5 threads that
        // each increment 'sharedCounter' 100000 times WITHOUT any lock,
        // join them all, and print the final value. Run it a few times
        // and notice the result is often LESS than 500000 (lost updates).


        // TODO 4: Fix the race condition from TODO 3 using a
        // lock (lockObj) { ... } block around the increment, and show
        // the result is now reliably 500000.


        // TODO 5: (Optional/advanced) Rewrite TODO 4 using Monitor.Enter
        // / Monitor.Exit explicitly instead of the lock statement (lock
        // is syntactic sugar over Monitor), wrapped in try/finally.


        // TODO 6: Print Thread.CurrentThread.ManagedThreadId at a few
        // points to observe which thread is executing which code.
    }

    static void PrintNumbers()
    {
        // TODO: implement per TODO 1
    }
}
