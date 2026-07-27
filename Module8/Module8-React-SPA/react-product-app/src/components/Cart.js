import React from "react";

function Cart({ items, onClear }) {
  return (
    <div style={{ background: "#f5f5f5", padding: 10, marginBottom: 16, borderRadius: 6 }}>
      <strong>Cart: {items.length} item(s)</strong>
      {items.length > 0 && (
        <button onClick={onClear} style={{ marginLeft: 12 }}>
          Clear Cart
        </button>
      )}
    </div>
  );
}

export default Cart;
