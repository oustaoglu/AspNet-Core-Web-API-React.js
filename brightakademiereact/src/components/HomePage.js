import React from 'react';
import Header from './Header';
import CourseList from './CourseList'; // Eğitim bilgilerini listeleyen bileşen
import Footer from './Footer';
import MainImage from './MainImage';

const HomePage = () => {
    return (
        <div>
            <MainImage />
            <main >
                <CourseList /> {/* Eğitim bilgilerini listeleyen bileşen */}
            </main>
        </div>
    );
};

export default HomePage;
