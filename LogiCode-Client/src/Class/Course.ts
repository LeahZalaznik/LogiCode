import { Lesson } from "./Lesson";

export enum eLevel{
    easy,
    meduim,
    hard
}
export class Course{
    constructor(public Id?:number, public Title?:string, public Descreption?:string,
         public ProgrammingLanguage?:string, public DurationHours?:number, public Level?:eLevel, 
        public Price?:number, public ImageUrl?:string, public Points?:Array<string>, public Lessons?:Array<Lesson>){}
}