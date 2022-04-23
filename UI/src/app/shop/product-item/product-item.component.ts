import { Component, Input, OnInit } from '@angular/core';
import { Iproduct } from 'src/app/shared/models/product';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.css']
})
export class ProductItemComponent implements OnInit {
@Input() product:Iproduct={
  name: '',
  description: '',
  price: 0,
  proeductURL: ''
};
  constructor() { }

  ngOnInit(): void {
  }

}
