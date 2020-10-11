import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable, throwError } from 'rxjs'
import { catchError, tap } from 'rxjs/operators'
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpResponse } from '@angular/common/http';
import { RoleModel } from '../models/role.model'

@Injectable({
    providedIn: 'root'
})

export class RoleService {
    private data: any;
    private apiUrl = environment.apiEndpoint + "/api/role";
    token: any;
    username: any;

    constructor(private http: HttpClient) {
        this.data = JSON.parse(localStorage.getItem('adminUser'));
        this.token = this.data.token;
    }

    public GetAll(): Observable<RoleModel[]> {
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.get<RoleModel[]>(this.apiUrl + "/get", { headers: headers }).pipe(tap(data => data),
            catchError(this.handleError)
        );
    }

    public GetById(id: string): Observable<RoleModel> {
        var editurl = this.apiUrl + "/get/" + id;
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.get<RoleModel>(editurl, { headers: headers }).pipe(tap(data => data),
            catchError(this.handleError)
        );
    }

    public Update(model: RoleModel) {
        var updateurl = this.apiUrl + "/update";
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(updateurl, model, { headers: headers, observe: "response" })
            .pipe(
                catchError(this.handleError)
            );
    }

    public Delete(id: number) {
        var data = new RoleModel();
        data.id = id;
        var deleteUrl = this.apiUrl + '/delete'
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(deleteUrl, data, { headers: headers, observe: "response" })
            .pipe(
                catchError(this.handleError)
            );
    }

    public Add(model: RoleModel) {
        var addurl = this.apiUrl + "/insert";
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(addurl, model, { headers: headers, observe: "response" })
            .pipe(
                catchError(this.handleError)
            );
    }

    private handleError(error: HttpErrorResponse) {
        console.log(`handleError:--${error.status}-${error.error.message}`)
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
