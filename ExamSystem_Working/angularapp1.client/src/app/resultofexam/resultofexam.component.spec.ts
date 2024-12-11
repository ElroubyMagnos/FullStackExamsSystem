import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ResultofexamComponent } from './resultofexam.component';

describe('ResultofexamComponent', () => {
  let component: ResultofexamComponent;
  let fixture: ComponentFixture<ResultofexamComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ResultofexamComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ResultofexamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
