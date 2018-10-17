import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InvestmentComponent } from './service.component';

describe('ServiceComponent', () => {
  let component: InvestmentComponent;
  let fixture: ComponentFixture<InvestmentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InvestmentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InvestmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
