import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {NgxPaginationModule} from "ngx-pagination";
import {DataTableComponent} from "../components/data-table/data-table.component";

@NgModule({
  declarations: [DataTableComponent],
  exports: [
    DataTableComponent
  ],
  imports: [
    CommonModule,
    NgxPaginationModule
  ]
})
export class SharedModule { }
