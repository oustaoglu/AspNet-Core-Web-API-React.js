// pages/category/[id].js
import { useRouter } from 'next/router';

const CategoryDetail = () => {
    const router = useRouter();
    const { id } = router.query;

    // Burada kategori ayrıntılarını API'den çekebilir ve görüntüleyebilirsiniz.

    return (
        <div>
            <h1>Category Detail Page</h1>
            <p>Category ID: {id}</p>
            {/* Kategori ayrıntıları burada görüntülenebilir. */}
        </div>
    );
};

export default CategoryDetail;
