export class Question {
    constructor(init ?: Partial<Question>) {
        Object.assign(this, init);
    }

    id                : any;
    description       : string = "";
    startQuestion?    : any;
    createdDate       : Date = new Date();
}