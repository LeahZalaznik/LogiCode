import { Component } from '@angular/core';
import { GooglePayButtonModule } from '@google-pay/button-angular';

@Component({
  selector: 'app-google-pay',
  imports: [GooglePayButtonModule],
  templateUrl: './google-pay.component.html',
  styleUrl: './google-pay.component.css'
})
export class GooglePayComponent {
  price:string = '0';
 onLoadPaymentData(event: any) {
    console.log('Load Payment Data', event);
  }
}
