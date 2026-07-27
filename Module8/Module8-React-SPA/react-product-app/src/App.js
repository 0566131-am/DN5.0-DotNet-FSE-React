import React, { useState } from "react";
import ProductList from "./components/ProductList";
import Cart from "./components/Cart";

function App() {
  const [cartItems, setCartItems] = useState([]);

  const handleAddToCart = (product) => {
    setCartItems((prev) => [...prev, product]);
  };

  const handleClearCart = () => {
    setCartItems([]);
  };

  return (
    <div style={{ fontFamily: "sans-serif", maxWidth: 700, margin: "0 auto", padding: 20 }}>
      <h1>Module 8 - React Product Catalog</h1>
      <Cart items={cartItems} onClear={handleClearCart} />
      <ProductList onAddToCart={handleAddToCart} />
    </div>
  );
}

export default App;
