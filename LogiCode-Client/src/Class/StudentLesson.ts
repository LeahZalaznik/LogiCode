export class StudentCours {
    constructor(
        public id?: number,
        public studentId?: number,
        public courseId?: number,
        public purchaseDate?: Date,
        public expiryDate?: Date,
        public status?: string,
        public finalGrade?: DoubleRange) {}
}
export class StudentLesson{
    constructor(
        public id?: number,
        public studentId?: number,
        public  isWatched?:boolean,
        public  watchedOn?:Date,
        public exerciseScore?:DoubleRange) {}
}