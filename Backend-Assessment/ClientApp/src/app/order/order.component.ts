import {Component, OnInit, QueryList, TemplateRef, ViewChildren} from '@angular/core';
import {OrderService} from "../services/order.service";
import {GetPage} from "../models/order-model";

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.scss']
})
export class OrderComponent implements OnInit {
  public categoryList: any = [];
  public filters = new GetPage();
  public showHeaders = true;
  public headers = [
    'Id',
    'Name'
  ];
  @ViewChildren('col') public cols!: QueryList<TemplateRef<any>>

  constructor(
    private manaService: OrderService,
  ) {
    this.filters.pageSize = 5;
    this.filters.pageIndex = 1;
  }

  public ngOnInit(): void {
    this.getData();
  }

  public getData(): void {
    this.manaService.getCategories(this.filters).toPromise().then((res) => {
      this.categoryList = res;
    }, err => console.log(err.errors));
  }

}
