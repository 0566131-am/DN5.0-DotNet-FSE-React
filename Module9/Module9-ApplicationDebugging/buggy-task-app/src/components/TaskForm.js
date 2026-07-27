import React, { useState } from "react";

function TaskForm({ onAdd }) {
  const [text, setText] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!text.trim()) return;
    onAdd(text);
    setText("");
  };

  return (
    <form onSubmit={handleSubmit} style={{ marginBottom: 16 }}>
      <input
        type="text"
        value={text}
        onChange={(e) => setText(e.target.value)}
        placeholder="New task..."
        style={{ padding: 6, marginRight: 6 }}
      />
      {/* Try clicking this twice quickly to reproduce Bug 1 (see App.js handleAddTask) */}
      <button type="submit">Add Task</button>
    </form>
  );
}

export default TaskForm;
