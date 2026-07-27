import React, { useState } from "react";
import TaskForm from "./components/TaskForm";
import TaskList from "./components/TaskList";
import TaskStats from "./components/TaskStats";
import TaskFilter from "./components/TaskFilter";

function App() {
  const [tasks, setTasks] = useState([
    { id: 1, text: "Set up dev environment", completed: true, priority: "High" },
    { id: 2, text: "Read Module 9 handbook section", completed: false, priority: "Medium" },
    { id: 3, text: "Fix bug 1", completed: false } // <- no `priority` on purpose (Bug 4 trigger)
  ]);
  const [filter, setFilter] = useState("all");

  // BUG 1: stale closure — see TaskForm.js for where this is called from.
  // If handleAddTask is invoked twice before a re-render (e.g. simulated network
  // delay), both calls close over the same `tasks` snapshot and the second
  // call's setTasks(...) silently overwrites the first addition.
  const handleAddTask = (text) => {
    setTimeout(() => {
      setTasks([...tasks, { id: Date.now(), text, completed: false, priority: "Normal" }]);
    }, 300);
  };

  const handleToggle = (id) => {
    setTasks(tasks.map((t) => (t.id === id ? { ...t, completed: !t.completed } : t)));
  };

  const handleDelete = (id) => {
    setTasks(tasks.filter((t) => t.id !== id));
  };

  return (
    <div style={{ fontFamily: "sans-serif", maxWidth: 700, margin: "0 auto", padding: 20 }}>
      <h1>Module 9 - Buggy Task App</h1>
      <p>Find and fix the 5 planted bugs. See README.md for hints.</p>

      <TaskForm onAdd={handleAddTask} />
      <TaskStats tasks={tasks} />
      <TaskFilter filter={filter} onFilterChange={setFilter} />
      <TaskList tasks={tasks} filter={filter} onToggle={handleToggle} onDelete={handleDelete} />
    </div>
  );
}

export default App;
