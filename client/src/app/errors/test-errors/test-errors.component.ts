import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-test-errors',
  templateUrl: './test-errors.component.html',
  styleUrls: ['./test-errors.component.css']
})
export class TestErrorsComponent implements OnInit {
  baseUrl = 'https://localhost:44307/api/' ;
  validationErrors : string[] = [];

  constructor(private http : HttpClient) { }

  ngOnInit(): void {
  }

  get404Error(){  //For getting 404 error, endpoint from server
    this.http.get(this.baseUrl + 'Buggy/not-found').subscribe(response => {
      console.log(response);
    }, error =>{
      console.log(error);
    })
  }
  get400Error(){  //For getting 400 error, endpoint from server
    this.http.get(this.baseUrl + 'Buggy/bad-request').subscribe(response => {
      console.log(response);
    }, error =>{
      console.log(error);
    })
  }
  get500Error(){  //For getting 500 error, endpoint from server
    this.http.get(this.baseUrl + 'Buggy/server-error').subscribe(response => {
      console.log(response);
    }, error =>{
      console.log(error);
    })
  }
  get401Error(){  //For getting 500 error, endpoint from server
    debugger;
    this.http.get(this.baseUrl + 'Buggy/auth').subscribe(response => {
      console.log(response);
    }, error =>{
      console.log(error);
    })
  }
  get400ValidationError(){  //For getting 400 Validation error, endpoint from server
    this.http.post(this.baseUrl + 'Account/register', {}).subscribe(response => {
      console.log(response);
    }, error =>{
      this.validationErrors = error;
      console.log(error);
    })
  }

}
