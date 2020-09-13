import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AdminAuthGuardService } from './auth-guard/AdminAuthGuardService';
import { UserAuthGuardService } from './auth-guard/UserAuthGuardService';

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
    UserLayoutComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NgbModule,
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
      { path: 'login', component: LoginComponent },
      { path: 'home', component: HomeComponent },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [AdminAuthGuardService,UserAuthGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
