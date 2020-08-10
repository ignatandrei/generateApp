@{
	var angular="@angular";
}
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ani12_14Component } from './my-test.component';

describe('Ani12_14Component', () => {
  let component: Ani12_14Component;
  let fixture: ComponentFixture<Ani12_14Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ani12_14Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ani12_14Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
