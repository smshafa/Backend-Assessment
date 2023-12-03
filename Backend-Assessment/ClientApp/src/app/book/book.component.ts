import {Component, OnInit} from '@angular/core';
import {BookService} from "../services/book.service";
import {IPenaltyBussinessQuery} from "../models/penalty-bussiness-model";

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  public checkin: any;
  public checkout: any;
  public country: any;
  public result: any;

  constructor(private bookService: BookService) {
  }

  ngOnInit(): void {

  }

  public calculate(): void  {
    const model: IPenaltyBussinessQuery = {
      CountryId: this.country,
      DateCheckedIn: this.checkin,
      DateCheckedOut: this.checkout
    };

    this.bookService.getPenaltyBussiness(model).toPromise().then((result) => {
      console.log(result);
      this.result = result;
    });
  }
}
