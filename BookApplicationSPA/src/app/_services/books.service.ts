import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Book } from '../_models/book.model';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) { }

  private apiUrl : string = environment.apiUrl + 'api/books/';

  getBooks() {
    return this.http.get<Book[]>(this.apiUrl);
  }

  getBook(id: string) {
    return this.http.get<Book>(this.apiUrl + id);
  }

  postBook(name: string, author: string, type: string) {
    const book = { name, author, type };
    return this.http.post<Book>(this.apiUrl, book);
  }

  updateBook(_id: string, name: string, author: string, type: string) {
    const book = { _id, name, author, type };
    return this.http.put<Book>(this.apiUrl +  _id, book);
  }

  deleteBook(id: string) {
    return this.http.delete<Book>(this.apiUrl + id);
  }
}
