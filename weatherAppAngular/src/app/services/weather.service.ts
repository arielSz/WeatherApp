import { Injectable } from "@angular/core";
import { Observable } from "rxjs/Observable";
import { HttpClient } from "@angular/common/http";
import { environment } from "../../environments/environment";

@Injectable()
export class WeatherService {

    constructor(private http: HttpClient) {
    }

    public get(city: string, country: string): Observable<any> {
        return this.http.get(`${environment.baseUrl}/api/weather/${country}/${city}`);
    }
}