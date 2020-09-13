import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginModel } from './models/loginModel';
import { LoginService } from './services/loginService';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  private _loginservice;
  output: any;

  constructor(private _Route: Router, loginservice: LoginService) { 
    this._loginservice = loginservice;
  }

  LoginModel: LoginModel = new LoginModel();  

  ngOnInit() {
    localStorage.clear();
  }

  onSubmit() 
    {
      this._loginservice.validateLoginUser(this.LoginModel).subscribe(
        response => 
        {     
            if (response.token == null || response.role == -1) {
              console.log(`response = ${response.token}`);
              this._Route.navigate(['/login']);
            }
              

            if (response.role == 1) 
              this._Route.navigate(['/admin/dashboard']);

            if (response.role == 2) 
              this._Route.navigate(['/user/dashboard']);
        });
    }

}
