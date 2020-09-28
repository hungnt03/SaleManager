import { Component, OnInit, ViewChild } from '@angular/core';
import { CategoryService } from './services/category.service';
import { CategoryModel } from './models/category.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {

  private _categoryService;
  categories: CategoryModel[];
  errorMessage: any;

  constructor(private _route: Router, private categoryService: CategoryService) {
    this._categoryService = categoryService;
  }

  ngOnInit() {
    this._categoryService.GetAllCategory().subscribe(
      data => {
        this.categories = data
      },
      error => this.errorMessage = <any>error
    );
  }

  onDelete(id: number) {
    if (confirm("Are you sure to delete Category ?")) {
      this._categoryService.DeleteCategory(id).subscribe(
        response => {
          if (response.status == "200") {
            alert('Deleted Category Successfully');
            location.reload();
          } else {
            alert('Something Went Wrong');
            this._route.navigate(['/category/all']);
          }
        }
      );
    }
  }

  applyFilter(filterValue: string) {
    
  }
}
