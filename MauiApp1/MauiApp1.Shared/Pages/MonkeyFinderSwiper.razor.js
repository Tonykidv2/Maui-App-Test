let swiper;

export function initSwiper() {
    //console.log('Entered initSwiper!');
    //console.log('swiper text:' + document.querySelector('.swiper').textContent);
    //console.log(document.querySelector('.swiper'));

    swiper = new Swiper('.swiper', {

        //slidesPerView: 5,
        //spaceBetween: 10,
        //slidesPerGroup: 2,
        //loop: false,

        //// If we need pagination
        //pagination: {
        //    el: '.swiper-pagination',
        //    clickable: true,
        //},

        //// Navigation arrows
        //navigation: {
        //    nextEl: '.swiper-button-next',
        //    prevEl: '.swiper-button-prev',
        //},

        //// And if we need scrollbar
        //scrollbar: {
        //    el: '.swiper-scrollbar',
        //},
        //breakpoints: {
        //    100: {
        //        slidesPerView: 2,
        //        spaceBetween: 10,
        //    },
        //    640: {
        //        slidesPerView: 3,
        //        spaceBetween: 10,
        //    },
        //    768: {
        //        slidesPerView: 4,
        //        spaceBetween: 10,
        //    },
        //    1024: {
        //        slidesPerView: 5,
        //        spaceBetween: 10,
        //    },
        //}
        //// Optional parameters
        //direction: 'horizontal',
        //loop: false,

        ////// If we need pagination
        //pagination: {
        //    el: '.swiper-pagination',
        //},

        //// Navigation arrows
        //navigation: {
        //    nextEl: '.swiper-button-next',
        //    prevEl: '.swiper-button-prev',
        //},

        //// And if we need scrollbar
        //scrollbar: {
        //    el: '.swiper-scrollbar',
        //},

        effect: 'cards',
        grabCursor: true,
        intialSlide: 0,
        rotate: false,
        mousewheel: {
            invert: false
        },
    });

    swiper.on('slideChange', function () {

        //console.log('slide changed');
        //things get wonky when you allow looping
        //console.log(swiper.realIndex);//Whats currently showing
        //console.log(swiper.activeIndex);//Going to Index

        DotNet.invokeMethodAsync('MauiApp1.Shared', 'SlideChange', swiper.realIndex)
    });
}

export function showAlert(message) {
    alert(message);
}

export function destorySwiper() {
    swiper.destroy();
}