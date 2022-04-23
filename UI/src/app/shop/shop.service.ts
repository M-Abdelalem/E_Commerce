import { Injectable } from '@angular/core';
import{ HttpClient, HttpParams}from'@angular/common/http'
import { Iproduct } from '../shared/models/product';
import { Observable } from 'rxjs';
import { IproductType } from '../shared/models/productType';
@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseurl='https://localhost:7243'

  constructor(private http:HttpClient) {
   }
   getProducts(brandId:number):Observable<Iproduct[]>{
     let parameter=new HttpParams();
      parameter=parameter.append("brandId",brandId)

      return this.http.get<Iproduct[]>(this.baseurl+'/product',{params:parameter});
     
   }
   getProductTypes():Observable<IproductType[]>{
    return this.http.get<IproductType[]>(this.baseurl+'/ProductType');
    
  }
}
