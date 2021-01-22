import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from './models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private _client: HttpClient;

  constructor(httpClient: HttpClient) {
    this._client = httpClient;
  }

  public getUsers(): Observable<User[]> {
    return this._client.get<User[]>('http://iis-prod/azure/v1.0/api/users', {withCredentials: true});
  }
}
