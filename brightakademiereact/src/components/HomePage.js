import React from "react";
import CourseList from "./CourseList";
import Carousel from "./Carousel";
import CategoryList from "./CategoryList";

const HomePage = () => {
  return (
    <div>
      <Carousel />
      <main className="grid grid-cols-6">
        <CategoryList />
        <div className="col-span-5">
          <CourseList />
        </div>
      </main>
    </div>
  );
};

export default HomePage;
