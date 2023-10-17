import React, { useRef } from 'react';
import Slider from 'react-slick';
import 'slick-carousel/slick/slick.css';
import 'slick-carousel/slick/slick-theme.css';

function Carousel() {
    const sliderRef = useRef(null);

    const settings = {
        dots: true,
        infinite: true,
        speed: 1000,
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplay: true,
        autoplaySpeed: 3000,
    };

    const sliderContainerStyle = {
        display: 'flex',
        justifyContent: 'center',
        height: '720px',
    };

    const sliderStyle = {
        overflow: 'hidden',
        width: '100%',
    };

    const imageStyle = {
        width: '100%',
        height: 'auto',
    };

    const arrowStyle = {
        position: 'absolute',
        top: '50%',
        transform: 'translateY(-50%)',
    };

    const handlePreviousSlide = () => {
        sliderRef.current.slickPrev();
    };

    const handleNextSlide = () => {
        sliderRef.current.slickNext();
    };

    return (
        <div style={sliderContainerStyle}>
            <div style={sliderStyle}>
                <Slider ref={sliderRef} {...settings}>
                    <div>
                        <img src="/images/slider1.jpg" alt="Slide 1" style={imageStyle} />
                    </div>
                    <div>
                        <img src="/images/slider2.jpg" alt="Slide 2" style={imageStyle} />
                    </div>
                    <div>
                        <img src="/images/slider3.jpg" alt="Slide 3" style={imageStyle} />
                    </div>
                </Slider>
            </div>
            <button className="slick-prev" style={{ ...arrowStyle, left: 0 }} onClick={handlePreviousSlide}>
                Previous
            </button>

            <button className="slick-next" style={{ ...arrowStyle, right: 0 }} onClick={handleNextSlide}>
                Next
            </button>
        </div>
    );
}

export default Carousel;
