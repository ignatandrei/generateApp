import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ani10_12Component } from './my-test.component';

describe('Ani10_12Component', () => {
  let component: Ani10_12Component;
  let fixture: ComponentFixture<Ani10_12Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ani10_12Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ani10_12Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
