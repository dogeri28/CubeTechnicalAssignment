import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { TemperatureConverterFormComponent } from './temperature-converter-form/temperature-converter-form.component';

@NgModule({
  declarations: [AppComponent, TemperatureConverterFormComponent],
  imports: [BrowserModule, FormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
