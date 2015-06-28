/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */


function solve() {
    var domElement = (function () {
        function createStringOfAttributes() {
            var result = [],
                index = 0;

            for (var attributeName in this.attributes) {
                result[index] = attributeName.toString() + '="' + this.attributes[attributeName] + '" ';
                index += 1;
            }

            result = result.sort(function (first, second) {
                return first.localeCompare(second);
            });

            if (Object.keys(this.attributes).length == 0) {
                return '';
            }

            return ' ' + result.join('').trim();
        }

        function createStringOfChildren() {
            var result = [];
            result = this.listOfChildren.map(function (child) {
                if (typeof (child) == 'string') {
                    return child;
                }
                return child.innerHTML;
            });

            if (result.length > 0) {
                return result.join('');
            }

            return '';
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this._content = '';
                this.attributes = {};
                this.listOfChildren = [];
                return this;
            },
            appendChild: function (child) {
                if (typeof (child) == 'string') {
                    this.content = child;
                    this.listOfChildren.push(child);
                    return this;
                }

                this.content = '';

                this.listOfChildren.push(child);
                child.parent = this;

                return this;
            },
            addAttribute: function (name, value) {
                if (!name) {
                    throw new Error('Name of attribute must not be empty.');
                }

                if (name.match(/[!,. 0-9]/g)) {
                    throw new Error('Attribute name contains bad characters.');
                }

                this.attributes[name] = value;

                return this;
            },
            get innerHTML() {
                var generatedHtml = '',
                    stringOfAttributes = '',
                    stringOfChildren = '';

                stringOfAttributes = createStringOfAttributes.call(this);

                stringOfChildren = createStringOfChildren.call(this);

                if (this.listOfChildren.length > 0) {
                    generatedHtml += '<' + this.type + stringOfAttributes + '>' + stringOfChildren + '</' + this.type + '>';
                } else {
                    generatedHtml += '<' + this.type + stringOfAttributes + '>' + this.content + '</' + this.type + '>';
                }

                return generatedHtml;
            }
        };

        Object.defineProperty(domElement, 'type', {
            get: function () {
                return this._type;
            },
            set: function (value) {
                if (!value) {
                    throw new Error('Type can not be empty');
                }

                if (typeof (value) !== 'string') {
                    throw new Error('Type is not string.');
                }

                if (value.match(/[!.,]/g)) {
                    throw new Error('Type contains bad characters.');
                }

                this._type = value;
            }
        });

        Object.defineProperty(domElement, 'removeAttribute', {
            value: function (attributeToRemove) {
                if (!this.attributes[attributeToRemove]) {
                    throw new Error('Can not remove non-existing attribute.');
                }

                delete this.attributes[attributeToRemove];

                return this;
            }
        });

        Object.defineProperty(domElement, 'content', {
            get: function () {
                return this._content;
            },
            set: function (contentToAdd) {
                if (this.listOfChildren.length == 0) {
                    this._content = contentToAdd;
                }
            }
        });

        Object.defineProperty(domElement, 'parent', {
            get: function () {
                return this._parent;
            },
            set: function (parentToAdd) {
                this._parent = parentToAdd;
                return this;
            }
        });

        return domElement;
    }());

    return domElement;
}

solve();

module.exports = solve;
