import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { Observable, throwError } from 'rxjs'
import { catchError, tap } from 'rxjs/operators'
import { HttpClient, HttpErrorResponse, HttpHeaders, HttpResponse } from '@angular/common/http';
import { CategoryModel } from '../models/categoryModel'
import { CategoryViewModel } from '../models/categoryViewModel'
import { CategoryActiveModel } from '../models/categoryActiveModel'

@Injectable({
    providedIn: 'root'
})

export class CategoryService {
    private data: any;
    private apiUrl = environment.apiEndpoint + "/api/category";
    token: any;
    username: any;

    constructor(private http: HttpClient) {
        this.data = JSON.parse(localStorage.getItem('AdminUser'));
        this.token = this.data.token;
    }

    // Get All Plans
    public GetAllCategory(): Observable<CategoryModel[]> {
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.get<CategoryModel[]>(this.apiUrl + "/get", { headers: headers }).pipe(tap(data => data),
            catchError(this.handleError)
        );
    }

    // Get All Plans by PlanId
    public GetCategoryById(id): Observable<CategoryModel> {
        var editurl = this.apiUrl + "/get/" + id;
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.get<CategoryModel>(editurl, { headers: headers }).pipe(tap(data => data),
            catchError(this.handleError)
        );
    }

    // Update Plan
    public UpdatePlan(categoryModel: CategoryModel) {
        var updateurl = this.apiUrl + "/update";
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(updateurl, categoryModel, { headers: headers })
            .pipe(
                catchError(this.handleError)
            );
    }

    public DeleteCategory(id: number) {
        var data = new CategoryModel();
        data.id = id;
        var deleteUrl = this.apiUrl + '/delete'
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(deleteUrl, data, { headers: headers, observe: "response" })
            .pipe(
                catchError(this.handleError)
            );
    }

    // Add Category
    public AddCategory(categoryModel: CategoryModel) {
        var addurl = this.apiUrl + "/insert";
        let headers = new HttpHeaders({ 'Content-Type': 'application/json' });
        headers = headers.append('Authorization', 'Bearer ' + `${this.token}`);
        return this.http.post<any>(addurl, categoryModel, { headers: headers, observe: "response" })
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
