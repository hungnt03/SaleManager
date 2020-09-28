import { Component, OnInit, ViewChild } from '@angular/core';
import { RoleService } from './services/role.service';
import { RoleModel } from './models/role.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.component.html',
  styleUrls: ['./roles.component.css']
})
export class RolesComponent implements OnInit {

  private _roleService;
  roles: RoleModel[];
  errorMessage: any;

  constructor(private _route: Router, private roleService: RoleService) {
    this._roleService = roleService;
   }

  ngOnInit() {
    this._roleService.GetAll().subscribe(
      data => {
        this.roles = data
      },
      error => this.errorMessage = <any>error
    );
  }

  onDelete(id: number) {
    if (confirm("Are you sure to delete Role ?")) {
      this._roleService.Delete(id).subscribe(
        response => {
          if (response.status == "200") {
            alert('Deleted role successfully');
            location.reload();
          } else {
            alert('Something went wrong');
            this._route.navigate(['/role/all']);
          }
        }
      );
    }
  }

}
