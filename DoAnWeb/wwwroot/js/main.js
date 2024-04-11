
document.querySelector('#mob-menu-toggle').addEventListener('click', () => document.querySelector('#header-wrapper').classList.add('active'))

document.querySelector('#mob-menu-close').addEventListener('click', () => document.querySelector('#header-wrapper').classList.remove('active'))

// product

document.addEventListener("DOMContentLoaded", function() {
    const blogRow = document.getElementById("blogRow");
    const nextButton = document.getElementById("nextButton");
    const prevButton = document.getElementById("prevButton");

    const cols = blogRow.querySelectorAll(".col-12");
  
    let currentIndex = 0;
    const numColsToShow = 3;
  
    function showColumns() {
        for (let i = 0; i < cols.length; i++) {
            if (i >= currentIndex && i < currentIndex + numColsToShow) {
                cols[i].style.display = "block";
            } else {
                cols[i].style.display = "none";
            }
        }
    }
  
    function handleNextButtonClick() {
        if (currentIndex + numColsToShow < cols.length) {
            currentIndex += numColsToShow;
            showColumns();
        }
    }
  
    function handlePrevButtonClick() {
        if (currentIndex - numColsToShow >= 0) {
            currentIndex -= numColsToShow;
            showColumns();
        }
    }

    nextButton.addEventListener("click", handleNextButtonClick);
    prevButton.addEventListener("click", handlePrevButtonClick);
  
    showColumns();
});

let products = [
    {
        name: 'JBL E55BT KEY BLACK',
        image1: './img/hd-1.png',
        old_price: '400.000 VND',
        curr_price: '300.000 VND'
    },
    {
        name: 'JBL JR 310BT',
        image1: './img/hd-2.png',
        old_price: '400.000 VND',
        curr_price: '300.000 VND'
    },
    {
        name: 'JBL TUNE 750BTNC',
        image1: './img/hd-3.png',
        old_price: '400.000 VND',
        curr_price: '300.000 VND'
    },
    {
        name: 'JBL Horizon',
        image1: './img/hd-4.png',
        old_price: '400.000 VND',
        curr_price: '300.000 VND'
    },
    {
        name: 'JBL Tune 220TWS',
        image1: './img/wl1.png',
        old_price: '400.000 VND',
        curr_price: '300.000 VND'
    },
    {
        name: 'UA Project Rock',
        image1: './img/wl2.png',
        old_price: '400.000 VND',
        curr_price: '300.000 VND'
    },
]

let product_list = document.querySelector('#products')

renderProducts = (products) => {
    products.forEach(e => {
        let prod = `
        <div class="col-lg-4 col-md-6 col-sm-12">
        <div class="product-card">
            <div class="product-card-img">
                <img src="${e.image1}" alt="">
            </div>
            <div class="product-card-info">
                <div class="product-card-btn">
                    <button class="btn-card">shop</button>
                    <button class="btn-card"><i class='bx bx-heart'></i></button>
                    <button class="btn-card"><i class='bx bx-cart'></i></button>
                </div>
                <div class="product-card-name">
                    ${e.name}
                </div>
                <div class="product-card-price">
                    <span><del>${e.old_price}</del></span>
                    <span class="curr-price">${e.curr_price}</span>
                </div>
            </div>
        </div>
    </div>
    `

    product_list.insertAdjacentHTML("beforeend", prod)
    })
}

renderProducts(products)
renderProducts(products)



function menuToggle(isHovered) {
    const toggleMenu = document.querySelector('.dropdown-menu-list');
    if (isHovered) {
        toggleMenu.classList.add('active');
    } else {
        toggleMenu.classList.remove('active');
    }
}

