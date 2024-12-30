import Posts from "@/app/components/Posts";
import React, { Suspense } from "react";

// import { Container } from './styles';

function Post() {
  return (
    <Suspense>
      <div>
        <Posts />
      </div>
    </Suspense>
  );
}

export default Post;
