import { ShoppingList } from './models/shopping-list.js'
import mustache from './mustache.js'



const demoTemplate = `

{{#lists}}
    <p>
    <strong>Name</strong> {{Name}}
    <br>
    <strong>Budget</strong> {{{displayBudget}}}
    <br>
    <strong>Completed</strong> {{{Completed}}}
    </p>
    <hr>
{{/lists}}

`

async function showShoppingList() {

    let url = "api/ShoppingList";

    let request = await fetch(url);

    let result = await request.json();

    let shoppingLists = [];

    result.forEach((settings) => {

        shoppingLists.push(new ShoppingList(settings));

    });

    window.lastResult = result;

    let context = {
        lists: []
    };

    context.lists = shoppingLists.sort((a, b) => {
        return a.Name.localeCompare(b.Name)
    });

    window.currentContext = context;

    let html = mustache.render(demoTemplate, context);

    renderShoppingLists(html);

}

function renderShoppingLists(html) {

    let target = document.querySelector("#ShoppingListArea");

    target.innerHTML = html;
}
showShoppingList();

window.sortShoppingListsByBudget = () => {

    const shoppingLists = window.currentContext.lists.sort((a, b) => {
        return a.Budget - b.Budget;
    });

    const newContext = {
        lists: shoppingLists
    };

    let html = mustache.render(demoTemplate, newContext);


    renderShoppingLists(html);

}