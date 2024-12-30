"use client";
import React, { useState } from "react";
import { FiPlusCircle } from "react-icons/fi";
import { FaRegImages } from "react-icons/fa6";
import "react-quill-new/dist/quill.snow.css";
import dynamic from "next/dynamic";

const ReactQuill = dynamic(() => import("react-quill-new"), { ssr: false });

const modules = {
  toolbar: [
    [{ font: [] }],
    [{ size: [] }],
    [{ color: [] }, { background: [] }],

    ["bold", "italic", "underline", "strike", "blockquote"],
    [{ align: [] }],
    [
      { list: "ordered" },
      { list: "bullet" },
      { indent: "-1" },
      { indent: "+1" },
    ],
    ["link", "image"],
    ["code-block"],
  ],
  clipboard: {
    // toggle to add extra line breaks when pasting HTML:
    matchVisual: false,
  },
};

const formats = [
  "header",
  "font",
  "size",
  "bold",
  "italic",
  "underline",
  "strike",
  "blockquote",
  "color",
  "background",
  "list",
  "indent",
  "link",
  "image",
  "align",
  "code-block",
];

function editor() {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <div className="container">
      <input
        placeholder="titulo"
        className="p-12 text-5xl rounded-none outline-none bg-transparent"
      />
      <div className="editor">
        <ReactQuill
          onChange={(value) => console.log(value)}
          placeholder="Digite seu texto"
          className="textArea"
          modules={modules}
          formats={formats}
        />
      </div>
    </div>
  );
}

export default editor;
