import { TestBed } from '@angular/core/testing';

import { EmpleoyeeService } from './empleoyee.service';

describe('EmpleoyeeService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EmpleoyeeService = TestBed.get(EmpleoyeeService);
    expect(service).toBeTruthy();
  });
});
