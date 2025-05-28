import { Injectable } from '@angular/core';
import { Lesson } from '../Class/Lesson';

@Injectable({
  providedIn: 'root'
})
export class LessonService {

  constructor() {
    const lesson: Lesson = {
      id: 1,
      title: 'מבוא ל-HTML',
      content: `
    <div class="container py-5">
      <div class="card shadow-lg border-0">
        <div class="card-body" style="font-family: Arial; color: #333; line-height: 1.7;">
          
          <h2 class="text-primary mb-3">מה זה HTML?</h2>
          
          <p><strong>HTML</strong> היא שפת סימון לבניית מבנה של דפי אינטרנט. היא כוללת תגיות כמו <code>&lt;div&gt;</code>, <code>&lt;p&gt;</code>, <code>&lt;img&gt;</code> ועוד.</p>
          
          <ul class="list-group list-group-flush mb-4">
            <li class="list-group-item">תגיות כותרת: <code>&lt;h1&gt; ... &lt;/h1&gt;</code></li>
            <li class="list-group-item">פסקאות: <code>&lt;p&gt; ... &lt;/p&gt;</code></li>
            <li class="list-group-item">תמונות: <code>&lt;img src="..." /&gt;</code></li>
          </ul>
          
          <h4 class="text-info mb-2">💡 דוגמה לקוד:</h4>
    
          <div class="position-relative">
            <pre class="bg-light border rounded p-3"><code>&lt;!DOCTYPE html&gt;
    &lt;html&gt;
      &lt;head&gt;
        &lt;title&gt;הדף הראשון שלי&lt;/title&gt;
      &lt;/head&gt;
      &lt;body&gt;
        &lt;h1&gt;שלום עולם&lt;/h1&gt;
        &lt;p&gt;זהו פסקה ראשונה&lt;/p&gt;
      &lt;/body&gt;
    &lt;/html&gt;
    </code></pre>
          </div>
    
          <h4 class="text-success mb-2">📸 דוגמה לתמונה:</h4>
          <img src=".png" alt="HTML Example" class="img-fluid rounded border mb-4" />
          
          <h4 class="text-purple mb-2">🎥 סרטון הסבר:</h4>
          <div class="ratio ratio-16x9 mb-4">
            <video controls class="rounded">
              <source src="https://example.com/videos/html-intro.mp4" type="video/mp4" />
              הדפדפן שלך לא תומך בהצגת וידאו.
            </video>
          </div>
          
          <blockquote class="blockquote bg-light border-start border-primary ps-3 py-2">
            <p class="mb-0">HTML היא הבסיס לכל עמוד אינטרנט.</p>
          </blockquote>
          
          <p class="mt-4 text-muted">🧭 בשיעור הבא נלמד על CSS וכיצד לעצב דף אינטרנט.</p>
        </div>
      </div>
    </div>
    `
    };
    

    this.Lessons.push(new Lesson(lesson.id, lesson.title, lesson.content, lesson.videoUrl))
  }
  Lessons: Array<Lesson> = new Array<Lesson>()
  courseName:string=''
}
