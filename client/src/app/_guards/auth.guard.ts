import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AccountService } from '../_services/account.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  private constructor(private accountService : AccountService, private toastr : ToastrService ){}
  canActivate(): Observable<boolean> { //Used as route guard, so if and only if the user is logged in, he can use the component
    return this.accountService.currentUser$.pipe(
      map(user =>{
        if(user) return true;
        this.toastr.error("You shall not pass!!")
      })
    );
  }
  
}
