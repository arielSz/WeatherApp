export class WeatherResponseDto {
    Humidity: Number;
    Location: Location;
    Temperature: Temperature;
}
class Location{
    City: string;
    Country: string;
}
class Temperature{
    Format: string;
    Value: number;
}