import { Component, OnInit } from '@angular/core';
import { TemperatureConversion } from '../data/temperature-conversion';
import { DataService } from '../data/data.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-temperature-converter-form',
  templateUrl: './temperature-converter-form.component.html',
  styleUrls: ['./temperature-converter-form.component.css'],
})
export class TemperatureConverterFormComponent implements OnInit {
  originalTemperatureConversion: TemperatureConversion = {
    temperatureTypeFrom: 0,
    temperatureTypeTo: 0,
    temperatureValueFrom: 0,
    temperatureValueTo: 0,
  };

  temperatureConversion: TemperatureConversion = {
    ...this.originalTemperatureConversion,
  };

  constructor(private dataService: DataService) {}

  ngOnInit(): void {}

  onSubmit(form: NgForm) {
    this.dataService
      .postTemperatureConversionForm(this.temperatureConversion)
      .subscribe(
        (result) => {
          this.temperatureConversion = result;
        },
        (error) => console.log('error:', error)
      );
  }
}
