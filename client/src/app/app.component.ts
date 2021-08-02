import { HttpClient } from '@angular/common/http';
import { OnInit } from '@angular/core';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  users : any;
  constructor(private http : HttpClient) {};
  ngOnInit(){
    this.getUsers();
  }
  getUsers(){
    this.http.get('https://localhost:44307/api/Users').subscribe(
      response => {
        this.users = response;
      },
      error => {
        console.log(error);
      }
    )
  }
  title = 'The Dating App';

}
