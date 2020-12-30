import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { Book } from 'src/app/_models/book.model';
import { BooksService } from 'src/app/_services/books.service';

@Component({
  selector: 'app-book-addedit',
  templateUrl: './book-addedit.component.html',
  styleUrls: ['./book-addedit.component.css']
})
export class BookAddeditComponent implements OnInit {
  
  private mode = "create";
  private bookId: string;
  book: Book = {
    _id: "",
    name: "",
    author: "",
    type: ""
  }

  constructor(private booksService: BooksService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe((paramMap: ParamMap) => {
      if (paramMap.has('id')) {
        this.mode = "edit";
        this.bookId = paramMap.get('id');
        this.booksService.getBook(this.bookId)
          .subscribe(res => {
            this.book = res;
            console.log(res);
          });
      } else {
        this.mode = "create";
        this.bookId = null;
      }
    })
  }

  onSave(form: NgForm) {
    if (form.invalid) {
      return;
    }
    if (this.mode === "create") {
      this.booksService.postBook(form.value.name, form.value.author, form.value.type)
        .subscribe((res) => {
          this.router.navigate(['/list']);
        }, err => console.log(err));
    } else {
      this.booksService.updateBook(this.bookId, form.value.name, form.value.author, form.value.type)
        .subscribe(res => {
          this.router.navigate(['/list']);
        }, err => console.log(err));
    }
    form.resetForm();
  }

}
