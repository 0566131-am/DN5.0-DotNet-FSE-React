# Module 8 – Single Page Application Framework: React — Hands-on Practice

Covers: SPA concepts, React components (functional + class), props, state, ES6/JSX,
events, conditional rendering, lists & keys, forms, and calling an API with React.

## Project included
`react-product-app` — a small Create-React-App-style project (plain JS, no TypeScript,
matching the handbook's beginner track). Open it in VS Code as the handbook recommends.

## How to run
```
cd react-product-app
npm install
npm start
```
This starts the dev server (usually http://localhost:3000).

## Problem Statements

### 1. Functional vs Class components
`ProductCard` is written as a functional component. Rewrite a copy of it as a class
component (`ProductCardClass.js`) that renders the same output, to see the syntax
difference firsthand.

### 2. Props
`ProductList` passes `name`, `price`, and `onAddToCart` down to each `ProductCard` as
props. Add a new prop, `isFeatured` (boolean), and conditionally show a "⭐ Featured"
badge when it's true.

### 3. State and events
`Cart.js` uses `useState` to track cart items and a count. Add a "Clear Cart" button
that resets state back to empty.

### 4. Conditional rendering
In `ProductList.js`, show a "No products found" message when the filtered list is empty,
using the `&&` pattern described in the handbook.

### 5. Lists and keys
`ProductList` already renders products with `.map()` and a `key`. Break it (remove the
`key` prop) and observe the console warning — then fix it, to understand why keys matter.

### 6. Forms (controlled inputs)
`SearchBar.js` is a controlled input bound to state. Extend it to also filter by a
minimum price using a second controlled input.

### 7. Calling an API
`ProductList` fetches data from a mock JSON endpoint (`public/products.json`, loaded via
`fetch`) on mount using `useEffect`. Try swapping the `fetch` call for `axios` — install
it with `npm install axios` — as the handbook's "Calling API with React" section
demonstrates.

## Check your understanding
- https://www.geeksforgeeks.org/reactjs/react-quiz/
- https://www.geeksforgeeks.org/quizzes/?category=reactjs
