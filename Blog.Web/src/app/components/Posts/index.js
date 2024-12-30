"use client";
import { post } from "@/constants";
import { NotificationsLogo, UnlikeLogo } from "@/constants/images";
import { useSearchParams } from "next/navigation";
import React, { Suspense, useEffect, useState } from "react";

function Posts() {
  const param = useSearchParams();
  const postId = param.get("post");
  useEffect(() => {
    findPost();
  }, []);

  function findPost() {
    setPostagem(post.find((x) => x.id == postId));
  }

  const [postagem, setPostagem] = useState();

  if (postagem != undefined)
    return (
      <Suspense>
        <div className="flex flex-col my-10 items-center px-4">
          <div className="gap-3">
            <h1 className="text-[42px] font-[700]">{postagem.titulo}</h1>
            <p className="text-sm text-[#6c757d]">{postagem.usuario}</p>
            <p className="text-sm text-[#6c757d]">{postagem.data}</p>
          </div>
          {/* <div className="m-8 border-b-black border-t-black flex justify-start">
          <button>
            <NotificationsLogo />
            <UnlikeLogo />
          </button>
        </div> */}
          <div className="mt-10">
            <p className="text-xl">{postagem.texto}</p>
          </div>
        </div>
      </Suspense>
    );
}

export default Posts;
