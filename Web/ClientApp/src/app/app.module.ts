import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
//https://www.npmjs.com/package/ng-bootstrap-form-validation
//npm i ng-bootstrap-form-validation
import { NgBootstrapFormValidationModule, CUSTOM_ERROR_MESSAGES } from 'ng-bootstrap-form-validation';

import { AdminAuthGuardService } from './auth-guard/AdminAuthGuardService';
import { UserAuthGuardService } from './auth-guard/UserAuthGuardService';
import { CategoryService } from './categories/services/category.service';
import { RoleService } from './roles/services/role.service';

import { CUSTOM_ERRORS } from "./_layout/custom-errors";

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { UploadComponent } from './upload/upload.component';
import { LoginComponent } from './login/login.component';
import { AdminDashboardComponent } from './admin-dashboard/admin-dashboard.component';
import { UserDashboardComponent } from './user-dashboard/user-dashboard.component';
import { AdminLayoutComponent } from './_layout/admin-layout.component';
import { UserLayoutComponent } from './_layout/user-layout.component';
import { CategoriesComponent } from './categories/categories.component';
import { CategoryComponent } from './categories/category.component';
import { UserComponent } from './auths/user.component'
import { UsersComponent } from './auths/users.component'
import { UserEditComponent } from './auths/user-edit.component';
import { RolesComponent } from './roles/roles.component'
import { RoleComponent } from './roles/role.component'
import { RoleModel } from './roles/models/Role.model';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    UploadComponent,
    LoginComponent,
    AdminDashboardComponent,
    UserDashboardComponent,
    AdminLayoutComponent,
    UserLayoutComponent,
    CategoriesComponent,
    CategoryComponent,
    UserComponent,
    UsersComponent,
    UserEditComponent,
    RolesComponent,
    RoleComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule,
    NgBootstrapFormValidationModule.forRoot(),
    NgBootstrapFormValidationModule,
    RouterModule.forRoot([
      { path: '', redirectTo: '/login', pathMatch: 'full' },
      {
        path: 'admin', component: AdminLayoutComponent,
        children: [
          { path: 'dashboard', component: AdminDashboardComponent, canActivate: [AdminAuthGuardService] }
        ]
      },
      {
        path: 'user', component: UserLayoutComponent,
        children: [
          { path: 'dashboard', component: UserDashboardComponent, canActivate: [UserAuthGuardService] }
        ]
      },
      {
        path: 'category',
        component: AdminLayoutComponent,
        children: [
          { path: 'all', component: CategoriesComponent, canActivate: [AdminAuthGuardService] },
          { path: 'detail/:categoryId', component: CategoryComponent, canActivate: [AdminAuthGuardService] },
          { path: 'add', component: CategoryComponent, canActivate: [AdminAuthGuardService] },
        ]
      },
      {
        path: 'role',
        component: AdminLayoutComponent,
        children: [
          { path: 'all', component: RolesComponent, canActivate: [AdminAuthGuardService] },
          { path: 'detail/:roleId', component: RoleComponent, canActivate: [AdminAuthGuardService] },
          { path: 'add', component: RoleComponent, canActivate: [AdminAuthGuardService] },
        ]
      },
      {
        path: 'user',
        component: AdminLayoutComponent,
        children: [
          { path: 'all', component: UsersComponent },
          { path: 'add', component: UserComponent },
          { path: 'edit', component: UserEditComponent }
        ]
      },
      { path: 'login', component: LoginComponent },
      { path: 'home', component: HomeComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [
    AdminAuthGuardService,
    UserAuthGuardService,
    CategoryService,
    RoleService,
    {
      provide: CUSTOM_ERROR_MESSAGES,
      useValue: CUSTOM_ERRORS,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
