import React from "react";

function TaskStats({ tasks }) {
  // BUG 3: off-by-one — the loop starts at i = 1, so index 0 is never checked,
  // undercounting completed tasks by one whenever tasks[0].completed is true.
  let completedCount = 0;
  for (let i = 1; i < tasks.length; i++) {
    if (tasks[i].completed) completedCount++;
  }

  return (
    <p>
      Completed: {completedCount} / {tasks.length}
    </p>
  );
}

export default TaskStats;
