function buttonClickedEvent(event, arguments) {
    var currentWindow = window,
        currentBrowser = currentWindow.navigator.appCodeName,
        browserIsMozilla;

    browserIsMozilla = currentBrowser == "Mozilla";

    if (browserIsMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}