import React from "react";

function TaskList({ tasks, filter, onToggle, onDelete }) {
  const visibleTasks = tasks.filter((t) => {
    if (filter === "all") return true;
    if (filter === "completed") return t.completed;
    if (filter === "pending") return !t.completed;
    return true;
  });

  return (
    <ul style={{ listStyle: "none", padding: 0 }}>
      {/* BUG 2: using the array index as the key instead of task.id.
          After deleting a task, React can mismatch rows to the wrong DOM node —
          try deleting the first task and watch checkbox states shift. */}
      {visibleTasks.map((task, index) => (
        <li key={index} style={{ padding: 6, borderBottom: "1px solid #eee" }}>
          <input type="checkbox" checked={task.completed} onChange={() => onToggle(task.id)} />
          <span style={{ marginLeft: 8, textDecoration: task.completed ? "line-through" : "none" }}>
            {task.text}
          </span>
          {/* BUG 4: task.priority can be undefined (see the 3rd seed task in App.js) —
              calling .toUpperCase() on undefined crashes the app. */}
          <span style={{ marginLeft: 8, fontSize: 12, color: "#888" }}>
            [{task.priority.toUpperCase()}]
          </span>
          <button onClick={() => onDelete(task.id)} style={{ marginLeft: 8 }}>
            Delete
          </button>
        </li>
      ))}
    </ul>
  );
}

export default TaskList;
