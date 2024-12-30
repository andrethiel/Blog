import React from "react";
import PostItem from "../PostItem";
import { acessados, post } from "@/constants";
import PostItemPopular from "@/app/components/PostItemPopular";

function Posts() {
  return (
    <div className="grid grid-cols-1 gap-2 md:flex lg:flex xl:flex">
      <div>
        <h5
          className="font-bold mb-8 text-2xl"
          style={{ borderBottom: "1px solid #e8f3ec" }}
        >
          <span
            style={{ borderBottom: "1px solid rgba(0,0,0,0.44)" }}
            className="inline-block pb-5 mb-[-1] "
          >
            Todos os posts
          </span>
        </h5>
        {post.map((item) => (
          <PostItem
            key={item.id}
            id={item.id}
            titulo={item.titulo}
            data={item.data}
            texto={item.texto}
            usuario={item.usuario}
          />
        ))}
      </div>
      <div className="pl-4">
        <h5
          className="font-bold mb-8 text-2xl"
          style={{ borderBottom: "1px solid #e8f3ec" }}
        >
          <span
            style={{ borderBottom: "1px solid rgba(0,0,0,0.44)" }}
            className="inline-block pb-5 mb-[-1] "
          >
            Mais acessados
          </span>
        </h5>
        <PostItemPopular data={acessados} />
      </div>
    </div>
  );
}

export default Posts;
