import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavLessonsComponent } from './nav-lessons.component';

describe('NavLessonsComponent', () => {
  let component: NavLessonsComponent;
  let fixture: ComponentFixture<NavLessonsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavLessonsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavLessonsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
