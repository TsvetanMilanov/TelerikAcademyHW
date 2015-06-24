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
 * // method removeAttribute(attribute)
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
        function sortArrayOfAttributes(arr) {
            var tempKeys = [];
            var result = {};

            for (var a in arr) {
                tempKeys.push(a.toString());
            }

            tempKeys = tempKeys.sort();


            for (var i = 0; i < tempKeys.length; i += 1) {
                result[tempKeys[i]] = arr[tempKeys[i]];
            }

            return result;
        }

        function addTextContent(content) {
            var indexOfContentToAdd = 0;

            var substring = '</' + this.type;

            for (var i = 0; i < this.htmlContent.length; i += 1) {
                var currentSubstring = this.htmlContent.substr(i, this.type.length + 2);
                if (substring == currentSubstring) {
                    indexOfContentToAdd = i;
                    break;
                }
            }

            var resultArray = this.htmlContent.split('');

            resultArray.splice(indexOfContentToAdd, 0, content);

            this.htmlContent = resultArray.join('');
        }

        function addChild(content) {
            if (this.htmlContent.length <= 0) {
                this.arrayOfAttributes = sortArrayOfAttributes(this.arrayOfAttributes);

                var attributes = '';

                for (var attr in this.arrayOfAttributes) {
                    attributes += ' ' + attr + '="' + this.arrayOfAttributes[attr] + '"';
                }

                attributes = attributes.trim();
                if (attributes.length > 0) {
                    attributes = ' ' + attributes;
                }

                this.htmlContent += '<' + this.type + attributes + '>' + '</' + this.type + '>';
            }

            var indexOfContentToAdd = 0;

            var substring = '</' + this.type;

            for (var i = 0; i < this.htmlContent.length; i += 1) {
                var currentSubstring = this.htmlContent.substr(i, this.type.length + 2);
                if (substring == currentSubstring) {
                    indexOfContentToAdd = i;
                    break;
                }
            }

            var resultArray = this.htmlContent.split('');

            resultArray.splice(indexOfContentToAdd, 0, content);

            this.htmlContent = resultArray.join('');
        }

        var domElement = {
            init: function (type) {
                this.arrayOfAttributes = {};
                this.childIsText = false;
                this.htmlContent = '';
                this._child = '';
                this._content = '';
                this.publicChild = '';
                this.arrayOfChilds = [],
                    this.type = type;
                return this;
            },
            appendChild: function (child) {
                if (typeof child == 'string') {
                    this._child = child;
                    this.childIsText = true;
                    this.arrayOfChilds.push(child);
                    return this;
                }

                child.parent = this;
                this.publicChild = child;

                this.arrayOfChilds.push(child);

                return this;
            },
            addAttribute: function (name, value) {
                if (!name) {
                    throw new Error('Invalid attribute name (does not exist)');
                }

                if (typeof name !== 'string') {
                    throw new Error('Invalid type of attribute name');
                }

                if (name.split('').indexOf(' ') >= 0) {
                    throw new Error('Attribute name contains bad characters');
                }

                this.arrayOfAttributes[name] = value;
                return this;
            },
            get innerHTML() {
                if (this.htmlContent.length > 0 && this._content.length <= 0 && this.publicChild == '') {
                    return this.htmlContent;
                }

                this.arrayOfAttributes = sortArrayOfAttributes(this.arrayOfAttributes);

                var attributes = '';

                for (var attr in this.arrayOfAttributes) {
                    attributes += ' ' + attr + '="' + this.arrayOfAttributes[attr] + '"';
                }

                attributes = attributes.trim();

                if (attributes.length > 0) {
                    attributes = ' ' + attributes;
                }

                this.htmlContent = '<' + this.type + attributes + '>' + '</' + this.type + '>';

                if (this.childIsText) {
                    addTextContent.call(this, this._child);
                }

                if (this.publicChild != '') {
                    this.htmlContent = '<' + this.type + attributes + '>' + '</' + this.type + '>';

                    for (var i = 0; i < this.arrayOfChilds.length; i += 1) {
                        if (typeof this.arrayOfChilds[i] == 'string') {
                            addTextContent.call(this, this.arrayOfChilds[i]);
                        } else {
                            addChild.call(this, this.arrayOfChilds[i].innerHTML);
                        }
                    }

                    return this.htmlContent;
                }

                if (this._content.length > 0 && !this.childIsText) {
                    addTextContent.call(this, this._content);
                }

                return this.htmlContent;
            },
            get type() {
                return this._type;
            },
            set type(value) {
                if (!value) {
                    throw new Error('Type must have value');
                }

                if (!(typeof value == 'string')) {
                    throw new Error('Type must be string');
                }

                if (value.split('').indexOf('!') >= 0) {
                    throw Error('Invalid type');
                }

                this._type = value;
            },
            set content(value) {
                this.publicChild != '' ? this._content = '' : this._content = value;
            }
        };
        return domElement;
    }());

    return domElement;
}

module.exports = solve;
