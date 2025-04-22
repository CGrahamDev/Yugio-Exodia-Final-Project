import { TestBed } from '@angular/core/testing';

import { GuideApiService } from './guide-api.service';

describe('GuideApiService', () => {
  let service: GuideApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GuideApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
