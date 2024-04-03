let searchElement = document.getElementById('filterInput');

searchElement.addEventListener('keyup', function () {
    let filter = this.value.toLowerCase();
    let cards = document.getElementsByClassName('card');

    for (let i = 0; i < cards.length; i++) {
        let card = cards[i];
        let cardTitle = card.getElementsByClassName('card__title')[0].innerText.toLowerCase();

        if (cardTitle.indexOf(filter) > -1) {
            card.style.display = "";
        } else {
            card.style.display = "none";
        }
    }
});

searchElement.addEventListener('mouseout', function () {
    let img = document.getElementsByClassName('search-box__img')[0];
    img.style.opacity = this.value ? 0 : 1;
    if (!this.value) {
        this.classList.remove('search-box_expanded');
    }
    this.blur();
});

searchElement.addEventListener('focus', function () {
    let img = document.getElementsByClassName('search-box__img')[0];
    img.style.opacity = 0;

});

searchElement.addEventListener('mouseover', function () {
    this.classList.add('search-box_expanded');
});