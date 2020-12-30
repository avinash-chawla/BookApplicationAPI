import { AuthService } from './_services/auth.service';
import { Injectable, Injector } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class TokenInterceptorService implements HttpInterceptor {

  constructor(private injector: Injector) {}

  
  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let authService = this.injector.get(AuthService);
    let tokenisedReq = request.clone(
      { headers : request.headers.set("Authorization","bearer "+ authService.getToken())}
    )
    return next.handle(request);
  }
}
