import { AuthGuard } from './auth.guard';
import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from "@angular/router";
import { BookAddeditComponent } from './books/book-addedit/book-addedit.component';
import { BookListComponent } from './books/book-list/book-list.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';

const routes : Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/login'},
  { path: 'list', component: BookListComponent },
  { path: 'create', component: BookAddeditComponent },
  { path: 'edit/:id', component: BookAddeditComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }