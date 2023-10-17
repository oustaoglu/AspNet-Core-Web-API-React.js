import React from 'react';
import CourseList from './CourseList'; // Eğitim bilgilerini listeleyen bileşen
import Carousel from './Carousel';

const HomePage = () => {
    return (
        <div>
            <Carousel />
            <main >
                <CourseList /> {/* Eğitim bilgilerini listeleyen bileşen */}
            </main>
        </div>
    );
};

export default HomePage;
