var applicationName = navigator.appName,
    addScroll = false,
    pX = 0,
    pY = 0;

if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6') > 0)) {
    addScroll = true;
}

document.onmousemove = mouseMove;

if (applicationName == 'Netscape') {
    document.captureEvents(Event.MOUSEMOVE);
}

function mouseMove(event) {
    if (applicationName == 'Netscape') {
        pX = event.pageX - 5;
        pY = event.pageY;
    } else {
        pX = event.x - 5;
        pY = event.y;
    }

    if (applicationName == 'Netscape') {
        if (document.layers.ToolTip.visibility == 'show') {
            popTip();
        }
    } else {
        if (document.all.ToolTip.style.visibility == 'visible') {
            popTip();
        }
    }
}

function popTip() {
    var theLayer;

    if (applicationName == "Netscape") {
        theLayer = eval('document.layers[\'ToolTip\']');

        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }

        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'ToolTip\']');

        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = 'visible';
        }
    }
}

function hideTip() {
    var args = hideTip.arguments;

    if (applicationName == "Netscape") {
        document.layers.ToolType.visibility = 'hide';
    }
    else {
        document.all.ToolType.style.visibility = 'hidden';
    }
}

function hideFirstMenu() {
    if (applicationName == "Netscape") {
        document.layers['menu1'].visibility = 'hide';
    } else {
        document.all['menu1'].style.visibility = 'hidden';
    }
}

function hideSecondMenu() {
    if (applicationName == "Netscape") {
        document.layers['menu2'].visibility = 'hide';
    } else {
        document.all['menu2'].style.visibility = 'hidden';
    }
}

function showFirstMenu() {
    var theLayer;

    if (applicationName == "Netscape") {
        theLayer = eval('document.layers[\'menu1\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'menu1\']');
        theLayer.style.visibility = 'visible';
    }
}

function showSecondMenu() {
    var theLayer;

    if (applicationName == "Netscape") {
        theLayer = eval('document.layers[\'menu2\']');
        theLayer.visibility = 'show';
    } else {
        theLayer = eval('document.all[\'menu2\']');
        theLayer.style.visibility = 'visible';
    }
}