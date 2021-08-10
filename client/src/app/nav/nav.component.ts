import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {

  model : any = {}; //Empty object
  currentUser$ : Observable<User> //Initializes an observable for async pipe
  constructor(private accountService : AccountService  ) { }  //AccountService is injected into the ctor so that we can make use of the service and make a post req to API

  ngOnInit(): void {
    this.currentUser$ = this.accountService.currentUser$; //This will maintain the observable that is used at the login 
  }

  login(){
     this.accountService.login(this.model).subscribe( //since it is an observable we have to use subscribe as it is lazy
       response => {
         console.log(response);
       }, error => {
         console.log(error);
         
       }
     )
  }

  logout(){
    this.accountService.logout();
  }


}
