import React from "react";

// import { Container } from './styles';

function PostItem({ id, titulo, texto, usuario, data }) {
  return (
    <a href={`/page/post?post=${id}`}>
      <div className="mb-4 flex content-between">
        <div className="pr-4 flex flex-col gap-1">
          <h1 className="mb-3 font-bold text-[30px]">{titulo}</h1>
          <p>{texto.substring(0, 100)}</p>
          <div className="text-[#6c757d] flex flex-col gap-1">
            <p className="text-sm">{usuario}</p>
            <small>{data}</small>
          </div>
        </div>
      </div>
    </a>
  );
}

export default PostItem;
