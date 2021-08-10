import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  // @Input() usersFromHomeComponent : any //This is used for parent-child relationship
  @Output() cancelRegister = new EventEmitter(); //This is used for child-parent relationship
  model : any = {};
  constructor(private accountService : AccountService) {}

  ngOnInit(): void {
  }

  register(){ //This method will pass the model to the service which will pass to API
    this.accountService.register(this.model).subscribe(
      response => {
        console.log(response);
        this.cancel();
        
      }, error =>{
        console.log(error);
        
      }
    )

    
  }

  cancel(){
    console.log("Cancelled");
    this.cancelRegister.emit(false);
  }
}
