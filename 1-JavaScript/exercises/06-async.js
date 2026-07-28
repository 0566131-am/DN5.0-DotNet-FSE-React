// Exercise 6: Asynchronous JavaScript
// Concepts: callbacks, callback hell, Promises, async/await

// TODO 1: Write a function fetchDataCallback(callback) that uses
// setTimeout to simulate a 1-second network delay, then calls
// callback(null, { id: 1, name: "Sample" }).


// TODO 2: Deliberately create a small "callback hell" example by
// nesting 2-3 calls to fetchDataCallback inside each other's callbacks.


// TODO 3: Rewrite fetchDataCallback as fetchDataPromise() that returns
// a Promise instead, using resolve/reject.


// TODO 4: Chain 3 fetchDataPromise() calls using .then() instead of
// nested callbacks, and add a .catch() at the end.


// TODO 5: Rewrite the same chain using async/await inside an async
// function, wrapped in try/catch for error handling.


// TODO 6: Use Promise.all() to run 3 fetchDataPromise() calls in
// parallel and log all results once they resolve.
