import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DatePipe } from '@angular/common';
import { UserModel } from './models/userModel';
import { UserService } from './services/user.service';

@Component({
  selector: 'app-user-registration',
  templateUrl: './user.component.html',
  styleUrls: []
})
export class UserComponent implements OnInit {

  model: UserModel = new UserModel();
  private _userService;
  output: any;

  constructor(
    private datePipe: DatePipe,
    private _Route: Router,
    private userService: UserService) {
    this._userService = userService;
  }

  ngOnInit() {
  }

  onSubmit() {
    this._userService.AddUser(this.model).subscribe(
      response => {
        this.output = response
        if (this.output.StatusCode == "409") {
          alert('User Already Exists');
        }
        else if (this.output.StatusCode == "200") {
          alert('User Created Successfully');
          this._Route.navigate(['/user/all']);
        }
        else {
          alert('Something Went Wrong');
        }
      });
  }

}
