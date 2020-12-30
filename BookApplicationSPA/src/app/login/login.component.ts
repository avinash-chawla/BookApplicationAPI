import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginUserData = {
    username: "",
    password: ""
  };

  constructor(private auth: AuthService, private router: Router) { }

  ngOnInit() {
  }

  loginUser () {
    this.auth.loginUser(this.loginUserData)
    .subscribe(
      res => {
        localStorage.setItem('token', res.token)
        console.log(res);
        console.log(res.token);
        this.router.navigate(['/'])
      },
      err => console.log(err)
    ) 
  }

}
