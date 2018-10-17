import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PalmCarouselComponent } from './palm-carousel.component';

describe('PalmCarouselComponent', () => {
  let component: PalmCarouselComponent;
  let fixture: ComponentFixture<PalmCarouselComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PalmCarouselComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PalmCarouselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
