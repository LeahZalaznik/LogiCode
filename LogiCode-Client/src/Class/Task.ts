export class Task {
  constructor(
    public id?: number,
    public title?: string,
    public description?: string,
    public isCompleted?: boolean,
    public studentId?: number,
    public createdAt?: Date) { }
}
