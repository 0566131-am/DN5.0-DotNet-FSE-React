import React from "react";

// Functional component receiving props: name, price, isFeatured, onAddToCart
function ProductCard({ name, price, isFeatured, onAddToCart }) {
  return (
    <div style={{ border: "1px solid #ccc", borderRadius: 6, padding: 12, marginBottom: 8 }}>
      <strong>{name}</strong> {isFeatured && <span>⭐ Featured</span>}
      <p>₹{price}</p>
      <button onClick={onAddToCart}>Add to Cart</button>
    </div>
  );
}

export default ProductCard;
