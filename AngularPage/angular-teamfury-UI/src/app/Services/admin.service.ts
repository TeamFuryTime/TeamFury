import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Employee } from '../models/employee';
import { Observable } from 'rxjs';
import { UserViewModel } from '../models/user.view.model';
import { ApiResponse } from '../models/api-response';
import { map } from 'rxjs';


const APIUrlAuth = "https://localhost:7177/api/"

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  employee:Employee = {
    username: "",
    password: "",
    email: "",
    phoneNumber: "",
    role: ""
  };

  constructor(private http:HttpClient) { }

  createUser(employee:Employee):Observable<Employee>{
    return this.http.post<Employee>(APIUrlAuth + 'admin/employee', employee)
  }

  getAllUsers():Observable<UserViewModel[]>{
    return this.http.get<ApiResponse>(APIUrlAuth + 'admin/employee/view')
    .pipe(map((data) => data.result))
  }

}
