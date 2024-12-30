import React from "react";
import Carrossel from "./components/Carrossel";
import Posts from "./components/ListPosts";
import Categorias from "./components/Categorias";

export default function Home() {
  return (
    <div>
      <Carrossel />
      <Categorias />
      <Posts />
    </div>
  );
}
