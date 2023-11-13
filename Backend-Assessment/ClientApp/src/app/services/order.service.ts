import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {IPage} from "../models/order-model";
import {map} from "rxjs/operators";
import {Observable} from "rxjs";
import {environment} from "../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  apiUrl = environment.apiUrl;

  constructor(
    private http: HttpClient) {

  }

  public getCategories(body: IPage): Observable<any> {
    const headers = {'content-type': 'application/json'}
    const data = JSON.stringify(body);
    return this.http.post(`${this.apiUrl}Category/GetCategories`, data, {'headers':headers}).pipe(map((result) => {
        return result;
      })
    );
  }
}
