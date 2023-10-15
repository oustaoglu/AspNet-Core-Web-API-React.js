import { useEffect, useState } from 'react';
import Link from 'next/link';

const CategoryList = () => {
    const [categories, setCategories] = useState([]);

    useEffect(() => {
        fetch('http://localhost:1907/api/categories')
            .then((response) => response.json())
            .then((data) => setCategories(data.Data));
    }, []);

    return (
        <section className="text-gray-600 body-font">
            <div className="container px-5 py-24 mx-auto">
                <div className="flex flex-wrap -mx-4 -mb-10 text-center">
                    <div key="all" className="sm:w-1/3 mb-10 px-4">
                        <div className="rounded-lg border border-gray-300 p-4">
                            <div className="rounded-lg h-64 overflow-hidden">
                                {/* Tüm Kategoriler için bir resim ekleyebilirsiniz */}
                                <img alt="Tüm Kategoriler" className="object-cover object-center h-full w-full" src="/images/all.jpg" />
                            </div>
                            <h2 className="title-font text-2xl font-medium text-gray-900 mt-6 mb-3">Kategoriler</h2>
                            <div className="flex justify-between mt-6">
                                <div className="flex mx-auto text-white bg-indigo-500 border-0 py-2 px-8 focus:outline-none hover:bg-indigo-600 rounded-lg">
                                    <Link href="/categories">
                                        <a>Kategoriler</a>
                                    </Link>
                                </div>
                            </div>
                        </div>
                    </div>
                    {categories.map((category) => (
                        <div key={category.Id} className="sm:w-1/3 mb-10 px-4">
                            <div className="rounded-lg border border-gray-300 p-4">
                                <div className="rounded-lg h-64 overflow-hidden">
                                    <img alt={category.Name} className="object-cover object-center h-full w-full" src={`/images/${category.Id}.jpg`} />
                                </div>
                                <h2 className="title-font text-2xl font-medium text-gray-900 mt-6 mb-3">{category.Name}</h2>
                                <p className="leading-relaxed text-base">{category.Description}</p>
                                <div className="flex justify-between mt-6">
                                    <div className="flex mx-auto text-white bg-indigo-500 border-0 py-2 px-8 focus:outline-none hover-bg-indigo-600 rounded-lg">
                                        <Link href={`/category/${category.Id}`}>
                                            <a>{category.Name}</a>
                                        </Link>
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

export default CategoryList;
