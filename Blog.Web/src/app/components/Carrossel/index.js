"use client";
import React from "react";
import { Swiper, SwiperSlide } from "swiper/react";
import { Autoplay, Navigation } from "swiper/modules";
import "swiper/css";
import "swiper/css/navigation";
import Image from "next/image";

function Carrossel() {
  return (
    <section>
      <Swiper
        navigation
        modules={[Navigation, Autoplay]}
        onSwiper={(swiper) => console.log(swiper)}
        className="w-full mb-16 h-96"
        autoplay={{
          delay: 2500,
          disableOnInteraction: false,
        }}
      >
        <SwiperSlide>
          <div className="flex h-full w-full items-center justify-center relative">
            <img
              src={
                "https://images.unsplash.com/photo-1665686304129-a6e2d16923e8"
              }
              className="block h-full w-full object-cover"
            />
            <div className="absolute px-5 py-6 bottom-0 left-0 w-full pointer-events-none z-[1]">
              <span className="text-white">Categoria</span>
              <h2 className="text-white text-xl xl:text-2xl">
                Piloto do avião Embraer E190 acidentado era muito experiente e
                tinha mais de 15.000 horas de voo
              </h2>
              <span className="text-white">26 de dezembro de 2024</span>
            </div>
          </div>
        </SwiperSlide>
        <SwiperSlide>
          <div className="flex h-full w-full items-center justify-center">
            <img
              src={
                "https://images.unsplash.com/photo-1508780709619-79562169bc64"
              }
              className="block h-full w-full object-cover"
            />
          </div>
        </SwiperSlide>
      </Swiper>
    </section>
  );
}

export default Carrossel;
