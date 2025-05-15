export class Course{
   constructor(public id?:number,public title?:string    
        ,public description? :string
        ,public ProgrammingLanguage?:string
        ,public DurationHours?:number
        ,public Price?: number
        ,public ImageUrl?:string
        ,public DurationMinutes?:number
        ,public Points?:number
    ) {        
    }
    
}