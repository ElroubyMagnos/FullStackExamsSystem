import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TestselectComponent } from './testselect.component';

describe('TestselectComponent', () => {
  let component: TestselectComponent;
  let fixture: ComponentFixture<TestselectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TestselectComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TestselectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
