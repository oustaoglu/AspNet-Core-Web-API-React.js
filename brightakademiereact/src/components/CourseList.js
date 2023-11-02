import { useEffect, useState } from "react";
import Link from "next/link";

const CourseList = () => {
  const [courses, setCourses] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5240/api/courses")
      .then((response) => response.json())
      .then((data) => setCourses(data.data));
  }, []);

  return (
    <section className="text-gray-600 body-font flex justify-center">
      <div className="container px-5 py-10 mx-auto w-auto">
        <div className="flex flex-wrap -mx-4 -mb-10 text-center">
          {courses.slice(0, 30).map((course) => (
            <div key={course.id} className="sm:w-1/3 mb-10 px-4">
              <div className="rounded-lg border border-gray-300 p-4">
                <div className="rounded-lg h-64 overflow-hidden">
                  <img
                    alt={course.name}
                    className=" object-center h-full w-full"
                    src={`/images/${course.id}.jpg`}
                  />
                </div>
                <h2 className="title-font text-2xl font-medium text-gray-900 mt-6 mb-3">
                  {course.name}
                </h2>
                <div className="flex justify-center mt-6">
                  <div className="flex mr-1 mx-auto text-white bg-yellow-500 border-0 py-2 px-8 focus:outline-none hover:bg-yellow-600 rounded-lg cursor-pointer">
                    <Link href={`/course/${course.id}`}>Detay</Link>
                  </div>
                  <div className="flex mx-auto text-white bg-blue-500 border-0 py-2 px-8 focus:outline-none hover:bg-blue-600 rounded-lg cursor-pointer">
                    <Link href={`/course/${course.id}`}>Sepete Ekle</Link>
                  </div>
                </div>
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
};

export default CourseList;
