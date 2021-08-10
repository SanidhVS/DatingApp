import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map} from 'rxjs/operators';
import { User } from '../_models/user';

@Injectable({   //this service can be injected into other components or services
  providedIn: 'root'
})
export class AccountService {

  baseURL = "https://localhost:44307/api/";
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable(); //Createws an observable
  constructor(private http: HttpClient ) {

  }

  login(model : any){
    return this.http.post(this.baseURL + 'account/login' , model).pipe( //This refers to the the api that we created in AccountController.cs and pass the parameter model as the parameter for backend
      map((response : User) =>
      {
        const user = response;
        if(user){
          localStorage.setItem('user', JSON.stringify(user));   //Sets up the user log in in local storage of the browser for persisting the login
          this.currentUserSource.next(user); //grabs the next observable
        }
      }
      )
    ); 
  }

  logout(){

    localStorage.removeItem('user'); //For removing the log session from the local storage while logging out
    this.currentUserSource.next(null);
  }

  setCurrentUser(user : User){
    this.currentUserSource.next(user);
  }

  register(model : any){ //Register method for adding new users
    return this.http.post(this.baseURL + 'account/register', model).pipe(
      map((user : User) => {
        if(user){
          localStorage.setItem('user', JSON.stringify(user));
          this.currentUserSource.next(user);
        }
      })
    ) 
}
}
