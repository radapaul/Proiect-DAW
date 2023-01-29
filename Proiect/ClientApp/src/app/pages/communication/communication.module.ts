import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CommunicationComponent } from './communication.component';

import { ParentComponent } from './parent/parent.component';
import { ChildComponent } from './child/child.component';
import { Comp1Component } from './comp1/comp1.component';
import { Comp2Component } from './comp2/comp2.component';
import { CommunicationRoutingModule } from './communication-routing.module';

import { MatCardModule } from '@angular/material/card';
import { MatDividerModule } from '@angular/material/divider';


@NgModule({
  declarations: [
    CommunicationComponent,
    ParentComponent,
    ChildComponent,
    Comp1Component,
    Comp2Component
  ],
  imports: [
    CommonModule,
    CommunicationRoutingModule,
    MatCardModule,
    MatDividerModule
  ]
})
export class CommunicationModule { }
