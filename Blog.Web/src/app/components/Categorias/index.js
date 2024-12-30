import React from "react";
import CategoriaItem from "../CategoriaItem";

function Categorias() {
  return (
    <div className="mb-14">
      <h5
        className="font-bold mb-8 text-2xl"
        style={{ borderBottom: "1px solid #e8f3ec" }}
      >
        <span
          style={{ borderBottom: "1px solid rgba(0,0,0,0.44)" }}
          className="inline-block pb-5 mb-[-1] "
        >
          Categorias
        </span>
      </h5>
      <div className="flex flex-wrap gap-[10]">
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
        <CategoriaItem />
      </div>
    </div>
  );
}

export default Categorias;
