import React from "react";

function TaskFilter({ filter, onFilterChange }) {
  // BUG 5: the <select> options use the strings "all" / "completed" / "pending",
  // but this handler was accidentally written to compare against booleans,
  // so onFilterChange never actually receives a value TaskList.js expects —
  // the filter dropdown appears to do nothing.
  const handleChange = (e) => {
    const value = e.target.value;
    const filterValue = value === "completed" ? true : value === "pending" ? false : "all";
    onFilterChange(filterValue);
  };

  return (
    <select value={filter} onChange={handleChange} style={{ marginBottom: 10 }}>
      <option value="all">All</option>
      <option value="completed">Completed</option>
      <option value="pending">Pending</option>
    </select>
  );
}

export default TaskFilter;
