import { Component, OnInit } from '@angular/core';
import { IgxButtonDirective, IgxRippleDirective, IgxDialogComponent } from 'igniteui-angular';

@Component({
    selector: 'app-dialog',
    styleUrls: ['dialog.component.css'],
    templateUrl:'dialog.component.html',
    imports: [IgxButtonDirective, IgxRippleDirective, IgxDialogComponent]
})
export class DialogSample1Component implements OnInit {
  ngOnInit(): void {
   
  }
}
