import { StudentCours, StudentLesson } from "./StudentLesson";
import { Task } from "./Task";

export class Student {

    constructor(
        public id?: number,
        public email?: string,
        public password?: string,
        public name?: string,
        public provider?: string,
        public providerId?: string,
        public potoUrl?: string,
        public studentCourses?: Array<StudentCours| null>,
        public studentLessons?: Array<StudentLesson | null>,
        public studentTasks?: Array<Task | null>){ 
    }
}