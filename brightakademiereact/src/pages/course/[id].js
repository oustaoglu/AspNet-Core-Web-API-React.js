import CourseDetail from '../../components/CourseDetail';

export async function getServerSideProps(context) {
    const courseId = context.params.id;

    // Kurs ID'sini CourseDetail bileşenine ileterek ilgili kursun detaylarını alın
    return {
        props: {
            courseId,
        },
    };
}

export default function CourseDetailPage({ courseId }) {
    return <CourseDetail courseId={courseId} />;
}
