import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs'
import { catchError, tap } from 'rxjs/operators'
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpResponse } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { UserModel } from '../models/userModel';

@Injectable({
    providedIn: 'root'
})

export class UserService {

    private data: any;
    private apiUrl = environment.apiEndpoint + "/api/auth";
    token: any;
    username: any;

    constructor(private http: HttpClient) {
        this.data = JSON.parse(localStorage.getItem('adminUser'));
        this.token = this.data.token;
    }

    public GetAllUser(): Observable<UserModel[]> {
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.get<UserModel[]>(this.apiUrl + "/get", { headers: headers }).pipe(tap(data => data),
            catchError(this.handleError)
        );
    }

    public GetUserById(id: string): Observable<UserModel> {
        var editurl = this.apiUrl + "/get/" + id;
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.get<UserModel>(editurl, { headers: headers }).pipe(tap(data => data),
            catchError(this.handleError)
        );
    }

    public AddUser(model: UserModel) {
        var addurl = this.apiUrl + "/register";
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(this.apiUrl, model, { headers: headers })
            .pipe(
                catchError(this.handleError)
            );
    }

    private handleError(error: HttpErrorResponse) {
        if (error.error instanceof ErrorEvent) {
            // A client-side or network error occurred. Handle it accordingly.
            console.error('An error occurred:', error.error.message);
        } else {
            // The backend returned an unsuccessful response code.
            // The response body may contain clues as to what went wrong,
            console.error(`Backend returned code ${error.status}, ` + `body was: ${error.error}`);
        }
        // return an observable with a user-facing error message
        return throwError('Something bad happened; please try again later.');
    };
}