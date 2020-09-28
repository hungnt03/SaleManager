import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router'
import { CategoryService } from './services/category.service';
import { CategoryModel } from './models/category.model';
import {FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  private _categoryService;
  model: CategoryModel = new CategoryModel();
  errorMessage: any;
  categoryId: any;
  formGroup: FormGroup;

  constructor(private _route: Router, private _routeParams: ActivatedRoute, private categoryService: CategoryService) {
    this._categoryService = categoryService;
  }

  ngOnInit() {
    this.categoryId = +this._routeParams.snapshot.paramMap.get('categoryId');
    console.log(`this.route.snapshot.paramMap = ${JSON.stringify(this._routeParams.snapshot.paramMap)}`);
    console.log(`categoryId = ${this.categoryId}`);
    //Get category
    if (this.categoryId != null && this.categoryId != 0) {
      this._categoryService.GetCategoryById(this.categoryId).subscribe(
        data => {
          this.model = data
        },
        error => this.errorMessage = <any>error
      );
    }

    this.formGroup = new FormGroup({
      name: new FormControl('', [
        Validators.required,
      ]),
      description: new FormControl('', [
        Validators.required,
        Validators.minLength(8),
        Validators.maxLength(20)
      ])
    });
  }

  onSubmit() {
    if (this.categoryId == null || this.categoryId === 0) {
      this._categoryService.AddCategory(this.model).subscribe(
        response => {
          if (response.status == "409") {
            alert('category Already Exists');
          }
          else if (response.status == "200") {
            alert('category Saved Successfully');
            this._route.navigate(['/category/all']);
          }
          else {
            alert('Something Went Wrong');
          }
        });
    } else {
      this._categoryService.UpdatePlan(this.model).subscribe(
        response => {
          if (response.status == "200") {
            alert('category Saved Successfully');
            this._route.navigate(['/category/all']);
          }
          else {
            alert('Something Went Wrong');
          }
        });
    }
  }

  onReset() {
    this.formGroup.reset();
  }
}
