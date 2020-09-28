import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router'
import { RoleService } from './services/role.service';
import { RoleModel } from './models/role.model';
import {FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-roles',
  templateUrl: './role.component.html',
  styleUrls: []
})
export class RoleComponent implements OnInit {

  private _roleService;
  model: RoleModel = new RoleModel();
  errorMessage: any;
  roleId: any;
  formGroup: FormGroup;

  constructor(private _route: Router, private _routeParams: ActivatedRoute, private roleService: RoleService) {
    this._roleService = roleService;
   }

  ngOnInit() {
    this.roleId = this._routeParams.snapshot.paramMap.get('roleId');
    console.log(`roleId = ${this.roleId}`);
    //Get role
    if (this.roleId != null && this.roleId != '') {
      this._roleService.GetById(this.roleId).subscribe(
        data => {
          this.model = data
        },
        error => this.errorMessage = <any>error
      );
    }

    this.formGroup = new FormGroup({
      name: new FormControl('', [
        Validators.required,
      ])
    });
  }

  onSubmit() {
    if (this.roleId == null || this.roleId === '') {
      this._roleService.Add(this.model).subscribe(
        response => {
          if (response.status == "409") {
            alert('role already Exists');
          }
          else if (response.status == "200") {
            alert('role saved successfully');
            this._route.navigate(['/role/all']);
          }
          else {
            alert('something went wrong');
          }
        });
    } else {
      this._roleService.Update(this.model).subscribe(
        response => {
          if (response.status == "200") {
            alert('role saved successfully');
            this._route.navigate(['/role/all']);
          }
          else {
            alert('something went wrong');
          }
        });
    }
  }

  onReset() {
    this.formGroup.reset();
  }

}
