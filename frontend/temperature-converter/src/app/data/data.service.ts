import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { TemperatureConversion } from './temperature-conversion';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  constructor(private http: HttpClient) {}

  postTemperatureConversionForm(
    temperatureConversion: TemperatureConversion
  ): Observable<any> {
    var response = this.http.post(
      'http://localhost:36994/api/temperature',
      temperatureConversion
    );

    return response;
  }
}
