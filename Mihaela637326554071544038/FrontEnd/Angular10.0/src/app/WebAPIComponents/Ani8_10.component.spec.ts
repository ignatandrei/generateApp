@{
	var angular="@angular";
}
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { Ani8_10Component } from './my-test.component';

describe('Ani8_10Component', () => {
  let component: Ani8_10Component;
  let fixture: ComponentFixture<Ani8_10Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ Ani8_10Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Ani8_10Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
