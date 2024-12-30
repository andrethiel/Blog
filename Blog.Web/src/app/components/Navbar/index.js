"use client";
import Link from "next/link";
import React, { useState } from "react";
import { Bars3Icon, XMarkIcon } from "@heroicons/react/24/outline";
import { Transition } from "@headlessui/react";

function Navbar() {
  const [isOpen, setIsOpen] = useState(false);

  return (
    <nav className="shadow-sm w-full z-10">
      <div className="max-w-screen-xl flex flex-wrap items-center justify-between mx-auto p-4">
        <a href="#" className="flex items-center">
          <h1 className="font-bold text-xl cursor-pointer">
            Steam <span className="text-blue-500">Line</span>
          </h1>
        </a>
        <div className="flex lg:hidden md:hidden">
          <button
            type="button"
            className="inline-flex items-center p-2 w-10 h-10 justify-center text-sm rounded-lg border-2 bg-primery"
            onClick={() => setIsOpen(!isOpen)}
          >
            {isOpen ? <XMarkIcon /> : <Bars3Icon />}
          </button>
        </div>
        <div className={`${!isOpen ? "hidden" : ""} w-full md:block md:w-auto`}>
          <ul className="font-medium flex flex-col p-4 md:p-0 mt-4 border-2 lg:bg-white md:bg-white border-gray-600 bg-secondary rounded-lg md:flex-row md:space-x-8 md:mt-0 md:border-0">
            <Link href="/pages/Principal">Inicio</Link>
          </ul>
        </div>
      </div>
    </nav>
  );
}

export default Navbar;
