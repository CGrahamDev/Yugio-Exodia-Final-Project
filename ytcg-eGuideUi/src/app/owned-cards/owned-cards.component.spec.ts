import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OwnedCardsComponent } from './owned-cards.component';

describe('OwnedCardsComponent', () => {
  let component: OwnedCardsComponent;
  let fixture: ComponentFixture<OwnedCardsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [OwnedCardsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OwnedCardsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
