import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpleoyeeComponent } from './empleoyee.component';

describe('EmpleoyeeComponent', () => {
  let component: EmpleoyeeComponent;
  let fixture: ComponentFixture<EmpleoyeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmpleoyeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpleoyeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
