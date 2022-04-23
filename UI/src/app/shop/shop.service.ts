import { Injectable } from '@angular/core';
import{ HttpClient, HttpParams}from'@angular/common/http'
import { Iproduct } from '../shared/models/product';
import { Observable } from 'rxjs';
import { IproductType } from '../shared/models/productType';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseurl=environment.baseurl

  constructor(private http:HttpClient) {
   }
   getProducts(productTypeId:number):Observable<Iproduct[]>{
     let parameter=new HttpParams();
      parameter=parameter.append("productTypeId",productTypeId)

      return this.http.get<Iproduct[]>(this.baseurl+'/product',{params:parameter});
     
   }
   getProductTypes():Observable<IproductType[]>{
    return this.http.get<IproductType[]>(this.baseurl+'/ProductType');
    
  }
}
