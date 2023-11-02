import Link from "next/link";
import { useEffect, useState } from "react";

const CategoryList = () => {
  const [categories, setCategories] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5240/api/categories")
      .then((response) => response.json())
      .then((data) => setCategories(data.Data));
  }, []);

  return (
    <section>
      <table className="border-collapse width-100 m-10 sticky top-10 z-10">
        <tbody>
          <tr>
            <div className="flex items-center justify-center bg-blue-500">
              <p className="text-white text-xl font-semibold">Kategoriler</p>
            </div>
          </tr>
          {categories.map((category, index) => (
            <tr key={index}>
              <td className="border border-solid border-gray-300 p-2 hover:bg-blue-500 font-semibold">
                <Link href={`/category/${category.Id}`}>
                  <p className="mr-5 hover:text-gray-900">{category.Name}</p>
                </Link>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </section>
  );
};

export default CategoryList;
