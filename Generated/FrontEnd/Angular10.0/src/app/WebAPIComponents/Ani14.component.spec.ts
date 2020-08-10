import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ani14Component } from './my-test.component';

describe('Ani14Component', () => {
  let component: Ani14Component;
  let fixture: ComponentFixture<Ani14Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ani14Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ani14Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
