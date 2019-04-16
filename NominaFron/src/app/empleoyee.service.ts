import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, of, throwError  } from 'rxjs';
import { Empleoyee } from './empleoyee'; 
import { map, retry, catchError, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})



export class EmpleoyeeService {
  url = 'https://localhost:44353/api/EmpleoyesAPI';
  private empleoyees  = []; 
  constructor(private http: HttpClient) { }

  //: Observable<Empleoyee> 
  getEmployees(): Observable<Empleoyee[]>  {
    return this.http.get<Empleoyee[]>(this.url + "/AllEmployeeDetails");  
    
   // return this.http.get(this.url).subscribe((res : any[])=>{
   //   console.log(res);
   //   this.empleoyees = res;
   //   });

      


    // return this.http.get<Empleoyee>(this.url)
    //.pipe(
    //  retry(1),
    //  catchError(this.handleError)
    //)

// Tried adding headers with no luck

  }

  getAllEmployee(): Observable<Empleoyee[]> {
     return this.http.get<Empleoyee[]>(this.url);
  }  

  getEmployeeById(employeeId: string): Observable<Empleoyee> {  
    return this.http.get<Empleoyee>(this.url + employeeId);  
  }  

  private extractData(res: Response) {
    let body = res;
    return body || { };
  }

  handleError(error) {
    let errorMessage = '';
    if(error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    window.alert(errorMessage);
    return throwError(errorMessage);
 }

}
