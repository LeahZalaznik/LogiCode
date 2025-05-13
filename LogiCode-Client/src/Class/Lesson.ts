import { Exercise } from "./Exercise";

export class Lesson{

    constructor(public id?:number,public title?:string,public content?:string,public videoUrl?:string ,public exercise?:Exercise) {        
    }
}