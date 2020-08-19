import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ValoriComponent } from './my-test.component';

describe('ValoriComponent', () => {
  let component: ValoriComponent;
  let fixture: ComponentFixture<ValoriComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ValoriComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ValoriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
