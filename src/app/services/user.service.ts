import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../model/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = `${environment.ApiUrl}/User`;

  constructor(private http: HttpClient) {}

  GetUser(): Observable<User[]> {
    return this.http.get<User[]>(this.apiUrl);
  }

  GetUserId(id : number) : Observable<User>{
    console.log(1)
     return this.http.get<User>(`${this.apiUrl}/${id}`);
     
  }

  CreateUser(user: User): Observable<User> {
    //const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post<User>(this.apiUrl, user );//{ headers });
  }
  Delete(id:number | undefined) : Observable<User[]>{
      return this.http.delete<User[]>(`${this.apiUrl}/${id}`);
      
  }
  
}
 