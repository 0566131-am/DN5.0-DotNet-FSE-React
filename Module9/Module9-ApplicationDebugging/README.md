# Module 9 – Application Debugging — Hands-on Practice

Covers: debugging React apps with Chrome DevTools (DOM inspection, breakpoints, Sources
panel) and with the VS Code debugger (breakpoints, watches, step into/over/out).

## Project included
`buggy-task-app` — a small React app (Create-React-App style) with **5 intentional bugs**
planted in it. Your job is to find and fix each one using DevTools / VS Code, not by
just reading the code.

## How to run
```
cd buggy-task-app
npm install
npm start
```

## Debugging Exercises

### Bug 1 — Wrong state update (stale closure)
Symptom: clicking "Add Task" twice quickly only adds one task.
- Open Chrome DevTools → Sources panel, set a breakpoint inside `handleAddTask` in
  `TaskForm.js`, and step through with Step Into / Step Over to see the state value used.
- Fix: use the functional form of `setState` (`setTasks(prev => [...prev, ...])`).

### Bug 2 — Broken list rendering (missing key / wrong key)
Symptom: console warning about missing/duplicate keys, and checking one task's checkbox
seems to check the wrong row after deleting an item.
- Use the Elements panel to inspect the DOM tree and confirm which row actually re-rendered.
- Fix the `key` prop in `TaskList.js`.

### Bug 3 — Off-by-one in a counter
Symptom: the "completed count" displayed is always one less than expected.
- Set a breakpoint in `TaskStats.js` and inspect the `completedCount` variable in the
  Locals/Watch panel as you step through.
- Fix the counting logic.

### Bug 4 — Undefined property crash
Symptom: the app crashes with "Cannot read properties of undefined" when a task has no
`priority` field.
- Reproduce it, read the stack trace in the Console, and use the Sources panel to jump to
  the exact line.
- Fix with a default value or optional chaining (`task.priority ?? "Normal"`).

### Bug 5 — Debugging in VS Code
Symptom: `TaskFilter.js`'s filter dropdown doesn't actually filter anything.
- Set a breakpoint on the filter function using the VS Code debugger (requires the
  "Debugger for Chrome"/built-in JS debug config, or `launch.json` pointed at
  `http://localhost:3000`).
- Step through and inspect the `filterValue` variable to find the logic error.

## Tools reminder
- Chrome DevTools: F12 or right-click → Inspect. Sources tab for breakpoints, Elements
  tab for DOM inspection, Console for errors/logs.
- VS Code: use the Run and Debug panel; a `.vscode/launch.json` is included pre-configured
  for "Launch Chrome against localhost".

## Check your understanding
- https://www.geeksforgeeks.org/quizzes/error-handling-and-debugging/
- https://www.toolsrail.com/quiz/web-browsers-developer-tools-quiz.php
