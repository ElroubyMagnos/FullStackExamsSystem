import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HomelogoutComponent } from './homelogout.component';

describe('HomelogoutComponent', () => {
  let component: HomelogoutComponent;
  let fixture: ComponentFixture<HomelogoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HomelogoutComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HomelogoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
