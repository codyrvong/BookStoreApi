import mustache from './mustache.js'

(async () => {

    let request = await fetch("templates/bob.html");

    let template = await request.text();

    let context = {};

    context.items = [
        { name: "Bob", age: 30, job: "Teacher" },
        { name: "Rob", age: 32, job: "Custodian" },
        { name: "Tob", age: 35, job: "ASA" },
        { name: "Sob", age: 37, job: "President" },
        { name: "Dob", age: 39, job: "Engineer", pet: { name: "Bobby", species: "dog" } }

    ]

    //let context = {
    //name: "Bob",
    //age: 30,
    //job: "Teacher"
    //};

    let html = mustache.render(template, context);


    document.body.innerHTML = html;



})();