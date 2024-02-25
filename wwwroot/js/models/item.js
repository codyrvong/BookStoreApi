export class Item {

    constructor(settings) {


        this.Name = settings.Name ?? "No Name";
        this.Price = settings.Price ?? 0;
        this.Description = settings.Description ?? "No Desc.";
        this.Selected = settings.Selected ?? false;
    }

    get displayPrice() {
        return `&dollar;${this.Price.toFixed(2)}`;
    }
}