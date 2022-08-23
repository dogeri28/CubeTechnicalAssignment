import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemperatureConverterFormComponent } from './temperature-converter-form.component';

describe('TemperatureConverterFormComponent', () => {
  let component: TemperatureConverterFormComponent;
  let fixture: ComponentFixture<TemperatureConverterFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemperatureConverterFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemperatureConverterFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
