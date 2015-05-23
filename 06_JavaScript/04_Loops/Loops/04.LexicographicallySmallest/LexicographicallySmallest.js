var allElements = document.getElementsByTagName('*');
var isFirstWord = true;
var smallest = "";

for (var i = 0; i < allElements.length; i++) {
    var currentElement = allElements[i];
    var allProperties = currentElement.attributes;

    for (var j = 0; j < allProperties.length; j++) {
        var propertiesValue = allProperties[j].value;

        if (isFirstWord) {
            smallest = propertiesValue;
            isFirstWord = false;
            continue;
        } else {
            if (smallest.localeCompare(propertiesValue) > 0) {
                smallest = propertiesValue;
            }
        }
    }
}

console.log(smallest);
document.writeln('<p>' + smallest + '</p>');