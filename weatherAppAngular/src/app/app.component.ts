import { Component } from '@angular/core';
import { WeatherService } from './services/weather.service';
import { WeatherResponseDto } from './model/WeatherResponse';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
    city: string;
    country: string;
    weather: WeatherResponseDto;

    constructor(private weatherService: WeatherService) {
    }
    
    checkWeather() {
      this.weatherService.get(this.city,this.country).subscribe((response) => {
        this.weather = response;
      });
    }
}
