import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, of, throwError  } from 'rxjs';
import { Empleoyee } from './empleoyee'; 
import { map, retry, catchError, tap } from 'rxjs/operators';


const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
};
const apiUrl = "https://localhost:44353/api/EmpleoyesAPI";

@Injectable({
  providedIn: 'root'
})



export class EmpleoyeeService {
  //url = 'https://localhost:44353/api/EmpleoyesAPI';
  private empleoyees  = []; 
  constructor(private http: HttpClient) { }

 
  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
  
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
  
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  //: Observable<Empleoyee> 
  getEmployees(): Observable<Empleoyee[]>  {
   
    return this.http.get<Empleoyee[]>(apiUrl)
    .pipe(
      tap(heroes => console.log('fetched employees')),
      catchError(this.handleError('getEmployees', []))
    );
   
    //return this.http.get<Empleoyee[]>(this.url + "/AllEmployeeDetails");  
    
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

 /*  getAllEmployee(): Observable<Empleoyee[]> {
     return this.http.get<Empleoyee[]>(this.url);
  }  
 */
  getEmployeeById(employeeId: string): Observable<Empleoyee> {  
    const url = `${apiUrl}/${employeeId}`;
    return this.http.get<Empleoyee>(url).pipe(
      tap(_ => console.log(`fetched product id=${employeeId}`)),
      catchError(this.handleError<Empleoyee>(`getEmployeeById id=${employeeId}`))
    );


    //return this.http.get<Empleoyee>(this.url + employeeId);  
  }  

  private extractData(res: Response) {
    let body = res;
    return body || { };
  }

/* 
  handleError(error) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    window.alert(errorMessage);
    return throwError(errorMessage);
  } */

}
