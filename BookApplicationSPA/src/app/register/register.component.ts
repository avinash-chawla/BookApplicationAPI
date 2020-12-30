import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../_services/auth.service';

export interface Register{
  email: string,
  password: string
}

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  registerUserData = {
    username: "",
    password: ""
  }
  constructor(private auth: AuthService, private router: Router) { }

  ngOnInit() {
  }

  registerUser() {
    this.auth.registerUser(this.registerUserData)
    .subscribe(
      res => {
        localStorage.setItem('token', res.token)
        this.router.navigate(['/special'])
      },
      err => console.log(err)
    )      
  }

}
