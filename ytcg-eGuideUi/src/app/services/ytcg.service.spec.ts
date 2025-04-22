import { TestBed } from '@angular/core/testing';

import { YtcgService } from './ytcg.service';

describe('YtcgService', () => {
  let service: YtcgService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(YtcgService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
