import React from 'react';
import Header from './Header';
import CourseList from './CourseList'; // Eğitim bilgilerini listeleyen bileşen
import Footer from './Footer';

const HomePage = () => {
    return (
        <div>
            <Header /> {/* Başlık bileşeni */}
            <main>
                <CourseList /> {/* Eğitim bilgilerini listeleyen bileşen */}
            </main>
            <Footer /> {/* Altbilgi bileşeni */}
        </div>
    );
};

export default HomePage;
