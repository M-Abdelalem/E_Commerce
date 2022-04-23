import { Component, OnInit } from '@angular/core';
import { Iproduct } from '../shared/models/product';
import { IproductType } from '../shared/models/productType';
import { ShopService } from './shop.service';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.css']
})
export class ShopComponent implements OnInit {
  products: Iproduct[]=[];
  productTypes: IproductType[]=[];
  selectedproductTypeId:number=0;
  constructor(private shopService:ShopService) { }

  ngOnInit(): void {
    
    this.shopService.getProductTypes().subscribe(data=>{
      this.productTypes=[{id:0,name:'all'},...data]
      console.log(this.productTypes)

    });
    this.selectproducts();

  }
   SelectBrand(productTypeId:number)
  {
    debugger
    this.selectedproductTypeId=productTypeId
    this.selectproducts();

  }
  selectproducts(){  
    debugger
     this.shopService.getProducts(this.selectedproductTypeId).subscribe(data=>{
    this.products=data
    console.log(this.selectedproductTypeId)

  });}
}


