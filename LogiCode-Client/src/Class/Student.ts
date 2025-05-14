
export class Student{

    constructor(
        public id?:number,
        public email?:string,
        public password?:string,
        public name?:string,
        public provider?:string,
        public providerId?: string) {        
    }
}