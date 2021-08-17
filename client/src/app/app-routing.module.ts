import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [  //This represents the different routing that we want, and its here that we declare different paths and where should it direct to
  {path: '', component: HomeComponent}, //Will route to home component when there is no /
  {
    path : '',
    runGuardsAndResolvers : 'always',
    canActivate : [AuthGuard], //Will route to MemberListComponent, AuthGuard is used for preventing unauthorized access
    children : [
      {path: 'members', component: MemberListComponent}, 
      {path: 'members/:id', component: MemberDetailComponent}, //Will route to MemberDetailComponent
      {path: 'lists', component: ListsComponent}, //Will route to ListsComponent
      {path: 'messages', component: MessagesComponent}, //Will route to MessagesComponent

    ]
  },
  {path: 'errors', component : TestErrorsComponent},
  {path: 'not-found', component : NotFoundComponent},
  {path: 'server-error', component : ServerErrorComponent},
  {path: '**', component: NotFoundComponent, pathMatch : 'full'}, //Will route to home component if theres any wrong URL



]; 

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
