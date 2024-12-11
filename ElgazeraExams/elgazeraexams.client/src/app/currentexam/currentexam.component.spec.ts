import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CurrentexamComponent } from './currentexam.component';

describe('CurrentexamComponent', () => {
  let component: CurrentexamComponent;
  let fixture: ComponentFixture<CurrentexamComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CurrentexamComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CurrentexamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
