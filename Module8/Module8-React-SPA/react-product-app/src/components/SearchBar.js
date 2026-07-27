import React from "react";

// Controlled input pattern: value comes from parent state, onChange reports back up.
function SearchBar({ searchTerm, onSearchChange }) {
  return (
    <input
      type="text"
      placeholder="Search products..."
      value={searchTerm}
      onChange={(e) => onSearchChange(e.target.value)}
      style={{ padding: 6, width: "100%", marginBottom: 10 }}
    />
  );
}

export default SearchBar;
