import { Component, ElementRef, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { LessonService } from '../../Services/lesson-service.service';
import { Lesson } from '../../Class/Lesson';
import { NavLessonsComponent } from "../nav-lessons/nav-lessons.component";

@Component({
  selector: 'lesson',
  templateUrl: './lesson.component.html',
  styleUrls: ['./lesson.component.css'],
  imports: [NavLessonsComponent]
})
export class LessonComponent implements OnInit, AfterViewInit {

  Lessons: Array<Lesson> = [];
  @ViewChild('LessonContainer') LessonContainer!: ElementRef;
  constructor(public ls: LessonService) {}

  ngOnInit(): void {
    this.Lessons = this.ls.Lessons;
  }

  ngAfterViewInit(): void {

    setTimeout(() => {
      this.addCopyButtonsToCode();
    }, 0);
  }

  addCopyButtonsToCode(): void {
    if (!this.LessonContainer) return;

    const codeBlocks = this.LessonContainer.nativeElement.querySelectorAll('pre code');

    codeBlocks.forEach((codeBlock: HTMLElement) => {
      const wrapper = codeBlock.parentElement as HTMLElement;

      // מניעת הוספת כפתור כפול
      if (wrapper.querySelector('.copy-btn')) return;

      const button = document.createElement('button');
      button.textContent = 'copy';
      button.className = 'copy-btn btn btn-sm btn-outline-secondary';
      button.style.position = 'absolute';
      button.style.marginBottom='5px'
      button.style.top = '5px';
      button.style.left = '5px';
      button.style.zIndex = '10';

      button.addEventListener('click', () => {
        navigator.clipboard.writeText(codeBlock.innerText).then(() => {
          button.textContent = 'copied!';
          setTimeout(() => (button.textContent = 'copy'),2000);
        });
      });

      // מוודאים שה-pre הוא position: relative
      wrapper.style.position = 'relative';
      wrapper.appendChild(button);
    });
  }

  markAsWatched() {
    console.log('שיעור סומן כנצפה');
  }

  submitComment() {
    console.log('תגובה נשלחה');
  }
}
