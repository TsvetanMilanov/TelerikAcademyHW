/* globals $ */

function solve() {

  return function (selector) {
    var template = '';
    //var template = '<table class="items-table"><thead><tr><th>#</th>{{#each headers}}<th>{{this}}</th>{{/each}}</tr></thead> <tbody>{{#each items}} <tr> <td>{{@index}}</td> <td>{{this.col1}}</td> <td>{{this.col2}}</td> <td>{{this.col3}}</td> </tr>{{/each}} </tbody> </table>';

    var $container = $('<div/>');
    var $table = $('<table/>');
    var $thead = $('<thead/>');
    var $tbody = $('<tbody/>');
    var $tr = $('<tr/>');
    var $th = $('<th/>');
    var $td = $('<td/>');

    $thead
        .append($tr.clone(true)
            .append($th.clone(true).text('#'))
            .append('{{#each headers}}')
            .append($th.clone(true).text('{{this}}'))
            .append('{{/each}}'));

    $tbody
        .append('{{#each items}}')
        .append($tr.clone(true)
            .append($td.clone(true).text('{{@index}}'))
            .append($td.clone(true).text('{{this.col1}}'))
            .append($td.clone(true).text('{{this.col2}}'))
            .append($td.clone(true).text('{{this.col3}}'))
            .append('{{/each}}'));

    $table.addClass('items-table');
    $table.append($thead);
    $table.append($tbody);

    $container.append($table);

    template = $container.html();

    $(selector).html(template);
  };
}

module.exports = solve;