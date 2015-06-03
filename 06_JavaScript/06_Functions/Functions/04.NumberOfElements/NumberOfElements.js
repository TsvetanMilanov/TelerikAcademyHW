var elements = [];

function countDivs() {
    elements = document.body.getElementsByTagName('div');

    console.log(elements.length);
}

countDivs();