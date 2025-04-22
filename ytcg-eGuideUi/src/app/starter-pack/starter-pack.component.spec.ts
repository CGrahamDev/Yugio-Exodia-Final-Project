import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StarterPackComponent } from './starter-pack.component';

describe('StarterPackComponent', () => {
  let component: StarterPackComponent;
  let fixture: ComponentFixture<StarterPackComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StarterPackComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StarterPackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
