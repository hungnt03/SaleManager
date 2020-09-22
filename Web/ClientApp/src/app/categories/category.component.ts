import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router'
import { CategoryService } from './services/category.service';
import { CategoryModel } from './models/categoryModel';

@Component({
  selector: 'category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css']
})
export class CategoryComponent implements OnInit {

  private _categoryService;
  category: CategoryModel = new CategoryModel();
  errorMessage: any;
  categoryId: any;

  constructor(private _route: Router, private _routeParams: ActivatedRoute, private categoryService: CategoryService) {
    this._categoryService = categoryService;
  }

  ngOnInit() {
    this.categoryId = +this._routeParams.snapshot.paramMap.get('categoryId');
    console.log(`this.route.snapshot.paramMap = ${JSON.stringify(this._routeParams.snapshot.paramMap)}`);
    //Get category
    if (this.categoryId != null) {
      this._categoryService.GetCategoryById(this.categoryId).subscribe(
        data => {
          this.category = data
        },
        error => this.errorMessage = <any>error
      );
    }
  }

  onSubmit() {
    if (this.categoryId == null) {
      this._categoryService.AddCategory(this.category).subscribe(
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
      this._categoryService.UpdatePlan(this.category).subscribe(
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
}
