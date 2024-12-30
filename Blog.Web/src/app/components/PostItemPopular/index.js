import React from "react";
import "./style.css";

function PostItemPopular({ data }) {
  return (
    <ol className="list-featured">
      {data.map((item, index) => (
        <li key={index}>
          <span>
            <h6 className="font-bold text-lg">{item.titulo}</h6>
          </span>
        </li>
      ))}
    </ol>
  );
}

export default PostItemPopular;
