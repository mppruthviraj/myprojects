"use strict";

var carousel = {
    showItems: {},
    count: {
        withDuplicated: {},
        withoutDuplicated: {}
    },
    activeIndex: {},
    fullWidth: {},
    transitionTime: "0.75s",
    showNav: true,
    showDots: true,
    responsiveTable: [[300, 1], [600, 1], [1000, 1]],
    moveBy: 1,
    position: 0,
    transition: "none",
    class: {
        item: ".BrandGuidelineCarousel-item",
        wrapper: ".BrandGuidelineCarousel-stage",
        dots: ".BrandGuidelineCarousel-dots"
    },

    init: function (_el) {
        //TODO read configuration fronm data attr
        var carouselWidth = $("#" + _el).innerWidth();
        carousel.transition = "none";
        carousel.fullWidth[_el] = carouselWidth;
        carousel.showItems[_el] = carousel.getCountFromResponsiveTable(carouselWidth);

        carousel.count.withoutDuplicated[_el] = $("#" + _el).find(carousel.class.item).length;
        carousel.duplicate(_el);
        carousel.count.withDuplicated[_el] = $("#" + _el).find(carousel.class.item).length;

        carousel.activeIndex[_el] = carousel.showItems[_el];

        var resizeTimer;

        $(window).resize(function () {
            clearTimeout(resizeTimer);
            resizeTimer = setTimeout(function () {
                carousel.transition = "none";
                carousel.fullWidth[_el] = $("#" + _el).innerWidth();
                carousel.showItems[_el] = carousel.getCountFromResponsiveTable(carousel.fullWidth[_el]);
                carousel.styleCarousel(_el);
            }, 250);
        });

        carousel.styleCarousel(_el);
        carousel.bindNavigation(_el);
        carousel.renderDots(_el);
        carousel.styleDots(_el);
        carousel.transition = "1s";
    },

    bindNavigation: function (_el) {
        $("#" + _el).find(".prev").on("click", function () {
            carousel.setActivIndex(-1, _el);
        });
        $("#" + _el).find(".next").on("click", function () {
            carousel.setActivIndex(+1, _el);
        });
    },

    renderDots: function (_el) {
        var pages = carousel.getPages(_el);
        for (var page = 0; page < pages.length; page++) {
            pages[page];
            $("#" + _el).find(carousel.class.dots)
                .append($("<span data-page-index='" + pages[page] + "'></span>"))
        }
        $("#" + _el).find(carousel.class.dots + " span").on("click", function (event) {
            carousel.jumpToIndex(event.target.getAttribute("data-page-index"), _el);
        });
    },

    styleDots: function (_el) {
        $("#" + _el).find(carousel.class.dots + " span").each(function (index, element) {
                $(this).removeClass("active");
                if (carousel.isCurrentPage(parseInt(element.getAttribute("data-page-index")), _el)) {
                    $(this).addClass("active");
                }
            }
        )
    },

    styleCarousel: function (_el) {
        $("#" + _el).find(carousel.class.item).each(function (index) {
            $(this).css(carousel.itemStyles(_el));
            $(this).removeClass("active");
            if (carousel.getActivIndex(index, _el)) {
                $(this).addClass("active");
            }
        });

        $("#" + _el).find(carousel.class.wrapper).css(carousel.listStyles(_el));
        carousel.styleDots(_el);
    },

    itemStyles: function (_el, clear) {
        //todo: check this
        if (!clear) {
        }
        return {'width': Math.floor(carousel.fullWidth[_el] / carousel.showItems[_el]) + 'px'};
    },

    listStyles: function (_el) {
        var position = -carousel.activeIndex[_el] * Math.floor(carousel.fullWidth[_el] / carousel.showItems[_el]);
        return {
            'transform': 'translate3d(' + position + 'px, 0px, 0px)',
            'width': Math.floor(carousel.fullWidth[_el] * carousel.count.withDuplicated[_el]) + 'px',
            'transition': carousel.transition
        };
    },

    getCountFromResponsiveTable: function (width) {
        var tempCount;
        for (var t in carousel.responsiveTable) {
            if (width > carousel.responsiveTable[t][0] && carousel.responsiveTable[t][1] > 0) {
                tempCount = carousel.responsiveTable[t][1];
            }
        }
        return tempCount;
    },

    duplicate: function (_el) {
        var objToClone = $("#" + _el + " " + carousel.class.wrapper + " " + carousel.class.item);
        objToClone.each(function (index) {
            if (index < carousel.showItems[_el]) {
                $(this).clone().appendTo("#" + _el + " " + carousel.class.wrapper);
            }
        });
        $(objToClone.get().reverse()).each(function (index) {
            if (index < carousel.showItems[_el]) {
                $(this).clone().prependTo("#" + _el + " " + carousel.class.wrapper);
            }
        });
    },

    getActivIndex: function (index, _el) {
        return !!(carousel.activeIndex[_el] <= index && index < carousel.activeIndex[_el] + carousel.showItems[_el]);
    },

    isCurrentPage: function (dot, _el) {
        if (carousel.activeIndex[_el] < carousel.showItems[_el]) {
            return (carousel.activeIndex[_el] + carousel.count.withoutDuplicated >= dot && carousel.activeIndex[_el] + carousel.count.withoutDuplicated < dot + carousel.showItems);
        } else if (carousel.activeIndex[_el] == carousel.showItems[_el] + carousel.count.withoutDuplicated[_el]) {
            return dot === carousel.showItems
        }
        else {
            return (carousel.activeIndex[_el] >= dot && carousel.activeIndex[_el] < dot + carousel.showItems[_el]);
        }
    },

    getPages: function (_el) {
        var countIndex = 0;
        var pagesIndexes = [];
        while (countIndex * carousel.showItems[_el] < carousel.count.withoutDuplicated[_el]) {
            countIndex++;
            pagesIndexes.push(countIndex * carousel.showItems[_el]);
        }
        return pagesIndexes;
    },

    setActivIndex: function (direction, _el) {
        var nextIndex = carousel.activeIndex[_el] + (carousel.moveBy * direction);
        carousel.transition = "none";
        if (nextIndex > carousel.count.withoutDuplicated[_el]) {
            carousel.activeIndex[_el] = 0;
            carousel.styleCarousel(_el);
        } else if (nextIndex < carousel.showItems[_el]) {
            carousel.activeIndex[_el] = carousel.count.withoutDuplicated[_el] + carousel.showItems[_el];
            carousel.styleCarousel(_el);
        }
        setTimeout(function () {
            carousel.transition = carousel.transitionTime;
            carousel.activeIndex[_el] += (carousel.moveBy * direction);
            carousel.styleCarousel(_el)
        }, 10);

    },

    jumpToIndex: function (index, _el) {
        carousel.transition = carousel.transitionTime;
        carousel.activeIndex[_el] = parseInt(index);
        carousel.styleCarousel(_el)
    }
};
