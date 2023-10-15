import { useEffect, useState } from 'react';
import { useRouter } from 'next/router';

const CategoryPage = () => {
    const router = useRouter();
    const { id } = router.query;
    const [category, setCategory] = useState(null);

    useEffect(() => {
        // Kategori içeriğini yüklemek için API çağrısı yapabilirsiniz.
        // Örnek bir API çağrısı:

        fetch(`http://localhost:5034/api/categories/${id}`)
            .then((response) => response.json())
            .then((data) => setCategory(data));
    }, [id]);

    if (!category) {
        return <p>Yükleniyor...</p>;
    }

    return (
        <div>
            <h1>Kategori Sayfası - ID: {id}</h1>
            <h2>Kategori Adı: {category.Name}</h2>
            <p>Kategori Açıklaması: {category.Description}</p>
            {/* Kategori içeriği gösterme kodu buraya gelebilir */}
        </div>
    );
};

export default CategoryPage;
