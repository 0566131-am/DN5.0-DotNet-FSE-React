import React, { useState, useEffect } from "react";
import ProductCard from "./ProductCard";
import SearchBar from "./SearchBar";

function ProductList({ onAddToCart }) {
  const [products, setProducts] = useState([]);
  const [searchTerm, setSearchTerm] = useState("");

  // Calling an API with React: fetch on mount (swap for axios as a practice exercise).
  useEffect(() => {
    fetch("/products.json")
      .then((res) => res.json())
      .then((data) => setProducts(data))
      .catch((err) => console.error("Failed to load products:", err));
  }, []);

  const filtered = products.filter((p) =>
    p.name.toLowerCase().includes(searchTerm.toLowerCase())
  );

  return (
    <div>
      <h2>Products</h2>
      <SearchBar searchTerm={searchTerm} onSearchChange={setSearchTerm} />

      {/* Conditional rendering: show empty-state message when nothing matches */}
      {filtered.length === 0 && <p>No products found.</p>}

      {/* Lists and keys: each ProductCard needs a stable, unique key */}
      {filtered.map((product) => (
        <ProductCard
          key={product.id}
          name={product.name}
          price={product.price}
          isFeatured={product.isFeatured}
          onAddToCart={() => onAddToCart(product)}
        />
      ))}
    </div>
  );
}

export default ProductList;
