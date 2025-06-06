import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GooglePayComponent } from './google-pay.component';

describe('GooglePayComponent', () => {
  let component: GooglePayComponent;
  let fixture: ComponentFixture<GooglePayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GooglePayComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GooglePayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
